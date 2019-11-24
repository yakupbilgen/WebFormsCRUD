using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms_CRUD.Site
{
	public partial class UpdateProduct : System.Web.UI.Page
	{
		SqlConnection ctx = new SqlConnection("data source=DESKTOP-LU5VIM4\\MSSQLSERVER1;initial catalog=DBWebFormsCRUD;integrated security=True");

		protected void Page_Load(object sender, EventArgs e)
		{
			if (Session["user"] == null)
			{
				Response.Redirect("Login.aspx");
			}
		}

		protected void btnBilgiGetir_Click(object sender, EventArgs e)
		{
			txtUrunAdi.Text = "";
			txtUrunFiyat.Text = "";
			txtUrunStok.Text = "";
			lblidbulunamadi.Text = "";
			if (txtid.Text != "")
			{
				ctx.Open();
				string query = "SELECT ProductName,UnitPrice,UnitStock FROM TBLProduct  WHERE ProductID=@productid";
				SqlCommand cmd = new SqlCommand(query, ctx);
				cmd.Parameters.AddWithValue("@productid", Convert.ToInt32(txtid.Text));
				SqlDataReader dr = cmd.ExecuteReader();
				while (dr.Read())
				{
					txtUrunAdi.Text = dr[0].ToString();
					txtUrunFiyat.Text = dr[1].ToString();
					txtUrunStok.Text = dr[2].ToString();
					lblidbulunamadi.Text = "";
				}
				if (dr.Read() == true)
				{
					lblidbulunamadi.Text = "İD'ye ait kayıt bulunamadı!";
				}
				ctx.Close();
			}
			else
			{
				lblidbulunamadi.Text = "İD boş bırakılamaz!";
			}
		}

		protected void btnGuncelle_Click(object sender, EventArgs e)
		{
			ctx.Open();
			string query = "UPDATE TBLProduct SET ProductName=@productname, UnitPrice=@unitprice, UnitStock=@unitstock WHERE ProductID=@productid";
			SqlCommand cmd = new SqlCommand(query, ctx);
			cmd.Parameters.AddWithValue("@productname", txtUrunAdi.Text);
			cmd.Parameters.AddWithValue("@unitprice", Convert.ToDecimal(txtUrunFiyat.Text));
			cmd.Parameters.AddWithValue("@unitstock", Convert.ToInt32(txtUrunStok.Text));
			cmd.Parameters.AddWithValue("@productid", Convert.ToInt32(txtid.Text));
			cmd.ExecuteNonQuery();
			Response.Redirect("Product.aspx");
			ctx.Close();
		}
	}
}