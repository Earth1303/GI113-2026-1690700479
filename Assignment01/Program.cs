using System.Xml.Linq;

namespace Assignment01
{
    internal class Program
    {
        static void Main(string[] args)      
        {
            const string GameTitle = "Character";

            var HeroName = "Megachad";
            int MaxHp = 240;
            int HPRegen = 10;
            double Lifesteal = 0.05;
            int Shield = 100;
            double Armor = 0.2;
            int Damage = 20;
            double critChance = 0.01;
            double critDamage = 2.5;
            int AttackSpeed = 1;
            float MovementSpeed = 0.96f;

            Console.WriteLine($"===== {GameTitle} =====");
            Console.WriteLine($"Hero Name: {HeroName}");
            Console.WriteLine($"Max HP: {MaxHp}");
            Console.WriteLine($"HP Regen: {HPRegen}");
            Console.WriteLine($"Lifesteal: {Lifesteal:P0}");
            Console.WriteLine($"Shield: {Shield}");
            Console.WriteLine($"Armor: {Armor:P0}");
            Console.WriteLine($"Damage: {Damage}");
            Console.WriteLine($"Crit Chance: {critChance:P0}");
            Console.WriteLine($"Crit Damage: {critDamage}x");
            Console.WriteLine($"Attack Speed: {AttackSpeed:P0}");
            Console.WriteLine($"Movement Speed: {MovementSpeed}");

            double DamageAsDouble = Damage;
            Console.WriteLine($"Damage as double (implicit): {DamageAsDouble}");

            int MovementSpeedTruncated = (int)MovementSpeed;               
            int MovementSpeedRounded = Convert.ToInt32(MovementSpeed);     
            Console.WriteLine($"Movement Speed cast (truncates)  : {MovementSpeedTruncated}");
            Console.WriteLine($"Movement Speed Convert (rounds)  : {MovementSpeedRounded}");
        }


    }
}
