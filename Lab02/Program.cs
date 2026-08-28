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
           
            
            
            // ตัวละคร 1
            string Name1 = "Kim";
            string Class1 = "Tank";
            char rank1 = 'A';
            int level1 = 10;
            int maxHp1 = 150;
            int currentHp1 = 150;
            float attackPower1 = 5.0f;
            double critMultiplier1 = 1.05;
            bool Character1 = true;

            // ตัวละคร 2
            string Name2 = "Alice";
            string Class2 = "Archer";
            char rank2 = 'S';
            int level2 = 12;
            int maxHp2 = 70;
            int currentHp2 = 70;
            float attackPower2 = 15.0f;
            double critMultiplier2 = 2.25;
            bool Character2 = true;
            // ตัวละคร 3
            string Name3 = "Coner";
            string Class3 = "Assassin";
            char rank3 = 'S';
            int level3 = 11;
            int maxHp3 = 65;
            int currentHp3 = 65;
            float attackPower3 = 30.2f;
            double critMultiplier3 = 1.75;
            bool Character3 = true;
            // ตัวละคร 4
            string Name4 = "Mari";
            string Class4 = "Summoner";
            char rank4 = 'B';
            int level4 = 13;
            int maxHp4 = 60;
            int currentHp4 = 60;
            float attackPower4 = 9.5f;
            double critMultiplier4 = 1.25;
            bool Character4 = true;

            Console.WriteLine($"===== CHARACTER 1 STATUS: INITIAL =====");
            Console.WriteLine($"Rank: {rank1}");
            Console.WriteLine($"Name: {Name1}");
            Console.WriteLine($"Class: {Class1}");
            Console.WriteLine($"Level: {level1}");
            Console.WriteLine($"Max HP: {maxHp1}");
            Console.WriteLine($"Current HP: {currentHp1}");
            Console.WriteLine($"Attack Power: {attackPower1}");
            Console.WriteLine($"Critical Multiplier: {critMultiplier1}");
            Console.WriteLine($"Is Character: {Character1}");
           
            Console.WriteLine($"===== CHARACTER 2 STATUS: INITIAL =====");
            Console.WriteLine($"Rank: {2}");
            Console.WriteLine($"Name: {Name2}");
            Console.WriteLine($"Class: {Class2}");
            Console.WriteLine($"Level: {level2}");
            Console.WriteLine($"Max HP: {maxHp2}");
            Console.WriteLine($"Current HP: {currentHp2}");
            Console.WriteLine($"Attack Power: {attackPower2}");
            Console.WriteLine($"Critical Multiplier: {critMultiplier2}");
            Console.WriteLine($"Is Character: {Character2}");
           
            Console.WriteLine($"===== CHARACTER 3 STATUS: INITIAL =====");
            Console.WriteLine($"Rank: {3}");
            Console.WriteLine($"Name: {Name3}");
            Console.WriteLine($"Class: {Class3}");
            Console.WriteLine($"Level: {level3}");
            Console.WriteLine($"Max HP: {maxHp3}");
            Console.WriteLine($"Current HP: {currentHp3}");
            Console.WriteLine($"Attack Power: {attackPower3}");
            Console.WriteLine($"Critical Multiplier: {critMultiplier3}");
            Console.WriteLine($"Is Character: {Character3}");
           
            Console.WriteLine($"===== CHARACTER 4 STATUS: INITIAL =====");
            Console.WriteLine($"Rank: {rank4}");
            Console.WriteLine($"Name: {Name4}");
            Console.WriteLine($"Class: {Class4}");
            Console.WriteLine($"Level: {level4}");
            Console.WriteLine($"Max HP: {maxHp4}");
            Console.WriteLine($"Current HP: {currentHp4}");
            Console.WriteLine($"Attack Power: {attackPower4}");
            Console.WriteLine($"Critical Multiplier: {critMultiplier4}");
            Console.WriteLine($"Is Character: {Character4}");
















        }
    }
}
