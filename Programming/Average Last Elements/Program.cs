using System;
using System.Linq;

int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
int n = int.Parse(Console.ReadLine());

if (n > 0 && n <= numbers.Length)
{
    double average = numbers.Skip(numbers.Length - n).Take(n).Average();
    Console.WriteLine($"{average:F2}");
}
