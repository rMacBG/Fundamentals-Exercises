namespace StoreBoxes
{
    public class Program
    {
        static void Main(string[] args)
        {
           List<Box> boxes = new List<Box>();
            string line = Console.ReadLine();
            while (line != "end")
            {
                string[] tokens = Console.ReadLine()
                    .Split();
                string serialNumber = tokens[0];
                string name = tokens[1];
                int quantity = int.Parse(tokens[2]);
                decimal price = decimal.Parse(tokens[3]);

                Box box = new Box()
                {
                    SerialNumber = serialNumber,
                    Item = new Item()
                    {
                        Name = name,
                        Price = price,
                    },
                    Quantity = quantity,

                };
                boxes.Add(box);
                line = Console.ReadLine();

            }
            List<Box>SortedBox = boxes
                .OrderByDescending(b => b.PriceBox)
                .ToList();
            foreach (Box box in SortedBox)
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.Quantity}");
                Console.WriteLine($"{box.PriceBox:f2}");
            }
        }
    }
    public class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
    public class Box
    {
        public Box()
        {
            Item = new Item();
        }
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int Quantity { get; set; }
        public decimal PriceBox
        {
            get
            {
                return Quantity * Item.Price;
            }
        }
    }
}