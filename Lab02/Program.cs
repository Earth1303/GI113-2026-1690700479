namespace Lab02

/*
 * Student ID : 1690700479
 * Name       : Chutchapol Changsee
 * Section    : 129A
 * No.        : 
 * Course     : GI113 Computer Programming (GI)
 */
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
            int hpPercent = currentHp * 100 / maxHp;
            

            Console.WriteLine($"===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"Name: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"Level: {level}");
            Console.WriteLine($"Max HP: {maxHp}");
            Console.WriteLine($"Current HP: {currentHp}");
            Console.WriteLine($"Attack Power: {attackPower}");
            Console.WriteLine($"Critical Multiplier: {critMultiplier}");
            Console.WriteLine($"Is Boss: {isBoss}");
            Console.WriteLine($"HP Percent: {hpPercent}%");

            Console.WriteLine($"Kirin takes 60 damage!");
           

            Console.WriteLine($"===== BOSS STATUS: AFTER DAMAGE =====");
            Console.WriteLine($"HP: {(currentHp - 60)} / {maxHp}");
            Console.WriteLine($"HP Percent: {(currentHp - 60) * 100 / maxHp}%");
        }
    }
}
