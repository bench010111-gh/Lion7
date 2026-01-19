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

        private static readonly string[] PlayerIdle =
        {
        @"                   ",
        @"   ○          ○  /)",
        @"  ( \\        |\/.|",
        @"   77        / \  ¿"
        };

        private static readonly string[] PlayerCaught =
        {
        @"             ◀▶◀",
        @"   ○         \○/",
        @"  ( \\        |",
        @"   77        / \"
        };

        private void DrawAscii(int x, int y, string[] art)
        {
            for (int i = 0; i < art.Length; i++)
                WriteText(x, y + i, art[i]);
        }

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

            int inputY = _h - 1;
            int bottomBorderY = inputY - 1; // border sits above input line
            DrawBorderNoTop(bottomBorderY);

            string title = "===============================  FISH TYPER  ===================================";

            WriteText(2, 0, title);
            WriteText(2, 1, $"DAY {world.Day}   TIME LEFT {world.GetTimeLeftSeconds(),2}s");
            WriteText(2, 2, $"FISH CAUGHT {world.CaughtToday} / {world.Quota} QUOTA");
            WriteText(1, 3, new string('-', _w - 2)); // inside width


            var art = splash.IsActive ? PlayerCaught : PlayerIdle;
            DrawAscii(2, Game.FishermanY, art);

            // Fish lanes: y = hudHeight .. (hudHeight + laneCount - 1)
            // 입력줄(y=24)은 laneCount에 포함되지 않아서 자연히 제외됩니다.
            for (int lane = 0; lane < _laneCount; lane++)
            {
                var f = laneFish[lane];
                if (f is null) continue;

                int y = Game.FishTopY + lane;
                int x = (int)MathF.Round(f.X);
                DrawWordClipped(x, y, f.Word);
            }

            // Splash는 HUD 안에
            splash.RenderTo(_buffer[2], 28);

            // ✅ 입력 줄: 맨 마지막 줄(y = height - 1)
            string prompt = $"> {input.Current}";
            WriteText(2, _h - 1, $"> {input.Current}");

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

            // Don't write into border columns
            int minX = 1;
            int maxX = _w - 2;

            int px = x;
            for (int i = 0; i < text.Length; i++)
            {
                if (px > maxX) break;
                if (px >= minX)
                    _buffer[y][px] = text[i];
                px++;
            }
        }

        private void DrawWordClipped(int x, int y, string word)
        {
            if (y < 0 || y >= _h) return;

            int minX = 1;
            int maxX = _w - 2;

            var line = _buffer[y];

            for (int i = 0; i < word.Length; i++)
            {
                int px = x + i;
                if (px < minX) continue;
                if (px > maxX) break;
                line[px] = word[i];
            }
        }


        private ConsoleColor GetDayColor(int day)
        {
            ConsoleColor[] palette =
            {
                ConsoleColor.Cyan,
                ConsoleColor.Green,
                ConsoleColor.Yellow,
                ConsoleColor.Magenta,
                ConsoleColor.Blue,
                ConsoleColor.DarkRed,
                ConsoleColor.White,
                ConsoleColor.DarkYellow,
                ConsoleColor.DarkGray
            };

            return palette[(day - 1) % palette.Length];
        }

        private void DrawBorderNoTop(int bottomBorderY)
        {
            // Sides (no top border)
            for (int y = 1; y <= bottomBorderY; y++)
            {
                _buffer[y][0] = '║';
                _buffer[y][_w - 1] = '║';
            }

            // Bottom border
            _buffer[bottomBorderY][0] = '╚';
            for (int x = 1; x < _w - 1; x++)
                _buffer[bottomBorderY][x] = '═';
            _buffer[bottomBorderY][_w - 1] = '╝';
        }

    }
}
