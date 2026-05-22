using System;
using System.Configuration;
using System.Data.SqlClient;

namespace ASP_Assignment_1
{
    public partial class Validator : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["ASP_DB"].ConnectionString;

        protected void btnCheck_Click(object sender, EventArgs e)
        {
            if (!Page.IsValid)
                return;

            if (txtName.Text == txtFamily.Text)
            {
                lblMessage.Text = "Name and Family Name cannot be same!";
                lblMessage.ForeColor = System.Drawing.Color.Red;
                return;
            }

            SqlConnection con = new SqlConnection(cs);

            string query = @"INSERT INTO Users
            (Name, FamilyName, Address, City, ZipCode, Phone, Email)
            VALUES (@Name,@Family,@Address,@City,@Zip,@Phone,@Email)";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@Name", txtName.Text);
            cmd.Parameters.AddWithValue("@Family", txtFamily.Text);
            cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
            cmd.Parameters.AddWithValue("@City", txtCity.Text);
            cmd.Parameters.AddWithValue("@Zip", txtZip.Text);
            cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            lblMessage.Text = "User Saved Successfully!";
            lblMessage.ForeColor = System.Drawing.Color.Green;
        }
    }
}
