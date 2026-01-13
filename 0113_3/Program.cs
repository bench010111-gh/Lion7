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
using System.Reflection.Metadata.Ecma335;

namespace ConsoleApp9
{

    /*
    internal class Program
    {   

        /*
        class Character
        {
            // ** getter/setter -> property 
            public int Att { get; set; }

            // read only
            public int MaxHP { get; private set; }
        }
        */

        /*
        class Player
        {
            private string name = "";
            private int gold;
            private int maxHP;

            public Player()
            {
                maxHP = 100;
            }

            // property - MaxHP (read only)
            public int MaxHP
            {
                get { return maxHP; }
                private set { maxHP = value; }
            }

            // property
            public string Name { get { return name; } set { name = value; } }
            public int Gold
            {
                get { return gold; }
                set
                {
                    if (value < 0)
                    {
                        Console.WriteLine("Not enough gold.");
                    }
                    else
                    {
                        gold = value;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Console.Clear();

            Player player = new();
            player.Name = "John Doe";
            player.Gold = 1000;
            // player.MaxHP = 10;

            Console.WriteLine($"Name: {player.Name}");
            Console.WriteLine($"Gold: {player.Gold}");
            Console.WriteLine($"MaxHP: {player.MaxHP}");
        }
        */


        /*
        class Student
        {
            // TODO: 필드 선언
            private string name = "";
            private int score;
            
            // TODO: Name 프로퍼티 (읽기 전용)
            public string Name
            {
                get { return name; }
            }
            
            // TODO: Score 프로퍼티 (0~100 검증)
            public int Score
            {
                get { return score; }
                set
                {
                    if ( value < 0 || value > 100)
                    {
                        Console.WriteLine("Invalid Score input");
                    }
                    else
                    {
                        score = value;
                    }
                }
            }
            
            // TODO: Grade 프로퍼티 (자동 계산, 읽기 전용)
            public string Grade
            {
                get
                {
                    if (score >= 90) return "A";
                    else if (score >= 80) return "B";
                    else if (score >= 70) return "C";
                    else if (score >= 60) return "D";
                    else return "F";
                }
            }
            
            // 생성자
            public Student(string studentName)
            {
                // TODO: 구현
                name = studentName;
            }
            
            // 정보 출력
            public void ShowInfo()
            {
                Console.WriteLine($"━━━━━━━━━━━━━━━━");
                Console.WriteLine($"이름: {Name}");
                Console.WriteLine($"점수: {Score}점");
                Console.WriteLine($"등급: {Grade}");
                Console.WriteLine($"━━━━━━━━━━━━━━━━");
            }
        }

        static void Main(string[] args)
        {
            Student student = new Student("홍길동");
            
            student.Score = 95;
            student.ShowInfo();
            
            Console.WriteLine();
            
            student.Score = 75;
            student.ShowInfo();
            
            Console.WriteLine();
            
            // 잘못된 값 입력 시도
            student.Score = 150;  // 100으로 제한되어야 함
            student.Score = -10;  // 0으로 제한되어야 함
            student.ShowInfo();
        }
        
            
    }
    */

    class Character
    {
        // static: shared data
        public static int totalCount = 0;

        public static string Gameersion {get; set;} = "1.0.0";

        // unique per object
        public string name = "";

        public void AddCount()
        {
            totalCount++;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Character c1 = new Character();
            Character c2 = new Character();

            c1.name = "Barbarian";
            c2.name = "Wizard";

            Character.totalCount = 1;

            Console.WriteLine(c1.name);
            Console.WriteLine(c2.name);

            c1.AddCount();
            c2.AddCount();

            Console.WriteLine("Count: " + Character.totalCount);
        }
    }

}