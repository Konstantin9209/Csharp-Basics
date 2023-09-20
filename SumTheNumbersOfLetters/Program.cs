using System.ComponentModel.Design;

namespace SumTheNumbersOfLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int vowelWeight = 0;
            for (int i = 0; i < text.Length; i += 1)
            {
                char MyChar = text[i];
                if (MyChar == 'a')
                {
                    vowelWeight += 1;
                }
                else if (MyChar == 'e')
                {
                    vowelWeight += 2;
                }
                else if (MyChar == 'i')
                {
                    vowelWeight += 3;
                }
                else if (MyChar == 'o')
                {
                    vowelWeight += 4;
                }
                else if (MyChar == 'u')
                {
                    vowelWeight += 5;
                }
            }
            Console.WriteLine("Vowels sum = " + vowelWeight);
        }
    }
}