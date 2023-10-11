namespace T09
{
    class FishTank
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            int volume = width * length * height;
            double capacityInLiters = volume * 0.001;
            double freeCapacity = capacityInLiters * (1 - 0.01 * percent);

            Console.WriteLine(Math.Round(freeCapacity, 2));
        }
    }
}
