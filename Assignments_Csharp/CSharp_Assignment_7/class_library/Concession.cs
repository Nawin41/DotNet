using System;

namespace class_library
{
    public class Concession
    {
        public void CalculateConcession(int age, int totalFare)
        {
            if (age <= 5)
            {
                Console.WriteLine("Little Champs - Free Ticket");
            }
            else if (age > 60)
            {
                double concessionAmount = totalFare * 0.30;
                double finalFare = totalFare - concessionAmount;

                Console.WriteLine("Senior Citizen - Fare after concession: " + finalFare);
            }
            else
            {
                Console.WriteLine("Ticket Booked - Fare: " + totalFare);
            }
        }
    }
}