namespace BowValleyCinemaRoom
{
    partial class AddMovie
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
            btnRegisterMovie = new Button();
            textCopiesInStore = new TextBox();
            labelTotalCopies = new Label();
            textYear = new TextBox();
            labelYear = new Label();
            labelCategory = new Label();
            textDescription = new TextBox();
            labelDescription = new Label();
            textTitle = new TextBox();
            labelTitle = new Label();
            comboBoxCategory = new ComboBox();
            textPrice = new TextBox();
            labelPrice = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnRegisterMovie
            // 
            btnRegisterMovie.BackColor = SystemColors.GradientActiveCaption;
            btnRegisterMovie.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegisterMovie.Location = new Point(204, 519);
            btnRegisterMovie.Margin = new Padding(3, 4, 3, 4);
            btnRegisterMovie.Name = "btnRegisterMovie";
            btnRegisterMovie.Size = new Size(182, 46);
            btnRegisterMovie.TabIndex = 61;
            btnRegisterMovie.Text = "Add Movie";
            btnRegisterMovie.UseVisualStyleBackColor = false;
            btnRegisterMovie.Click += btnRegisterMovie_Click;
            // 
            // textCopiesInStore
            // 
            textCopiesInStore.Location = new Point(167, 400);
            textCopiesInStore.Margin = new Padding(3, 4, 3, 4);
            textCopiesInStore.Name = "textCopiesInStore";
            textCopiesInStore.Size = new Size(219, 26);
            textCopiesInStore.TabIndex = 60;
            // 
            // labelTotalCopies
            // 
            labelTotalCopies.AutoSize = true;
            labelTotalCopies.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelTotalCopies.Location = new Point(25, 404);
            labelTotalCopies.Name = "labelTotalCopies";
            labelTotalCopies.Size = new Size(117, 20);
            labelTotalCopies.TabIndex = 59;
            labelTotalCopies.Text = "Copies in Store";
            // 
            // textYear
            // 
            textYear.Location = new Point(167, 346);
            textYear.Margin = new Padding(3, 4, 3, 4);
            textYear.Name = "textYear";
            textYear.Size = new Size(219, 26);
            textYear.TabIndex = 58;
            // 
            // labelYear
            // 
            labelYear.AutoSize = true;
            labelYear.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelYear.Location = new Point(106, 349);
            labelYear.Name = "labelYear";
            labelYear.Size = new Size(41, 20);
            labelYear.TabIndex = 57;
            labelYear.Text = "Year";
            // 
            // labelCategory
            // 
            labelCategory.AutoSize = true;
            labelCategory.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelCategory.Location = new Point(66, 292);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(79, 20);
            labelCategory.TabIndex = 55;
            labelCategory.Text = "Category";
            // 
            // textDescription
            // 
            textDescription.Location = new Point(167, 123);
            textDescription.Margin = new Padding(3, 4, 3, 4);
            textDescription.Multiline = true;
            textDescription.Name = "textDescription";
            textDescription.Size = new Size(219, 139);
            textDescription.TabIndex = 51;
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelDescription.Location = new Point(52, 126);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(91, 20);
            labelDescription.TabIndex = 50;
            labelDescription.Text = "Description";
            // 
            // textTitle
            // 
            textTitle.Location = new Point(167, 66);
            textTitle.Margin = new Padding(3, 4, 3, 4);
            textTitle.Name = "textTitle";
            textTitle.Size = new Size(219, 26);
            textTitle.TabIndex = 49;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitle.Location = new Point(111, 69);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(35, 20);
            labelTitle.TabIndex = 48;
            labelTitle.Text = "Title";
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Items.AddRange(new object[] { "Action", "Comedy", "Drama", "Fantasy", "Horror", "Mystery", "Romance", "Thriller", "Western" });
            comboBoxCategory.Location = new Point(167, 288);
            comboBoxCategory.Margin = new Padding(3, 4, 3, 4);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(219, 28);
            comboBoxCategory.TabIndex = 62;
            // 
            // textPrice
            // 
            textPrice.Location = new Point(167, 458);
            textPrice.Margin = new Padding(3, 4, 3, 4);
            textPrice.Name = "textPrice";
            textPrice.Size = new Size(219, 26);
            textPrice.TabIndex = 64;
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelPrice.Location = new Point(101, 461);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(46, 20);
            labelPrice.TabIndex = 63;
            labelPrice.Text = "Price";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(25, 20);
            label1.Name = "label1";
            label1.Size = new Size(136, 23);
            label1.TabIndex = 65;
            label1.Text = "Add a Movie";
            // 
            // AddMovie
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(458, 593);
            Controls.Add(label1);
            Controls.Add(textPrice);
            Controls.Add(labelPrice);
            Controls.Add(comboBoxCategory);
            Controls.Add(btnRegisterMovie);
            Controls.Add(textCopiesInStore);
            Controls.Add(labelTotalCopies);
            Controls.Add(textYear);
            Controls.Add(labelYear);
            Controls.Add(labelCategory);
            Controls.Add(textDescription);
            Controls.Add(labelDescription);
            Controls.Add(textTitle);
            Controls.Add(labelTitle);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddMovie";
            Text = "AddMovie";
            Load += AddMovie_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegisterMovie;
        private TextBox textCopiesInStore;
        private Label labelTotalCopies;
        private TextBox textYear;
        private Label labelYear;
        private Label labelCategory;
        private TextBox textDescription;
        private Label labelDescription;
        private TextBox textTitle;
        private Label labelTitle;
        private ComboBox comboBoxCategory;
        private TextBox textPrice;
        private Label labelPrice;
        private Label label1;
    }
}