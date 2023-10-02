using System.ComponentModel.Design;

namespace BiggestOfFiveNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numb1 = int.Parse(Console.ReadLine());
            int numb2 = int.Parse(Console.ReadLine());
            int numb3 = int.Parse(Console.ReadLine());
            int numb4 = int.Parse(Console.ReadLine());
            int numb5 = int.Parse(Console.ReadLine());

            if (numb1 > numb2 && numb1 > numb3 && numb1 > numb4 && numb1 > numb5)
            {
                Console.WriteLine(numb1);
            }
            else if (numb2 > numb1 && numb2 > numb3 && numb2 > numb4 && numb2 > numb5)
            {
                Console.WriteLine(numb2);
            }
            else if (numb3 > numb1 && numb3 > numb2 && numb3 > numb4 && numb3 > numb5)
            {
                Console.WriteLine(numb3);
            }
            else if (numb4 > numb1 && numb4 > numb2 && numb4 > numb3 && numb4 > numb5)
            {
                Console.WriteLine(numb4);
            }
            else
            {
                Console.WriteLine(numb5);
            }
        }
            }
}
        
        