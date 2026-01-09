using System;

class Program
{
    static void Main()
    {
        const int W = 80;
        const int H = 25;

        Console.CursorVisible = false;

        // ===== Symbols =====
        string playerChar = "⃝";
        string houseChar = "𖠿";
        string treeChar = "𖠰";
        string lakeChar = "~";

        char hLine = '─';
        char vLine = '│';
        char tl = '┌', tr = '┐', bl = '└', br = '┘';

        // ===== UI & Area Layout =====
        int uiY = 0;

        int topBorderY = 1;
        int bottomBorderY = 24;

        int leftBorderX = 0;
        int rightBorderX = 79;

        int interiorMinX = 1;
        int interiorMaxX = 78;
        int interiorMinY = 2;
        int interiorMaxY = 23;

        // ===== Game State =====
        int gold = 0;

        int bagSlots = 3;
        int maxBagSlots = 10;
        int wood = 0;

        // House position (bottom-right inside)
        int houseX = interiorMaxX;
        int houseY = interiorMaxY;

        // Player spawn (left of house)
        int playerX = houseX - 1;
        int playerY = houseY;

        bool[,] tree = new bool[H, W];
        bool[,] lake = new bool[H, W];
        int treeCount = 0;

        // ===== Create Lake (center of screen) =====
        int lakeWidth = 12;
        int lakeHeight = 5;
        int lakeStartX = (interiorMinX + interiorMaxX) / 2 - lakeWidth / 2;
        int lakeStartY = (interiorMinY + interiorMaxY) / 2 - lakeHeight / 2;

        for (int y = 0; y < lakeHeight; y++)
        {
            for (int x = 0; x < lakeWidth; x++)
            {
                int gx = lakeStartX + x;
                int gy = lakeStartY + y;

                bool corner =
                    (y == 0 && (x == 0 || x == lakeWidth - 1)) ||
                    (y == lakeHeight - 1 && (x == 0 || x == lakeWidth - 1));

                if (!corner)
                {
                    lake[gy, gx] = true;
                }
            }
        }

        // ===== Forest generation: 6~7 patches =====
        Random rng = new Random();
        int patchCount = rng.Next(6, 8); // 6 or 7

        for (int p = 0; p < patchCount; p++)
        {
            // Random patch size (varying)
            int patchW = rng.Next(6, 16);  // width 6~15
            int patchH = rng.Next(3, 9);   // height 3~8

            // Random patch center (keep inside interior safely)
            int centerX = rng.Next(interiorMinX + 2, interiorMaxX - 2);
            int centerY = rng.Next(interiorMinY + 2, interiorMaxY - 2);

            int startX = centerX - patchW / 2;
            int endX = startX + patchW - 1;

            int startY = centerY - patchH / 2;
            int endY = startY + patchH - 1;

            // Clamp to interior
            if (startX < interiorMinX) startX = interiorMinX;
            if (endX > interiorMaxX) endX = interiorMaxX;
            if (startY < interiorMinY) startY = interiorMinY;
            if (endY > interiorMaxY) endY = interiorMaxY;

            // Fill patch area with some randomness to make it "patchy"
            for (int y = startY; y <= endY; y++)
            {
                for (int x = startX; x <= endX; x++)
                {
                    // Exclusion zones
                    bool isHouse = (x == houseX && y == houseY);
                    bool isSpawn = (x == playerX && y == playerY);

                    if (isHouse || isSpawn) continue;
                    if (lake[y, x]) continue;

                    // Make edges sparser so it looks less like a perfect rectangle
                    bool isEdge = (x == startX || x == endX || y == startY || y == endY);

                    // Chance rules:
                    // - interior of patch: high chance
                    // - edges: lower chance
                    int roll = rng.Next(100);

                    bool placeTree;
                    if (isEdge)
                        placeTree = (roll < 55);  // 55% on edges
                    else
                        placeTree = (roll < 85);  // 85% inside

                    if (placeTree && !tree[y, x])
                    {
                        tree[y, x] = true;
                        treeCount++;
                    }
                }
            }

            // Optional: carve 1~2 small gaps inside the patch to create walk paths
            int holes = rng.Next(1, 3);
            for (int h = 0; h < holes; h++)
            {
                int hx = rng.Next(startX, endX + 1);
                int hy = rng.Next(startY, endY + 1);

                if (!lake[hy, hx] && !(hx == houseX && hy == houseY) && !(hx == playerX && hy == playerY))
                {
                    if (tree[hy, hx])
                    {
                        tree[hy, hx] = false;
                        treeCount--;
                    }
                }
            }
        }

        bool inHouse = false;
        int houseMenuIndex = 0;

        ConsoleKeyInfo keyInfo;

        while (true)
        {
            if (treeCount == 0)
            {
                Console.Clear();
                Console.WriteLine("All trees are gone. Game Clear!");
                break;
            }

            Console.Clear();

            // ===== UI =====
            Console.SetCursorPosition(0, uiY);
            Console.ForegroundColor = ConsoleColor.Yellow;

            string uiText = inHouse
                ? $"[HOUSE] Gold: {gold}   (Wood auto-sold)"
                : $"Gold: {gold}   Bag: {wood}/{bagSlots} wood";

            Console.Write(uiText.PadRight(W));
            Console.ResetColor();

            // ===== Borders =====
            Console.SetCursorPosition(leftBorderX, topBorderY);
            Console.Write(tl);
            for (int x = 1; x < rightBorderX; x++) Console.Write(hLine);
            Console.Write(tr);

            for (int y = interiorMinY; y <= interiorMaxY; y++)
            {
                Console.SetCursorPosition(leftBorderX, y);
                Console.Write(vLine);
                Console.SetCursorPosition(rightBorderX, y);
                Console.Write(vLine);
            }

            Console.SetCursorPosition(leftBorderX, bottomBorderY);
            Console.Write(bl);
            for (int x = 1; x < rightBorderX; x++) Console.Write(hLine);
            Console.Write(br);

            if (!inHouse)
            {
                // Lake
                Console.ForegroundColor = ConsoleColor.Blue;
                for (int y = interiorMinY; y <= interiorMaxY; y++)
                    for (int x = interiorMinX; x <= interiorMaxX; x++)
                        if (lake[y, x])
                        {
                            Console.SetCursorPosition(x, y);
                            Console.Write(lakeChar);
                        }
                Console.ResetColor();

                // Trees
                Console.ForegroundColor = ConsoleColor.Green;
                for (int y = interiorMinY; y <= interiorMaxY; y++)
                    for (int x = interiorMinX; x <= interiorMaxX; x++)
                        if (tree[y, x])
                        {
                            Console.SetCursorPosition(x, y);
                            Console.Write(treeChar);
                        }
                Console.ResetColor();

                // House
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(houseX, houseY);
                Console.Write(houseChar);
                Console.ResetColor();

                // Player
                Console.SetCursorPosition(playerX, playerY);
                Console.Write(playerChar);
            }
            else
            {
                Console.SetCursorPosition(3, 4);
                Console.Write("Welcome Home!");

                int cost = bagSlots >= maxBagSlots ? 0 : 3 + 3 * (bagSlots - 3);
                Console.SetCursorPosition(3, 6);
                Console.Write(bagSlots >= maxBagSlots
                    ? $"Bag MAX ({bagSlots}/{maxBagSlots})"
                    : $"Bag: {bagSlots}/{maxBagSlots}  Upgrade cost: {cost}");

                Console.SetCursorPosition(3, 9);
                Console.Write(houseMenuIndex == 0 ? "> Buy new bag" : "  Buy new bag");
                Console.SetCursorPosition(3, 10);
                Console.Write(houseMenuIndex == 1 ? "> Exit house" : "  Exit house");
            }

            keyInfo = Console.ReadKey(true);

            if (inHouse)
            {
                if (keyInfo.Key == ConsoleKey.UpArrow) houseMenuIndex = 0;
                else if (keyInfo.Key == ConsoleKey.DownArrow) houseMenuIndex = 1;
                else if (keyInfo.Key == ConsoleKey.Enter || keyInfo.Key == ConsoleKey.Spacebar)
                {
                    if (houseMenuIndex == 0 && bagSlots < maxBagSlots)
                    {
                        int cost = 3 + 3 * (bagSlots - 3);
                        if (gold >= cost)
                        {
                            gold -= cost;
                            bagSlots++;
                        }
                    }
                    else
                    {
                        inHouse = false;
                        playerX = houseX - 1;
                        playerY = houseY;
                    }
                }
                continue;
            }

            int nextX = playerX;
            int nextY = playerY;

            if (keyInfo.Key == ConsoleKey.UpArrow) nextY--;
            else if (keyInfo.Key == ConsoleKey.DownArrow) nextY++;
            else if (keyInfo.Key == ConsoleKey.LeftArrow) nextX--;
            else if (keyInfo.Key == ConsoleKey.RightArrow) nextX++;
            else if (keyInfo.Key == ConsoleKey.Spacebar)
            {
                if (wood < bagSlots)
                {
                    // Check 4 adjacent cells; chop the first tree found
                    int[,] dirs = { { 0, -1 }, { 0, 1 }, { -1, 0 }, { 1, 0 } };
                    for (int i = 0; i < 4; i++)
                    {
                        int tx = playerX + dirs[i, 0];
                        int ty = playerY + dirs[i, 1];

                        if (tx < interiorMinX || tx > interiorMaxX || ty < interiorMinY || ty > interiorMaxY)
                            continue;

                        if (tree[ty, tx])
                        {
                            tree[ty, tx] = false;
                            treeCount--;
                            wood++;
                            break;
                        }
                    }
                }
                continue;
            }
            else continue;

            // Border limits
            if (nextX < interiorMinX || nextX > interiorMaxX ||
                nextY < interiorMinY || nextY > interiorMaxY) continue;

            // Collision: trees and lake are solid
            if (tree[nextY, nextX] || lake[nextY, nextX]) continue;

            // Move player
            playerX = nextX;
            playerY = nextY;

            // Enter house (overlap)
            if (playerX == houseX && playerY == houseY)
            {
                gold += wood;
                wood = 0;
                inHouse = true;
                houseMenuIndex = 0;
            }
        }
    }
}
