using System;

namespace C_sharp_code_challenge_4
{
    class Distance
    {
        public int Kilometer { get; set; }

        public static Distance Add(Distance d1, Distance d2)
        {
            Distance d3 = new Distance();
            d3.Kilometer = d1.Kilometer + d2.Kilometer;
            return d3;
        }

        public void Display()
        {
            Console.WriteLine("Total Distance: " + Kilometer + " km");
        }
    }

    class DistanceProgram
    {
        public static void question_1()
        {
            Distance d1 = new Distance();
            Distance d2 = new Distance();

            Console.Write("Enter Distance 1 (km): ");
            d1.Kilometer = int.Parse(Console.ReadLine());

            Console.Write("Enter Distance 2 (km): ");
            d2.Kilometer = int.Parse(Console.ReadLine());

            Distance d3 = Distance.Add(d1, d2);
            d3.Display();

            Console.ReadLine();
        }
    }
}
