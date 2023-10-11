namespace T05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pens = int.Parse(Console.ReadLine());
            int markers = int.Parse(Console.ReadLine());
            int litersPrep = int.Parse(Console.ReadLine());
            double percentDiscount = double.Parse(Console.ReadLine());

            double priceBeforeDiscount = pens * 5.80 + markers * 7.20 + litersPrep * 1.20;
            double finalPrice = priceBeforeDiscount - (priceBeforeDiscount * percentDiscount / 100);

            Console.WriteLine(finalPrice);
        }
    }
}