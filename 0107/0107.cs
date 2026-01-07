using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Security.Principal;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            // // ternary operator
            // int a = 10, b = 20;
            // int max = (a > b) ? a : b;
            // Console.WriteLine(max);

            // int score = 85;
            // string grade = (score >= 90) ? "pass" : "fail";
            // Console.WriteLine("=== P/F Grading using ternary ===");
            // Console.WriteLine($"Student A {score}: {grade}");


            // int playerLevel = 45;
            // string classType =  (playerLevel >  50) ? "Advanced" :
            //                     (playerLevel >= 30) ? "Intermediate" : "Beginner";
            // Console.WriteLine("=== Player Class Type ===");
            // Console.WriteLine($"Player Level: {playerLevel}, Class Type: {classType}");


            // int currentHealth = 30;
            // int maxHealth = 100;
            // string healthStatus = (currentHealth >= 70) ? "Healthy" :
            //                       (currentHealth >= 30) ? "Injured" : "Danger";

            // Console.WriteLine("=== Player Health Status ===");
            // Console.WriteLine($"Current Health: {currentHealth}/{maxHealth}");
            // Console.WriteLine($"Status: {healthStatus}");


            // // operator priority
            // int result = 10 + 2 * 5;
            // Console.WriteLine(result);  // 20

            // int result2 = (10 + 2) * 5;
            // Console.WriteLine(result2); // 60


            // // 예제 2: 데미지 계산
            // int baseDamage = 50;
            // int bonusDamage = 20;
            // double criticalMultiplier = 1.5;

            // // 잘못된 계산
            // double damage1 = baseDamage + bonusDamage * criticalMultiplier;
            // // 올바른 계산
            // double damage2 = (baseDamage + bonusDamage) * criticalMultiplier;

            // Console.WriteLine("\n=== 크리티컬 데미지 계산 ===");
            // Console.WriteLine($"기본 데미지: {baseDamage}");
            // Console.WriteLine($"보너스 데미지: {bonusDamage}");
            // Console.WriteLine($"크리티컬 배율: {criticalMultiplier}");
            // Console.WriteLine($"잘못된 계산: {damage1}");  // 80.0
            // Console.WriteLine($"올바른 계산: {damage2}");  // 105.0


            // // control operators: if statement
            // int score = 85;
            // if (score >= 90)
            //     Console.WriteLine("A Grade");
            // else 
            //     Console.WriteLine("Below 90");
            // // result: Below 90

            // // control operators: else statement
            // int number = 10;
            // if (number > 15)
            //     Console.WriteLine("Number is greater than 15");
            // else
            //     Console.WriteLine("Number is 15 or less");
            // // result: Number is 15 or less

            // // control operators: else if statement
            // int score = 75;
            // Console.Write($"Score: {score} - ");
            // if (score >= 90)
            // {
            //     Console.WriteLine("A Grade");
            // } 
            // else if (score >= 80)
            // {
            //     Console.WriteLine("B Grade");
            // }
            // else if (score >= 70)
            // {
            //     Console.WriteLine("C Grade");
            // }
            // else
            // {
            //     Console.WriteLine("F Grade");
            // }


            // // exercise
            // int currentHealth = 30, maxHealth = 100;

            // Console.WriteLine($"Current Health: {currentHealth}/{maxHealth}");

            // if (currentHealth < 30)
            // {
            //     Console.WriteLine("⚠️ Warning: Low Health!");
            //     Console.WriteLine("Use Recovery Item!");
            // }

            // if (currentHealth <= 50)
            // {
            //     Console.WriteLine("💊 Health is below 50%.");
            // }

            // if (currentHealth == 0)
            // {
            //     Console.WriteLine("💀 Game Over.");
            //     Console.WriteLine("Respawn at the starting point.");
            // }

            // Console.WriteLine("");

            // int enemyDistance = 5;
            // int attackRange = 3;

            // if (attackRange <= enemyDistance)
            // {
            //     Console.WriteLine("⚔️ Enemy is within attack range!");
            //     Console.WriteLine("Attack Possible!");
            // }
            // else
            // {
            //     Console.WriteLine("🏃 Enemy is out of range.");
            //     Console.WriteLine("Move closer to attack.");
            // }


            // // Item Purchase System
            // // int playerGold = 500;
            // int itemPrice = 250;
            // string itemName = "Steel Blade";

            // Console.WriteLine("Enter Player Gold Amount:");
            // int playerGold = int.Parse(Console.ReadLine()!);


            // Console.WriteLine("=== Shop ===");
            // Console.WriteLine($"Item: {itemName}");
            // Console.WriteLine($"Price: {itemPrice} Gold");
            // Console.WriteLine($"\nPlayer Gold: {playerGold} Gold");
            // Console.WriteLine("");

            // if (playerGold >= itemPrice)
            // {
            //     // Player can afford the item
            //     playerGold -= itemPrice;
            //     Console.WriteLine($"Purchase Successful!");
            //     Console.WriteLine($"You bought a {itemName}");
            //     Console.WriteLine($"Remaining Gold: {playerGold} Gold");
            // }
            // else
            // {
            //     // Player cannot afford the item
            //     Console.WriteLine("Insufficient Gold!");
            //     Console.WriteLine($"You need {itemPrice - playerGold} more Gold to buy {itemName}");
            // }


            // // score-based grading system
            // Console.Write("Enter Score: ");
            // int score = int.Parse(Console.ReadLine()!);
            // string rank = "";

            // Console.WriteLine("=== Score-based Ranking System ===");
            // Console.WriteLine($"Score: {score}");

            // if (score >= 10000)
            // {
            //     rank = "SSS";
            //     Console.WriteLine($"Rank: \"{rank}\" (Legend)");
            //     Console.WriteLine($"Reward: Legendary Item + 10k Gold");
            // } 
            // else if (score >= 8000){
            //     rank = "SS";
            //     Console.WriteLine($"Rank: \"{rank}\" (Master)");
            //     Console.WriteLine($"Reward: Epic Item + 5k Gold");
            // } 
            // else if (score >= 6000)
            // {
            //     rank = "S";
            //     Console.WriteLine($"Rank: \"{rank}\" (Diamond)");
            //     Console.WriteLine($"Reward: Rare Item + 3k Gold");
            // } 
            // else if (score >= 4000)
            // {
            //     rank = "A";
            //     Console.WriteLine($"Rank: \"{rank}\" (Platinum)");
            //     Console.WriteLine($"Reward: Uncommon Item + 1.5k Gold");
            // } 
            // else
            // {
            //     rank = "B";
            //     Console.WriteLine($"Rank: \"{rank}\" (Gold)");
            //     Console.WriteLine($"Reward: Common Item + 500 Gold");
            // }


            // // health status checker
            // Console.WriteLine("=== Player Health Status Checker ===");
            // Console.Write("Enter Current Health: ");
            // int currentHealth = int.Parse(Console.ReadLine()!);
            // //string healthStatus = "";

            // if (currentHealth >= 80)
            // {
            //     Console.WriteLine("Health Status: Healthy 💚");
            // }
            // else if (currentHealth >= 60)
            // {
            //     Console.WriteLine("Health Status: Good 🟢");
            // }
            // else if (currentHealth >= 40)
            // {
            //     Console.WriteLine("Health Status: Normal 🟡");
            // }
            // else if (currentHealth >= 20)
            // {
            //     Console.WriteLine("Health Status: Danger 🟠");
            // }
            // else
            // {
            //     Console.WriteLine("Health Status: Critical 🔴");
            // }


            // // contrl operators: switch statement
            // Console.WriteLine("=== Day of the Week ===");
            // Console.Write("Enter day number (1-7): ");
            // int day = int.Parse(Console.ReadLine()!);

            // switch (day)
            // {
            //     case 1 :
            //         Console.WriteLine("Monday");
            //         break;
            //     case 2 :
            //         Console.WriteLine("Tuesday");
            //         break;
            //     case 3 :
            //         Console.WriteLine("Wednesday");
            //         break;
            //     case 4 :
            //         Console.WriteLine("Thursday");
            //         break;
            //     case 5 :
            //         Console.WriteLine("Friday");
            //         break;
            //     case 6 :
            //         Console.WriteLine("Saturday");
            //         break;
            //     case 7 :
            //         Console.WriteLine("Sunday");
            //         break;
            //     default :
            //         Console.WriteLine("Invalid day number. Please enter a number between 1 and 7.");
            //         break;
            // }


            // exercise
            // Console.WriteLine("=== Character Selection ===");
            // Console.WriteLine("1: Warrior, 2: Mage, 3: Archer, 4: Thief");
            // Console.Write("Select your chracter: ");
            // int characterChoice = int.Parse(Console.ReadLine()!);

            // string characterClass = "";
            // string specialty = "";
            // string mainWeaponry = "";
            // string stat = "";

            // switch (characterChoice)
            // {
            //     case 1:
            //         characterClass = "Warrior";
            //         specialty = "Unbreaking Will";
            //         mainWeaponry = "Heavy Arms";
            //         stat = "Health +100, Attack +50";
            //         break;
            //     case 2:
            //         characterClass = "Mage";
            //         specialty = "Magic Bolts";
            //         mainWeaponry = "Staffs, Tomes";
            //         stat = "Mana +100, Attack +70";
            //         break;
            //     case 3:
            //         characterClass = "Archer";
            //         specialty = "Marksmanship";
            //         mainWeaponry = "Bows";
            //         stat = "Speed +50, Attack +70";
            //         break;
            //     case 4:
            //         characterClass = "Thief";
            //         specialty = "Stealth";
            //         mainWeaponry = "Daggers";
            //         stat = "Agility +100, Attack +60";
            //         break;
            //     default:
            //         Console.WriteLine("Invalid selection. Please choose a number between 1 and 4.");
            //         break;
            // }

            // Console.WriteLine($"Character Class: {characterClass}!");
            // Console.WriteLine($"Specialty: {specialty}");
            // Console.WriteLine($"Main Weaponry: {mainWeaponry}");
            // Console.WriteLine($"Stat: {stat}");


            // // control opeartors: for loop
            // Console.WriteLine("=== Wave 1 ===");
            // int waveMonsterCount = 5;

            // for (int i = 1; i <= waveMonsterCount; i++)
            // {
            //     Console.WriteLine($"Goblin #{i} spawned!");
            // }
            // Console.WriteLine($"\nTotal {waveMonsterCount} goblins spawned!");


            // // exercise
            // Console.WriteLine("=== Game Countdown ===");

            // for (int i = 5; i >= 1; i--)
            // {
            //     Console.WriteLine($"{i}...");
            //     Thread.Sleep(1000);
            // }
            // Console.WriteLine("Start!");


            // // infinite loop
            // for (int i = 0; ; i++)
            // {
            //     Console.Write($"\rInfinite Loop Count: {i}");
            //     Thread.Sleep(500);
            // }


            // rng
            // Console.WriteLine("=== Random Loot Drops ===");
            // Random rand = new Random();
            // int number = rand.Next(1, 7); // die 

            // Console.WriteLine($"You rolled a {number}!");


            // exercise
            // Console.WriteLine("=== 20 Loot Crates ===");

            // // Infinity Edge: 5%
            // // Bloodthirster: 10%
            // // Statikk Shiv: 15%
            // // Zeal: 30%
            // // Doran's Blade: 40%

            // string[] lootItems = ["Infinity Edge", "Bloodthirster", "Statikk Shiv", "Zeal", "Doran's Blade"];

            // Random rand = new();
            // int random;

            // for( int i = 1; i <= 20; i++)
            // {
            //     random = rand.Next(1, 201);
            //     if (random <= 5)
            //     {
            //         Console.WriteLine($"#{i}: {lootItems[0]}!");
            //     }
            //     else if (random <= 15)
            //     {
            //         Console.WriteLine($"#{i}: {lootItems[1]}!");
            //     }
            //     else if (random <= 30)
            //     {
            //         Console.WriteLine($"#{i}: {lootItems[2]}!");
            //     }
            //     else if (random <= 60)
            //     {
            //         Console.WriteLine($"#{i}: {lootItems[3]}!");
            //     }
            //     else if (random <= 100)
            //     {
            //         Console.WriteLine($"#{i}: {lootItems[4]}!");
            //     }
            //     else
            //     {
            //         Console.WriteLine($"#{i} BETTER LUCK NEXT TIME!");
            //     }

            //     Thread.Sleep(200);
            // }


            // // Assignment 1: Clothing Recommendation based on Temperature
            // Console.Write("Input temperature: ");
            // int temp = int.Parse(Console.ReadLine()!);

            // Console.WriteLine($"Current Temperature is {temp} C!");

            // if (temp >= 30)
            // {
            //     Console.WriteLine("Too hot! Wear a T-shirt and a pair of shorts.");
            // }
            // else if (temp >= 20)
            // {
            //     Console.WriteLine("Just right! Wear a long-sleeve shirt.");
            // }
            // else if (temp >= 10)
            // {
            //     Console.WriteLine("Chilly! Wear a cardigan or a jacket.");
            // }
            // else
            // {
            //     Console.WriteLine("Cold! Please wear paddings and a muffler!");
            // }

            // // Assignment 2: Choosing a Class of Game Character
            // Console.Write("Choose a class (1:Warrior, 2:Mage, 3:Archer, 4:Thief): ");
            // string characterClass = Console.ReadLine()!;

            // Console.WriteLine("\n=== Character Creation ===");

            // switch (characterClass)
            // {
            //     case "1" :
            //         Console.WriteLine("Warrior: high HP and Armor\nStat: HP +50, Dmg +10");
            //         break;
            //     case "2" :
            //         Console.WriteLine("Mage: potent Magic Arrow\nStat: MP +100, Mgc +20");
            //         break;
            //     case "3" :
            //         Console.WriteLine("Archer: ranged Attack specialist\nStat: Agl +15, Crt +10%");
            //         break;
            //     case "4" :
            //         Console.WriteLine("Thief: fast Speed and Dodge\nStat: Agl +20, Dge +15%");
            //         break;
            //     default :
            //         Console.WriteLine("Wrong input. Choose from 1 ~ 4");
            //         break;
            // }


            // sword enchatment exercise
            // system: consume 1 token per attempt, 30% to enchant +1, max +3, if fail then back to +0

            string weaponName = "Rocket Hammer";
            int currentEnchantLevel = 0;

            int enchantmentToken = 15;
            int enchantmentSuccessChance = 3; // 30%
            int maxEnchant = 3;

            Random rand = new();
            int rngOutcome;

            for (int i = 0; i < enchantmentToken; i++)  // try until token runs out
            {
                rngOutcome = rand.Next(1, 11);          // take rng from 1~10
                Console.WriteLine("Enchanting...");
                Thread.Sleep(2000);
                if (rngOutcome <= enchantmentSuccessChance) // if (30% chance)
                {
                    currentEnchantLevel++;                  // enchant success
                    if (currentEnchantLevel == maxEnchant)  // if max enchant level +3
                    {
                        Console.WriteLine($"Amazing! your \"{weaponName}\" is now max level +{maxEnchant}");
                        break;  // break;
                    }
                    Console.WriteLine($"Congratulations! your \"{weaponName}\" is now enchanted to +{currentEnchantLevel}");    // +1, +2 case
                }
                else    // failed attempt
                {
                    currentEnchantLevel = 0;    // back to +0
                    Console.WriteLine($"Better luck next time! your \"{weaponName}\" is now back to +{currentEnchantLevel}");
                }

                enchantmentToken--;     // anyways, take away 1 token

                Console.WriteLine($"Remaining Token: {enchantmentToken}\n");
                Thread.Sleep(2000);
            }


        }

    }
}