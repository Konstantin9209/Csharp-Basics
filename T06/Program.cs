namespace T06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nylon = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int thinner = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            double priceForNylon = (nylon + 2) * 1.50;
            double priceForPaint = (paint + paint * 0.10) * 14.50;
            double priceForThinner = thinner * 5;
            double materialsPrice = priceForNylon + priceForPaint + priceForThinner + 0.40;
            double workersPrice = (materialsPrice * 0.30) * hours;

            double totalSum = materialsPrice + workersPrice;

            Console.WriteLine(totalSum);
        }
    }
}