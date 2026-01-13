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
using System.Runtime.CompilerServices;

namespace ConsoleApp9
{
    internal class Program
    {

        // default parameter
        static void CastFireBall (string target, int damage = 100, int manaCost = 30)
        {
            Console.WriteLine($" Cast Fireball!");
            Console.WriteLine($" Target:    {target}");
            Console.WriteLine($" Damage:    {damage}");
            Console.WriteLine($" Mana Cost: {manaCost}");
        }

        // use item
        static void UseItem (string item, int healValue)
        {
            Console.WriteLine($" 💊 Used {item}!");
            Console.WriteLine($" Healing Amount: {healValue} HP");
            Console.WriteLine();
        }

        // cast summon
        static void CastSummon (string mob, int level, int amount)
        {
            Console.WriteLine($" ✨ Summoned {mob}!");
            Console.WriteLine($" Level: {level}");
            Console.WriteLine($" Amount: {amount}");
            Console.WriteLine();
        }

        // ref keyword (better pointer)
        static void Attack(ref int a)
        {
            Console.WriteLine("Damag : " + a);
            a++;
        }

        // out keyword to output multiple returns
        static void Attack(int a, int d, out int attack, out int defense)
        {
            attack = a;
            defense = d;

            attack++;
            defense++;
        }



        // static void Main(string[] args)
        // {
        //     Console.Clear();

        //     //
        //     // Console.WriteLine("=== Use Item === \n");
        //     // UseItem("Health Potion", 50);
        //     // UseItem("High Quality Health Potion", 100);
        //     // Console.WriteLine("=== Cast: Summon === \n");
        //     // CastSummon("Slime", 1, 1);
        //     // CastSummon("Goblin", 5, 1);
        //     // CastSummon("Dragon", 50, 3);

        //     // // ref
        //     // int a = 10;
        //     // Attack (ref a);
        //     // Console.WriteLine("a value : " + a);

        //     // // out
        //     // int attack;
        //     // int defense;
        //     // Attack(10, 20, out attack, out defense);
        //     // Console.WriteLine($"Damage : {attack}");
        //     // Console.WriteLine($"Armor : {defense}");
        // }



        // // normal
        // static void Swap1(int a, int b)
        // {
        //     int temp = a;
        //     a = b;
        //     b = temp;
        // }

        // // ref
        // static void Swap2(ref int a, ref int b)
        // {
        //     int temp = a;
        //     a = b;
        //     b = temp;
        // }

        // static void Main(string[] args)
        // {
        //     Console.Clear();

        //     int x = 10;
        //     int y = 20;

        //     Swap2(ref x, ref y);

        //     Console.WriteLine($"x: {x}, y: {y}");
        // }



        // recursion
        // getting 1 to n's Sum
        
        static int SumToN(int n)
        {
            if (n <= 0)
            {
                return 0;
            }

            return n + SumToN(n - 1);
        }



        // =====================================================================================
        // // 문제 1: 평균 계산 함수: 정수 배열을 받아 평균을 반환하는 함수를 만드세요.
        // static double GetAverage(List<int> numArr)
        // {
        //     double sum = 0;
        //     double avg;

        //     for (int i = 0; i < numArr.Count; i++)
        //     {
        //         sum += numArr[i];
        //     }

        //     avg = sum / (double)numArr.Count;
        //     return avg;
        // }

        // static void Main(string[] args)
        // {
        //     Console.Clear();


        //     Console.WriteLine("Enter numbers (put x to finish): "); // take in user input 'til x
        //     List<int> numArr1 = new List<int>();    // List<num> initialized
        //     while (true)
        //     {
        //         string userInput = Console.ReadLine()!;
        //         if (userInput == "x") break;    // break condition

        //         int inputNumber = int.Parse(userInput);
                
        //         numArr1.Add(inputNumber);
        //     }
        //     double numArr1Avg = GetAverage(numArr1);    // function call

        //     Console.Write("The average of given array [");  // printing elements
        //     for (int i = 0; i < numArr1.Count; i++)
        //     {
        //         if (i == numArr1.Count - 1)
        //             Console.Write(numArr1[i]);
        //         else
        //             Console.Write(numArr1[i] + ", ");
        //     }
        //     Console.Write("] is: ");

        //     Console.WriteLine(numArr1Avg);  // printing average
        // }


        // =====================================================================================
        // // 문제 2: 등급 판별 함수: 점수를 받아 A, B, C, D, F 등급을 반환하는 함수를 만드세요.
        // static string GradeScore (int score)
        // {
        //     if      (score >= 90) return "A";
        //     else if (score >= 80) return "B";
        //     else if (score >= 70) return "C";
        //     else if (score >= 60) return "D";
        //     else return "F";
        // }

