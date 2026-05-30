using System;
using System.Data.SqlClient;

namespace TrainReservationSystem
{
    class Cancellation
    {
        public static void CancelTicket()
        {
            int id = Program.ReadInt("Booking ID: ");

            SqlConnection con = DB.GetConnection();

            SqlCommand info = new SqlCommand(
                "SELECT * FROM Booking WHERE BookingId=@id", con);

            info.Parameters.AddWithValue("@id", id);

            con.Open();
            SqlDataReader dr = info.ExecuteReader();

            if (!dr.Read())
            {
                Console.WriteLine("Invalid ID");
                return;
            }

            Console.WriteLine("Train: " + dr["TrainNo"]);
            Console.WriteLine("Passengers: " + dr["Passengers"]);

            dr.Close();

            Console.Write("Confirm cancel (Y/N): ");
            if (Console.ReadLine().ToUpper() != "Y")
                return;

            int tickets = Program.ReadInt("Tickets to cancel: ");
            int refund = tickets * 900;

            SqlCommand insert = new SqlCommand(
                "INSERT INTO Cancellation VALUES(@id,@t,@r)", con);

            insert.Parameters.AddWithValue("@id", id);
            insert.Parameters.AddWithValue("@t", tickets);
            insert.Parameters.AddWithValue("@r", refund);
            insert.ExecuteNonQuery();

            Console.WriteLine("Refund: " + refund);

            con.Close();
        }
    }
}