using System;

namespace Assets.Scripts
{
    public class Enums
    {

        public enum Rarity
        {
            Common, 
            Uncommon,
            Special,
            Set,
            Rare,
            Epic,
            Mithyc
        };

        public enum Position
        {
            Head,
            Breast,
            LeftArm,
            RightArm,
            LeftLeg,
            RightLeg
        }

        public static Rarity GenerateRandomRarity()
        {
            Random random = new Random();
            Array rarityValues = Enum.GetValues(typeof(Rarity));
            return (Rarity)rarityValues.GetValue(random.Next(rarityValues.Length));
        }

        public static Position GenerateRandomPosition(int position = 7)
        {
            Random random = new Random();
            Array positionValues = Enum.GetValues(typeof(Position));

            if(position == 7)
                return (Position)positionValues.GetValue(random.Next(positionValues.Length));
            else
                return (Position)positionValues.GetValue(position-1);

        }

    }
}
