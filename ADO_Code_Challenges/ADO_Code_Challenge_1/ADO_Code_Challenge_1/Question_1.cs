using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ADO_Code_Challenge_1
{
    class Question_1
    {
        public string EmpName { get; set; }
        public decimal EmpSal { get; set; }
        public char EmpType { get; set; }
        DataAccess access = new DataAccess();



        public int AddEmployee()
        {
            Console.WriteLine("Enter Employee Name :");
            EmpName = Console.ReadLine();



            Console.WriteLine("Enter Employee Salary :");
            EmpSal = Convert.ToDecimal(Console.ReadLine());



            Console.WriteLine("Enter Employee Type (F/P) :");
            EmpType = Convert.ToChar(Console.ReadLine().ToUpper());



            return access.InsertEmployee(EmpName, EmpSal, EmpType);
        }



        public SqlDataReader ShowEmployees()
        {
            return access.GetEmployees();
        }
    }



    class DataAccess
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;



        public SqlConnection GetConnection()
        {
            string str = "Data Source=ICS-LT-4363YS3;Initial Catalog=Employeemanagement;Integrated Security=True";



            con = new SqlConnection(str);
            con.Open();
            return con;
        }



        public int InsertEmployee(string name, decimal sal, char type)
        {
            int result = 0;



            try
            {
                con = GetConnection();



                cmd = new SqlCommand("Employee", con);
                cmd.CommandType = CommandType.StoredProcedure;



                cmd.Parameters.AddWithValue("@empname", name);
                cmd.Parameters.AddWithValue("@empsal", sal);
                cmd.Parameters.AddWithValue("@emptype", type);



                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



            return result;
        }
        public SqlDataReader GetEmployees()
        {
            try
            {
                con = GetConnection();



                cmd = new SqlCommand("select * from employee_details", con);
                dr = cmd.ExecuteReader();



                return dr;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



            return null;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Question_1 emp = new Question_1();



            Console.WriteLine("Insert Employee");



            int res = emp.AddEmployee();



            if (res > 0)
                Console.WriteLine("Employee Inserted Successfully");
            else
                Console.WriteLine("Insertion Failed");



            Console.WriteLine("\nEmployee Details");



            SqlDataReader dr = emp.ShowEmployees();



            while (dr.Read())
            {
                Console.WriteLine(
                dr["empno"] + " " + dr["empname"] + " " + dr["empsal"] + " " + dr["emptype"]);
            }



            Console.ReadLine();
        }
    }
}