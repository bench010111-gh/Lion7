using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Security.Principal;
using System.Runtime.InteropServices.Marshalling;
using System.Globalization;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.Clear();

            // // control flow statement: while loop
            // int i = 0;  // instantiation

            // while (i < 10)  // condition
            // {
            //     i++;    // increment
            //     Console.WriteLine("Hello World!"); // execution code
            // }

            // // for loop (instantiation; condition; increment) {}


            // // example: 10 -> 1 countdown
            // Console.WriteLine("=== Example 2: Countdown === \n");
            // int countdown = 10; // instantiation

            // while (countdown > 0)   // condition
            // {
            //     Console.WriteLine($"{countdown}...");
            //     Thread.Sleep(500);

            //     countdown--;    // increment
            // }


            // // example: sum
            // Console.WriteLine("=== Example 3: Getting Sum === \n");
            // int sum = 0;
            // int i = 1;

            // while (i <= 5)
            // {
            //     sum += i;
            //     Console.WriteLine(sum);
            //     i++;
            // }

            // Console.WriteLine($"\nTotal sum is: {sum}");


            // // example: loop
            // Console.WriteLine("=== Example 4: Reaching Goal === \n");
            // int coins = 0;
            // int target = 50;
            // int day = 0;

            // while (coins < target)
            // {
            //     day++;
            //     coins += 10;
            //     Console.WriteLine($"Day {day}: {coins} coins collected");
            // }

            // Console.WriteLine($"?? Goal Reached! Took total of {day} days.\n");


            // // control statement: do-while loop
            // int x = 0;

            // do
            // {
            //     Console.WriteLine($"Code is guaranteed to run at least 1 time ({x})");
            //     x++;
            // } while (x < 10);


            // // example
            // string choice;
            // int totalPrice = 0;

            // do
            // {
            //     // menu
            //     Console.WriteLine("=== Menu: ===");
            //     Console.WriteLine("1. Black Bean Noodles: $5");
            //     Console.WriteLine("2. Spicy Seafood Noodles: $6");
            //     Console.WriteLine("3. S&S Pork: $15");
            //     Console.WriteLine("4. Egg Fried Rice: $7");
            //     Console.WriteLine("0. End Menu");

            //     Console.Write("Enter menu number: ");
            //     choice = Console.ReadLine()!;

            //     switch (choice)
            //     {
            //         case "1" : 
            //             Console.WriteLine("You have chosen Black Bean Noodles! ($5)");
            //             totalPrice += 5; break;
            //         case "2" : 
            //             Console.WriteLine("You have chosen Spicy Seafood Noodles! ($6)");
            //             totalPrice += 6; break;
            //         case "3" : 
            //             Console.WriteLine("You have chosen S&S Pork! ($15)");
            //             totalPrice += 15; break;
            //         case "4" : 
            //             Console.WriteLine("You have chosen Egg Fried Rice! ($7)");
            //             totalPrice += 7; break;
            //         case "0" :
            //             Console.WriteLine("You have chose to select menu! exiting...");
            //             break;
            //         default : 
            //             Console.WriteLine("Invalid menu! Please enter from 0 ~ 4");
            //             break;
            //     }

            //     Console.WriteLine("\n");

            // } while (choice != "0");

            // Console.WriteLine($"Total billing is ${totalPrice}!");


            // // control statment in loop: break, continue
            // for (int i = 0; i < 10; i++)
            // {
            //     if (i == 5)
            //     {
            //         // break;
            //         continue;
            //     }
            //     Console.WriteLine(i);
            // }


            // // example
            // for (int i = 1; i <= 10; i++)
            // {
            //     if (i % 2 == 0) continue;
            //     Console.WriteLine(i); // only write odds
            // }


            // // control flow statement in loop: goto
            // int n = 1;
            // start: // this can be used as loop (rare case)

            // if (n <= 5)
            // {
            //     Console.WriteLine(n);
            //     n++;
            //     goto start;
            // }


            // // nested loop
            // for (int i = 0; i < 3; i++)
            // {
            //     for (int j = 0; j < 3; j++)
            //     {
            //         Console.WriteLine($"i:{i}, j:{j}");
            //     }
            //     Console.WriteLine("");
            // }


            // // exercise:
            // Console.WriteLine("=== making 3x3 cube using nested loop\n");

            // for (int i = 0; i < 3; i++)
            // {
            //     for (int j = 0; j < 3; j++)
            //     {
            //         Console.Write("⬜ ");
            //     }
            //     Console.Write("\n");
            // }


            // // exercise 2:
            // Console.WriteLine("=== Number Table ===\n");

            // for (int i = 0; i < 3; i++)
            // {
            //     for (int j = 1; j <= 3; j++)
            //     {
            //         Console.Write(j + " ");
            //     }
            //     Console.Write("\n");
            // }


            // // exercise 3:
            // Console.WriteLine("=== Asterisk Pyramid ===\n");
            // for (int i = 0; i < 5; i++)
            // {
            //     for (int j = 0; j <5; j++)
            //     {
            //         if (j >= i) Console.Write("*");
            //         else        Console.Write(" ");
            //     }
            //     Console.Write("\n");
            // }


            // // exercise 4:
            // Console.WriteLine("=== 3x3 Mult. Table ===\n");
            // for (int i = 1; i <= 3; i++)
            // {
            //     for (int j = 1; j <= 3; j++)
            //     {
            //         Console.Write($"{i}x{j}={i*j}  ");
            //     }
            //     Console.Write("\n");
            // }


            // // exercise 5:
            // Console.WriteLine("=== Simple Grid Map ===\n");
            // for (int i = 1; i <= 4; i++)
            // {
            //     for (int j = 1; j <= 4; j++)
            //     {
            //         if (i == 1 && j == 1) Console.Write("🏠 ");
            //         else if (i == 4 && j == 4) Console.Write("🎯 ");
            //         else Console.Write("🟩 ");
            //     }
            //     Console.Write("\n");
            // }

            
            int x = 10, y = 10;
            int targetX = 50, targetY = 20;

            ConsoleKeyInfo keyInfo;

            Console.CursorVisible = false;

            while (true)
            {
                Console.Clear();    // clear screen

                Console.SetCursorPosition(x, y);    // coordinate

                Console.Write("●"); // current position

                Console.SetCursorPosition(targetX, targetY);
                Console.Write("🏠");

                if (x == targetX && y == targetY)
                {
                    Console.Clear();
                    Console.WriteLine("You made it!");
                    break;
                }

                keyInfo = Console.ReadKey(true);    // key input

                // direction key based corrdinate update
                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow     : if (y > 0) y--; break;
                    case ConsoleKey.DownArrow   : if (y < Console.WindowHeight - 1) y++; break;
                    case ConsoleKey.LeftArrow   : if (x > 0) x--; break;
                    case ConsoleKey.RightArrow  : if (x < Console.WindowWidth - 1) x++; break;
                    case ConsoleKey.Escape      : break;
                }
            }


        }
    }
}