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
            Console.Clear();


            // // array
            // // method 1:
            // int[] scores = new int[5];
            // scores[0] = 0;
            // scores[1] = 1;
            // scores[2] = 2;
            // scores[3] = 3;
            // scores[4] = 4;
            // // scores[5] = 5;   // index out of range

            // // method 2:
            // int[] numbers = new int[5] {10, 20, 30, 40, 50};

            // // method 3:
            // int[] numbers2 = {10, 20, 30, 40, 50};

            // // method 3-1:
            // int[] numbers3 = [10, 20, 30, 40, 50];

            // for (int i = 0; i < scores.Length; i++)
            // {
            //     Console.WriteLine(scores[i]);
            // }



            // // inventory system
            // string[] inventory = new string[5];

            // // take inventory via input:
            // Console.WriteLine("=== Input Inventory ===\n");
            // for (int i = 0; i < inventory.Length; i++)
            // {
            //     Console.Write($"Input Item #{i+1}: ");
            //     inventory[i] = Console.ReadLine()!;
            // }

            // // print inventory
            // Console.WriteLine("\n=== Inventory List ===\n");
            // for (int i = 0; i < inventory.Length; i++)
            // {
            //     Console.WriteLine($"Item #{i+1}: {inventory[i]}");
            // }
            // Console.Write("\n");

            // // consume inventory
            // Console.WriteLine($"You used {inventory[0]}!");
            // inventory[0] = "Empty Slot";

            //             // print inventory
            // Console.WriteLine("\n=== Inventory List ===\n");
            // for (int i = 0; i < inventory.Length; i++)
            // {
            //     Console.WriteLine($"Item #{i+1}: {inventory[i]}");
            // }
            // Console.Write("\n");



            // // array exercise: character stat
            // string[] stat = {"HP", "MP", "ATK", "DEF", "DEX"};
            // int[] statNum = {100, 50, 80, 60, 45};

            // Console.WriteLine("=== Character Stat ===\n");
            // for (int i = 0; i < stat.Length; i++)
            // {
            //     Console.WriteLine($"{stat[i]}: {statNum[i]}");
            // }



            // // daily quest
            // string[] monster = {"Goblin", "Ork", "Slime", "Dragon", "Zombie"};
            // int[] slayCounter = {5, 3, 8, 2, 7};
            // int slayGoal = 5;

            // Console.WriteLine("=== Daily Quest Status ===\n");
            // for (int i = 0; i < monster.Length; i++)
            // {
            //     Console.Write($"{monster[i]}: {slayCounter[i]} / {slayGoal}  ");
            //     if (slayCounter[i] >= slayGoal)
            //         Console.Write("Completed!\n");
            //     else
            //         Console.Write("Not Yet Completed...\n");
            // }



            // // provided array functions
            // int[] scores = {95, 92, 78, 95, 88};

            // Console.WriteLine($"Total num of scores: {scores.Length}");

            // Console.WriteLine("Individual scores: ");
            // for (int i = 0; i < scores.Length; i++)
            // {
            //     Console.WriteLine($"Player {i+1}: {scores[i]}");
            // }

            // // sum
            // int sum = 0;
            // for (int i = 0; i < scores.Length; i++)
            // {
            //     sum += scores[i];
            // }
            // Console.WriteLine($"Total score: {sum}");
            // Console.WriteLine($"Average score: {sum / scores.Length}");

            // // greatest
            // int max = scores[0];
            // for (int i = 1; i < scores.Length; i++)
            //     if (max < scores[i]) max = scores[i];
            // Console.WriteLine($"Greatest score is {max}");

            // // least
            // int min = scores[0];
            // for (int i = 1; i < scores.Length; i++)
            //     if (min > scores[i]) min = scores[i];
            // Console.WriteLine($"Least score is {min}");

            // // C# array class method
            // Console.WriteLine("\n=== C# Array Class Methods === \n");
            // // sort
            // int[] sortedScores = (int[])scores.Clone(); // copy

            // Array.Sort(sortedScores);
            // Console.WriteLine("Array after sorted: ");
            // for (int i = 0; i < sortedScores.Length; i++)
            //     Console.Write($"{sortedScores[i]} ");
            // Console.WriteLine();
            
            // Array.Reverse(sortedScores);
            // Console.WriteLine("Array after sorted, reversed: ");
            // for (int i = 0; i < sortedScores.Length; i++)
            //     Console.Write($"{sortedScores[i]} ");
            // Console.WriteLine();

            // // foreach loop
            // Console.WriteLine("Array listed using foreach: ");
            // foreach (int score in scores)
            //     Console.Write($"{score} ");
            // Console.WriteLine();



            // // multi dimensional array
            // // 방법 1: 크기만 지정
            // int[,] grid = new int[3, 4];  // 3행 4열

            // // 방법 2: 선언과 동시에 초기화
            // int[,] numbers = new int[2, 3]
            // {
            //     { 1, 2, 3 },
            //     { 4, 5, 6 }
            // };

            // // 방법 3: new 생략 (간단한 초기화)
            // int[,] scores = 
            // {
            //     { 90, 85, 88 },
            //     { 92, 78, 95 },
            //     { 87, 91, 84 }
            // };



            // // 배열 크기 확인
            // int[,] array = new int[3, 4];

            // // 전체 요소 개수
            // int totalElements = array.Length;  // 12 (3 x 4)

            // // 특정 차원의 길이
            // int rows = array.GetLength(0);     // 3 (행 개수)
            // int cols = array.GetLength(1);     // 4 (열 개수)

            // // Rank: 배열의 차원 수
            // int dimensions = array.Rank;       // 2



            // // seating chart
            // Console.WriteLine("=== Seating Chart ===\n");
            // string[,] seatingChart =
            // {
            //     {"A1", "A2", "A3"},
            //     {"B1", "B2", "B3"},
            //     {"C1", "C2", "C3"}
            // };

            // for (int i = 0; i < seatingChart.GetLength(1); i++)
            // {
            //     for (int j = 0; j < seatingChart.GetLength(1); j++)
            //     {
            //         Console.Write($"[{seatingChart[i,j]}]");
            //     }
            //     Console.WriteLine();
            // }



            // // 2D Game Map
            // int[,] map = new int[5, 5]
            // {
            //     {0, 0, 0, 0, 0},
            //     {1, 0, 2, 0, 2},
            //     {3, 0, 1, 1, 0},
            //     {3, 2, 1, 1, 0},
            //     {0, 0, 0, 0, 9,}
            // };

            // Console.WriteLine("=== Dungeon Map ===\n");
            // Console.WriteLine("0: path, 1: wall, 2: monster, 3: treasure, 9: exit");

            // // print map
            // for (int y = 0; y < map.GetLength(0); y++)
            // {
            //     for (int x = 0; x < map.GetLength(1); x++)
            //     {
            //         switch (map[y, x])
            //         {
            //             case 0 :
            //                 Console.Write("⬛ ");
            //                 break;
            //             case 1 :
            //                 Console.Write("⬜ ");
            //                 break;
            //             case 2 :
            //                 Console.Write("👹 ");
            //                 break;
            //             case 3 :
            //                 Console.Write("💎 ");
            //                 break;
            //             case 9 :
            //                 Console.Write("🚪 ");
            //                 break;
            //             default :
            //                 break;

            //         }
            //     }
            //     Console.WriteLine();
            // }



            // // exercise
            // Console.WriteLine("=== Grade Report === \n");

            // string[] category = {"Grammar", "English", "Math", "Science"};
            // string[] name = {"John", "Jane", "Adam"};
            // int[,] grade =
            // {
            //     {85, 90, 88, 92},
            //     {78, 85, 90, 87},
            //     {92, 88, 95, 90}
            // };

            // Console.Write("Name\t");
            // for (int i = 0; i < category.Length; i++)
            // {
            //     Console.Write($"{category[i]}\t");
            // }
            // Console.Write("Average\t");
            // Console.WriteLine("\n───────────────────────────────────────────────────────────────────");

            // double sum;
            // double avg;

            // for (int i = 0; i < name.Length; i++)
            // {
            //     Console.Write($"{name[i]}\t");
            //     sum = 0;
            //     for (int j = 0; j < grade.GetLength(1); j++)
            //     {
            //         Console.Write($"{grade[i,j]}\t");
            //         sum += grade[i,j];
            //     }
            //     avg = sum / grade.GetLength(1);
            //     Console.WriteLine($"{avg:F1}");
            // }

            // Console.WriteLine("\n=== Average by Class ===");

            // for (int i = 0; i < grade.GetLength(1); i++)
            // {
            //     sum = 0;
            //     for (int j = 0; j < grade.GetLength(0); j++)
            //     {
            //         sum += grade[j, i];
            //     }
            //     avg = (double)sum / grade.GetLength(0);
            //     Console.WriteLine($"{category[i]}: {avg:F1}");
            // }



            // // 가변 배열, Jagged Array
            // Console.WriteLine("=== Raid Party ===\n");
            // string[][] raid = new string[3][];
            // raid[0] = new string[] {"Swordsman", "Healer"};
            // raid[1] = new string[] {"Marksman", "Assassin", "Mage"};
            // raid[2] = new string[] {"Swordsman", "Healer", "Tanker", "Mage", "Archer"};

            // // visiting elements
            // for (int i = 0; i < raid.Length; i++)
            // {
            //     Console.WriteLine($"Party {i+1} (member count: {raid[i].Length})");
            //     for (int j = 0; j < raid[i].Length; j++)
            //     {
            //         Console.Write($" -{raid[i][j]} ");
            //     }
            //     Console.WriteLine("\n");
            // }



            // // 동적 배열, Dynamic Array
            // // 선언 방법
            // List<int> numbers = new List<int>();           // 빈 리스트
            // List<string> names = new List<string>();       // 문자열 리스트
            // List<float> prices = new List<float>();        // 실수 리스트

            // // 초기값과 함께 선언
            // List<int> scores = new List<int> { 85, 90, 78, 95 };
            // List<string> items = new List<string> { "검", "방패", "포션" };

            // // C# 3.0 이후 간단한 초기화
            // var players = new List<string> { "철수", "영희", "민수" };

            // // how to add new elements
            // items.Add("Staff");
            // for (int i = 0; i < items.Count; i++)
            //     Console.Write($"{items[i]} ");



            // // List exercise
            // List<string> inventory = new List<string>();
            // Console.WriteLine("=== Assassing Inventory System ===\n");

            // // add inventory
            // inventory.Add("Health Potion");
            // inventory.Add("Mana Potion");
            // inventory.Add("Dagger of Moloc");
            
            // Console.WriteLine("3 Items Added to Inventory!");

            // for (int i = 0; i < inventory.Count; i++)
            // {
            //     Console.WriteLine($"[{i+1}]: {inventory[i]}");
            // }
            // Console.WriteLine("\n");

            // inventory.Add("Poison Vial");
            // inventory[1] = "Cloak of Mist";         // direct update
            // inventory.Insert(3, "Nimbus Boots");    // insert (squeeze in)
            // inventory.Remove("Health Potion");      // remove item by 'value'

            // for (int i = 0; i < inventory.Count; i++)
            // {
            //     Console.WriteLine($"[{i+1}]: {inventory[i]}");
            // }



            // // Dictionary
            // Dictionary<string, int> stats = new Dictionary<string, int>();

            // // add in data
            // stats.Add("HP", 100);
            // stats.Add("MP", 50);
            // stats.Add("Str", 75);

            // Console.WriteLine(stats["HP"]);
            // // when needing iteration in Dictionaly, using foreach is preferable



            // // Exercise: buying an item
            // Console.WriteLine("\n=== 상점 아이템 ===");
            // Dictionary<string, int> shop = new Dictionary<string, int>
            // {
            //     { "회복 포션", 50 },
            //     { "마나 포션", 40 },
            //     { "강철 검", 500 },
            //     { "가죽 갑옷", 300 },
            //     { "마법 반지", 1000 }
            // };
            
            // foreach (var item in shop)
            // {
            //     Console.WriteLine($"{item.Key}: {item.Value}골드");
            // }
            
            // // 구매 시스템
            // string buyItem = "강철 검";
            // int playerGold = 600;
            
            // if (shop.ContainsKey(buyItem))
            // {
            //     int price = shop[buyItem];
            //     if (playerGold >= price)
            //     {
            //         playerGold -= price;
            //         Console.WriteLine($"\n✅ '{buyItem}' 구매 성공!");
            //         Console.WriteLine($"남은 골드: {playerGold}");
            //     }
            //     else
            //     {
            //         Console.WriteLine($"\n❌ 골드가 부족합니다!");
            //     }
            // }



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

                    // key area
                    int pressKey;   // taking in int keyInfo

                    if(Console.KeyAvailable)    // check if key is pressed
                    {
                        pressKey = _getch();

                        switch (pressKey)
                        {
                            case 72:    // up arrow                  
                                playerY--;
                                if (playerY < 1)
                                    playerY = 1;
                                break;
                            case 75:    // left arrow
                                playerX--;
                                if (playerX < 0)
                                    playerX = 0;
                                break;
                            case 77:    // right arrow
                                playerX++;
                                if (playerX > 75)
                                    playerX = 75;
                                break;
                            case 80:    // down arrow
                                playerY++;
                                if (playerY > 21)
                                    playerY = 21;
                                break;
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
                            case ConsoleKey.Spacebar: Console.Write("미사일키"); break;
                            case ConsoleKey.Escape: return; //ESC키로 종료 
                        }
                    }

                    for (int i = 0; i < player.Length; i++)
                    {
                        // console coord
                        Console.SetCursorPosition(playerX, playerY + i);
                        // print the string array
                        Console.WriteLine(player[i]);
                    }
                }
            }


        }
    }
}