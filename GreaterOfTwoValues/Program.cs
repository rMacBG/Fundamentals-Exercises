using System.Dynamic;

namespace GreaterOfTwoValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputType = Console.ReadLine();
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            Console.WriteLine(TypeParser(inputType, input1, input2));
        }
        public static string TypeParser(string inputType, string input1, string input2)
        {
            string result = "";
            switch (inputType)
            {
                case "int":
                       result =Math.Max(int.Parse(input1), int.Parse(input2)).ToString();
                    break;
                case "char":
                case "string":
                    result = StringResult(input1, input2);
                    break;
                default:
                    break;
            }
            return result;
        }
        public static string StringResult(string input1, string input2)
        {
            int length = Math.Min(input1.Length, input2.Length);
            for (int i = 0; i < length; i++)
            {
                if (input1[i] > input2[i])
                {
                    return input1;
                }
                else if (input2[i] > input2[i])
                {
                    return input2;  
                }

            }
            return input1.Length > input2.Length ? input1 : input2;
        }
    }
}