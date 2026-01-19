using System;

namespace FishTyper
{
    public sealed class Spawner
    {
        private readonly WordBank _words;
        private readonly Random _rng = new Random();
        private double _timer = 0;

        public Spawner(WordBank words)
        {
            _words = words;
        }

        public void Update(double dt, World world, DifficultyProfile diff, Fish?[] laneFish)
        {
            _timer += dt;

            float interval = diff.GetSpawnInterval(world.Day);
            if (_timer < interval) return;

            _timer = 0;

            // 랜덤 레인에서 스폰 (한 레인에 1마리 제한)
            // 너무 자주 실패하지 않도록 최대 6회 재시도
            const int maxTries = 6;

            for (int t = 0; t < maxTries; t++)
            {
                int lane = _rng.Next(0, laneFish.Length);
                if (laneFish[lane] != null) continue;

                SpawnOne(lane, world, diff, laneFish);
                break;
            }
        }

        private void SpawnOne(int lane, World world, DifficultyProfile diff, Fish?[] laneFish)
        {
            int y = Game.FishTopY + lane; // 5~24

            // 레인 인덱스 짝수: L->R, 홀수: R->L (교차 방지)
            Direction dir = (lane % 2 == 0) ? Direction.LeftToRight : Direction.RightToLeft;

            int minLen = diff.GetMinWordLen();
            int maxLen = diff.GetMaxWordLen(world.Day);
            if (maxLen < minLen) maxLen = minLen;

            int targetLen = _rng.Next(minLen, maxLen + 1);
            string word = _words.GetWord(targetLen);

            float baseSpeed = diff.GetFishSpeed(world.Day);
            float jitter = (float)(_rng.NextDouble() * 2.0 - 1.0) * 1.2f; // -1.2~+1.2
            float speed = Math.Max(3f, baseSpeed + jitter);

            float startX = (dir == Direction.LeftToRight)
                ? -word.Length
                : Game.Width; // 오른쪽 끝에서 시작

            laneFish[lane] = new Fish(word, lane, y, startX, speed, dir);
        }
    }
}
