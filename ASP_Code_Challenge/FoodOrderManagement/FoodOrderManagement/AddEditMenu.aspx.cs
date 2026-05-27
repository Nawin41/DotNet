using System;
using System.Configuration;
using System.Data.SqlClient;

namespace FoodOrderManagement
{
    public partial class AddEditMenu : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["FoodDB"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] == null)
                Response.Redirect("Login.aspx");
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);

            if (Request.QueryString["MenuId"] == null)
            {
                string q = "INSERT INTO MenuItems(ItemName,Category,Price) VALUES(@n,@c,@p)";
                SqlCommand cmd = new SqlCommand(q, con);

                cmd.Parameters.AddWithValue("@n", txtName.Text);
                cmd.Parameters.AddWithValue("@c", txtCat.Text);
                cmd.Parameters.AddWithValue("@p", txtPrice.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            else
            {
                int id = Convert.ToInt32(Request.QueryString["MenuId"]);

                string q = "UPDATE MenuItems SET ItemName=@n WHERE MenuId=@id";
                SqlCommand cmd = new SqlCommand(q, con);

                cmd.Parameters.AddWithValue("@n", txtName.Text);
                cmd.Parameters.AddWithValue("@id", id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}
