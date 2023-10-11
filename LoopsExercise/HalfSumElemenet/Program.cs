namespace HalfSumElemenet
{
    internal class Program
    {
        static void Main(string[] args)
        {
        int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int maxNumber = int.MinValue;
            
            for (int i = 0; i < n; i++)
            {
            int currentNumber = int.Parse(Console.ReadLine());

                if(currentNumber > maxNumber)
                maxNumber = currentNumber;

                sum += currentNumber;
                }
            
            sum = sum - maxNumber;
            if (sum == maxNumber)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sum}");

            }
            else
            {
                int diff =Math.Abs(sum - maxNumber);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff}");
            }
        }
    }
}