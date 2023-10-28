using System.Security.Cryptography.X509Certificates;

namespace Articles
{
    public class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public void Edit(string content)
        {
            Content = content;
        }
        public void ChangeAuthor(string author)
        {
            Author = author;
        }
        public void Rename(string title)
        {
            Title = title;
        }
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }

    }

    public class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(", ");
            Article article = new Article(input[0], input[1], input[2]);
            int numberOfCommands = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] command = Console.ReadLine()
                    .Split(": ");
                string commandType = command[0];
                string commandValue = command[1];

                if (commandType == "Edit")
                {
                    article.Edit(commandValue);
                }

                if (commandType == "Rename")
                {
                    article.Rename(commandValue);
                }

                if (commandType == "ChangeAuthor")
                {
                    article.ChangeAuthor(commandValue);
                }
            }
            Console.WriteLine(article);

        }
    }
}