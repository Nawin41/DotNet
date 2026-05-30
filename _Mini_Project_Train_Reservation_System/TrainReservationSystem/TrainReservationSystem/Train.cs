using System;
using System.Data.SqlClient;

namespace TrainReservationSystem
{
    class Train
    {
        public static void AddTrain()
        {
            try
            {
                Console.WriteLine("\n========== ADD TRAIN ==========");

                int no = Program.ReadInt("Train No: ");

                SqlConnection con = DB.GetConnection();

                SqlCommand check = new SqlCommand(
                    "SELECT COUNT(*) FROM Trains WHERE TrainNo=@n", con);

                check.Parameters.AddWithValue("@n", no);

                con.Open();
                int exists = (int)check.ExecuteScalar();

                if (exists > 0)
                {
                    Console.WriteLine("Train number already exists");
                    con.Close();
                    return;
                }

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("From: ");
                string from = Console.ReadLine();

                Console.Write("To: ");
                string to = Console.ReadLine();

                Console.Write("Class: ");
                string cls = Console.ReadLine();

                int seats = Program.ReadInt("Seats: ");
                int charge = Program.ReadInt("Charges: ");

                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Trains VALUES(@no,@name,@f,@t,@c,@s,@ch,0)", con);

                cmd.Parameters.AddWithValue("@no", no);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@f", from);
                cmd.Parameters.AddWithValue("@t", to);
                cmd.Parameters.AddWithValue("@c", cls);
                cmd.Parameters.AddWithValue("@s", seats);
                cmd.Parameters.AddWithValue("@ch", charge);

                cmd.ExecuteNonQuery();

                Console.WriteLine("Train added successfully");
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        public static void ViewTrains()
        {
            try
            {
                SqlConnection con = DB.GetConnection();

                SqlCommand cmd = new SqlCommand(
                    "SELECT * FROM Trains WHERE IsDeleted = 0", con);

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (!dr.HasRows)
                {
                    Console.WriteLine("No trains available");
                    return;
                }

                Console.WriteLine("\n======================================================================");
                Console.WriteLine("                           TRAIN LIST");
                Console.WriteLine("======================================================================");

                Console.WriteLine(
                    $"{"No",-5} {"Name",-12} {"From",-12} {"To",-12} {"Class",-10} {"Seats",-6} {"Price",-6}");

                Console.WriteLine("----------------------------------------------------------------------");

                while (dr.Read())
                {
                    Console.WriteLine(
                        $"{dr["TrainNo"],-5} " +
                        $"{dr["Name"],-12} " +
                        $"{dr["FromStation"],-12} " +
                        $"{dr["ToStation"],-12} " +
                        $"{dr["Class"],-10} " +
                        $"{dr["Availability"],-6} " +
                        $"{dr["Charges"],-6}");
                }

                Console.WriteLine("======================================================================");

                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        public static void UpdateTrain()
        {
            try
            {
                Console.WriteLine("\n========== UPDATE TRAIN ==========");

                int no = Program.ReadInt("Enter Train No: ");

                SqlConnection con = DB.GetConnection();

                Console.Write("New Name: ");
                string name = Console.ReadLine();

                int seats = Program.ReadInt("New Seats: ");
                int charges = Program.ReadInt("New Charges: ");

                SqlCommand cmd = new SqlCommand(
                    "UPDATE Trains SET Name=@n, Availability=@s, Charges=@c WHERE TrainNo=@id", con);

                cmd.Parameters.AddWithValue("@id", no);
                cmd.Parameters.AddWithValue("@n", name);
                cmd.Parameters.AddWithValue("@s", seats);
                cmd.Parameters.AddWithValue("@c", charges);

                con.Open();

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                    Console.WriteLine("Train updated successfully");
                else
                    Console.WriteLine("Train not found");

                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        public static void SearchTrain()
        {
            try
            {
                Console.WriteLine("\n========== SEARCH TRAIN ==========");

                Console.Write("From: ");
                string from = Console.ReadLine();

                Console.Write("To: ");
                string to = Console.ReadLine();

                SqlConnection con = DB.GetConnection();

                SqlCommand cmd = new SqlCommand(
                    "SELECT * FROM Trains WHERE FromStation=@f AND ToStation=@t AND IsDeleted=0", con);

                cmd.Parameters.AddWithValue("@f", from);
                cmd.Parameters.AddWithValue("@t", to);

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (!dr.HasRows)
                {
                    Console.WriteLine("No matching trains found");
                    return;
                }

                Console.WriteLine("\nMatching Trains:");
                Console.WriteLine("--------------------------------");

                while (dr.Read())
                {
                    Console.WriteLine($"{dr["TrainNo"]} - {dr["Name"]}");
                }

                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        public static void DeleteTrain()
        {
            try
            {
                Console.WriteLine("\n========== DELETE TRAIN ==========");

                int no = Program.ReadInt("Enter Train No: ");

                SqlConnection con = DB.GetConnection();

                SqlCommand check = new SqlCommand(
                    "SELECT COUNT(*) FROM Booking WHERE TrainNo=@n", con);

                check.Parameters.AddWithValue("@n", no);

                con.Open();
                int count = (int)check.ExecuteScalar();

                if (count > 0)
                {
                    Console.WriteLine("Cannot delete. Bookings exist for this train.");
                    con.Close();
                    return;
                }

                Console.Write("Confirm delete (Y/N): ");
                string confirm = Console.ReadLine();

                if (confirm.ToUpper() != "Y")
                {
                    Console.WriteLine("Delete cancelled");
                    con.Close();
                    return;
                }

                //Soft delete
                SqlCommand cmd = new SqlCommand(
                    "UPDATE Trains SET IsDeleted = 1 WHERE TrainNo=@n", con);

                cmd.Parameters.AddWithValue("@n", no);

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                    Console.WriteLine("Train deleted (soft delete applied)");
                else
                    Console.WriteLine("Train not found");

                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}