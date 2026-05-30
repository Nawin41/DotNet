using System.Data.SqlClient;

namespace TrainReservationSystem
{
    class DB
    {
        public static string cs =
            "Data Source=ICS-LT-4363YS3;Initial Catalog=TrainDB;Integrated Security=True";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(cs);
        }
    }
}