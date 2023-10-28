namespace PassValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pass = Console.ReadLine();
            PasswordValidator(pass);
        }

        static void PasswordValidator(string password)
        {
            bool length = false;
            bool lettersDigits = true;
            bool digits = false;
            int digitsCounter = 0;

            if (password.Length >= 6 && password.Length <= 10)
            {
                length = true;
            }
            else
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            for (int i = 0; i < password.Length; i++)
            {
                char current = password[i];

                if ((int)current >= 48 && (int)current <= 57)
                {
                    digitsCounter++;
                }

                if ((int)current < 48 || (int)current > 122
                  || (int)current > 90 && (int)current < 97
                  || (int)current > 57 && (int)current < 65)
                {
                    lettersDigits = false;
                }
            }
                if (lettersDigits == false)
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                }
                if (digitsCounter < 2)
                {
                    Console.WriteLine("Password must have at least 2 digits");
                }
                else if (digitsCounter >= 2)
                {
                    digits = true;
                }

                if (length && lettersDigits && digits)
                {
                    Console.WriteLine("Password is valid");
                }
            
        }

    }
}