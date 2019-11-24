using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebForms_CRUD
{
	public partial class NewCategory : System.Web.UI.Page
	{
		SqlConnection ctx = new SqlConnection("data source=DESKTOP-LU5VIM4\\MSSQLSERVER1;initial catalog=DBWebFormsCRUD;integrated security=True");

		protected void Page_Load(object sender, EventArgs e)
		{
			if (Session["user"] == null)
			{
				Response.Redirect("Login.aspx");
			}
		}

		protected void btnEkle_Click(object sender, EventArgs e)
		{
			ctx.Open();
			string query = "INSERT INTO TBLCategory (CategoryName,Description) VALUES (@categoryname,@description)";
			SqlCommand cmd = new SqlCommand(query, ctx); ;
			cmd.Parameters.AddWithValue("@categoryname", txtKategori.Text);
			cmd.Parameters.AddWithValue("@description", txtAciklama.Text);
			if (txtAciklama.Text =="" || txtKategori.Text == "")
			{
				lblDurum.Text="Lütfen tüm alanları doldurunuz!";
			}
			else
			{
				cmd.ExecuteNonQuery();
				Response.Redirect("~/Site/Category.aspx");
			}

			ctx.Close();
		}
	}
}