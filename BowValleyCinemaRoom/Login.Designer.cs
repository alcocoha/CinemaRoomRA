namespace BowValleyCinemaRoom
{
    partial class Login
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
            pictureBox1 = new PictureBox();
            labelEmail = new Label();
            labelPassword = new Label();
            textEmail = new TextBox();
            textPassword = new TextBox();
            btnLogin = new Button();
            labelDescription = new Label();
            linkRegister = new LinkLabel();
            lbl_nameYara = new Label();
            lbl_nameJorge = new Label();
            lbl_nameAbigail = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo_bowcinema;
            pictureBox1.Location = new Point(45, 66);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(353, 247);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelEmail.Location = new Point(505, 115);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(52, 21);
            labelEmail.TabIndex = 1;
            labelEmail.Text = "Email";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelPassword.Location = new Point(468, 171);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(88, 21);
            labelPassword.TabIndex = 2;
            labelPassword.Text = "Password";
            // 
            // textEmail
            // 
            textEmail.Location = new Point(570, 113);
            textEmail.Margin = new Padding(3, 4, 3, 4);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(192, 26);
            textEmail.TabIndex = 3;
            // 
            // textPassword
            // 
            textPassword.Location = new Point(569, 167);
            textPassword.Margin = new Padding(3, 4, 3, 4);
            textPassword.Name = "textPassword";
            textPassword.PasswordChar = '*';
            textPassword.Size = new Size(193, 26);
            textPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.GradientActiveCaption;
            btnLogin.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.Location = new Point(645, 217);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(118, 42);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelDescription.Location = new Point(372, 377);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(391, 21);
            labelDescription.TabIndex = 6;
            labelDescription.Text = "Final Project: Trio Triumph Movie Rental System";
            // 
            // linkRegister
            // 
            linkRegister.AutoSize = true;
            linkRegister.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            linkRegister.Location = new Point(678, 293);
            linkRegister.Name = "linkRegister";
            linkRegister.Size = new Size(75, 21);
            linkRegister.TabIndex = 7;
            linkRegister.TabStop = true;
            linkRegister.Text = "Register";
            linkRegister.LinkClicked += linkRegister_LinkClicked;
            // 
            // lbl_nameYara
            // 
            lbl_nameYara.AutoSize = true;
            lbl_nameYara.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_nameYara.Location = new Point(627, 410);
            lbl_nameYara.Name = "lbl_nameYara";
            lbl_nameYara.Size = new Size(136, 21);
            lbl_nameYara.TabIndex = 8;
            lbl_nameYara.Text = "Yara Pysmenko";
            // 
            // lbl_nameJorge
            // 
            lbl_nameJorge.AutoSize = true;
            lbl_nameJorge.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_nameJorge.Location = new Point(500, 443);
            lbl_nameJorge.Name = "lbl_nameJorge";
            lbl_nameJorge.Size = new Size(263, 21);
            lbl_nameJorge.TabIndex = 9;
            lbl_nameJorge.Text = "Jorge Alberto Hurtado Ortega";
            // 
            // lbl_nameAbigail
            // 
            lbl_nameAbigail.AutoSize = true;
            lbl_nameAbigail.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_nameAbigail.Location = new Point(655, 476);
            lbl_nameAbigail.Name = "lbl_nameAbigail";
            lbl_nameAbigail.Size = new Size(108, 21);
            lbl_nameAbigail.TabIndex = 10;
            lbl_nameAbigail.Text = "Abigail Cruz";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(813, 549);
            Controls.Add(lbl_nameAbigail);
            Controls.Add(lbl_nameJorge);
            Controls.Add(lbl_nameYara);
            Controls.Add(linkRegister);
            Controls.Add(labelDescription);
            Controls.Add(btnLogin);
            Controls.Add(textPassword);
            Controls.Add(textEmail);
            Controls.Add(labelPassword);
            Controls.Add(labelEmail);
            Controls.Add(pictureBox1);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label labelEmail;
        private Label labelPassword;
        private TextBox textEmail;
        private TextBox textPassword;
        private Button btnLogin;
        private Label labelDescription;
        private LinkLabel linkRegister;
        private Label lbl_nameYara;
        private Label lbl_nameJorge;
        private Label lbl_nameAbigail;
    }
}