using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FishTyper
{
    public sealed class WordBank
    {
        private readonly Random _rng = new Random();
        private readonly Dictionary<int, List<string>> _byLen = new();

        public WordBank(string path = "words.txt")
        {
            Load(path);
        }

        private void Load(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException($"Word file not found: {path}");

            foreach (var raw in File.ReadLines(path))
            {
                var w = raw.Trim().ToLowerInvariant();
                if (w.Length == 0) continue;

                // 알파벳만(원하시면 하이픈 허용 등 확장 가능)
                if (!w.All(c => c >= 'a' && c <= 'z')) continue;

                if (!_byLen.TryGetValue(w.Length, out var list))
                {
                    list = new List<string>();
                    _byLen[w.Length] = list;
                }

                list.Add(w);
            }
        }

        public string GetWord(int targetLen)
        {
            // 1) 정확히 targetLen
            if (_byLen.TryGetValue(targetLen, out var exact) && exact.Count > 0)
                return exact[_rng.Next(exact.Count)];

            // 2) 없으면 가까운 길이로 보정(±1, ±2, ...)
            int maxSearch = 20; // 안전장치
            for (int d = 1; d <= maxSearch; d++)
            {
                if (_byLen.TryGetValue(targetLen - d, out var left) && left.Count > 0)
                    return left[_rng.Next(left.Count)];
                if (_byLen.TryGetValue(targetLen + d, out var right) && right.Count > 0)
                    return right[_rng.Next(right.Count)];
            }

            // 3) 그래도 없으면 예외(단어 파일이 너무 빈약한 경우)
            throw new InvalidOperationException("No words available in word bank.");
        }
    }
}
