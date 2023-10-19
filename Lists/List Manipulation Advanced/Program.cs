using System;
using System.Collections.Generic;
using System.Linq;

List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

string input;
while ((input = Console.ReadLine()) != "end")
{
    string[] commandParts = input.Split(" ");
    string commandName = commandParts[0];

    if (commandName == "Contains")
    {
        int containedNumber = int.Parse(commandParts[1]);
        if (numbers.Contains(containedNumber))
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No such number");
        }
    }
    else if (commandName == "PrintEven")
    {
        Console.WriteLine(string.Join(" ", numbers.Where(n => n % 2 == 0)));
    }
    else if (commandName == "PrintOdd")
    {
        Console.WriteLine(string.Join(" ", numbers.Where(n => n % 2 != 0)));
    }
    else if (commandName == "GetSum")
    {
        Console.WriteLine(numbers.Sum());
    }
    else if (commandName == "Filter")
    {
        string condition = commandParts[1];
        int filterNumber = int.Parse(commandParts[2]);

        List<int> filteredNumbers = new List<int>();

        foreach (int num in numbers)
        {
            if (condition == "<" && num < filterNumber)
            {
                filteredNumbers.Add(num);
            }
            else if (condition == ">" && num > filterNumber)
            {
                filteredNumbers.Add(num);
            }
            else if (condition == "<=" && num <= filterNumber)
            {
                filteredNumbers.Add(num);
            }
            else if (condition == ">=" && num >= filterNumber)
            {
                filteredNumbers.Add(num);
            }
        }

        Console.WriteLine(string.Join(" ", filteredNumbers));
    }
}

Console.WriteLine(string.Join(" ", numbers));
