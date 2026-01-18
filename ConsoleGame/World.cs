namespace FishTyper
{
    public sealed class World
    {
        public int Day { get; private set; } = 0;

        // 하루(60초) 동안 잡아야 하는 목표
        public int Quota { get; set; }

        public int CaughtToday { get; set; }

        // 0~60
        public double DayElapsedSeconds { get; private set; } = 0;

        public void StartNewDay(DifficultyProfile diff)
        {
            Day++;
            DayElapsedSeconds = 0;
            CaughtToday = 0;

            Quota = diff.GetQuota(Day);
        }

        // true면 day end
        public bool UpdateDayTimer(double dt)
        {
            DayElapsedSeconds += dt;
            return DayElapsedSeconds >= 60.0;
        }

        public int GetTimeLeftSeconds()
        {
            int left = (int)(60.0 - DayElapsedSeconds);
            if (left < 0) left = 0;
            return left;
        }
    }
}
