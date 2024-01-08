using Assets.Scripts;
using System.Collections.Generic;
using static Assets.Scripts.Enums;

public class Poke 
{
    public string ImageRoute { get; set; }
    public Position Position { get; set; }
    public Rarity Rarity { get; set; }
    public List<Hability> Habilities { get; set; }

    public Poke() { 
        Habilities = new List<Hability>();
    }

    public static Poke GenerateNewPoke(int position = 7)
    {
        Poke newPoke = new Poke();

        newPoke.Position = GenerateRandomPosition(position);
        newPoke.Rarity = GenerateRandomRarity();

        int habilityCount = 2;
        for (int i = 0; i < habilityCount; i++)
        {
            newPoke.Habilities.Add(Hability.GenerateNewHability());
        }
        switch(position)
        {
            case 1:
                newPoke.ImageRoute = "C:\\Proyectos\\Megamon\\Assets\\Images\\Pokes\\Cabeza.jpg";
                break;
            case 2:
                newPoke.ImageRoute = "C:\\Proyectos\\Megamon\\Assets\\Images\\Pokes\\Pecho.jpg";
                break;
            case 3:
                newPoke.ImageRoute = "C:\\Proyectos\\Megamon\\Assets\\Images\\Pokes\\BrazoIzq.jpg";
                break;
            case 4:
                newPoke.ImageRoute = "C:\\Proyectos\\Megamon\\Assets\\Images\\Pokes\\BrazoDer.jpg";
                break;
            case 5:
                newPoke.ImageRoute = "C:\\Proyectos\\Megamon\\Assets\\Images\\Pokes\\PiernaIzq.jpg";
                break;
            case 6:
                newPoke.ImageRoute = "C:\\Proyectos\\Megamon\\Assets\\Images\\Pokes\\PiernaDer.jpg";
                break;
        }
        return newPoke;
    }
}
