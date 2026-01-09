//failed to run in mac

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Security.Principal;
using System.Runtime.InteropServices.Marshalling;
using System.Globalization;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Xml.Schema;
using System.Runtime.InteropServices;

namespace ConsoleApp9
{
    internal class Program
    {
        // needed for game exercise
        [DllImport("msvcrt.dll")] // this is for better performance
        static extern int _getch(); // from c library

        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(int vKey);

        const int VK_UP = 0x26;
        const int VK_DOWN = 0x28;
        const int VK_LEFT = 0x25;
        const int VK_RIGHT = 0x27;
        const int VK_SPACE = 0x20;
        const int VK_ESCAPE = 0x1B;

        static bool IsDown(int vKey) => (GetAsyncKeyState(vKey) & 0x8000) != 0;

        static void Main(string[] args)
        {
            // game application practice
            // Console.SetWindowSize(80, 25);
            // Console.SetBufferSize(80, 25);

            string[] player = new string[]
            {
                "->",
                ">>>",
                "->"
            };  // displaying via array

            int playerX = 0;
            int playerY = 12;

            string projectile = "*";

            List<(int x, int y)> missiles = new List<(int x, int y)>();

            Console.CursorVisible = false;  // remove cursor

            bool prevSpaceDown = false;

            // Sleep() 1000 is stopping for 1 sec.
            // delayed response 1 sec loop

            int dwTime = Environment.TickCount; // 1/1000 sec unit
            int tickUnit = 50;
            
            while (true)
            {
                if (dwTime + tickUnit < Environment.TickCount)
                {
                    dwTime = Environment.TickCount;

                    Console.Clear();

                    // =====================
                    // INPUT (부드러운 이동)
                    // =====================

                    // ESC 종료
                    if (IsDown(VK_ESCAPE))
                        return;

                    int dx = 0;
                    int dy = 0;

                    if (IsDown(VK_UP)) dy--;
                    if (IsDown(VK_DOWN)) dy++;
                    if (IsDown(VK_LEFT)) dx--;
                    if (IsDown(VK_RIGHT)) dx++;

                    // 위치 업데이트 (대각선 포함)
                    playerX += dx;
                    playerY += dy;

                    // 경계 제한
                    if (playerX < 0) playerX = 0;
                    if (playerX > 75) playerX = 75;
                    if (playerY < 1) playerY = 1;
                    if (playerY > 21) playerY = 21;

                    // =====================
                    // SPACE : 미사일 발사 (단발)
                    // =====================

                    bool spaceDown = IsDown(VK_SPACE);
                    if (spaceDown && !prevSpaceDown)
                    {
                        int missileX = playerX + player[1].Length; // 우주선 중간 줄 끝
                        int missileY = playerY + 1;                // 중간 줄

                        missiles.Add((missileX, missileY));
                    }
                    prevSpaceDown = spaceDown;

                    // =====================
                    // UPDATE : 미사일 이동
                    // =====================

                    for (int i = missiles.Count - 1; i >= 0; i--)
                    {
                        var m = missiles[i];
                        m.x += 1; // 오른쪽 이동

                        if (m.x >= 79)
                            missiles.RemoveAt(i);
                        else
                            missiles[i] = m;
                    }

                    // =====================
                    // RENDER : 플레이어
                    // =====================

                    for (int i = 0; i < player.Length; i++)
                    {
                        Console.SetCursorPosition(playerX, playerY + i);
                        Console.WriteLine(player[i]);
                    }

                    // =====================
                    // RENDER : 미사일
                    // =====================

                    foreach (var m in missiles)
                    {
                        if (m.x >= 0 && m.x < Console.WindowWidth &&
                            m.y >= 0 && m.y < Console.WindowHeight)
                        {
                            Console.SetCursorPosition(m.x, m.y);
                            Console.Write(projectile);
                        }
                    }
                }
            }



        }
    }
}