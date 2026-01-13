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

        // Method Overloading - if different parameter, 
        //      then can use mult functions of same name
        static void Attack()
        {
            Console.WriteLine($"Basic Attack to m");
            Console.WriteLine($"n damage");
        }
        static void Attack(string target)
        {
            Console.WriteLine($"Basic Attack to {target}");
            Console.WriteLine($"n damage");
        }
        static void Attack(string target, int damage)
        {
            Console.WriteLine($"Basic Attack to {target}");
            Console.WriteLine($"{damage} damage");
        }
        static void Attack(string target, int damage, string skillName)
        {
            Console.WriteLine($"✨ Skill activated : {skillName}");
            Console.WriteLine($"⚔️ {damage} damage dealt to {target}");
        }


        static void Main(string[] args)
        {
            Console.Clear();

            Attack();

            Console.WriteLine();
            Attack("Monster");

            Console.WriteLine();
            Attack("Monster", 100);

            Console.WriteLine();
            Attack("Monster", 100, "Fireball");

        }

    }

}