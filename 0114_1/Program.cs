using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// inheritance

namespace _0114_1
{
    // parent class
    class Character
    {
        // public, private, protected(allow usage by child)
        protected string name = "";
        protected int level;
        protected int hp;
        protected int maxHP;
        protected int attack;
        protected int defense;

        public Character(string characterName)
        {
            name = characterName;
            level = 1;
            maxHP = 1;
            hp = maxHP;
            attack = 30;
            defense = 20;

            Console.WriteLine($"Character {name} created!");
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Name : {name}");
            Console.WriteLine($"Level : {level}");
            Console.WriteLine($"HP : {hp}/{maxHP}");
            Console.WriteLine($"Attack : {attack}");
            Console.WriteLine($"Defense : {defense}");
        }
    }

    class Warrior : Character
    {
        private int rage; // warrior-unique attribute

        public Warrior(string name) : base(name) // put name parameter to parent's constructr
        {
            // name = "Warrior";   // same as base.name
            attack = 60;
            defense = 40;
            maxHP = 150;
            hp = maxHP;
            rage = 0;

            Console.WriteLine("Job : Warrior");
        }

        public override void ShowInfo()
        {
            // base.ShowInfo();    // can function call parent function
            Console.WriteLine($"Rage : {rage}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Character character = new Character("Peter");
            // character.ShowInfo();

            // Warrior warrior = new Warrior("John");
            // warrior.ShowInfo();

            Character character = new Warrior("PJ");
            character.ShowInfo();

            // inheritance relationship
            // child calling: parent constructor, then child constructor
            //                  child destructor, then parent destructor

            // how to intialize parent member via child member
            
        }
    }
}
