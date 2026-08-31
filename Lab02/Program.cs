/*
 * Student ID : 1690701758
 * Name       : Ornicha pomnoi
 * Section    : 129B
 * No.        : N/A
 * Course     : GI113 Computer Programming (GI)
 */

namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bossName = "Kirin";
            char rank = 'S';
            int level = 7;
            int maxHp = 240;
            int currentHp = 175;
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            Console.WriteLine("Hello, World!");
            Console.WriteLine($"Name: {bossName}");
            Console.WriteLine($"Rank:{rank}");
            Console.WriteLine($"HP:{currentHp}/{maxHp}");
            Console.WriteLine($"Attack Power: {attackPower}");
            Console.WriteLine($"Crit Mulipier: {critMultiplier}");
            Console.WriteLine($"Is Boss:{isBoss}");
            Console.WriteLine();

            int hpPercent = currentHp * 100 / maxHp; //คำนวณเปอร์เซ็น
            Console.WriteLine($"HP Percent: {hpPercent}%");
            Console.WriteLine();

            Console.WriteLine($"Kirin takes 60 damage!");
            currentHp = currentHp - 60;
            Console.WriteLine();

            Console.WriteLine($"===== BOSS STATUS: AFTER DAMAGE =====");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percent: {hpPercent}%");
            //รักเกย์เสมอ ไม่เจอก็รัก

            string hero1Name = "lucian";
            int hero1Hp = 240; 
            float hero1Atk = 50f;
            double hero1CritRate = 2.00;
            char hero1Rank = 'S';

            Console.WriteLine("====HERO S====");
            Console.WriteLine($"NAME: {hero1Name}");
            Console.WriteLine($"HP: {hero1Hp}");
            Console.WriteLine($"Attack Power: {hero1Atk}");
            Console.WriteLine($"Crit Rate: {hero1CritRate}");
            Console.WriteLine($"Rank: {hero1Rank}");


            string hero2Name = "zudan";
            int hero2Hp = 90;
            float hero2Atk = 70f;
            double hero2CritRate = 1;
            char hero2Rank = 'A';

            Console.WriteLine("====HERO A====");
            Console.WriteLine($"NAME: {hero2Name}");
            Console.WriteLine($"HP: {hero2Hp}");
            Console.WriteLine($"Attack Power: {hero2Atk}");
            Console.WriteLine($"Crit Rate: {hero2CritRate}");
            Console.WriteLine($"Rank: {hero2Rank}");

            string hero3Name = "moko";
            int hero3Hp = 300;
            float hero3Atk = 45.5f;
            double hero3CritRate = 0.50;
            char hero3Rank = 'A';

            Console.WriteLine("====HERO A====");
            Console.WriteLine($"NAME: {hero3Name}");
            Console.WriteLine($"HP: {hero3Hp}");
            Console.WriteLine($"Attack Power: {hero3Atk}");
            Console.WriteLine($"Crit Rate: {hero3CritRate}");
            Console.WriteLine($"Rank: {hero3Rank}");

            string hero4Name = "C an";
            int hero4Hp = 120;
            float hero4Atk = 20.5f;
            double hero4CritRate = 0.10;
            char hero4Rank = '?';

            Console.WriteLine("====HERO ?====");
            Console.WriteLine($"NAME: {hero4Name}");
            Console.WriteLine($"HP: {hero4Hp}");
            Console.WriteLine($"Attack Power: {hero4Atk}");
            Console.WriteLine($"Crit Rate: {hero4CritRate}");
            Console.WriteLine($"Rank: {hero4Rank}");


        }
    }
}
