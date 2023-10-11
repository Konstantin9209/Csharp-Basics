namespace TrainTheTrainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int juryMembers = int.Parse(Console.ReadLine());

            double totalGradesSum = 0;
            int presentationCount = 0;

            while (true)
            {
                string presName = Console.ReadLine();

                if (presName == "Finish")
                    break;

                presentationCount++;
                double presentationAverage = 0;

                for (int juryMember = 1; juryMember <= juryMembers; juryMember++)
                {
                    double curGrade = double.Parse(Console.ReadLine());
                    presentationAverage += curGrade;
                    totalGradesSum += curGrade;
                }

                Console.WriteLine($"{presName} - {presentationAverage / juryMembers:f2}.");
            }

            Console.WriteLine($"Student's final assessment is {totalGradesSum / (presentationCount * juryMembers):f2}");
        }
    }
}
