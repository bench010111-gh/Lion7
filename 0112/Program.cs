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

        // level 1 function
        static void SayHello() // function name is universally PascalCase
        {
            Console.WriteLine("Hello, Sir Knight!");
            Console.WriteLine("Let's start the adventure!");
        }

        // fucntion definition: Game start message
        static void ShowGamStart()
        {
            Console.WriteLine("╔═══════════════════════════════════╗");
            Console.WriteLine("║         ⚔ RPG 게임 시작 ⚔         ║");
            Console.WriteLine("╚═══════════════════════════════════╝");
        }

        // funciton definition: print border lines
        static void PrintSeparator()
        {
            Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
        }


        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Call functions below");
            
            ShowGamStart();
            Console.WriteLine();

            SayHello();
            PrintSeparator();

            Console.WriteLine("Loading Game Menu...");

            PrintSeparator();

            // can call same function mult times
            Console.WriteLine("Game Over");

            PrintSeparator();

        }

    }

}