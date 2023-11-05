int[] numbs = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int rotations = int.Parse(Console.ReadLine());

for (int i = 0; i < rotations; i++)
{
    int lastElement = numbs[numbs.Length - 1];
    for (int j = numbs.Length - 1; j > 0; j--)
    {
        numbs[j] = numbs[j - 1];
    }
    numbs[0] = lastElement; 
}

Console.WriteLine(string.Join(", ", numbs));