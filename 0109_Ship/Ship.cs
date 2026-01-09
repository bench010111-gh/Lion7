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

            ConsoleKeyInfo keyInfo; // key input

            Console.CursorVisible = false;  // remove cursor

            // Sleep() 1000 is stopping for 1 sec.
            // delayed response 1 sec loop

            int dwTime = Environment.TickCount; // 1/1000 sec unit
            int tickUnit = 50;
            
            while (true)
            {
                // 1 sec loop
                if(dwTime + tickUnit < Environment.TickCount)
                {
                    // current time setting
                    dwTime = Environment.TickCount;

                    Console.Clear();

                    for (int i = missiles.Count - 1; i >= 0; i--)
                    {
                        var m = missiles[i];
                        m.x += 1;   // move one space to the right

                        // remove missile if off the screen
                        if (m.x >= 79)
                            missiles.RemoveAt(i);
                        else
                            missiles[i] = m;
                    }

                    // key area
                    // int pressKey;   // taking in int keyInfo

                    if (Console.KeyAvailable)
                    {
                        keyInfo = Console.ReadKey(true);

                        switch (keyInfo.Key)
                        {
                            case ConsoleKey.UpArrow:
                                if (playerY > 1) playerY--;
                                break;

                            case ConsoleKey.DownArrow:
                                if (playerY < 21) playerY++;
                                break;

                            case ConsoleKey.LeftArrow:
                                if (playerX > 0) playerX--;
                                break;

                            case ConsoleKey.RightArrow:
                                if (playerX < 75) playerX++;
                                break;

                            case ConsoleKey.Spacebar:
                                int missileX = playerX + player[1].Length;
                                int missileY = playerY + 1;

                                missiles.Add((missileX, missileY));
                                break;

                            case ConsoleKey.Escape:
                                return;
                        }
                    }


                    if(Console.KeyAvailable)   // if key pressed
                    {
                        keyInfo = Console.ReadKey(true);    // take in keyInfo

                        switch (keyInfo.Key)
                        {
                            case ConsoleKey.UpArrow: if (playerY > 0) playerY--; break;
                            case ConsoleKey.DownArrow: if (playerY < Console.WindowHeight - 1) playerY++; break;
                            case ConsoleKey.LeftArrow: if (playerX > 0) playerX--; break;
                            case ConsoleKey.RightArrow: if (playerX < Console.WindowWidth - 1) playerX++; break;
                            case ConsoleKey.Escape: return; //ESC키로 종료 
                        }
                    }

                    // render in player
                    for (int i = 0; i < player.Length; i++)
                    {
                        // console coord
                        Console.SetCursorPosition(playerX, playerY + i);
                        // print the string array
                        Console.WriteLine(player[i]);
                    }

                    // render in missile
                    foreach (var m in missiles)
                    {
                        if (m.x >= 0 && m.x < 80 && m.y >= 0 && m.y < 25)
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