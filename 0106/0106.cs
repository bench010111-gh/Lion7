using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // // take in user input
            // Console.WriteLine("Enter your age:");

            // int age = int.Parse(Console.ReadLine()!);

            // Console.WriteLine($"Next year, you will be {age + 1} years old!");


            // // binary and int
            // Console.WriteLine("Enter a binary number:");
            // string binaryInput = Console.ReadLine()!;
            // int intValue = Convert.ToInt32(binaryInput, 2);

            // // int to binary
            // string binaryOutput = Convert.ToString(intValue, 2);

            // Console.WriteLine($"Input binary value is: {binaryInput}");
            // Console.WriteLine($"Converted int value is: {intValue}");
            // Console.WriteLine($"Converted back to binary: {binaryOutput}");


            // // exercise
            // Console.WriteLine("=== Character Creation ===");

            // Console.Write("Enter character's name: ");
            // string name = Console.ReadLine()!;
            // Console.WriteLine($"Welcome, {name}!");

            // Console.Write("\nEnter character's starting level: ");
            // string levelInput = Console.ReadLine()!;
            // Console.WriteLine($"{name}'s starting level is {levelInput}.");


            // // var
            // var name = "Alice";
            // var age = 25;
            // var isStudent = true;

            // Console.WriteLine($"Name: {name}, Age: {age}, Is Student: {isStudent}");
            // Console.WriteLine($"{name} is {name.GetType()}, {age} is {age.GetType()}, {isStudent} is {isStudent.GetType()}");


            // // default
            // int defaultInt = default;
            // bool defaultBool = default;
            // string defaultString = default;

            // Console.WriteLine($"Default int: {defaultInt}");
            // Console.WriteLine($"Default bool: {defaultBool}");
            // Console.WriteLine($"Default string: {defaultString ?? "null"}");


            // // operator
            // int a = 5, b = 3;
            // int sum = a + b;
            // bool isEqual = (a == b);

            // Console.WriteLine($"Sum: {sum}");
            // Console.WriteLine($"Are \'a\' and \'b\' equal? {isEqual}");

            // int a = 10, b = 3;
            // Console.WriteLine($"{a + b} \n{a - b} \n{a * b} \n{a / b} \n{a % b}");

            // string firstName = "John", lastName = "Doe";
            // string fullName = firstName + " " + lastName;
            // Console.WriteLine(fullName);


            // int a = 10, b = 3, c;

            // c = a + b;
            // a += b;
            // Console.WriteLine($"a + b = {c} = {a}");
            // a = 10; // reset a

            // c = a - b;
            // a -= b;
            // Console.WriteLine($"a - b = {c} = {a}");
            // a = 10; // reset a

            // c = a * b;
            // a *= b;
            // Console.WriteLine($"a * b = {c} = {a}");
            // a = 10; // reset a

            // c = a / b;
            // a /= b;
            // Console.WriteLine($"a / b = {c} = {a}");
            // a = 10; // reset a

            // c = a % b;
            // a %= b;
            // Console.WriteLine($"a % b = {c} = {a}");



            // // character stat estimation
            // int baseAttack = 50;
            // int weaponAttack = 30;
            // int totalAttack = baseAttack + weaponAttack;

            // Console.WriteLine("=== Attack Estimator ===");
            // Console.WriteLine($"Base Attack: {baseAttack}");
            // Console.WriteLine($"Weapon Attack: {weaponAttack}");
            // Console.WriteLine($"Total Attack: {totalAttack}");

            // // damage estimation
            // int playerHealth = 100;
            // int damage = 25;
            // playerHealth -= damage;

            // Console.WriteLine($"\n=== Damage Simulation ===");
            // Console.WriteLine($"Damage Taken: {damage}");
            // Console.WriteLine($"Remaining Health: {playerHealth}");

            // // experience points calculation
            // int monsterSlain = 5;
            // int expPerMonster = 100;
            // int totalExp = monsterSlain * expPerMonster;

            // Console.WriteLine($"\n=== Experience Points Calculation ===");
            // Console.WriteLine($"Monsters Slain: {monsterSlain}");
            // Console.WriteLine($"Experience per Monster: {expPerMonster}");
            // Console.WriteLine($"Total Experience Gained: {totalExp}");

            // // loot distribution
            // int totalGold = 1050;
            // int partyMembers = 4;
            // int goldPerMember = totalGold / partyMembers;
            // int remainingGold = totalGold % partyMembers;

            // Console.WriteLine($"\n=== Loot Distribution ===");
            // Console.WriteLine($"Total Gold: {totalGold}");
            // Console.WriteLine($"Party Members: {partyMembers}");
            // Console.WriteLine($"Gold per Member: {goldPerMember}");
            // Console.WriteLine($"Remaining Gold: {remainingGold}");


            // // increment and decrement operators
            // int b = 3;

            // Console.WriteLine(b++);   // 3
            // Console.WriteLine(b);     // 4
            // Console.WriteLine(++b);   // 5

            // Console.WriteLine(b--);   // 5
            // Console.WriteLine(b);     // 4
            // Console.WriteLine(--b);   // 3


            // // exercise
            // int kills = 0;
            // Console.WriteLine("=== Kill Counter ===");
            // Console.WriteLine($"Goblin slain! (Kill count: {++kills})");
            // Console.WriteLine($"Ork slain! (Kill count: {++kills})");
            // Console.WriteLine($"Dragon slain! (Kill count: {++kills})");

            // int bullets = 30;
            // Console.WriteLine($"\n=== Shooting Range ===");
            // Console.WriteLine($"Bullets remaining: {bullets}");
            // Console.WriteLine($"Shot fired! Bullets remaining: {--bullets}");
            // Console.WriteLine($"Shot fired! Bullets remaining: {--bullets}");
            // Console.WriteLine($"Shot fired! Bullets remaining: {--bullets}");

            // int countDown = 3;
            // Console.WriteLine($"\n=== Countdown Timer ===");
            // Console.WriteLine($"Countdown: {countDown--}");
            // Console.WriteLine($"Countdown: {countDown--}");
            // Console.WriteLine($"Countdown: {countDown--}");
            // Console.WriteLine("Liftoff!");


            // // bitwise operators & | ^ ~ 
            // int x = 5;  // 0101
            // int y = 3;  // 0011

            // Console.WriteLine(x & y);  // 0001 = 1
            // Console.WriteLine(x | y);  // 0111 = 7
            // Console.WriteLine(x ^ y);  // 0110 = 6
            // Console.WriteLine(~x);     // 1010 = -6 (two's complement)

            // // shift operators >> <<
            // Console.WriteLine(x >> 1); // 0010 = 2
            // Console.WriteLine(x << 1); // 1010 = 10


            // Assignment
            // Problem 1:
            Console.WriteLine("=== Problem 1: Health Point ===");

            int currentHP = 80;
            int maxHP = 100;
            Console.WriteLine($"Initial HP: {currentHP}/{maxHP}");

            currentHP -= 25; // damage taken
            Console.WriteLine($"After taking 25 damage: {currentHP}/{maxHP}");

            currentHP += 30; // healing received
            Console.WriteLine($"After receiving 30 healing: {currentHP}/{maxHP}");

            currentHP -= 5; // poison damage
            Console.WriteLine($"After taking 5 poison damage: {currentHP}/{maxHP}");

            // Problem 2:
            Console.WriteLine("\n=== Problem 2: Experience and Level ===");
            int expPerMonster = 150;
            int monstersKilled = 3;
            int expForLevelUp = 500;

            Console.WriteLine($"Monsters slain: {monstersKilled}");
            Console.WriteLine($"Total experience gained: {monstersKilled * expPerMonster}");
            Console.WriteLine($"Experience needed for level up: {expForLevelUp - (monstersKilled * expPerMonster)}");

            // Problem 3:
            Console.WriteLine("\n=== Problem 3: Loot Distribution ===");
            int totalGold = 1234;
            int partyMembers = 5;

            Console.WriteLine($"Total gold collected: {totalGold}");
            Console.WriteLine($"Number of party members: {partyMembers}");
            Console.WriteLine($"Gold per member: {totalGold / partyMembers}");
            Console.WriteLine($"Remaining gold: {totalGold % partyMembers}");

            // Problem 4:
            Console.WriteLine("\n=== Problem 4: Dungeon Entry Requirements ===");
            int playerLevel = 35;
            int requiredLevel = 30;
            bool hasKey = true;
            int currentHP1 = 60;
            int maxHP1 = 100;

            Console.WriteLine("=== Dungeon Entry Requirements ===");
            Console.WriteLine($"Level Requirement (>=30): {playerLevel >= requiredLevel}");
            Console.WriteLine($"Key Possession: {hasKey}");
            Console.WriteLine($"Health Requirement (>=50%): {currentHP1 >= (maxHP1 / 2)}");
            Console.WriteLine($"Can Enter Dungeon: {playerLevel >= requiredLevel && hasKey && currentHP1 >= (maxHP1 / 2)}");

            // Problem 5:
            Console.WriteLine("\n=== Problem 5: Shop Discount ===");
            int originalPrice = 5000;
            bool isVIP = true;      // 20% discount
            bool hasCoupon = true;  // 500g discount
            int updatedPrice = originalPrice;

            Console.WriteLine($"Original Price: {originalPrice} gold");
            if (isVIP)
            {
                updatedPrice = (int)(originalPrice * 0.8);
                Console.WriteLine($"VIP Discount (20%): {originalPrice * 0.8 } gold");
            } else {
                Console.WriteLine($"VIP Discount (20%): {updatedPrice} (No discount applied)");
            }

            if (hasCoupon)
            {
                updatedPrice -= 500;
                Console.WriteLine($"Coupon Discount (500g): {updatedPrice} gold");
            } else {
                Console.WriteLine($"Coupon Discount (500g): {updatedPrice} gold (No discount applied)");
            }


        }    
    }
}
