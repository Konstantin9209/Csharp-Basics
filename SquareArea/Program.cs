namespace SquareArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int sideOfSquare = int.Parse(input);
            int areaOfSquare = sideOfSquare * sideOfSquare;
            Console.WriteLine(areaOfSquare);
        }
    }
}