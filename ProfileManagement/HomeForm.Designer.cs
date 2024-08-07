namespace ProfileManagement
{
    partial class HomeForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.lbl_gender = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_dob = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_education = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_city = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_address = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_phone = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_email = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_lastName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_middleName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_firstName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_welcome = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_usernameStatus = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btn_addUser = new Guna.UI2.WinForms.Guna2Button();
            this.btn_updateUser = new Guna.UI2.WinForms.Guna2Button();
            this.btn_deleteUser = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.White;
            this.guna2Panel2.Controls.Add(this.lbl_gender);
            this.guna2Panel2.Controls.Add(this.lbl_dob);
            this.guna2Panel2.Controls.Add(this.lbl_education);
            this.guna2Panel2.Controls.Add(this.lbl_city);
            this.guna2Panel2.Controls.Add(this.lbl_address);
            this.guna2Panel2.Controls.Add(this.lbl_phone);
            this.guna2Panel2.Controls.Add(this.lbl_email);
            this.guna2Panel2.Controls.Add(this.lbl_lastName);
            this.guna2Panel2.Controls.Add(this.lbl_middleName);
            this.guna2Panel2.Controls.Add(this.lbl_firstName);
            this.guna2Panel2.Controls.Add(this.btn_deleteUser);
            this.guna2Panel2.Controls.Add(this.btn_updateUser);
            this.guna2Panel2.Controls.Add(this.btn_addUser);
            this.guna2Panel2.Controls.Add(this.lbl_usernameStatus);
            this.guna2Panel2.Controls.Add(this.lbl_welcome);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(999, 597);
            this.guna2Panel2.TabIndex = 1;
            // 
            // lbl_gender
            // 
            this.lbl_gender.BackColor = System.Drawing.Color.Transparent;
            this.lbl_gender.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbl_gender.Location = new System.Drawing.Point(30, 470);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(3, 2);
            this.lbl_gender.TabIndex = 48;
            // 
            // lbl_dob
            // 
            this.lbl_dob.BackColor = System.Drawing.Color.Transparent;
            this.lbl_dob.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbl_dob.Location = new System.Drawing.Point(30, 430);
            this.lbl_dob.Name = "lbl_dob";
            this.lbl_dob.Size = new System.Drawing.Size(3, 2);
            this.lbl_dob.TabIndex = 47;
            // 
            // lbl_education
            // 
            this.lbl_education.BackColor = System.Drawing.Color.Transparent;
            this.lbl_education.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbl_education.Location = new System.Drawing.Point(30, 390);
            this.lbl_education.Name = "lbl_education";
            this.lbl_education.Size = new System.Drawing.Size(3, 2);
            this.lbl_education.TabIndex = 46;
            // 
            // lbl_city
            // 
            this.lbl_city.BackColor = System.Drawing.Color.Transparent;
            this.lbl_city.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbl_city.Location = new System.Drawing.Point(30, 350);
            this.lbl_city.Name = "lbl_city";
            this.lbl_city.Size = new System.Drawing.Size(3, 2);
            this.lbl_city.TabIndex = 45;
            // 
            // lbl_address
            // 
            this.lbl_address.BackColor = System.Drawing.Color.Transparent;
            this.lbl_address.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbl_address.Location = new System.Drawing.Point(30, 310);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(3, 2);
            this.lbl_address.TabIndex = 44;
            // 
            // lbl_phone
            // 
            this.lbl_phone.BackColor = System.Drawing.Color.Transparent;
            this.lbl_phone.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbl_phone.Location = new System.Drawing.Point(30, 270);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(3, 2);
            this.lbl_phone.TabIndex = 43;
            // 
            // lbl_email
            // 
            this.lbl_email.BackColor = System.Drawing.Color.Transparent;
            this.lbl_email.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbl_email.Location = new System.Drawing.Point(30, 230);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(3, 2);
            this.lbl_email.TabIndex = 42;
            // 
            // lbl_lastName
            // 
            this.lbl_lastName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_lastName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbl_lastName.Location = new System.Drawing.Point(30, 190);
            this.lbl_lastName.Name = "lbl_lastName";
            this.lbl_lastName.Size = new System.Drawing.Size(3, 2);
            this.lbl_lastName.TabIndex = 41;
            // 
            // lbl_middleName
            // 
            this.lbl_middleName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_middleName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbl_middleName.Location = new System.Drawing.Point(30, 150);
            this.lbl_middleName.Name = "lbl_middleName";
            this.lbl_middleName.Size = new System.Drawing.Size(3, 2);
            this.lbl_middleName.TabIndex = 40;
            // 
            // lbl_firstName
            // 
            this.lbl_firstName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_firstName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbl_firstName.Location = new System.Drawing.Point(30, 110);
            this.lbl_firstName.Name = "lbl_firstName";
            this.lbl_firstName.Size = new System.Drawing.Size(3, 2);
            this.lbl_firstName.TabIndex = 39;
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.BackColor = System.Drawing.Color.Transparent;
            this.lbl_welcome.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome.ForeColor = System.Drawing.Color.Black;
            this.lbl_welcome.Location = new System.Drawing.Point(334, 30);
            this.lbl_welcome.Margin = new System.Windows.Forms.Padding(4);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(3, 2);
            this.lbl_welcome.TabIndex = 2;
            // 
            // lbl_usernameStatus
            // 
            this.lbl_usernameStatus.BackColor = System.Drawing.Color.Transparent;
            this.lbl_usernameStatus.Location = new System.Drawing.Point(29, 485);
            this.lbl_usernameStatus.Name = "lbl_usernameStatus";
            this.lbl_usernameStatus.Size = new System.Drawing.Size(3, 2);
            this.lbl_usernameStatus.TabIndex = 31;
            this.lbl_usernameStatus.Text = null;
            // 
            // btn_addUser
            // 
            this.btn_addUser.Location = new System.Drawing.Point(30, 530);
            this.btn_addUser.Name = "btn_addUser";
            this.btn_addUser.Size = new System.Drawing.Size(75, 23);
            this.btn_addUser.TabIndex = 49;
            this.btn_addUser.Text = "Add User";
            this.btn_addUser.Click += new System.EventHandler(this.btn_addUser_Click);
            // 
            // btn_updateUser
            // 
            this.btn_updateUser.Location = new System.Drawing.Point(120, 530);
            this.btn_updateUser.Name = "btn_updateUser";
            this.btn_updateUser.Size = new System.Drawing.Size(75, 23);
            this.btn_updateUser.TabIndex = 50;
            this.btn_updateUser.Text = "Update User";
            this.btn_updateUser.Click += new System.EventHandler(this.btn_updateUser_Click);
            // 
            // btn_deleteUser
            // 
            this.btn_deleteUser.Location = new System.Drawing.Point(210, 530);
            this.btn_deleteUser.Name = "btn_deleteUser";
            this.btn_deleteUser.Size = new System.Drawing.Size(75, 23);
            this.btn_deleteUser.TabIndex = 51;
            this.btn_deleteUser.Text = "Delete User";
            this.btn_deleteUser.Click += new System.EventHandler(this.btn_deleteUser_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 597);
            this.Controls.Add(this.guna2Panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeForm";
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.ResumeLayout(false);
        }

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_firstName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_middleName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_lastName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_email;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_phone;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_address;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_city;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_education;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_dob;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_gender;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_welcome;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_usernameStatus;
        private Guna.UI2.WinForms.Guna2Button btn_addUser;
        private Guna.UI2.WinForms.Guna2Button btn_updateUser;
        private Guna.UI2.WinForms.Guna2Button btn_deleteUser;
    }
}
