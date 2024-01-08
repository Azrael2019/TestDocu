using System;

namespace Assets.Scripts
{
    public class BaseStats
    {
        public int Force { get; set; }
        public int Dexterity { get; set; }
        public int Knowledge { get; set; }
        public int Intelligence { get; set; }
        public int Constitution { get; set; }

        public static BaseStats GenerateBasicStats ()
        {
            var baseStats = new BaseStats ();
            Random random = new Random();

            baseStats.Force = (int)random.Next(10);    
            baseStats.Dexterity = (int)random.Next(10);
            baseStats.Knowledge = (int)random.Next(10);
            baseStats.Intelligence = (int)random.Next(10);
            baseStats.Constitution = (int)random.Next(10); 

            return baseStats;
        }
    }
}
