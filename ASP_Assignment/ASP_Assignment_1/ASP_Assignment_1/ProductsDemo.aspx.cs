using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace ASP_Assignment_1
{
    public partial class ProductsDemo : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["ASP_DB"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadProducts();
            }
        }

        private void LoadProducts()
        {
            SqlConnection con = new SqlConnection(cs);

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Products", con);

            DataTable dt = new DataTable();
            da.Fill(dt);

            ddlProducts.DataSource = dt;
            ddlProducts.DataTextField = "Name";
            ddlProducts.DataValueField = "Id";
            ddlProducts.DataBind();

            ddlProducts.Items.Insert(0, "--Select--");
        }

        protected void ddlProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlProducts.SelectedValue == "--Select--")
                return;

            SqlConnection con = new SqlConnection(cs);

            string query = "SELECT ImagePath FROM Products WHERE Id=@Id";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Id", ddlProducts.SelectedValue);

            con.Open();

            object result = cmd.ExecuteScalar();

            if (result != null)
            {
                imgProduct.ImageUrl = result.ToString();  // ✅ loads ~/Images/...
            }

            con.Close();
        }

        protected void btnPrice_Click(object sender, EventArgs e)
        {
            if (ddlProducts.SelectedValue == "--Select--")
                return;

            SqlConnection con = new SqlConnection(cs);

            string query = "SELECT Price FROM Products WHERE Id=@Id";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Id", ddlProducts.SelectedValue);

            con.Open();

            object result = cmd.ExecuteScalar();

            if (result != null)
            {
                lblPrice.Text = "Price: ₹ " + result.ToString();
            }

            con.Close();
        }
    }
}