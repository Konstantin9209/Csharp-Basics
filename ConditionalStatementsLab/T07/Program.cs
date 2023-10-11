namespace T07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chickenMenu = int.Parse(Console.ReadLine());
            int fishMenu = int.Parse(Console.ReadLine());
            int vegetarianMenu = int.Parse(Console.ReadLine());

            double priceForChicken = chickenMenu * 10.35;
            double priceForFish = fishMenu * 12.40;
            double priceForVegetarian = vegetarianMenu * 8.15;

            double priceAllMenus = priceForChicken + priceForFish + priceForVegetarian;
            double priceDesert = priceAllMenus * 20 / 100;

            double TotalPrice = priceAllMenus + priceDesert + 2.50;
            Console.WriteLine(TotalPrice);
        }
    }
}