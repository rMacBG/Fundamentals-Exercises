namespace AbstractingAclass
{
    public abstract class SpaceStation
    {
        public abstract void FireLaser();
    }
    public class DeathStar : SpaceStation
    {
        public override void FireLaser()
        {
            Console.WriteLine("Pew Pew");
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
           DeathStar deathStar = new DeathStar();
            deathStar.FireLaser();
        }
    }
}