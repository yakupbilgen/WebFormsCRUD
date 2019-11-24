using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebForms_CRUD
{
	public partial class Login : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}
		SqlConnection ctx = new SqlConnection("data source=DESKTOP-LU5VIM4\\MSSQLSERVER1;initial catalog=DBWebFormsCRUD;integrated security=True");
		
		protected void btnLogin_Click(object sender, EventArgs e)
		{
			ctx.Open();

			string username = txtUsername.Text;
			string password = txtPassword.Text;
			string query = "SELECT * FROM TBLUser WHERE Username=@username and Password=@password";
			SqlCommand cmd = new SqlCommand(query, ctx);
			cmd.Parameters.AddWithValue("@username", txtUsername.Text);
			cmd.Parameters.AddWithValue("@password", txtPassword.Text);
			SqlDataReader dr = cmd.ExecuteReader();
			if (dr.Read())
			{
				Session.Add("user", username);
				Response.Redirect("Default.aspx");
			}
			else
			{
				lblDurum.Text = "Lütfen bilgilerinizi kontrol ediniz!";
			}
		}
	}
}