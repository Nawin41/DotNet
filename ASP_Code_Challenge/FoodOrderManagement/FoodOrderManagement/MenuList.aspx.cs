using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace FoodOrderManagement
{
    public partial class MenuList : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["FoodDB"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] == null)
            {
                Response.Redirect("Login.aspx");
            }

            LoadMenu();
            LoadCategoryStats(); 
        }

        private void LoadMenu()
        {
            SqlConnection con = new SqlConnection(cs);

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM MenuItems", con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            gvMenu.DataSource = dt;
            gvMenu.DataBind();
        }

        private void LoadCategoryStats()
        {
            DataTable dt;

            if (Cache["FoodCategoryStats"] == null)
            {
                lblCacheMsg.Text = "Loaded from Database";

                SqlConnection con = new SqlConnection(cs);

                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT Category, COUNT(*) AS Total FROM MenuItems GROUP BY Category",
                    con);

                dt = new DataTable();
                da.Fill(dt);

                Cache.Insert("FoodCategoryStats", dt, null,
                    DateTime.Now.AddMinutes(5), TimeSpan.Zero);
            }
            else
            {
                lblCacheMsg.Text = "Loaded from Cache";

                dt = (DataTable)Cache["FoodCategoryStats"];
            }

            gvStats.DataSource = dt;
            gvStats.DataBind();
        }
    }
}