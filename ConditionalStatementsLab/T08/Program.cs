namespace T08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tax = double.Parse(Console.ReadLine());

            double sneakersPrice = tax - (tax * 0.40);
            double uniformPrice = sneakersPrice - (sneakersPrice * 0.20);
            double ballPrice = uniformPrice / 4;
            double accessories = ballPrice / 5;

            double totalPrice = tax + sneakersPrice + uniformPrice + ballPrice + accessories;
            Console.WriteLine(totalPrice);
        }
    }
}