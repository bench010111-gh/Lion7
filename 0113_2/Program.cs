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
using System.Linq.Expressions;

namespace ConsoleApp9
{

    internal class Program
    {
        class Monster
        {
            // field
            public string name = "";
            public int level;
            public int hp;
            public int attack;
            public int defense;
            public int expReward;

            // basic constructor
            public Monster ()
            {
                name        = "Slime";
                level       = 1;
                hp          = 50;
                attack      = 10;
                defense     = 5;
                expReward   = 10;
            }

            // constructor with parameter
            public Monster (string monsterName, int monsterLevel)
            {
                name        = monsterName;
                level       = monsterLevel;
                hp          = 50 * level;
                attack      = 10 * level;
                defense     = 5 * level;
                expReward   = 10 * level;
            }

            // print info
            public void ShowStats()
            {
                Console.WriteLine($"👾 {name} (Lv.{level})");
                Console.WriteLine($"   HP: {hp}");
                Console.WriteLine($"   ATK: {attack}");
                Console.WriteLine($"   DEF: {defense}");
                Console.WriteLine($"   EXP: {expReward}");
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Console.Clear();

            // ex 1: basic constructor
            Monster slime = new();
            // slime.ShowStats();

            // ex 2: parametric constructor | Goblin Lv.5
            Monster goblin = new("Goblin", 5);
            // goblin.ShowStats();

            Console.WriteLine("=== Field Monster ===\n");
            Monster[] monsters = new Monster[3];
            monsters[0] = new Monster("Wolf", 3);
            monsters[1] = new Monster("Ork", 7);
            monsters[2] = new Monster("Troll", 10);

            for (int i = 0; i < monsters.Length; i++)
            {
                monsters[i].ShowStats();
            }

        }
            
    }
}