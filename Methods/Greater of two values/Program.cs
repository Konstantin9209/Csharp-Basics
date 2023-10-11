using System;

class Program
{
    static int CompareInt(int a, int b)
    {
        return Math.Max(a, b);
    }

    static char CompareChar(char a, char b)
    {
        return (a > b) ? a : b;
    }

    static string CompareString(string a, string b)
    {
        return (String.Compare(a, b) > 0) ? a : b;
    }

    static void Main()
    {
        Console.Write("");
        string dataType = Console.ReadLine();

        switch (dataType)
        {
            case "int":
                Console.Write("");
                int int1 = int.Parse(Console.ReadLine());
                Console.Write("");
                int int2 = int.Parse(Console.ReadLine());
                int intResult = CompareInt(int1, int2);
                Console.WriteLine(intResult);
                break;

            case "char":
                Console.Write("");
                char char1 = char.Parse(Console.ReadLine());
                Console.Write("");
                char char2 = char.Parse(Console.ReadLine());
                char charResult = CompareChar(char1, char2);
                Console.WriteLine(charResult);
                break;

            case "string":
                Console.Write("");
                string str1 = Console.ReadLine();
                Console.Write("");
                string str2 = Console.ReadLine();
                string strResult = CompareString(str1, str2);
                Console.WriteLine(strResult);
                break;

            default:
                Console.WriteLine("Invalid data type. Please enter 'int', 'char', or 'string'.");
                break;
        }
    }
}
