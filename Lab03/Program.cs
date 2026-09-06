namespace Lab03
{
    /*
 * Student ID : 1690700479
 * Name       : Chutchapol Changsee
 * Section    : 129A
 * No.        : 
 * Course     : GI113 Computer Programming (GI)
 */
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

            //Boss stats output
            Console.WriteLine($"===== KIRIN SAVE CONVERTER =====");
            Console.WriteLine($"Boss Name: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"Level: {level}");
            Console.WriteLine($"Max HP: {maxHp}");
            Console.WriteLine($"Current HP: {currentHp}");
            Console.WriteLine($"Attack Power: {attackPower}");
            Console.WriteLine($"Critical Multiplier: {critMultiplier}");
            Console.WriteLine($"Is Boss: {isBoss}"); 
             
             
            //Implicit Conversion: HP as double
            Console.WriteLine($"----- Implicit Conversion: HP as double -----");
            double currentHpAsDouble = currentHp;
            Console.WriteLine($"Current HP (as double): {currentHpAsDouble}");

            //Explicit Conversion: Attack Power as int
            Console.WriteLine($"----- Explicit Conversion: Attack Power as int -----");
            double hpPercentExact = currentHpAsDouble * 100 / maxHp;
            Console.WriteLine($"HP Percent (exact): {hpPercentExact}%");
         
           //Explicit Cast: Attack Power -> Display Int
           Console.WriteLine($"----- Explicit Cast: Attack Power -> Display Int -----");
           int attackDisplay = (int) attackPower;
           Console.WriteLine($"Attack Power (int cast): {attackDisplay}");

            //Cast vs Convert: Crit Multiplier
            Console.WriteLine($"----- Cast vs Convert: Crit Multiplier -----");
            int critCast = (int) critMultiplier;
            int critConvert = Convert.ToInt32(critMultiplier);
            Console.WriteLine($"Critical Multiplier (int cast): {critCast}");
            Console.WriteLine($"Critical Multiplier (Convert.ToInt32): {critConvert}");

        }
    }
}
