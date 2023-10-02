namespace Summer_Clothing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int temp = int.Parse(Console.ReadLine());
            string dayTime = Console.ReadLine();

            string outfit = "";
            string shoes = "";

            if (dayTime == "Morning")
            {
                if (temp >= 10 && temp <= 18)
                {
                    outfit = "Sweatshirt";
                    shoes = "Sneakers";
                }
                else if (temp > 18 && temp <= 24)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (temp >= 25)
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
            }
            else if (dayTime == "Afternoon")
            {
                if (temp >= 10 && temp <= 18)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (temp > 18 && temp <= 24)
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (temp >= 25)
                {
                    outfit = "Swim Suit";
                    shoes = "Barefoot";
                }
            }
            else if (dayTime == "Evening")
            {
                outfit = "Shirt";
                shoes = "Moccasins";
            }

            Console.WriteLine($"It's {temp} degrees, get your {outfit} and {shoes}.");
        }
    }
}
