using System;

namespace C_Sharp_Code_Challenge_3
{
    public class CricketTeam
    {
        public static void Pointscalculation(int no_of_matches)
        {
            Console.WriteLine("Enter number of matches:");
            no_of_matches = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = 1; i <= no_of_matches; i++)
            {
                Console.WriteLine("Enter score for match " + i + ":");
                int score = int.Parse(Console.ReadLine());
                sum += score;
            }

            double average = (double)sum / no_of_matches;
            Console.WriteLine("Total Matches: " + no_of_matches);
            Console.WriteLine("Sum of Scores: " + sum);
            Console.WriteLine("Average Score: " + average);
        }
    }
}