namespace SkiHoliday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string typeRoom = Console.ReadLine();
            string assessment = Console.ReadLine();
            double diff = days - 1;
            double price = 0;
            double totalPrice = 0;

            if (typeRoom == "room for one person")
            {
                price = diff * 118;
            }

            else if (typeRoom == "apartment")
            {
                price = diff * 155;
                if (days < 10)
                {
                    price = (diff * 155) * 0.7;
                }
                else if (days >= 10 && days <= 15)
                {
                    price = (diff * 155) * 0.65;
                }
                else
                {
                    price = (diff * 155) * 0.5;
                }
            }
            else if (typeRoom == "president apartment")
            {
                price = diff * 235;
                if (days < 10)
                {
                    price = (diff * 235) * 0.9;
                }
                else if (days >= 10 && days <= 15)
                {
                    price = (diff * 235) * 0.85;
                }
                else
                {
                    price = (diff * 235) * 0.8;
                }
            }
            if (assessment == "positive")
            {
                totalPrice = price * 1.25;
            }
            else if (assessment == "negative")
            {
                totalPrice = price * 0.9;
            }
            Console.WriteLine($"{totalPrice:F2}");
        }
    }
}