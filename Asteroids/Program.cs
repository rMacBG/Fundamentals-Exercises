namespace Asteroids
{
    public abstract class AstroDroid 
    {
        public virtual string GetSound()
        {
            return "Beep beep";
        }
        public void MakeSound()
        {
            Console.WriteLine(GetSound());
            Console.WriteLine();
        }
    }
    public class R2 : AstroDroid
    {
        public override string GetSound()
        {
            return "Beep bop";
        }
    }


    public class Program
    {
       public static void Main(string[] args)
        {
           R2 r2 = new R2();
            r2.MakeSound();
        }
    }
}