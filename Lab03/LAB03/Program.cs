using System.Runtime.Intrinsics.Arm;

namespace LAB03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MaxLevel = 10;

            var bossName = "Kirin";   // ต้องประกาศด้วย var ห้ามเขียน string ตรงๆ
            var rank = 'S';            // ต้องประกาศด้วย var ห้ามเขียน char ตรงๆ
            int level = 7;
            int maxHp = 240;
            int currentHp = 115;       // ค่าตั้งต้นของ Lab นี้คือ HP "หลังโดนโจมตี" จาก Lab 2 แล้ว ไม่ใช่ 175
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            //ปร้ิ้น
            Console.WriteLine("===== KIRIN SAVE CONVERTER =====");
            Console.WriteLine($"Name: {bossName}"+
            $"\nRANK: {rank}" +
             $"\nLevel: {level}" +
             $"\nMax HP: {maxHp}" +
             $"\nCurrent HP: {currentHp}" +
             $"\nAttack Power: {attackPower}" +
             $"\nCritical Multiplier: {critMultiplier}" +
             $"\nIs Boss: {isBoss}");

            Console.WriteLine("----- Implicit Conversion: HP as double -----");
            double currentHpAsDouble = currentHp;
            Console.WriteLine($"HP (double): {currentHpAsDouble}");

            Console.WriteLine("\n ----- Exact HP Percent (no interger truncation) -----");
            double hpPercentExact = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percent (exact): {hpPercentExact}%");

            Console.WriteLine("\n----- Explicit Cast: Attack Power -> Display int -----");
            int attackDisney = (int)attackPower;
            Console.WriteLine($"Attack Power (int cast): {attackDisney}");

            Console.WriteLine("\n---- - Cast vs Convert: Crit Multiplier-----");
            int critCast = (int)critMultiplier;
            int critConvert = Convert.ToInt32(critMultiplier);
            Console.WriteLine($"Critical Multiplier (int cast): {critCast}");
            Console.WriteLine($"Critical Multiplier (Convert.ToInt32): {critConvert}");
        }
    }
}
