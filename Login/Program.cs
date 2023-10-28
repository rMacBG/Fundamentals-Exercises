namespace Login
{
    public class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = "";
            int counter = 0;
            for (int i = username.Length - 1; i >= 0; i--)
            {
                password += username[i];
            }       
            while (counter < 4)
            {
                string passwordInput = Console.ReadLine();
                counter++;

                if (passwordInput == password)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                else if (counter == 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                }
                else if (passwordInput != password)
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
               
            }
        }
    }
}