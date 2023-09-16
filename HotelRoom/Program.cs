namespace HotelRoom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double studioPrice = 0;
            double apptPrice = 0;

            switch (month)
            {
                case "May":
                case "October":
                    studioPrice = 50;
                    apptPrice = 65;
                    break;

                case "June":
                case "September":
                    studioPrice = 75.20;
                    apptPrice = 68.70;
                    break;

                case "July":
                case "August":
                    studioPrice = 76;
                    apptPrice = 77;
                    break;
            }
            double studioTotal = studioPrice * nights;
            double apptTotal = apptPrice * nights;

            if (nights > 14)
            {
                if (month == "May" || month == "October")
                {
                    studioTotal = studioTotal * 0.7;
                }
                else if (month == "June" || month == "September")
                {
                    studioTotal = studioTotal * 0.8;
                }
                apptTotal *= 0.9;
            }
            else if (nights >= 7)
            {
                if (month == "May" || month == "October")
                {
                    studioTotal = studioTotal * 0.95;
                }
            }

            Console.WriteLine($"Apartment: {apptTotal:F2} lv.");
            Console.WriteLine($"Studio: {studioTotal:F2} lv.");
        }
    }
}
