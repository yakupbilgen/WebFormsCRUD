using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms_CRUD.Site
{
	public partial class NewProduct : System.Web.UI.Page
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
			string query = "INSERT INTO TBLProduct (ProductName,UnitPrice,UnitStock) VALUES (@productname,@unitprice,@unitstock)";
			SqlCommand cmd = new SqlCommand(query, ctx); ;
			cmd.Parameters.AddWithValue("@productname", txtProductName.Text);
			cmd.Parameters.AddWithValue("@unitprice", txtUnitPrice.Text);
			cmd.Parameters.AddWithValue("@unitstock", txtUnitStock.Text);
			if (txtProductName.Text == "" || txtUnitPrice.Text == "" || txtUnitStock.Text == "")
			{
				lblDurum.Text = "Lütfen tüm alanları doldurunuz!";
			}
			else
			{
				cmd.ExecuteNonQuery();
				Response.Redirect("~/Site/Product.aspx");
			}

			ctx.Close();
		}
	}
}