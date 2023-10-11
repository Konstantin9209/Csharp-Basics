double balance = 0;

while (true)
{
    string input = Console.ReadLine();

    if (input == "End")
    {
        break;
    }
    double amount = double.Parse(input);
    if (amount > 0)
    {
        balance += amount;
        Console.WriteLine($"Increase: {amount:f2}");
    }
    else if (amount < 0)
    {
        balance += amount;
        Console.WriteLine($"Decrease: {Math.Abs(amount):f2}");
    }

}
Console.WriteLine($"Balance: {balance:f2}");