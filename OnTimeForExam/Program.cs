namespace OnTimeForExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinute = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinute = int.Parse(Console.ReadLine());

            int examTime = examHour * 60 + examMinute;
            int arrivalTime = arrivalHour * 60 + arrivalMinute;

            if (arrivalTime > examTime)
            {
                Console.WriteLine("Late");
                int minutesLate = arrivalTime - examTime;
                int hours = minutesLate / 60;
                int minutes = minutesLate % 60;
                if (hours > 0)
                {
                    Console.WriteLine($"{hours}:{minutes:D2} hours after the start");
                }
                else
                {
                    Console.WriteLine($"{minutes} minutes after the start");
                }
            }
            else if (arrivalTime >= examTime - 30)
            {
                Console.WriteLine("On time");
                int minutesEarly = examTime - arrivalTime;
                if (minutesEarly != 0)
                {
                    Console.WriteLine($"{minutesEarly} minutes before the start");
                }
            }
            else
            {
                Console.WriteLine("Early");
                int minutesEarly = examTime - arrivalTime;
                int hours = minutesEarly / 60;
                int minutes = minutesEarly % 60;
                if (hours > 0)
                {
                    Console.WriteLine($"{hours}:{minutes:D2} hours before the start");
                }
                else
                {
                    Console.WriteLine($"{minutes} minutes before the start");
                }
            }
        }
    }
}