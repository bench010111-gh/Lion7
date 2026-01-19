namespace FishTyper
{
    public sealed class DifficultyProfile
    {
        // Quota
        private const int BaseQuota = 10;
        private const int QuotaGrowth = 5;

        // Word length
        private const int BaseMaxLen = 5;
        private const int MinLen = 3;

        // Speed (글자 길이/Day에 따라 자연스럽게 올라가도록)
        private const float BaseSpeed = 12f;
        private const float SpeedGrowth = 1.1f;

        // Spawn interval
        private const float BaseSpawnInterval = 1.25f;
        private const float IntervalDecay = 0.03f; // day가 오를수록 조금 빨라짐
        private const float MinSpawnInterval = 0.55f;

        public int GetQuota(int day)
            => BaseQuota + (day - 1) * QuotaGrowth;

        // 매일 cap이 +1
        public int GetMaxWordLen(int day)
            => BaseMaxLen + (day - 1);

        public int GetMinWordLen() => MinLen;

        private const float SpeedMultiplier = 0.5f;
        public float GetFishSpeed(int day)
            => (BaseSpeed + (day - 1) * SpeedGrowth) * SpeedMultiplier;



        public float GetSpawnInterval(int day)
        {
            float interval = BaseSpawnInterval - (day - 1) * IntervalDecay;
            if (interval < MinSpawnInterval) interval = MinSpawnInterval;
            return interval;
        }
    }
}
