using System;
using System.Data.SqlClient;

namespace TrainReservationSystem
{
    class Booking
    {
        public static void BookTicket()
        {
            int tno = Program.ReadInt("Train No: ");
            int p = Program.ReadInt("Passengers (max 3): ");

            if (p > 3)
            {
                Console.WriteLine("Max 3 allowed");
                return;
            }

            Console.Write("Travel Date (yyyy-mm-dd): ");
            DateTime date = Convert.ToDateTime(Console.ReadLine());

            SqlConnection con = DB.GetConnection();

            SqlCommand cmd = new SqlCommand(
                "SELECT Charges, Availability FROM Trains WHERE TrainNo=@t", con);

            cmd.Parameters.AddWithValue("@t", tno);

            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            if (!dr.Read())
            {
                Console.WriteLine("Train not found");
                return;
            }

            int avail = (int)dr["Availability"];

            if (avail < p)
            {
                Console.WriteLine("Not enough seats");
                return;
            }

            int amount = (int)dr["Charges"] * p;

            dr.Close();

            SqlCommand insert = new SqlCommand(
                "INSERT INTO Booking(BookDate,TravelDate,TrainNo,TravelClass,Passengers,Amount) VALUES(GETDATE(),@d,@t,'General',@p,@a); SELECT SCOPE_IDENTITY();", con);

            insert.Parameters.AddWithValue("@d", date);
            insert.Parameters.AddWithValue("@t", tno);
            insert.Parameters.AddWithValue("@p", p);
            insert.Parameters.AddWithValue("@a", amount);

            int id = Convert.ToInt32(insert.ExecuteScalar());

            SqlCommand update = new SqlCommand(
                "UPDATE Trains SET Availability = Availability - @p WHERE TrainNo=@t", con);

            update.Parameters.AddWithValue("@p", p);
            update.Parameters.AddWithValue("@t", tno);
            update.ExecuteNonQuery();

            Console.WriteLine("\nBooking Successful");
            Console.WriteLine("Booking ID : " + id);
            Console.WriteLine("Amount     : " + amount);

            con.Close();
        }

        public static void ViewBookings()
        {
            SqlConnection con = DB.GetConnection();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Booking", con);

            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            Console.WriteLine("\n==============================================================");
            Console.WriteLine("                    BOOKING DETAILS");
            Console.WriteLine("==============================================================");
            Console.WriteLine("ID   Train   Date        Passengers   Amount");
            Console.WriteLine("--------------------------------------------------------------");

            while (dr.Read())
            {
                Console.WriteLine(
                    $"{dr["BookingId"],-4} " +
                    $"{dr["TrainNo"],-6} " +
                    $"{Convert.ToDateTime(dr["TravelDate"]).ToString("yyyy-MM-dd"),-12} " +
                    $"{dr["Passengers"],-10} " +
                    $"{dr["Amount"],-6}");
            }

            Console.WriteLine("==============================================================");

            con.Close();
        }
    }
}