using System;
using System.Diagnostics.Metrics;

namespace Cards
{
    /*
Ace of Diamonds, Queen of Hearts, King of Clubs
3
Add, King of Diamonds
Insert, 2, Jack of Spades
Remove, Ace of Diamonds
     */
    internal class Program
    {
        static void Main()
        {
            List<string> cards = Console.ReadLine()
                .Split(',')
                .ToList();
            int n = int.Parse(Console.ReadLine());
            string commands = Console.ReadLine();
            int counter = 1;
            while (counter <= n)
            {

                string[] arguments = commands.Split(',');
                string command = arguments[0];
                string cardName = arguments[1];
                if (command == "Add")
                {
                    if (cards.Contains(cardName))
                    {
                        Console.WriteLine("Card is already in the deck");

                    }
                    else
                    {
                        cards.Add(arguments[1]);
                        Console.WriteLine("Card successfully added");

                    }
                    counter++;
                }
                else if (command == "Remove")
                {

                    if (arguments[1] == cardName)
                    {
                        cards.Remove(arguments[1]);
                        Console.WriteLine("Card successfully removed");
                    }
               else if (!cards.Contains(cardName))
                    {
                    Console.WriteLine("Card not found");
                    }



                    counter++;
                }
                else if (command == "Remove At")
                {
                    string index = arguments[1].Replace(",", "");
                    int indexOfCard = int.Parse(index);
                    if (indexOfCard < 0 || indexOfCard > cards.Count)
                    {
                        Console.WriteLine("Index out of range");
                    }
                    else
                    {
                        cards.RemoveAt(indexOfCard);
                        Console.WriteLine("Card successfully removed");
                    }
                    counter++;

                }
                else if (command == "Insert")
                {
                    string index = arguments[1].Replace(",", "");
                    int indexOfCard = int.Parse(index);
                    string cardName2 = arguments[2];
                    if (indexOfCard < 0 || indexOfCard > cards.Count)
                    {
                        Console.WriteLine("Index out of range");
                    }
                    else if (cards.Contains(cardName2))
                    {
                        Console.WriteLine("Card is already added");
                    }
                    else
                    {
                        cards.Insert(indexOfCard, arguments[2]);
                        Console.WriteLine("Card successfully added");
                    }
                    counter++;
                }
                if (counter > n)
                {
                    break;
                }
                commands = Console.ReadLine();
            }
            Console.WriteLine(string.Join(',', cards));

        }
    }
}