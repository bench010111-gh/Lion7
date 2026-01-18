namespace FishTyper
{
    public enum Direction
    {
        LeftToRight,
        RightToLeft
    }

    public sealed class Fish
    {
        public string Word { get; }
        public int LaneIndex { get; }
        public int Y { get; }               // 콘솔 y
        public float X { get; private set; }
        public float Speed { get; }
        public Direction Dir { get; }

        public Fish(string word, int laneIndex, int y, float startX, float speed, Direction dir)
        {
            Word = word;
            LaneIndex = laneIndex;
            Y = y;
            X = startX;
            Speed = speed;
            Dir = dir;
        }

        public void Update(double dt)
        {
            float dx = Speed * (float)dt;
            X += (Dir == Direction.LeftToRight) ? dx : -dx;
        }

        public bool IsOffscreen(int width)
        {
            if (Dir == Direction.LeftToRight)
                return X > width; // 오른쪽 밖으로
            else
                return X < -Word.Length; // 왼쪽 밖으로
        }

        public float TimeToExit(int width)
        {
            // 남은 거리 / speed
            float remaining = (Dir == Direction.LeftToRight)
                ? (width - X)
                : (X + Word.Length);

            if (remaining < 0) remaining = 0;
            return remaining / (Speed <= 0.001f ? 0.001f : Speed);
        }
    }
}
