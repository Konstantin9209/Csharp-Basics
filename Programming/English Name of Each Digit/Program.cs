using System;

string input = Console.ReadLine();

for (int i = input.Length - 1; i >= 0; i--)
{
    char digit = input[i];
    Console.WriteLine(NumberToWord(digit));
}

string NumberToWord(char digit)
{
    switch (digit)
    {
        case '0': return "zero";
        case '1': return "one";
        case '2': return "two";
        case '3': return "three";
        case '4': return "four";
        case '5': return "five";
        case '6': return "six";
        case '7': return "seven";
        case '8': return "eight";
        case '9': return "nine";
        default: return "Invalid digit";
    }
}
