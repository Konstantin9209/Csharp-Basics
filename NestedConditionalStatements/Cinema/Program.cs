namespace Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ticketType = Console.ReadLine();
            int rowCount = int.Parse(Console.ReadLine());
            int columnCount = int.Parse(Console.ReadLine());

            double price = 0;

            switch (ticketType)
            {
                case "Premiere":
                    price = rowCount * columnCount * 12.00;
                    break;
                case "Normal":
                    price = rowCount * columnCount * 7.50;
                    break;
                case "Discount":
                    price = rowCount * columnCount * 5.00;
                    break;
            }

            Console.WriteLine($"{price:F2} leva");
        }
    }
}