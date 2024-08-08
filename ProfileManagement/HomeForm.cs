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
			LoadUserDetails();
			SetWelcomeMessage();
		}
		private void SetWelcomeMessage()
		{
			lbl_welcome.Text = $"Welcome, {currentUsername}!";
		}
		private void LoadUserDetails()
		{
			User user = GetUserDetails(currentUsername);
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

				// Set text box values
				txt_firstName.Text = user.FirstName;
				txt_middleName.Text = user.MiddleName;
				txt_lastName.Text = user.LastName;
				txt_email.Text = user.Email;
				txt_phone.Text = user.PhoneNumber;
				txt_address.Text = user.Address;
				txt_city.Text = user.City;
				txt_education.Text = user.Education;
				txt_dob.Text = user.DOB.ToShortDateString();
				txt_gender.Text = user.Gender;
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
			// Validate inputs
			if (string.IsNullOrEmpty(txt_firstName.Text) ||
				string.IsNullOrEmpty(txt_lastName.Text) ||
				string.IsNullOrEmpty(txt_email.Text) ||
				string.IsNullOrEmpty(txt_phone.Text) ||
				string.IsNullOrEmpty(txt_address.Text) ||
				string.IsNullOrEmpty(txt_city.Text) ||
				string.IsNullOrEmpty(txt_education.Text) ||
				string.IsNullOrEmpty(txt_dob.Text) ||
				string.IsNullOrEmpty(txt_gender.Text))
			{
				MessageBox.Show("Please fill all fields.");
				return;
			}

			// Update user details
			bool success = UpdateUserDetails(
				txt_firstName.Text,
				txt_middleName.Text,
				txt_lastName.Text,
				txt_email.Text,
				txt_phone.Text,
				txt_address.Text,
				txt_city.Text,
				txt_education.Text,
				txt_dob.Text,
				txt_gender.Text
			);

			if (success)
			{
				MessageBox.Show("User details updated successfully.");
				LoadUserDetails(); // Refresh the user details after update
			}
			else
			{
				MessageBox.Show("Failed to update user details.");
			}
		}

		private bool UpdateUserDetails(string firstName, string middleName, string lastName, string email, string phone, string address, string city, string education, string dob, string gender)
		{
			try
			{
				string query = "UPDATE Users SET FirstName = @FirstName, MiddleName = @MiddleName, LastName = @LastName, Email = @Email, PhoneNumber = @PhoneNumber, Address = @Address, City = @City, Education = @Education, DOB = @DOB, Gender = @Gender WHERE UserName = @UserName";
				SqlParameter[] parameters = new SqlParameter[]
				{
			new SqlParameter("@FirstName", firstName),
			new SqlParameter("@MiddleName", middleName),
			new SqlParameter("@LastName", lastName),
			new SqlParameter("@Email", email),
			new SqlParameter("@PhoneNumber", phone),
			new SqlParameter("@Address", address),
			new SqlParameter("@City", city),
			new SqlParameter("@Education", education),
			new SqlParameter("@DOB", DateTime.Parse(dob)),
			new SqlParameter("@Gender", gender),
			new SqlParameter("@UserName", currentUsername)
				};

				DatabaseHelper.ExecuteQuery(query, parameters);

				// Assuming that if no exception is thrown, the update was successful
				return true;
			}
			catch (Exception ex)
			{
				// Log or handle the exception as needed
				MessageBox.Show($"Failed to update user details: {ex.Message}");
				return false;
			}
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
