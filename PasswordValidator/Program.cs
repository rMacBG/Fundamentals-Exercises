namespace PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string password = Console.ReadLine();
            PassValidator(password);

        }
        public static void PassValidator(string password)
        {
            bool length = false;
            bool digitsLetters = false;
            bool twoDigits = false;
            int digitsCount = 0;

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
                    digitsCount++;
                }
                if ((int)current < 48 || (int)current > 122 ||
                    (int)current > 90 && (int)current < 97 ||
                    (int)current > 57 && (int)current < 65)
                {
                    digitsLetters = false;
                }
            }
            if (digitsLetters == false) 
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (digitsCount < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            else if (digitsCount >= 2)
            {
                twoDigits = true;
            }
            if (length && digitsLetters && twoDigits) 
            {
                Console.WriteLine("Password is valid");
            }
        }
    }
}