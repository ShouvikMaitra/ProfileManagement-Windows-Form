﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProfileManagement
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			PopulateCountryCodes();
			PopulateCityDropdown();
			tb_username.TextChanged += tb_username_TextChanged;
			tb_confirmpassword.TextChanged += tb_confirmpassword_TextChanged;
		}
		private void PopulateCityDropdown()
		{
		
			var cities = new List<string>
	{
		"Mumbai",
		"Delhi",
		"Bangalore",
		"Hyderabad",
		"Chennai",
		"Kolkata",
		"Pune",
		"Ahmedabad",
		"Jaipur",
		"Surat",
		"Lucknow",
		"Kanpur",
		"Nagpur",
		"Indore",
		"Bhopal",
		"Vadodara",
		"Coimbatore",
		"Patna",
		"Agra",
		"Vijayawada",
		"Visakhapatnam"
      
    };

			cb_city.DataSource = cities;
			cb_city.DropDownStyle = ComboBoxStyle.DropDown; // Allow user input
		}


		private void btn_register_Click(object sender, EventArgs e)
		{
			
			if (!ValidateForm())
			{
				return;
			}

			string firstName = tb_FirstName.Text;
			string middleName = tb_MiddleName.Text;
			string lastName = tb_LastName.Text;
			string phoneNumber = cb_numbercode.SelectedItem.ToString() + tb_MobileNo.Text;
			string email = tb_email.Text;
			string address = rb_Address.Text;
			string city = cb_city.Text;
			DateTime dob = guna2DateTimePicker1.Value;
			string gender = gb_gender.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;
			string education = string.Join(", ", gb_education.Controls.OfType<CheckBox>().Where(c => c.Checked).Select(c => c.Text));
			string username = tb_username.Text;
			string password = tb_password.Text;

			string query = "INSERT INTO Users (FirstName, MiddleName, LastName, PhoneNumber, Email, Address, City, DOB, Gender, Education, UserName, Password) " +
						   "VALUES (@FirstName, @MiddleName, @LastName, @PhoneNumber, @Email, @Address, @City, @DOB, @Gender, @Education, @UserName, @Password)";

			SqlParameter[] parameters = new SqlParameter[]
			{
		new SqlParameter("@FirstName", firstName),
		new SqlParameter("@MiddleName", middleName),
		new SqlParameter("@LastName", lastName),
		new SqlParameter("@PhoneNumber", phoneNumber),
		new SqlParameter("@Email", email),
		new SqlParameter("@Address", address),
		new SqlParameter("@City", city),
		new SqlParameter("@DOB", dob),
		new SqlParameter("@Gender", gender),
		new SqlParameter("@Education", education),
		new SqlParameter("@UserName", username),
		new SqlParameter("@Password", password)
			};

			try
			{
				DatabaseHelper.ExecuteQuery(query, parameters);
				MessageBox.Show("User registered successfully!");

			
				LoginForm loginForm = new LoginForm();

			
				loginForm.FormClosed += (s, args) =>
				{
					this.Show();
					this.BringToFront();
					this.Focus();
				};

			
				this.Hide();
				loginForm.Show();
			}
			catch (Exception ex)
			{
				MessageBox.Show("An error occurred while registering the user: " + ex.Message);
			}
		}





		private bool ValidateForm()
		{
		
			if (string.IsNullOrWhiteSpace(tb_FirstName.Text) ||
				string.IsNullOrWhiteSpace(tb_LastName.Text) ||
				string.IsNullOrWhiteSpace(tb_MobileNo.Text) ||
				string.IsNullOrWhiteSpace(tb_email.Text) ||
				string.IsNullOrWhiteSpace(rb_Address.Text) ||
				string.IsNullOrWhiteSpace(tb_username.Text) ||
				string.IsNullOrWhiteSpace(tb_password.Text) ||
				string.IsNullOrWhiteSpace(tb_confirmpassword.Text) ||
				guna2DateTimePicker1.Value == null ||
				!IsEmailValid(tb_email.Text) ||
				tb_password.Text != tb_confirmpassword.Text)
			{
				MessageBox.Show("Please fill all required fields correctly and ensure passwords match.");
				return false;
			}

			
			if (!IsUserNameUnique(tb_username.Text))
			{
				MessageBox.Show("Username already exists. Please try another.");
				return false;
			}

			return true;
		}


		private bool IsEmailValid(string email)
		{
			try
			{
				var addr = new System.Net.Mail.MailAddress(email);
				return addr.Address == email;
			}
			catch
			{
				return false;
			}
		}

		private bool IsUserNameUnique(string userName)
		{
			string query = "SELECT COUNT(*) FROM Users WHERE UserName = @UserName";
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@UserName", userName)
			};

			DataTable dt = DatabaseHelper.GetDataTable(query, parameters);
			return dt.Rows[0][0].ToString() == "0";
		}

		private string GetSelectedGender()
		{
			if (rbtn_male.Checked)
				return "Male";
			if (rbtn_female.Checked)
				return "Female";
			return "Other";
		}

		private string GetSelectedEducation()
		{
			string education = string.Empty;

			if (checkBox_10th.Checked)
				education += "10th,";
			if (checkBox_12th.Checked)
				education += "12th,";
			if (checkBox_bachelor.Checked)
				education += "Bachelor,";
			if (checkBox_masters.Checked)
				education += "Masters,";

			return education.TrimEnd(',');
		}


				private void PopulateCountryCodes()
				{
					var countryCodes = new List<string>
								  {
									  "+1",    // USA
			                          "+44",   // UK
			                          "+91",   // India
			                        
			                      };

					cb_numbercode.DataSource = countryCodes;
					cb_numbercode.DropDownStyle = ComboBoxStyle.DropDownList;
				}


		private async void tb_username_TextChanged(object sender, EventArgs e)
		{
			// Run the check asynchronously
			await Task.Run(() => CheckUserNameAvailability(tb_username.Text));
		}
		private void CheckUserNameAvailability(string username)
		{
			if (string.IsNullOrWhiteSpace(username))
			{
				// Clear status if the username is empty
				UpdateUserNameStatus(string.Empty, false);
				return;
			}

			// Check for username availability
			bool isUnique = IsUserNameUnique(username);

			// Update the UI thread
			this.Invoke(new Action(() => UpdateUserNameStatus(username, isUnique)));
		}
		private void UpdateUserNameStatus(string username, bool isUnique)
		{
			if (isUnique)
			{
				lbl_usernameStatus.Text = "Username available";
				lbl_usernameStatus.ForeColor = System.Drawing.Color.Green;
			}
			else
			{
				lbl_usernameStatus.Text = "Username already taken";
				lbl_usernameStatus.ForeColor = System.Drawing.Color.Red;
			}
		}

		private void tb_confirmpassword_TextChanged(object sender, EventArgs e)
		{
			CheckPasswordMatch();
		}
		private void CheckPasswordMatch()
		{
			if (tb_password.Text != tb_confirmpassword.Text)
			{
				lbl_passwordStatus.Text = "Passwords do not match";
				lbl_passwordStatus.ForeColor = System.Drawing.Color.Red;
			}
			else
			{
				lbl_passwordStatus.Text = "Passwords match";
				lbl_passwordStatus.ForeColor = System.Drawing.Color.Green;
			}
		}

		private void linkLabel_login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			// Instantiate the LoginForm
			LoginForm loginForm = new LoginForm();

		
			loginForm.FormClosed += (s, args) =>
			{
				
				this.Show();
				this.BringToFront(); 
				this.Focus();        // Set focus back to the RegisterForm
			};

			this.Hide(); // Hide the registration form
			loginForm.Show(); // Show the LoginForm
		}


	}

}
