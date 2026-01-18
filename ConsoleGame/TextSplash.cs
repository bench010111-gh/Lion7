using System;

namespace FishTyper
{
    public sealed class TextSplash
    {
        private string _text = "";
        private double _timer = 0;

        private const double Duration = 0.6;

        public bool IsActive => _timer > 0;

        public void Show(string msg)
        {
            _text = msg;
            _timer = Duration;
        }

        public void Update(double dt)
        {
            if (_timer > 0)
                _timer -= dt;
        }

        public void RenderTo(char[] line, int x)
        {
            if (_timer <= 0) return;

            for (int i = 0; i < _text.Length; i++)
            {
                int px = x + i;
                if (px < 0 || px >= line.Length) break;
                line[px] = _text[i];
            }
        }
    }
}
