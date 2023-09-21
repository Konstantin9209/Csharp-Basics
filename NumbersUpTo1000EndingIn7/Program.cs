namespace NumbersUpTo1000EndingIn7
{
    internal class Program
    {
        static void Main(string[] args)
        {
int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 997;  i++) 
            {
            if(i % 10 == 7)
                {
                    Console.WriteLine(i);
                }
            }
                }
    }
}