using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.HtmlControls;
using System.Windows.Forms;

namespace ProfileManagement
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

       

        private bool ValidateUser(string username, string password)
        {
            string query = "SELECT COUNT(*) FROM Users WHERE UserName = @UserName AND Password = @Password";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@UserName", username),
                new SqlParameter("@Password", password)
            };

            DataTable dt = DatabaseHelper.GetDataTable(query, parameters);
            return dt.Rows[0][0].ToString() == "1";
        }

		private void linkLabel_Signup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			
			Form1 registrationForm = new Form1();

		
			registrationForm.FormClosed += (s, args) =>
			{
			
				this.Show();
				this.BringToFront(); 
				this.Focus();        // Set focus back to the LoginForm
			};

			this.Hide(); // Hide the login form
			registrationForm.Show(); // Show the registration form
		}


		private void btn_login_Click(object sender, EventArgs e)
		{
			string username = tb_username.Text;
			string password = tb_password.Text;

			if (ValidateUser(username, password))
			{
				MessageBox.Show("Login successful!");

				
				HomeForm homeForm = new HomeForm(username);

				homeForm.FormClosed += (s, args) =>
				{
					this.Show();
					this.BringToFront();
					this.Focus();
				};

				
				this.Hide();
				homeForm.Show();
			}
			else
			{
				MessageBox.Show("Invalid username or password.");
			}
		}


	}
}
