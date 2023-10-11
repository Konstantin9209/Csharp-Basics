static void PrintLine(int start, int end)
{
    for(int i = start; i <=end; i++)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine();
}

static void PrintTriangle(int num)
{
    for(int currrentLine = 1; currrentLine <= num; currrentLine++)
    {
        PrintLine(1, currrentLine);
    }
    for (int currrentLine = num -1; currrentLine >= 1; currrentLine--)
    {
        PrintLine(1, currrentLine);
    }
}
int number = int.Parse(Console.ReadLine());

PrintTriangle(number);