using System.Runtime;

namespace Lab05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("== >> GAME TITLE << ==");
            Console.WriteLine("Hero vs. Monster -- Caluclate Damage");

            Console.WriteLine("hero HP; ");
            bool heroHpOk = int.TryParse(Console.ReadLine(), out int heroHp);
            Console.WriteLine("Hero Attack: ");
            bool heroAttackOk = int.TryParse(Console.ReadLine(), out int heroAttack);
            Console.WriteLine("Hero Defense: ");
            bool heroDefenseOk = int.TryParse(Console.ReadLine(), out int heroDefense);

            Console.WriteLine("monster HP; ");
            bool monsterHpOk = int.TryParse(Console.ReadLine(), out int monsterHp);
            Console.WriteLine("Monster Attack: ");
            bool monsterAttackOk = int.TryParse(Console.ReadLine(), out int monsterAttack);
            Console.WriteLine("Monster Defense: ");
            bool monsterDefenseOk = int.TryParse(Console.ReadLine(), out int monsterDefense);

            bool heroInputVAlid = heroHpOk && heroAttackOk && heroDefenseOk;
            bool monsterInputValid = monsterHpOk && monsterAttackOk && monsterDefenseOk;
            Console.WriteLine($">> Hero stats valid: {heroInputVAlid}");
            Console.WriteLine($">> Monster stats valid: {monsterInputValid}");
            Console.WriteLine($">> Hero HP: {heroHp}, Attack: {heroAttack}, Defense: {heroDefense}");
            Console.WriteLine($">> Monster HP: {monsterHp}, Attack: {monsterAttack}, Defense: {monsterDefense}");

            int potionHeal = 14;
            heroHp += potionHeal;
            Console.WriteLine($"\nHero drinks a potion, healing {potionHeal} HP: {heroHp}");

            int normalDamage = Math.Max(0, heroAttack - monsterDefense);
            Console.WriteLine($"normal attack deals: {normalDamage} damage");

            int powerAttackDamage = Math.Max(0, (heroAttack * 2) - monsterDefense);
            Console.WriteLine($"power attack deals: {powerAttackDamage} damage");

            int counterAttackDamage = Math.Max(0, monsterAttack - heroDefense);
            Console.WriteLine($"counter attack deals: {counterAttackDamage} damage");

            Random mooliwb= new Random();
            int roll = mooliwb.Next(1, 101);
            bool isCrit = roll <= 10;
            int critDamage = normalDamage + Convert.ToInt32(isCrit) * normalDamage;
            Console.WriteLine($"critical attack roll: {roll}(Crit?: {isCrit});");
            Console.WriteLine($"If critical,normal attack deals: {critDamage} damage");

        }
    }

}

