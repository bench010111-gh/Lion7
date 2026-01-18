using System;
using System.Diagnostics;

namespace FishTyper
{
    public sealed class Game
    {
        public const int Width = 80;
        public const int Height = 25;

        // HUD: 0~4 (5줄)
        public const int HudHeight = 5;

        // 입력줄(맨 마지막 y=24)은 제외해야 하므로:
        // 물고기 레인: y=5~23 => 19줄
        public const int LaneCount = Height - HudHeight - 1; // 25-5-1=19

        private readonly World _world = new World();
        private readonly DifficultyProfile _diff = new DifficultyProfile();
        private readonly WordBank _words = new WordBank();
        private readonly InputLine _input = new InputLine();
        private readonly TextSplash _splash = new TextSplash();
        private readonly Renderer _renderer = new Renderer(Width, Height, HudHeight, LaneCount);
        private readonly TargetResolver _resolver = new TargetResolver(Width, HudHeight);

        private readonly Spawner _spawner;
        private readonly Fish?[] _laneFish = new Fish?[LaneCount];

        private bool _running = true;

        public Game()
        {
            _spawner = new Spawner(_words);
            _world.StartNewDay(_diff);
        }

        public void Run()
        {
            // TrySetConsoleSize(Width, Height);
            Console.CursorVisible = false;

            var sw = Stopwatch.StartNew();

            while (_running)
            {
                double dt = sw.Elapsed.TotalSeconds;
                sw.Restart();

                Tick(dt);
            }

            Console.CursorVisible = true;
            Console.ResetColor();
            Console.Clear();
        }

        private void Tick(double dt)
        {
            _input.Update();

            if (_input.HasSubmit)
            {
                string submitted = _input.ConsumeSubmit();

                if (!string.IsNullOrWhiteSpace(submitted))
                {
                    var target = _resolver.FindTarget(submitted, _laneFish);

                    if (target is not null)
                    {
                        _laneFish[target.LaneIndex] = null;
                        _world.CaughtToday++;
                        _splash.Show(">>> CAUGHT! <<<");

                        // ✅ 추가: quota 달성 즉시 day 종료
                        if (_world.CaughtToday >= _world.Quota)
                        {
                            EndDay();           // 성공이므로 다음 날로 넘어감
                            if (!_running) return;
                        }
                    }
                }
            }

            _spawner.Update(dt, _world, _diff, _laneFish);

            for (int i = 0; i < _laneFish.Length; i++)
            {
                var f = _laneFish[i];
                if (f is null) continue;

                f.Update(dt);
                if (f.IsOffscreen(Width))
                    _laneFish[i] = null;
            }

            _splash.Update(dt);

            if (_world.UpdateDayTimer(dt))
            {
                EndDay();
                if (!_running) return;
            }

            _renderer.Draw(_world, _diff, _laneFish, _input, _splash);
        }

        private void EndDay()
        {
            if (_world.CaughtToday < _world.Quota)
            {
                Console.SetCursorPosition(0, Height - 1);
                Console.ResetColor();
                Console.Write($"GAME OVER: quota failed ({_world.CaughtToday}/{_world.Quota}). Press Enter...");
                Console.CursorVisible = true;
                Console.ReadLine();
                _running = false;
                return;
            }

            for (int i = 0; i < _laneFish.Length; i++)
                _laneFish[i] = null;

            _world.StartNewDay(_diff);
            _splash.Show($">>> DAY {_world.Day} <<<");

        }

        /*
        private static void TrySetConsoleSize(int w, int h)
        {
            try
            {
                if (Console.BufferWidth < w) Console.BufferWidth = w;
                if (Console.BufferHeight < h) Console.BufferHeight = h;

                Console.SetWindowSize(w, h);
                Console.SetBufferSize(w, h);
            }
            catch { }
        }
        */
    }
}
