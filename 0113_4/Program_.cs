using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{

    // this keyword

    class Skill
    {
        // field / varaible
        private string name = "";
        private int att;

        public Skill ()
        {
            
        }

        public Skill (string name, int att)
        {
            this.name = name;
            this.att = att;
        }

        public void SkillStart ()
        {
            Console.WriteLine("Skill Name: " + name);
            Console.WriteLine("Skill Name: " + att);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Skill s = new Skill("Blizzard", 10000);
            s.SkillStart();
        }
    }

}