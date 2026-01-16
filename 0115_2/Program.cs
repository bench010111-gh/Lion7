using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0115_2
{
    // interface 
    interface IAttackable
    {
        void Attack(string target);
        int GetAttackPower();
    }

    // interface
    interface IDefendable
    {
        void Defend();
        int GetDefensePower();
    }

    class Knight : IAttackable, IDefendable
    {
        public string name = "";
        public int attackPower;
        public int defensePower;
        
        public Knight()
        {
            name = "검사";
            attackPower = 10;
            defensePower = 10;
        }

        public void Attack(string target)
        {
            Console.WriteLine("검으로 " + target + "를 공격했습니다");
        }

        public void Defend()
        {
            Console.WriteLine("기사가 방어모드 중입니다.");
        }

        public int GetAttackPower()
        {
            return attackPower;
        }

        public int GetDefensePower()
        {
            return defensePower;
        }
    }

    class Mage : IAttackable
    {
        public string name = "";
        public int attackPower;
        
        public Mage()
        {
            name = "마법사";
            attackPower = 20;
        }

        public void Attack(string target)
        {
            Console.WriteLine("마법 볼트로 " + target + "를 공격했습니다");
        }

        public int GetAttackPower()
        {
            return attackPower;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Knight knight = new Knight();
            // knight.Attack("오크");
            // knight.Defend();

            // Mage mage = new Mage();
            // mage.Attack("스켈레톤");

            // make array based on interface type
            IAttackable[] attacker = new IAttackable[2];

            attacker[0] = new Knight();
            attacker[1] = new Mage();

            IDefendable defender = new Knight();

            foreach(IAttackable att in attacker)
            {
                att.Attack("고블린");
            }

            defender.Defend();
        }
    }
}
