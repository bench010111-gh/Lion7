using System;
using System.Text;

namespace FishTyper
{
    public sealed class Renderer
    {
        private readonly int _w;
        private readonly int _h;
        private readonly int _hudH;
        private readonly int _laneCount;

        private readonly char[][] _buffer;
        private readonly StringBuilder _sb = new StringBuilder();

        public Renderer(int width, int height, int hudHeight, int laneCount)
        {
            _w = width;
            _h = height;
            _hudH = hudHeight;
            _laneCount = laneCount;

            _buffer = new char[_h][];
            for (int y = 0; y < _h; y++)
                _buffer[y] = new string(' ', _w).ToCharArray();
        }

        public void Draw(World world, DifficultyProfile diff, Fish?[] laneFish, InputLine input, TextSplash splash)
        {
            Clear();

            string title = "==============================  FISH TYPER  ==============================";
            WriteText(0, 0, title);

            WriteText(0, 1, $"DAY {world.Day}   TIME LEFT {world.GetTimeLeftSeconds(),2}s");
            WriteText(0, 2, $"FISH CAUGHT {world.CaughtToday} / {world.Quota} QUOTA");
            WriteText(0, 3, new string('-', _w));

            // Fish lanes: y = hudHeight .. (hudHeight + laneCount - 1)
            // 입력줄(y=24)은 laneCount에 포함되지 않아서 자연히 제외됩니다.
            for (int lane = 0; lane < _laneCount; lane++)
            {
                var f = laneFish[lane];
                if (f is null) continue;

                int y = _hudH + lane;
                int x = (int)MathF.Round(f.X);
                DrawWordClipped(x, y, f.Word);
            }

            // Splash는 HUD 안에
            splash.RenderTo(_buffer[2], 28);

            // ✅ 입력 줄: 맨 마지막 줄(y = height - 1)
            string prompt = $"> {input.Current}";
            WriteText(0, _h - 1, prompt);

            Console.SetCursorPosition(0, 0);
            Console.ForegroundColor = GetDayColor(world.Day);

            _sb.Clear();
            for (int y = 0; y < _h; y++)
            {
                _sb.Append(_buffer[y]);
                if (y < _h - 1) _sb.Append('\n');
            }

            Console.Write(_sb.ToString());
            Console.ResetColor();
        }

        private void Clear()
        {
            for (int y = 0; y < _h; y++)
            {
                var line = _buffer[y];
                for (int x = 0; x < _w; x++)
                    line[x] = ' ';
            }
        }

        private void WriteText(int x, int y, string text)
        {
            if (y < 0 || y >= _h) return;

            var line = _buffer[y];
            for (int i = 0; i < text.Length; i++)
            {
                int px = x + i;
                if (px < 0 || px >= _w) break;
                line[px] = text[i];
            }
        }

        private void DrawWordClipped(int x, int y, string word)
        {
            if (y < 0 || y >= _h) return;

            var line = _buffer[y];
            for (int i = 0; i < word.Length; i++)
            {
                int px = x + i;
                if (px < 0) continue;
                if (px >= _w) break;
                line[px] = word[i];
            }
        }

        private ConsoleColor GetDayColor(int day)
        {
            // 보기 좋은 색들만 순환 (Black은 글자 안 보일 수 있어 제외)
            ConsoleColor[] palette =
            {
                ConsoleColor.Cyan,
                ConsoleColor.Green,
                ConsoleColor.Yellow,
                ConsoleColor.Magenta,
                ConsoleColor.Blue,
                ConsoleColor.White
            };

            return palette[(day - 1) % palette.Length];
        }
    }
}
