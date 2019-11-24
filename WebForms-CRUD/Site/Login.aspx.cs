using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Text;
using System.Security.Cryptography;
using System.Data;

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
			if (ctx.State == ConnectionState.Open)
			{
				ctx.Close();
			}
			else
			{
				if (txtUsername.Text == "" || txtPassword.Text == "")
				{
					lblDurum.Text = "Kullanıcı adı ve şifre boş olamaz!";
				}
				else
				{
					ctx.Open();
					SHA1 sha = new SHA1CryptoServiceProvider();
					string hashpassword = Convert.ToBase64String(sha.ComputeHash(Encoding.UTF8.GetBytes(txtPassword.Text)));
					string query = "SELECT * FROM TBLUser WHERE UserName=@username and Password=@password";
					SqlCommand cmd = new SqlCommand(query, ctx);
					cmd.Parameters.AddWithValue("@username", txtUsername.Text);
					cmd.Parameters.AddWithValue("@password", hashpassword);
					SqlDataReader dr = cmd.ExecuteReader();
					if (dr.Read())
					{
						Session.Add("user", txtUsername.Text);
						Response.Redirect("Default.aspx");
					}
					else
					{
						lblDurum.Text = "Lütfen bilgilerinizi kontrol ediniz!";
					}
					ctx.Close();
				}
			}
		}

		protected void btnNewUser_Click(object sender, EventArgs e)
		{
			Response.Redirect("NewUser.aspx");
		}
	}
}