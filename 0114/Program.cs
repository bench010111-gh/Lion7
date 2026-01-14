using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0114
{
    // comms between classes
    class Player
    {
        private int hp;
        private int att;

        public void SetHp(int hp) { this.hp = hp; }
        public int GetHp() { return hp; }

        public void SetAtt(int att) { this.att = att; }
        public int GetAtt() { return att; }

        public void Render()
        {
            Console.WriteLine("Player");
            Console.WriteLine("Health : " + hp);
            Console.WriteLine("Attack : " + att);
            Console.WriteLine();
        }
    }

    class Monster
    {
        private int hp;
        private int att;

        public void SetHp(int hp) { this.hp = hp; }
        public int GetHp() { return hp; }

        public void SetAtt(int att) { this.att = att; }
        public int GetAtt() { return att; }

        public void Render()
        {
            Console.WriteLine("Monster");
            Console.WriteLine("Health : " + hp);
            Console.WriteLine("Attack : " + att);
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // player object
            Player player = new Player();
            player.SetAtt(10);
            player.SetHp(100);
            player.Render();
            
            // monster object
            Monster monster = new Monster();
            monster.SetAtt(5);
            monster.SetHp(100);
            monster.Render();

            // player attacks: monster
            monster.SetHp(monster.GetHp() - player.GetAtt());

            // monster attacks: player
            player.SetHp(player.GetHp() - monster.GetAtt());

            player.Render();
            monster.Render();
            
        }
    }
}
