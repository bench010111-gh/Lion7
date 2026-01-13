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
    // class definition -> member and method
    class Character_
    {
        // public can be accessed anywhere
        // private can only be accessed internally

        private string name = "";
        private int level;
        private int hp;
        private int maxHp;
        private int mp;
        private int maxMp;

        // Constructor is widely used for initialization
        public Character_ ()
        {
            name = "Ben Choi";
            level = 1;
            hp = 100;
            maxHp = 150;
            mp = 80;
            maxMp = 100;
        }

        // Access Modifier
        public Character_ (string _name, int _level, int _hp, int _maxHp, int _mp, int _maxMp)
        {
            name = _name;
            level = _level;
            hp = _hp;
            maxHp = _maxHp;
            mp = _mp;
            maxMp = _maxMp;
        }

        public void ShowStats()
        {
            Console.WriteLine($"=== {name}'s Stats ===");
            Console.WriteLine($"Level: {level}");
            Console.WriteLine($"Health Point: {hp} / {maxHp}");
            Console.WriteLine($"Health Point: {mp} / {maxMp}");
            Console.WriteLine();
        }
    }

    // ============ Character Class Definition
    class Character
    {
        // field
        private string name = "";
        private int level;
        private int hp;
        private int maxHP;
        private int mp;
        private int maxMP;

        public Character ()
        {
            name = "Lorem Ipsum";
            level = 1;
            hp = 1;
            maxHP = 1;
            mp = 1;
            maxMP = 1;
        }

        public void SetInfo (string _name, int _level, int _hp, int _maxHp, int _mp, int _maxMp)
        {
            name = _name;
            level = _level;
            hp = _hp;
            maxHP = _maxHp;
            mp = _mp;
            maxMP = _maxMp;
        }

        // method
        public void ShowInfo()
        {
            Console.WriteLine($"━━━━━━━━━━━━━━━━━━━━");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Level: {level}");
            Console.WriteLine($"HP: {hp}/{maxHP}");
            Console.WriteLine($"MP: {mp}/{maxMP}");
            Console.WriteLine($"━━━━━━━━━━━━━━━━━━━━");
            Console.WriteLine();
        }

        public void TakeDamage (int damage)
        {
            hp -= damage;
            if (hp < 0) hp = 0;

            Console.WriteLine($"⚔️ {name} has taken {damage} damage!");
            Console.WriteLine($"    current HP: {hp}/{maxHP}");
            Console.WriteLine();
        }

        public void Heal (int amount)
        {
            hp += amount;
            if (hp > maxHP) hp = maxHP;

            Console.WriteLine($"💚 {name}'s HP has been healed by {amount}!");
            Console.WriteLine($"    current HP: {hp}/{maxHP}");
            Console.WriteLine()
;        }
    }

    internal class Program
    {
        // static void Main(string[] args)
        // {
        //     Console.Clear();

        //     // create class object
        //     Character player = new(); // automatic Const Call
        //     player.ShowStats();

        //     Character player2 = new("John Kim", 2, 110, 250, 80, 100);
        //     player2.ShowStats();
        // }

        static void Main(string[] args)
        {
            Console.Clear();
            // procedure oriented vs object oriented

            // call constructure
            Character player1 = new Character();
            player1.SetInfo("Ben Choi", 10, 150, 150, 80, 80);

            // print method call
            player1.ShowInfo();
            player1.TakeDamage(50);
            player1.Heal(30);

            // make new object, then print
            Character player2 = new Character();
            player2.SetInfo("John Kim", 12, 220, 220, 100, 100);
            player2.ShowInfo();
        }
            
    }
}