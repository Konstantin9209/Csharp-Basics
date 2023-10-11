using System.ComponentModel.DataAnnotations;

namespace BiggestNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
         int countNumbers  = int.Parse(Console.ReadLine());
            int maxNumber = int.MinValue;
            for (int number = 1; number <= countNumbers; number++)
            {
                int value = int.Parse(Console.ReadLine());
                if (value > maxNumber)
                {
                    maxNumber = value;
                }
            }
            Console.WriteLine(maxNumber);
        }
    }
}