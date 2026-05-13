using System;
using System.Data;
using System.Data.SqlClient;

namespace ADO_Code_Challenge_1
{
    internal class Question_2
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection("Data Source=ICS-LT-4363YS3;Initial Catalog=Employeemanagement;Integrated Security=True");

            SqlCommand cmd = new SqlCommand("UpdateSalary", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Empno", 1);

            SqlParameter outParam = new SqlParameter("@UpdatedSalary", SqlDbType.Decimal);
            outParam.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(outParam);

            con.Open();

            cmd.ExecuteNonQuery();

            Console.WriteLine("Updated Salary : " + outParam.Value);

            SqlCommand cmd2 = new SqlCommand("SELECT * FROM Employee_Details", con);
            SqlDataReader dr = cmd2.ExecuteReader();

            Console.WriteLine("\nEmployee Records");

            while (dr.Read())
            {
                Console.WriteLine(dr["Empno"] + " " + dr["EmpName"] + " " + dr["Empsal"] + " " + dr["Emptype"]);
            }

            con.Close();

            Console.ReadLine();
        }
    }
}