        // static void Main(string[] args)
        // {
        //     Console.Clear();

        //     Console.Write("Enter score: ");
        //     int score = int.Parse(Console.ReadLine()!);

        //     string grade = GradeScore(score);

        //     Console.WriteLine($"The grade for score {score} is {grade}");
        // }


        // =====================================================================================
        // // 문제 3: 소수 판별 함수: 숫자를 받아 소수인지 판별하는 함수를 만드세요.
        // static bool IsPrime (int num)
        // {
        //     if (num <= 1) return false;
        //     if (num == 2) return true;
        //     if (num % 2 == 0) return false;

        //     var boundary = (int)Math.Floor(Math.Sqrt(num));
                
        //     for (int i = 3; i <= boundary; i += 2)
        //         if (num % i == 0)
        //             return false;
            
        //     return true; 
        // }

        // static void Main(string[] args)
        // {
        //     Console.Clear();

        //     Console.Write("Enter a number: ");
        //     int num = int.Parse(Console.ReadLine()!);

        //     bool isNumPrime = IsPrime(num);

        //     if (isNumPrime)
        //         Console.WriteLine("The input number is prime!");
        //     else
        //         Console.WriteLine("The input number is not prime!");
        // }


        // =====================================================================================
        // // 문제 4: 경험치 시스템: 현재 경험치와 획득 경험치를 받아 레벨업 여부와 새 경험치를 반환하는 함수를 만드세요. (out 사용)
        // static void ReturnLevelUpBoolAndRemainingExp (int currentExp, int earnedExp, out bool canLevelUp, out int updatedExp)
        // {
        //     int levelUpReq = 100;
        //     int totalExp = currentExp + earnedExp;

        //     if (totalExp >= levelUpReq)
        //     {
        //         canLevelUp = true;
        //         updatedExp = totalExp % levelUpReq;;
        //     }
        //     else
        //     {
        //         canLevelUp = false;
        //         updatedExp = totalExp;
        //     }
        // }

        // static void Main(string[] args)
        // {
        //     Console.Clear();

        //     Console.Write("Enter current Exp: ");
        //     int currentExp = int.Parse(Console.ReadLine()!);

        //     Console.Write("Enter earned Exp: ");
        //     int earnedExp = int.Parse(Console.ReadLine()!);

        //     ReturnLevelUpBoolAndRemainingExp(currentExp, earnedExp, out bool canLevelUp, out int updatedExp);

        //     Console.WriteLine();
        //     Console.WriteLine("Required Exp to level up is: 100");
        //     Console.WriteLine($"Can level up: {canLevelUp}");
        //     Console.WriteLine($"Updated Exp: {updatedExp}");

        // }


        // =====================================================================================
        // 문제 5: 아이템 강화 시스템 강화 레벨에 따라 성공 확률이 달라지는 아이템 강화 시스템을 함수로 구현하세요.
        static double UpdateUpgradeChance (int currentUpgrade)
        {
            double baseChance = 0.9;   // start from 90%
            double decay = 0.85;       // chance decay factor

            double upgradeChance = baseChance * Math.Pow(decay, currentUpgrade);    // exponential

            // ceiling limit to least chance
            if (upgradeChance < 0.05)
                upgradeChance = 0.05;

            return upgradeChance;
        }   // +0:90%, +1:77%, +3:55%, +5:39%, +7:28%, +10:17%

        static void Main(string[] args)
        {
            Console.Clear();

            int currentUpgrade = 0;
            Random rand = new Random();

            Console.WriteLine("=== Item Upgrade Anvil ===");
            Console.WriteLine("Press Enter to Hammer!\n");

            while (true)
            {
                Console.Write($"\nCurrent Upgrade Level: +{currentUpgrade} | ");
                double chance = UpdateUpgradeChance(currentUpgrade);

                Console.Write($"Success Chance: {(chance * 100):F1}% | ");
                Console.WriteLine("Press Enter to try upgrading (ESC to quit)");

                ConsoleKey key = Console.ReadKey(true).Key;
                if (key == ConsoleKey.Escape)
                    break;

                double roll = rand.NextDouble(); // 0.0 ~ 1.0

                if (roll <= chance)
                {
                    currentUpgrade++;
                    Console.WriteLine("✨ Upgrade SUCCESS!");
                }
                else
                {
                    Console.WriteLine("💥 Upgrade FAILED!");
                }
            }
        }

    }

}