namespace BowValleyCinemaRoom
{
    partial class Admin
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
            menuStrip1 = new MenuStrip();
            moviesToolStripMenuItem = new ToolStripMenuItem();
            createMovieToolStripMenuItem = new ToolStripMenuItem();
            seeMoviesToolStripMenuItem = new ToolStripMenuItem();
            usersToolStripMenuItem = new ToolStripMenuItem();
            openScreenAddNewAdmin = new ToolStripMenuItem();
            seeUserRegistersToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { moviesToolStripMenuItem, usersToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 3, 0, 3);
            menuStrip1.Size = new Size(758, 30);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // moviesToolStripMenuItem
            // 
            moviesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { createMovieToolStripMenuItem, seeMoviesToolStripMenuItem });
            moviesToolStripMenuItem.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            moviesToolStripMenuItem.Name = "moviesToolStripMenuItem";
            moviesToolStripMenuItem.Size = new Size(77, 24);
            moviesToolStripMenuItem.Text = "Movies";
            moviesToolStripMenuItem.Click += moviesToolStripMenuItem_Click;
            // 
            // createMovieToolStripMenuItem
            // 
            createMovieToolStripMenuItem.Name = "createMovieToolStripMenuItem";
            createMovieToolStripMenuItem.Size = new Size(224, 26);
            createMovieToolStripMenuItem.Text = "Add New Movie";
            createMovieToolStripMenuItem.Click += createMovieToolStripMenuItem_Click;
            // 
            // seeMoviesToolStripMenuItem
            // 
            seeMoviesToolStripMenuItem.Name = "seeMoviesToolStripMenuItem";
            seeMoviesToolStripMenuItem.Size = new Size(224, 26);
            seeMoviesToolStripMenuItem.Text = "See Movies";
            seeMoviesToolStripMenuItem.Click += seeMoviesToolStripMenuItem_Click;
            // 
            // usersToolStripMenuItem
            // 
            usersToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openScreenAddNewAdmin, seeUserRegistersToolStripMenuItem });
            usersToolStripMenuItem.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            usersToolStripMenuItem.Size = new Size(61, 24);
            usersToolStripMenuItem.Text = "Users";
            // 
            // openScreenAddNewAdmin
            // 
            openScreenAddNewAdmin.Name = "openScreenAddNewAdmin";
            openScreenAddNewAdmin.Size = new Size(224, 26);
            openScreenAddNewAdmin.Text = "Add New Admin";
            openScreenAddNewAdmin.Click += openScreenAddNewAdmin_Click;
            // 
            // seeUserRegistersToolStripMenuItem
            // 
            seeUserRegistersToolStripMenuItem.Name = "seeUserRegistersToolStripMenuItem";
            seeUserRegistersToolStripMenuItem.Size = new Size(224, 26);
            seeUserRegistersToolStripMenuItem.Text = "See User Registers";
            seeUserRegistersToolStripMenuItem.Click += seeUserRegistersToolStripMenuItem_Click;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(758, 468);
            Controls.Add(menuStrip1);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Admin";
            Text = "BowValleyCinemaRoom - Admin";
            WindowState = FormWindowState.Maximized;
            Load += Admin_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem moviesToolStripMenuItem;
        private ToolStripMenuItem createMovieToolStripMenuItem;
        private ToolStripMenuItem seeMoviesToolStripMenuItem;
        private ToolStripMenuItem usersToolStripMenuItem;
        private ToolStripMenuItem openScreenAddNewAdmin;
        private ToolStripMenuItem seeUserRegistersToolStripMenuItem;
    }
}