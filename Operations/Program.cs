namespace Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            string operatorSymbol = Console.ReadLine();

            double result = 0;
            string evenOrOdd = "";
            bool isZero = false;
            switch (operatorSymbol)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        isZero = true;
                    }
                    else
                    {
                        result = (double)num1 / num2;
                    }
                    break;
                case "%":
                    if (num2 == 0)
                    {
                        isZero = true;
                    }
                    else
                    {
                        result = num1 % num2;
                    }
                    break;
            }

            if (isZero)
            {
                Console.WriteLine($"Cannot divide {num1} by zero");
            }
            else if (operatorSymbol == "+" || operatorSymbol == "-" || operatorSymbol == "*")
            {
                if (result % 2 == 0)
                {
                    evenOrOdd = "even";
                }
                else
                {
                    evenOrOdd = "odd";
                }
                Console.WriteLine($"{num1} {operatorSymbol} {num2} = {result} - {evenOrOdd}");
            }
            else if (operatorSymbol == "/")
            {
                Console.WriteLine($"{num1} / {num2} = {result:F2}");
            }
            else if (operatorSymbol == "%")
            {
                Console.WriteLine($"{num1} % {num2} = {result}");
            }
        }
    }
}