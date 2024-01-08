
namespace Assets.Scripts
{

    public class Hability
    {
        public string Name;

        public static Hability GenerateNewHability()
        {
            var NewHability = new Hability();
            NewHability.Name = "New Hability";
            return NewHability;
        }
    }
}
