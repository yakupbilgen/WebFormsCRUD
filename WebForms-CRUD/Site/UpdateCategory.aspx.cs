using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebForms_CRUD.Site
{
	public partial class UpdateCategory : System.Web.UI.Page
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

			txtAciklama.Text = "";
			txtKategori.Text = "";
			lblidbulunamadi.Text = "";
			if (txtid.Text != "")
			{
				ctx.Open();
				string query = "SELECT CategoryName,Description FROM TBLCategory  WHERE CategoryID=@categoryid";
				SqlCommand cmd = new SqlCommand(query, ctx);
				cmd.Parameters.AddWithValue("@categoryid", Convert.ToInt32(txtid.Text));
				SqlDataReader dr = cmd.ExecuteReader();
				while (dr.Read())
				{
					txtKategori.Text = dr[0].ToString();
					txtAciklama.Text = dr[1].ToString();
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

		protected void btnEkle_Click(object sender, EventArgs e)
		{
			ctx.Open();
			string query = "UPDATE TBLCategory SET CategoryName=@categoryname, Description=@description WHERE CategoryID=@categoryid";
			SqlCommand cmd = new SqlCommand(query, ctx);
			cmd.Parameters.AddWithValue("@categoryname", txtKategori.Text);
			cmd.Parameters.AddWithValue("@description", txtAciklama.Text);
			cmd.Parameters.AddWithValue("@categoryid", txtid.Text);
			cmd.ExecuteNonQuery();
			Response.Redirect("Category.aspx");
			ctx.Close();
		}
	}
}