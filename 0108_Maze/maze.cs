using System;

class Program
{
    static void Main()
    {
        const int W = 80;
        const int H = 25;

        Console.CursorVisible = false;

        string wallChar = "■";
        string doorChar = "▥";
        string houseChar = "@";
        string keyChar = "k";
        string playerNoKey = "○";
        string playerHasKey = "☆";

        int startX = 0, startY = 0;
        int x = startX, y = startY;

        int doorX = 78, doorY = 23;
        int houseX = 79, houseY = 23;   // reachable (adjacent to door)

        int keyX = 38, keyY = 12;       // static key position (change if you want)

        bool hasKey = false;
        bool keyCollected = false;

        bool[,] wall = new bool[H, W];

        // 1) Border walls (thickness 1)
        for (int i = 0; i < W; i++)
        {
            wall[0, i] = true;
            wall[H - 1, i] = true;
        }
        for (int j = 0; j < H; j++)
        {
            wall[j, 0] = true;
            wall[j, W - 1] = true;
        }

        // 2) Open entrance near (0,0) so player is not trapped
        wall[startY, startX] = false; // (0,0)
        wall[0, 1] = false;           // (1,0)
        wall[1, 0] = false;           // (0,1)
        wall[1, 1] = false;           // (1,1)

        // 3) Simple internal walls (strip maze with gaps)
        for (int i = 2; i <= 77; i++) wall[2, i] = true;
        wall[2, 5] = false; wall[2, 20] = false; wall[2, 40] = false; wall[2, 60] = false;

        for (int i = 2; i <= 77; i++) wall[6, i] = true;
        wall[6, 10] = false; wall[6, 30] = false; wall[6, 50] = false; wall[6, 70] = false;

        for (int i = 2; i <= 77; i++) wall[10, i] = true;
        wall[10, 15] = false; wall[10, 35] = false; wall[10, 55] = false; wall[10, 75] = false;

        for (int i = 2; i <= 77; i++) wall[14, i] = true;
        wall[14, 8] = false; wall[14, 28] = false; wall[14, 48] = false; wall[14, 68] = false;

        for (int i = 2; i <= 77; i++) wall[18, i] = true;
        wall[18, 12] = false; wall[18, 32] = false; wall[18, 52] = false; wall[18, 72] = false;

        for (int i = 2; i <= 77; i++) wall[22, i] = true;
        wall[22, 6] = false; wall[22, 26] = false; wall[22, 46] = false; wall[22, 66] = false;

        for (int j = 2; j <= 22; j++) wall[j, 12] = true;
        wall[4, 12] = false; wall[9, 12] = false; wall[16, 12] = false; wall[21, 12] = false;

        for (int j = 2; j <= 22; j++) wall[j, 26] = true;
        wall[3, 26] = false; wall[8, 26] = false; wall[15, 26] = false; wall[20, 26] = false;

        for (int j = 2; j <= 22; j++) wall[j, 40] = true;
        wall[5, 40] = false; wall[11, 40] = false; wall[17, 40] = false; wall[22, 40] = false;

        for (int j = 2; j <= 22; j++) wall[j, 54] = true;
        wall[4, 54] = false; wall[10, 54] = false; wall[14, 54] = false; wall[19, 54] = false;

        for (int j = 2; j <= 22; j++) wall[j, 68] = true;
        wall[6, 68] = false; wall[12, 68] = false; wall[18, 68] = false; wall[22, 68] = false;

        // 4) Force door usage near the house
        wall[houseY, houseX] = false; // house cell must be open (even though it's on border)
        wall[doorY, doorX] = false;   // door cell is open (blocked by logic if no key)

        wall[22, 79] = true;          // block above house
        wall[24, 79] = true;          // block below house

        // 5) Make sure key cell is not a wall (in case it overlaps)
        wall[keyY, keyX] = false;

        ConsoleKeyInfo keyInfo;

        while (true)
        {
            Console.Clear();

            // Draw walls
            for (int yy = 0; yy < H; yy++)
            {
                for (int xx = 0; xx < W; xx++)
                {
                    if (wall[yy, xx])
                    {
                        Console.SetCursorPosition(xx, yy);
                        Console.Write(wallChar);
                    }
                }
            }

            // Draw door
            Console.SetCursorPosition(doorX, doorY);
            Console.Write(doorChar);

            // Draw key (if not collected)
            if (!keyCollected)
            {
                Console.SetCursorPosition(keyX, keyY);
                Console.Write(keyChar);
            }

            // Draw house
            Console.SetCursorPosition(houseX, houseY);
            Console.Write(houseChar);

            // Draw player last
            Console.SetCursorPosition(x, y);
            Console.Write(hasKey ? playerHasKey : playerNoKey);

            // Win condition
            if (x == houseX && y == houseY)
            {
                Console.Clear();
                Console.WriteLine("You made it!");
                break;
            }

            keyInfo = Console.ReadKey(true);

            int nextX = x;
            int nextY = y;

            switch (keyInfo.Key)
            {
                case ConsoleKey.UpArrow: nextY--; break;
                case ConsoleKey.DownArrow: nextY++; break;
                case ConsoleKey.LeftArrow: nextX--; break;
                case ConsoleKey.RightArrow: nextX++; break;
                case ConsoleKey.Escape: return;
            }

            // Bounds check
            if (nextX < 0 || nextX >= W || nextY < 0 || nextY >= H) continue;

            // Wall collision
            if (wall[nextY, nextX]) continue;

            // Door collision (locked)
            if (nextX == doorX && nextY == doorY && !hasKey) continue;

            // Move
            x = nextX;
            y = nextY;

            // Key pickup
            if (!keyCollected && x == keyX && y == keyY)
            {
                hasKey = true;
                keyCollected = true;
            }
        }
    }
}
