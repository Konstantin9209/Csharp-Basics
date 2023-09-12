namespace T02;

internal class RadiansToDegrees_02
{
    static void Main(string[] args)
    {
        double radians = double.Parse(Console.ReadLine());
        double deg = radians * 180 / Math.PI;

        Console.WriteLine(deg);
    }
}
