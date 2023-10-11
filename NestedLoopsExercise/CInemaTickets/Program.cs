namespace CinemaTickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalStudentTickets = 0;
            int totalKidsTickets = 0;
            int totalStandardTickets = 0;

            while (true)
            {
                string movieName = Console.ReadLine();

                if (movieName == "Finish")
                    break;

                int movieSize = int.Parse(Console.ReadLine());
                int movieSoldTickets = 0;
                while (movieSoldTickets < movieSize)
                {
                    string ticketType = Console.ReadLine();

                    if (ticketType == "End")
                        break;

                    movieSoldTickets++;
                    switch (ticketType)
                    {
                        case "kid": totalKidsTickets++; break;
                        case "student": totalStudentTickets++; break;
                        case "standard": totalStandardTickets++; break;
                    }
                }

                double percentFull = (movieSoldTickets * 100.0) / movieSize;

                Console.WriteLine($"{movieName} - {percentFull:f2}% full.");
            }

            int totalTickets = totalKidsTickets + totalStandardTickets + totalStudentTickets;

            double percentStudents = (totalStudentTickets * 100.0) / totalTickets;
            double percentStandard = (totalStandardTickets * 100.0) / totalTickets;
            double percentKids = (totalKidsTickets * 100.0) / totalTickets;

            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{percentStudents:f2}% student tickets.");
            Console.WriteLine($"{percentStandard:f2}% standard tickets.");
            Console.WriteLine($"{percentKids:f2}% kids tickets.");
        }
    }
}
