namespace BowValleyCinemaRoom
{
    partial class RegisterAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            comboYear = new ComboBox();
            comboDay = new ComboBox();
            comboMonth = new ComboBox();
            btnRegisterAdmin = new Button();
            textConfirmPassword = new TextBox();
            labelConfirmPassword = new Label();
            textPassword = new TextBox();
            labelPassword = new Label();
            textEmail = new TextBox();
            labelEmail = new Label();
            textPhone = new TextBox();
            labelPhone = new Label();
            labelBirthday = new Label();
            textAddress = new TextBox();
            labelAddress = new Label();
            textLastName = new TextBox();
            labelLastName = new Label();
            textFirstName = new TextBox();
            labelFirstName = new Label();
            lbl_titleNewAdmin = new Label();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(387, 232);
            label4.Name = "label4";
            label4.Size = new Size(35, 19);
            label4.TabIndex = 45;
            label4.Text = "Year";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(310, 232);
            label3.Name = "label3";
            label3.Size = new Size(33, 19);
            label3.TabIndex = 44;
            label3.Text = "Day";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(233, 232);
            label2.Name = "label2";
            label2.Size = new Size(51, 19);
            label2.TabIndex = 43;
            label2.Text = "Month";
            // 
            // comboYear
            // 
            comboYear.FormattingEnabled = true;
            comboYear.Items.AddRange(new object[] { "1950", "1951", "1952", "1953", "1954", "1955", "1956", "1957", "1958", "1959", "1960", "1961", "1962", "1963", "1964", "1965", "1966", "1967", "1968", "1969", "1970", "1971", "1972", "1973", "1974", "1975", "1976", "1977", "1978", "1979", "1980", "1981", "1982", "1983", "1984", "1985", "1986", "1987", "1988", "1989", "1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023" });
            comboYear.Location = new Point(385, 255);
            comboYear.Margin = new Padding(3, 4, 3, 4);
            comboYear.Name = "comboYear";
            comboYear.Size = new Size(67, 28);
            comboYear.TabIndex = 42;
            // 
            // comboDay
            // 
            comboDay.FormattingEnabled = true;
            comboDay.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31" });
            comboDay.Location = new Point(308, 255);
            comboDay.Margin = new Padding(3, 4, 3, 4);
            comboDay.Name = "comboDay";
            comboDay.Size = new Size(67, 28);
            comboDay.TabIndex = 41;
            // 
            // comboMonth
            // 
            comboMonth.FormattingEnabled = true;
            comboMonth.Items.AddRange(new object[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
            comboMonth.Location = new Point(233, 255);
            comboMonth.Margin = new Padding(3, 4, 3, 4);
            comboMonth.Name = "comboMonth";
            comboMonth.Size = new Size(67, 28);
            comboMonth.TabIndex = 40;
            // 
            // btnRegisterAdmin
            // 
            btnRegisterAdmin.BackColor = SystemColors.GradientActiveCaption;
            btnRegisterAdmin.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegisterAdmin.Location = new Point(299, 537);
            btnRegisterAdmin.Margin = new Padding(3, 4, 3, 4);
            btnRegisterAdmin.Name = "btnRegisterAdmin";
            btnRegisterAdmin.Size = new Size(153, 42);
            btnRegisterAdmin.TabIndex = 39;
            btnRegisterAdmin.Text = "Register";
            btnRegisterAdmin.UseVisualStyleBackColor = false;
            btnRegisterAdmin.Click += btnRegisterAdmin_Click;
            // 
            // textConfirmPassword
            // 
            textConfirmPassword.Location = new Point(233, 475);
            textConfirmPassword.Margin = new Padding(3, 4, 3, 4);
            textConfirmPassword.Name = "textConfirmPassword";
            textConfirmPassword.PasswordChar = '*';
            textConfirmPassword.Size = new Size(219, 26);
            textConfirmPassword.TabIndex = 38;
            // 
            // labelConfirmPassword
            // 
            labelConfirmPassword.AutoSize = true;
            labelConfirmPassword.Location = new Point(87, 478);
            labelConfirmPassword.Name = "labelConfirmPassword";
            labelConfirmPassword.Size = new Size(140, 20);
            labelConfirmPassword.TabIndex = 37;
            labelConfirmPassword.Text = "Confirm Password";
            // 
            // textPassword
            // 
            textPassword.Location = new Point(233, 421);
            textPassword.Margin = new Padding(3, 4, 3, 4);
            textPassword.Name = "textPassword";
            textPassword.PasswordChar = '*';
            textPassword.Size = new Size(219, 26);
            textPassword.TabIndex = 36;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(148, 424);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(79, 20);
            labelPassword.TabIndex = 35;
            labelPassword.Text = "Password";
            // 
            // textEmail
            // 
            textEmail.Location = new Point(233, 367);
            textEmail.Margin = new Padding(3, 4, 3, 4);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(219, 26);
            textEmail.TabIndex = 34;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(181, 370);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(46, 20);
            labelEmail.TabIndex = 33;
            labelEmail.Text = "Email";
            // 
            // textPhone
            // 
            textPhone.Location = new Point(233, 313);
            textPhone.Margin = new Padding(3, 4, 3, 4);
            textPhone.Name = "textPhone";
            textPhone.Size = new Size(219, 26);
            textPhone.TabIndex = 32;
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(171, 319);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(56, 20);
            labelPhone.TabIndex = 31;
            labelPhone.Text = "Phone";
            // 
            // labelBirthday
            // 
            labelBirthday.AutoSize = true;
            labelBirthday.Location = new Point(159, 258);
            labelBirthday.Name = "labelBirthday";
            labelBirthday.Size = new Size(68, 20);
            labelBirthday.TabIndex = 30;
            labelBirthday.Text = "Birthday";
            // 
            // textAddress
            // 
            textAddress.Location = new Point(233, 198);
            textAddress.Margin = new Padding(3, 4, 3, 4);
            textAddress.Name = "textAddress";
            textAddress.Size = new Size(219, 26);
            textAddress.TabIndex = 29;
            textAddress.TextChanged += textAddress_TextChanged;
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Location = new Point(160, 201);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(67, 20);
            labelAddress.TabIndex = 28;
            labelAddress.Text = "Address";
            // 
            // textLastName
            // 
            textLastName.Location = new Point(233, 141);
            textLastName.Margin = new Padding(3, 4, 3, 4);
            textLastName.Name = "textLastName";
            textLastName.Size = new Size(219, 26);
            textLastName.TabIndex = 27;
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Location = new Point(142, 144);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(85, 20);
            labelLastName.TabIndex = 26;
            labelLastName.Text = "Last Name";
            // 
            // textFirstName
            // 
            textFirstName.Location = new Point(233, 86);
            textFirstName.Margin = new Padding(3, 4, 3, 4);
            textFirstName.Name = "textFirstName";
            textFirstName.Size = new Size(219, 26);
            textFirstName.TabIndex = 25;
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Location = new Point(144, 86);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(83, 20);
            labelFirstName.TabIndex = 24;
            labelFirstName.Text = "First Name";
            // 
            // lbl_titleNewAdmin
            // 
            lbl_titleNewAdmin.AutoSize = true;
            lbl_titleNewAdmin.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_titleNewAdmin.Location = new Point(32, 30);
            lbl_titleNewAdmin.Name = "lbl_titleNewAdmin";
            lbl_titleNewAdmin.Size = new Size(243, 23);
            lbl_titleNewAdmin.TabIndex = 46;
            lbl_titleNewAdmin.Text = "New Admin Registration";
            // 
            // RegisterAdmin
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(574, 600);
            Controls.Add(lbl_titleNewAdmin);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboYear);
            Controls.Add(comboDay);
            Controls.Add(comboMonth);
            Controls.Add(btnRegisterAdmin);
            Controls.Add(textConfirmPassword);
            Controls.Add(labelConfirmPassword);
            Controls.Add(textPassword);
            Controls.Add(labelPassword);
            Controls.Add(textEmail);
            Controls.Add(labelEmail);
            Controls.Add(textPhone);
            Controls.Add(labelPhone);
            Controls.Add(labelBirthday);
            Controls.Add(textAddress);
            Controls.Add(labelAddress);
            Controls.Add(textLastName);
            Controls.Add(labelLastName);
            Controls.Add(textFirstName);
            Controls.Add(labelFirstName);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "RegisterAdmin";
            Text = "Add new admin";
            Load += RegisterAdmin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox comboYear;
        private ComboBox comboDay;
        private ComboBox comboMonth;
        private Button btnRegisterAdmin;
        private TextBox textConfirmPassword;
        private Label labelConfirmPassword;
        private TextBox textPassword;
        private Label labelPassword;
        private TextBox textEmail;
        private Label labelEmail;
        private TextBox textPhone;
        private Label labelPhone;
        private Label labelBirthday;
        private TextBox textAddress;
        private Label labelAddress;
        private TextBox textLastName;
        private Label labelLastName;
        private TextBox textFirstName;
        private Label labelFirstName;
        private Label lbl_titleNewAdmin;
    }
}