using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;  
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // // constant variable declaration
            // const double pi = 3.14159;
            // const int score = 100;

            // // displaying the constant values
            // Console.WriteLine("Value of pi: " + pi);
            // Console.WriteLine("Score: " + score);


            // // delclaring constant variables
            // const int MAX_PLAYERS = 4;
            // const int STARTING_GOLD = 1000;
            // const string VERSION = "1.0.0";

            // // displaying constant values
            // Console.WriteLine("=== 게임설정 ===");
            // Console.WriteLine($"최대 플레이어: {MAX_PLAYERS}");
            // Console.WriteLine($"시작골드: {STARTING_GOLD}G");
            // Console.WriteLine($"버전: {VERSION}");


            // int integerNum = 10;        // integer type
            // float floatNum = 3.14f;     // float type
            // double doulbeNum = 3.14159; // double type
            // // difference between float and double: float is 4 bytes, double is 8 bytes

            // Console.WriteLine(integerNum);
            // Console.WriteLine(floatNum);
            // Console.WriteLine(doulbeNum);


            // // game character stats
            // byte level = 50;                    // byte type (0-255)
            // short attack = 1500;
            // int gold = 1234567;
            // long experience = 99999999L;        // 'L' suffix for long type
            // // because of advancements of hardware, only int and float are commonly used

            // Console.WriteLine("=== 캐릭터 정보 ===");
            // Console.WriteLine($"레벨: {level}");
            // Console.WriteLine($"공격력: {attack}");
            // Console.WriteLine($"골드: {gold:N0}");          // N0 format specifier for thousand separators
            // Console.WriteLine($"경험치: {experience:N0}");

            // // check max values for each type
            // Console.WriteLine("\n=== 타입별 최대값 ===");
            // Console.WriteLine($"byte 최대값: {byte.MaxValue}");
            // Console.WriteLine($"short 최대값: {short.MaxValue}");
            // Console.WriteLine($"int 최대값: {int.MaxValue:N0}");
            // Console.WriteLine($"long 최대값: {long.MaxValue:N0}");


            // // decimal data expression
            // float singlePrecision = 3.141592f;        // float type (7 digits precision)
            // double doublePrecision = 3.14159265358979; // double type (15-16 digits precision)
            // decimal highPrecision = 3.1415926535897932384626433832m; // decimal type (28-29 digits precision)

            // Console.WriteLine(singlePrecision);
            // Console.WriteLine(doublePrecision);
            // Console.WriteLine(highPrecision);


            // // using literal suffixes
            // int intValue = 100;          // integer literal
            // long longValue = 100L;      // long literal
            // float floatValue = 3.14f;   // float literal
            // double doubleValue = 3.14;  // double literal
            // decimal decimalValue = 3.14m; // decimal literal

            // Console.WriteLine(intValue);
            // Console.WriteLine(longValue);
            // Console.WriteLine(floatValue);
            // Console.WriteLine(doubleValue);
            // Console.WriteLine(decimalValue);


            // // char type: expresses single character
            // char letter = 'A';
            // char symbol = '#';
            // char number = '7';
            // string emojiString = "😊";

            // Console.WriteLine(letter);
            // Console.WriteLine(symbol);
            // Console.WriteLine(number);
            // Console.WriteLine(emojiString);


            // // real number type practice
            // float speed = 5.5f;
            // double attackSpeed = 1.25;
            // decimal itemPrice = 12.99m;

            // Console.WriteLine("=== 캐릭터 능력치 ===");
            // Console.WriteLine($"이동속도 {speed}");
            // Console.WriteLine($"공격속도 {attackSpeed}");
            // Console.WriteLine($"아이템 가격 {itemPrice}");


            // // string type:
            // string greeting = "Hello, World!";
            // string name = "Alice";

            // Console.WriteLine(greeting);
            // Console.WriteLine(name);


            // // char and string practice
            // char grade = 'A';
            // char symbol = '★';
            // // char number = '9';

            // string playerName = "홍길동";
            // string welcomeMessage = "게임에 오신 것을 환영합니다!";
            // // string emptyString = "";

            // Console.WriteLine("=== RPG 게임 ===");
            // Console.WriteLine($"플레이어: {playerName}");
            // Console.WriteLine($"등급: {grade}등급 {symbol}");
            // Console.WriteLine(welcomeMessage);


            // // logical type: bool
            // bool isRunning = true;
            // bool isFinished = false;

            // Console.WriteLine(isRunning);
            // Console.WriteLine(isFinished);


            // // bool type practice
            // bool isRunning = true;
            // bool isPasued = false;
            // bool hasKey = false;
            // bool isDoorOpen = false;
            // bool isPlayerAlive = true;

            // int health = 80;
            // bool isHealthGood = true;
            // bool isHealthDanger = false;

            // Console.WriteLine("=== 게임 상태 ===");
            // Console.WriteLine($"게임 실행 중: {isRunning}");
            // Console.WriteLine($"게임 일시정지: {isPasued}");
            // Console.WriteLine($"열쇠 소지: {hasKey}");
            // Console.WriteLine($"문 열림: {isDoorOpen}");
            // Console.WriteLine($"플레이어 생존: {isPlayerAlive}");

            // Console.WriteLine("\n=== 캐릭터 상태 ===");
            // Console.WriteLine($"체력: {health}");
            // Console.WriteLine($"건강 상태: {isHealthGood}");
            // Console.WriteLine($"위험 상태: {isHealthDanger}");


            // int number = 123;
            // string numberAsString = number.ToString(); //정수를 문자열로 변환

            // bool flag = true;
            // string flagAsString = flag.ToString(); //논리값을 문자열로 변화

            // Console.WriteLine(numberAsString); //"123"
            // Console.WriteLine(flagAsString); //"true"


            const string block = "■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■";

            Console.Clear();
            Console.WriteLine($"{block}");
            Thread.Sleep(200);

            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine($"{block}");
            Thread.Sleep(200);

            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine($"{block}");
            Thread.Sleep(200);

            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine($"{block}");
            Thread.Sleep(200);

            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("            ┌──────────────┐");
            Console.WriteLine($"{block}");
            Thread.Sleep(200);

            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("            ┌──────────────┐");
            Console.WriteLine("            │  GAME START  │");
            Console.WriteLine($"{block}");
            Thread.Sleep(200);

            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("            ┌──────────────┐");
            Console.WriteLine("            │  GAME START  │");
            Console.WriteLine("            └──────────────┘");
            Console.WriteLine($"{block}");
            Thread.Sleep(200);

            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("            ┌──────────────┐");
            Console.WriteLine("            │  GAME START  │");
            Console.WriteLine("            └──────────────┘");
            Console.WriteLine("            ┌──────────────┐");
            Console.WriteLine($"{block}");
            Thread.Sleep(200);

            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("            ┌──────────────┐");
            Console.WriteLine("            │  GAME START  │");
            Console.WriteLine("            └──────────────┘");
            Console.WriteLine("            ┌──────────────┐");
            Console.WriteLine("            │  GAME QUIT   │");
            Console.WriteLine($"{block}");
            Thread.Sleep(200);

            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("            ┌──────────────┐");
            Console.WriteLine("            │  GAME START  │");
            Console.WriteLine("            └──────────────┘");
            Console.WriteLine("            ┌──────────────┐");
            Console.WriteLine("            │  GAME QUIT   │");
            Console.WriteLine("            └──────────────┘");
            Console.WriteLine($"{block}");
            Thread.Sleep(200);

            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("            ┌──────────────┐");
            Console.WriteLine("            │  GAME START  │");
            Console.WriteLine("            └──────────────┘");
            Console.WriteLine("            ┌──────────────┐");
            Console.WriteLine("            │  GAME QUIT   │");
            Console.WriteLine("            └──────────────┘");
            Console.WriteLine("");
            Console.WriteLine($"{block}");
            Thread.Sleep(200);

            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("            ┌──────────────┐");
            Console.WriteLine("            │  GAME START  │");
            Console.WriteLine("            └──────────────┘");
            Console.WriteLine("            ┌──────────────┐");
            Console.WriteLine("            │  GAME QUIT   │");
            Console.WriteLine("            └──────────────┘");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine($"{block}");
            Thread.Sleep(200);

            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("            ┌──────────────┐");
            Console.WriteLine("            │  GAME START  │");
            Console.WriteLine("            └──────────────┘");
            Console.WriteLine("            ┌──────────────┐");
            Console.WriteLine("            │  GAME QUIT   │");
            Console.WriteLine("            └──────────────┘");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine($"{block}");
            Thread.Sleep(200);
            
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("            ┌──────────────┐");
            Console.WriteLine("            │  GAME START  │");
            Console.WriteLine("            └──────────────┘");
            Console.WriteLine("            ┌──────────────┐");
            Console.WriteLine("            │  GAME QUIT   │");
            Console.WriteLine("            └──────────────┘");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Thread.Sleep(200);

        }
    }
}