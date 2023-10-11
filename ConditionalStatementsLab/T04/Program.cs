namespace T04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pagesCount = int.Parse(Console.ReadLine());
            int pages = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            int hours = pagesCount / (pages * days);
            Console.WriteLine(hours);
        }
    }
}