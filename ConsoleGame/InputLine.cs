using System;

namespace FishTyper
{
    public sealed class InputLine
    {
        public string Current { get; private set; } = "";

        public bool HasSubmit { get; private set; } = false;
        private string _submitted = "";

        public void Update()
        {
            while (Console.KeyAvailable)
            {
                var key = Console.ReadKey(intercept: true);

                if (key.Key == ConsoleKey.Enter)
                {
                    _submitted = Current.Trim();
                    Current = "";
                    HasSubmit = true;
                    return;
                }

                if (key.Key == ConsoleKey.Backspace)
                {
                    if (Current.Length > 0)
                        Current = Current.Substring(0, Current.Length - 1);
                    continue;
                }

                // 알파벳/숫자/기호 등 출력 가능한 문자만 받기
                char c = key.KeyChar;
                if (!char.IsControl(c))
                {
                    // 너무 길어지는 것 방지 (입력창)
                    if (Current.Length < 30)
                        Current += c;
                }
            }
        }

        public string ConsumeSubmit()
        {
            HasSubmit = false;
            return _submitted;
        }
    }
}
