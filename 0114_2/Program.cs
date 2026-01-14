using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// inheritance

namespace _0114_2
{
        // 문제 2: 상점 시스템
        // 다양한 상품 타입을 다형성으로 관리하고,
        // 타입별로 다른 할인율을 적용하세요.

    class Item    // parent class
    {
        public string Name;
        public int Discount;

        public Item (string name)
        {
            Name = name;
            Discount = 0;
        }

        public virtual void Desc()
        {
            Console.WriteLine($"This is an item, and is on {Discount}% sale");
        }

        public virtual void ApplyDiscount()
        {
            Discount = 0;
        }
    }

    class Dairies : Item  // child class
    {
        public Dairies (string name) : base(name) {}

        public override void Desc()
        {
            Console.WriteLine($"{Name}: This is a dairy item, and is on {Discount}% sale");
        }

        public override void ApplyDiscount()
        {
            Discount = 30;
        }
    }

    class Meat : Item
    {
        public Meat (string name) : base(name) {}

        public override void Desc()
        {
            Console.WriteLine($"{Name}: This is a meat item, and is on {Discount}% sale");
        }

        public override void ApplyDiscount()
        {
            Discount = 10;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Item[] items = new Item[4];

            items[0] = new Dairies("Milk");
            items[1] = new Dairies("Cheese");
            items[2] = new Meat("Chicken");
            items[3] = new Meat("Pork");

            for (int i = 0; i < items.Length; i++)
            {
                items[i].ApplyDiscount();
                items[i].Desc();
            }
        }
    }
}
