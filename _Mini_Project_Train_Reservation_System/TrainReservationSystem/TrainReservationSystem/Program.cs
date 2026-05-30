using System;

namespace TrainReservationSystem
{
    class Program
    {
        public static int ReadInt(string msg)
        {
            int val;
            while (true)
            {
                Console.Write(msg);
                if (int.TryParse(Console.ReadLine(), out val))
                    return val;

                Console.WriteLine("Invalid number. Try again.");
            }
        }

        static void Main()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("===== TRAIN RESERVATION SYSTEM =====");
                Console.WriteLine("1. Admin Login");
                Console.WriteLine("2. User Login");

                int choice = ReadInt("Enter choice: ");

                if (choice == 1) AdminLogin();
                else if (choice == 2) UserLogin();
            }
        }

        static void AdminLogin()
        {
            Console.Write("Username: ");
            string u = Console.ReadLine();
            Console.Write("Password: ");
            string p = Console.ReadLine();

            if (u == "admin" && p == "123") AdminMenu();
            else Console.WriteLine("Invalid login");
        }

        static void UserLogin()
        {
            Console.Write("Username: ");
            string u = Console.ReadLine();
            Console.Write("Password: ");
            string p = Console.ReadLine();

            if (u == "user" && p == "123") UserMenu();
            else Console.WriteLine("Invalid login");
        }

        static void AdminMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("===== ADMIN MENU =====");
                Console.WriteLine("1. Add Train");
                Console.WriteLine("2. View Trains");
                Console.WriteLine("3. Update Train");
                Console.WriteLine("4. Search Train");
                Console.WriteLine("5. View Bookings");
                Console.WriteLine("6. Book Ticket");
                Console.WriteLine("7. Cancel Ticket");
                Console.WriteLine("8. Logout");

                int ch = ReadInt("Choice: ");

                switch (ch)
                {
                    case 1: Train.AddTrain(); break;
                    case 2: Train.ViewTrains(); break;
                    case 3: Train.UpdateTrain(); break;
                    case 4: Train.SearchTrain(); break;
                    case 5: Booking.ViewBookings(); break;
                    case 6: Booking.BookTicket(); break;
                    case 7: Cancellation.CancelTicket(); break;
                    case 8: return;
                }

                Console.ReadLine();
            }
        }

        static void UserMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("===== USER MENU =====");
                Console.WriteLine("1. View Trains");
                Console.WriteLine("2. Search Train");
                Console.WriteLine("3. Book Ticket");
                Console.WriteLine("4. Cancel Ticket");
                Console.WriteLine("5. Logout");

                int ch = ReadInt("Choice: ");

                switch (ch)
                {
                    case 1: Train.ViewTrains(); break;
                    case 2: Train.SearchTrain(); break;
                    case 3: Booking.BookTicket(); break;
                    case 4: Cancellation.CancelTicket(); break;
                    case 5: return;
                }

                Console.ReadLine();
            }
        }
    }
}
