using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace WebForms_CRUD
{
	public partial class Contact : Page
	{
		SqlConnection ctx = new SqlConnection("data source=DESKTOP-LU5VIM4\\MSSQLSERVER1;initial catalog=DBWebFormsCRUD;integrated security=True");

		protected void Page_Load(object sender, EventArgs e)
		{
			if (Session["user"] == null)
			{
				Response.Redirect("Login.aspx");
			}

			ctx.Open();
			string query = "SELECT * FROM TBLCategory";

			DataTable dt = new DataTable();
			SqlDataAdapter da = new SqlDataAdapter(query, ctx); ;
			da.Fill(dt);
			Repeater1.DataSource = dt;
			Repeater1.DataBind();
			ctx.Close();
		}

		protected void btnSil_Click(object sender, EventArgs e)
		{
			ctx.Open();
			string query = "DELETE FROM TBLCategory WHERE CategoryID=@categoryid";
			SqlCommand cmd = new SqlCommand(query, ctx);
			cmd.Parameters.AddWithValue("@categoryid", txtSilid.Text);
			cmd.ExecuteNonQuery();
			Response.Redirect("Category.aspx");
			ctx.Close();
		}
	}
}