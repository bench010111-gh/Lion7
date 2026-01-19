using System;
using System.Diagnostics;

namespace FishTyper
{
    public sealed class Game
    {
        public const int Width = 80;
        public const int Height = 25;

        public const int HudHeight = 5;
        public const int InputY = Height - 1;

        // fisherman placement
        public const int FishermanY = HudHeight + 1;
        public const int FishermanHeight = 4; // PlayerIdle.Length (keep in sync)

        // fish area: start under fisherman, end above input
        public const int FishTopY = FishermanY + FishermanHeight;   // row right under the art
        public const int FishBottomY = InputY - 1;

        // lane count = number of usable rows for fish
        public const int LaneCount = FishBottomY - FishTopY + 1;

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
            //TrySetConsoleSize(Width, Height);
            Console.CursorVisible = false;

            const int targetFps = 20;
            const double targetFrameSec = 1.0 / targetFps;

            var clock = Stopwatch.StartNew();
            double last = clock.Elapsed.TotalSeconds;
            double accumulator = 0;

            while (_running)
            {
                double now = clock.Elapsed.TotalSeconds;
                double dt = now - last;
                last = now;

                // ✅ 탭 전환/렉 등으로 dt 폭주 방지
                if (dt > 0.25) dt = 0.25;

                accumulator += dt;

                // ✅ 고정 프레임: targetFrameSec만큼 쌓였을 때만 Tick 실행
                if (accumulator >= targetFrameSec)
                {
                    // accumulator가 너무 쌓였으면 한 번만 처리(spiral 방지)
                    accumulator = 0;

                    Tick(targetFrameSec);
                }
                else
                {
                    // 남은 시간만큼 쉬어 CPU 과열/출력 폭주 방지
                    int sleepMs = (int)((targetFrameSec - accumulator) * 1000);
                    if (sleepMs > 0) Thread.Sleep(sleepMs);
                }
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
