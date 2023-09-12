namespace T03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double sum = deposit + month * ((deposit * percent / 100) / 12);

            Console.WriteLine(sum);
        }
    }
}