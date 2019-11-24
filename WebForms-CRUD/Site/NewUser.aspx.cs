using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Data;

namespace WebForms_CRUD.Site
{
	public partial class NewUser : System.Web.UI.Page
	{
		SqlConnection ctx = new SqlConnection("data source=DESKTOP-LU5VIM4\\MSSQLSERVER1;initial catalog=DBWebFormsCRUD;integrated security=True");

		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void btnSaveUser_Click(object sender, EventArgs e)
		{
			if (ctx.State == ConnectionState.Open)
			{
				ctx.Close();
			}
			else
			{
				if (txtUserName.Text == "" || txtPassword.Text == "")
				{
					lblDurum.Text = "Kullanıcı adı ve şifre boş olamaz!";
				}
				else
				{
					ctx.Open();
					SHA1 sha = new SHA1CryptoServiceProvider();
					string hashpassword = Convert.ToBase64String(sha.ComputeHash(Encoding.UTF8.GetBytes(txtPassword.Text)));

					SqlCommand cmd = new SqlCommand("INSERT INTO TBLUser (UserName,Password) VALUES (@username,@password)", ctx);
					cmd.Parameters.AddWithValue("@username", txtUserName.Text);
					cmd.Parameters.AddWithValue("@password", hashpassword);
					SqlDataReader dr = cmd.ExecuteReader();
					Response.Redirect("Login.aspx");
					ctx.Close();
				}
			}
		}
	}
}
