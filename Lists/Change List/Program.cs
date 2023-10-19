using System;
using System.Collections.Generic;
using System.Linq;

List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

while (true)
{
    string command = Console.ReadLine();

    if (command == "end")
    {
        break;
    }

    string[] tokens = command.Split();
    string action = tokens[0];

    if (action == "Delete")
    {
        int element = int.Parse(tokens[1]);
        numbers.RemoveAll(x => x == element);
    }
    else if (action == "Insert")
    {
        int element = int.Parse(tokens[1]);
        int position = int.Parse(tokens[2]);
        numbers.Insert(position, element);
    }
}

Console.WriteLine(string.Join(" ", numbers));
 