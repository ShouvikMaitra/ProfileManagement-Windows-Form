using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace ProfileManagement
{
    public partial class HomeForm : Form
    {
        private string currentUsername;

        public HomeForm(string username)
        {
            InitializeComponent();
            currentUsername = username;
            LoadUserDetails(currentUsername);
        }

        private void LoadUserDetails(string username)
        {
            User user = GetUserDetails(username);
            if (user != null)
            {
                lbl_firstName.Text = $"First Name: {user.FirstName}";
                lbl_middleName.Text = $"Middle Name: {user.MiddleName}";
                lbl_lastName.Text = $"Last Name: {user.LastName}";
                lbl_phone.Text = $"Phone Number: {user.PhoneNumber}";
                lbl_email.Text = $"Email: {user.Email}";
                lbl_address.Text = $"Address: {user.Address}";
                lbl_city.Text = $"City: {user.City}";
                lbl_dob.Text = $"Date of Birth: {user.DOB.ToShortDateString()}";
                lbl_gender.Text = $"Gender: {user.Gender}";
                lbl_education.Text = $"Education: {user.Education}";
            }
        }

        private User GetUserDetails(string username)
        {
            string query = "SELECT * FROM Users WHERE UserName = @Username";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Username", username)
            };

            DataTable dataTable = DatabaseHelper.GetDataTable(query, parameters);
            if (dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];
                return new User
                {
                    FirstName = row["FirstName"].ToString(),
                    MiddleName = row["MiddleName"].ToString(),
                    LastName = row["LastName"].ToString(),
                    PhoneNumber = row["PhoneNumber"].ToString(),
                    Email = row["Email"].ToString(),
                    Address = row["Address"].ToString(),
                    City = row["City"].ToString(),
                    DOB = Convert.ToDateTime(row["DOB"]),
                    Gender = row["Gender"].ToString(),
                    Education = row["Education"].ToString(),
                    UserName = row["UserName"].ToString()
                };
            }
            return null;
        }

        private void btn_addUser_Click(object sender, EventArgs e)
        {
            Form1 registrationForm = new Form1();
            registrationForm.Show();
        }

        private void btn_updateUser_Click(object sender, EventArgs e)
        {
            Form1 updateForm = new Form1();
            updateForm.Show();
        }

        private void btn_deleteUser_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete your account?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                DeleteUser(currentUsername);
            }
        }

        private void DeleteUser(string username)
        {
            string query = "DELETE FROM Users WHERE UserName = @Username";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Username", username)
            };

            DatabaseHelper.ExecuteQuery(query, parameters);
            MessageBox.Show("User account deleted.");
            Application.Exit(); // Close the application after deletion
        }
    }
}
