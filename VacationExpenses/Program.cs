using System.ComponentModel.Design;

namespace VacationExpenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String season = Console.ReadLine();
            string accType = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());

            double finalPrice = 0;

            if (season == "Spring")
            {
                if (accType == "Hotel")
                {
                    finalPrice = days * 30;
                }
                else if (accType == "Camping")
                {
                    finalPrice = days * 10;
                }

                finalPrice *= 1 - 0.20;
            }
            else if (season == "Summer")
            {
                if (accType == "Hotel")
                {
                    finalPrice = days * 50;
                }
                else if (accType == "Camping")
                {
                    finalPrice = days * 30;
                }
            }
            else if (season == "Autumn")
            {
                if (accType == "Hotel")
                {
                    finalPrice = days * 20;
                }
                else if (accType == "Camping")
                {
                    finalPrice = days * 15;
                }

                finalPrice *= 1 - 0.30;
            }
            else if (season == "Winter")
            {
                if (accType == "Hotel")
                {
                    finalPrice = days * 40;
                }
                else if (accType == "Camping")
                {
                    finalPrice = days * 10;
                }

                finalPrice *= 1 - 0.10;

            }
            Console.WriteLine($"{finalPrice:F2}");
        }
        }
    }
