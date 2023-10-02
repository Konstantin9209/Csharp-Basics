using System.ComponentModel.Design;

namespace NumberOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            string op = Console.ReadLine();

            double result = 0;

            if (op == "+")
            {
                result = num1 + num2;
            }
            else if (op == "-")
            {
                result = num1 - num2;

            }
            else if (op == "*")
            {
                result = num1 * num2;
            }
            else if (op == "/")
            {
                result = (num1 / num2);
            }
            Console.WriteLine($"{num1} {op} {num2} = {result:F2}");
        }
    }
}
