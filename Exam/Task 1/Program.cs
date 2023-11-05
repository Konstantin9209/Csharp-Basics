int count = int.Parse(Console.ReadLine());
double grades = 0;
for(int i = 0; i < count; i++)
{
    grades += double.Parse(Console.ReadLine());
}
double averageGrade = grades / count;
Console.WriteLine($"{averageGrade:F2}");