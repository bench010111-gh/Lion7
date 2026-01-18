namespace FishTyper
{
    public sealed class TargetResolver
    {
        private readonly int _width;
        private readonly int _hudHeight; // 지금은 필요 없지만 유지

        public TargetResolver(int width, int hudHeight)
        {
            _width = width;
            _hudHeight = hudHeight;
        }

        public Fish? FindTarget(string text, Fish?[] laneFish)
        {
            Fish? best = null;
            float bestTime = float.MaxValue;

            for (int i = 0; i < laneFish.Length; i++)
            {
                var f = laneFish[i];
                if (f is null) continue;

                if (f.Word == text)
                {
                    float tte = f.TimeToExit(_width);
                    if (tte < bestTime)
                    {
                        bestTime = tte;
                        best = f;
                    }
                }
            }

            return best;
        }
    }
}
