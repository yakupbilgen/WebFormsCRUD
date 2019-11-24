using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms_CRUD
{
	public partial class About : Page
	{
		SqlConnection ctx = new SqlConnection("data source=DESKTOP-LU5VIM4\\MSSQLSERVER1;initial catalog=DBWebFormsCRUD;integrated security=True");

		protected void Page_Load(object sender, EventArgs e)
		{
			if (Session["user"] == null)
			{
				Response.Redirect("Login.aspx");
			}

			ctx.Open();
			string query = "SELECT * FROM TBLProduct";

			DataTable dt = new DataTable();
			SqlDataAdapter da = new SqlDataAdapter(query,ctx); ;
			da.Fill(dt);
			Repeater1.DataSource = dt;
			Repeater1.DataBind();
			ctx.Close();
		}

		protected void btnSil_Click(object sender, EventArgs e)
		{
			ctx.Open();
			string query = "DELETE FROM TBLProduct WHERE ProductID=@productid";
			SqlCommand cmd = new SqlCommand(query, ctx);
			cmd.Parameters.AddWithValue("@productid", txtSilid.Text);
			cmd.ExecuteNonQuery();
			Response.Redirect("Product.aspx");
			ctx.Close();
		}
	}
}