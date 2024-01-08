
using Assets.Scripts;
using static Assets.Scripts.Enums;

public class Bone
{
    public BaseStats MonBaseStats { get; set; }
    public Position Position { get; set; }
    public Rarity Rarity { get; set; }
    public string ImageRoute { get; set; }

    public static Bone GenerateNewBone(int position = 7)
    {
        Bone newPoke = new Bone();

        newPoke.Position = GenerateRandomPosition(position);
        newPoke.Rarity = GenerateRandomRarity();

        newPoke.MonBaseStats = BaseStats.GenerateBasicStats();

        return newPoke;
    }
}
