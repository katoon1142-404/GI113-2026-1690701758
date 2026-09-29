using System;
/*
* Student ID : 1690701758
* Name       : Ornicha pomnoi
* Section    : 129B
* No.        : N/A
* Course     : GI113 Computer Programming (GI)
*/
namespace Lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int lives = -1;

            // if (true)
            // {

            // }
            // if (lives <= 0) //ใส่เงื้อนไขที่ต้องการเช็ค ค่าที่ได้เป็น bool (true / false)
            // {
            //โค้ดด้านในจะรันก็ต่อเมื่อ if เป็น true
            //     Console.WriteLine("Game Over");
            // }
            // else
            // {
            //โค้ดด้านในจะรันก็ต่อเมื่อ if เป็น false
            //     Console.WriteLine("Keep Fighting");
            // }

            //ถ้า if ทำงานเสร็จแล้ว หรือ เป็น false จะทำงานต่อมาบรรทัดด้านนอกทันที
            // Console.WriteLine("Continue code");

            // bool haskey = true;
            //int level = 10;
            //Console.Write("Enter your level (1-99):");
            //bool intValidInput = int.TryParse(Console.ReadLine(), out int level);

            // if (!intValidInput || level < 1 || level > 99)
            // {
            //     Console.WriteLine("invalid Level");
            //}

            // if (level >= 10) //  เงื่อนไข 1
            // {
            //     Console.WriteLine("Boss floor unlocked!");
            // }
            // else if (level >= 10 && haskey) // เงื่อนไข 2
            // {
            //     Console.WriteLine("the door opens");
            // }
            // else if (level >= 5)
            // {
            //     if (haskey == true) // เงื่อนไข 3
            //    {
            //         Console.WriteLine("the door opens");
            //     }
            //     else
            //     {
            //         Console.WriteLine("locked, Find a key!");
            //     }
            // }

            //else // เมื่อไม่ตรงซักเงื่อนไข
            //{
            //    Console.WriteLine("the door stays shut.");
            //}

            //bool isposioned = true;

            //if (isposioned == true) // เช็คว่าเป็นจริงมั้ย??
            //{
            //    Console.WriteLine("You Died");
            //}
            //else if (isposioned == false) // เช็คว่าเป็นเท็จมั้ย??
            //{
            //    Console.WriteLine("You Lives");
            //}

            Console.WriteLine("WECOME TO MY WORLD, Ziria!");
            Console.WriteLine("GAME TITLE: SILENSONG");

            int ZiriaHP = 60;
            int SilenHP = 50;
            int ZiriaAtk = 25;
            int DrinkPotion = 30;
            Console.WriteLine("==>> HERO OF THE SEA <<==");
            Console.WriteLine("Ziria vs Silan");
            Console.WriteLine("Action 1: SING A SONG TOATTACK MONSTER");
            Console.WriteLine("Action 2: DRINK POTION");

            Console.Write("choose a u number between 1-2: ");
            bool userInput = int.TryParse(Console.ReadLine(), out int Action);

            if (!userInput || Action < 1 || Action > 2)
            {
                if (userInput = Action < 1 || Action > 2)
                {
                    Console.WriteLine("Choose a unber between 1 - 2");
                }
                else
                {
                    Console.WriteLine("Invalid input, please choose number between 1-2 only");
                }
            }
            else if (Action == 1)
            {
                SilenHP -= ZiriaAtk;
                if (SilenHP <= 0)
                {
                    Console.WriteLine("Monster Defeated!");
                }
                else
                {
                    Console.WriteLine($"Ziria Attacked the Silen, Silen have {SilenHP} HP left.");
                }
            }
            else if (Action == 2)
            {
                ZiriaHP += DrinkPotion;
                if (ZiriaHP <= 0)
                {
                    Console.WriteLine("Monster Defeated!");
                }
                else
                {
                    Console.WriteLine($"Ziria Drank a potionbloodsilen and restored {DrinkPotion}.Your current HP is {ZiriaHP}.");
                }
            }
            if (ZiriaHP <= 0)
            {
                Console.WriteLine("Game Over");
            }
            else
            {
                Console.WriteLine("Action 1: SING A SONG TOATTACK MONSTER");
                Console.WriteLine("Action 2: DRINK POTION");

                Console.Write("choose a u number between 1-2: ");
                bool userInput2 = int.TryParse(Console.ReadLine(), out int Action2);

                if (!userInput2 || Action2 < 1 || Action2 > 2)
                {
                    if (userInput2 = Action2 < 1 || Action2 > 2)
                    {
                        Console.WriteLine("Choose a unber between 1 - 2");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input, please choose number between 1-2 only");
                    }
                }
                else if (Action2 == 1)
                {
                    SilenHP -= ZiriaAtk;
                    if (SilenHP <= 0)
                    {
                        Console.WriteLine("===============");
                        Console.WriteLine("    You Win!   ");
                        Console.WriteLine("===============");
                    }
                    else
                    {
                        Console.WriteLine($"Ziria Attacked the Silen, Silen have {SilenHP} HP left.");
                    }
                }
                else if (Action2 == 2)
                {
                    DrinkPotion += ZiriaHP;
                    if (DrinkPotion <= 0)
                    {
                        Console.WriteLine("Ziria Drank a potionbloodsilen and restored {DrinkPotion}.Your current HP is {HeroHP}.");
                    }
                    else
                    {
                        Console.WriteLine($"Ziria Drank a potionbloodsilen and restored 30 HP.Your current HP is {ZiriaHP}.");
                    }
                }
                if (SilenHP > 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("=================================");
                    Console.WriteLine("Drink PotionBloodsi");
                    DrinkPotion += ZiriaHP;
                    Console.WriteLine($"you current HP is {ZiriaHP}");
                    Console.WriteLine("=================================");
                }
















            }
        }
    }
}