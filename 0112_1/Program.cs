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

        // level 2: parameter
        // exercise: TODO
        static void PlayerStat (string name, int att, int def, int dex, int luc)
        {
            Console.WriteLine($"Hello, {name}! You have: ");
            Console.WriteLine(att + " Attack, ");
            Console.WriteLine(def + " Defence, ");
            Console.WriteLine(dex + " Dexterity, ");
            Console.WriteLine(luc + " Luck");
        }



        // level 3: return
        static void GreetPlayer (string playerName)
        {
            Console.WriteLine($"Welcome. {playerName}!");
        }

        static void ShowPlayerInfo(string job, int level)
        {
            Console.WriteLine($"Job : {job}");
            Console.WriteLine($"Level : {level}");
        }

        static void DrawHealthBar(int current, int max, int barLength)
        {
            Console.Write("HP [");
            
            int filledLength = (int)((double)current / max * barLength);

            for (int i = 0 ; i < barLength; i++)
            {
                if (i < filledLength)
                    Console.Write("■");
                else
                    Console.Write("□");
            }

            Console.WriteLine($"] {current}/{max}");
        }

        // damage calc print
        static void ShowDamage(string attacker, string target, int damage)
        {
            Console.WriteLine($"{attacker}'s attack!");
            Console.WriteLine($"    tp {target}, {damage} damage dealt!");
        }



        // level 3: return type
        // int return
        static int GetNumber()
        {
            return 42;
        }
        // string return (applying)
        static string ConnectMessage(string name)
        {
            return name + " has entered the server";
        }



        static void Main(string[] args)
        {
            Console.Clear();

            // PlayerStat ("Ben", 100, 20, 30, 5);



            // // passing parameter
            // GreetPlayer("Ben Choi");
            // Console.WriteLine();

            // ShowPlayerInfo("Barbarian", 50);
            // Console.WriteLine();

            // DrawHealthBar(75, 100, 20);
            // DrawHealthBar(30, 100, 20);
            // DrawHealthBar(100, 100, 20);
            // Console.WriteLine();

            // ShowDamage("Player", "Goblin", 85);
            // Console.WriteLine();
            // ShowDamage("Dragon", "Player", 120);
            // Console.WriteLine();



            // level 3
            int num = GetNumber();
            Console.WriteLine("returned number: " + num);

            string cm = ConnectMessage("Aetherean");
            Console.WriteLine(cm);

        }

    }

}