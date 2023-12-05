namespace BowValleyCinemaRoom
{
    partial class UpdateMovie
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
            textPrice = new TextBox();
            labelPrice = new Label();
            comboBoxCategory = new ComboBox();
            btnUpdateMovie = new Button();
            textCopiesInStore = new TextBox();
            labelTotalCopies = new Label();
            textYear = new TextBox();
            labelYear = new Label();
            labelCategory = new Label();
            textDescription = new TextBox();
            labelDescription = new Label();
            textTitle = new TextBox();
            labelTitle = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // textPrice
            // 
            textPrice.Location = new Point(209, 478);
            textPrice.Margin = new Padding(3, 4, 3, 4);
            textPrice.Name = "textPrice";
            textPrice.Size = new Size(219, 26);
            textPrice.TabIndex = 77;
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Location = new Point(141, 481);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(46, 20);
            labelPrice.TabIndex = 76;
            labelPrice.Text = "Price";
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Items.AddRange(new object[] { "Action", "Comedy", "Drama", "Fantasy", "Horror", "Mystery", "Romance", "Thriller", "Western" });
            comboBoxCategory.Location = new Point(209, 309);
            comboBoxCategory.Margin = new Padding(3, 4, 3, 4);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(219, 28);
            comboBoxCategory.TabIndex = 75;
            // 
            // btnUpdateMovie
            // 
            btnUpdateMovie.BackColor = SystemColors.GradientActiveCaption;
            btnUpdateMovie.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateMovie.Location = new Point(246, 540);
            btnUpdateMovie.Margin = new Padding(3, 4, 3, 4);
            btnUpdateMovie.Name = "btnUpdateMovie";
            btnUpdateMovie.Size = new Size(182, 46);
            btnUpdateMovie.TabIndex = 74;
            btnUpdateMovie.Text = "Update";
            btnUpdateMovie.UseVisualStyleBackColor = false;
            btnUpdateMovie.Click += btnUpdateMovie_Click;
            // 
            // textCopiesInStore
            // 
            textCopiesInStore.Location = new Point(209, 421);
            textCopiesInStore.Margin = new Padding(3, 4, 3, 4);
            textCopiesInStore.Name = "textCopiesInStore";
            textCopiesInStore.Size = new Size(219, 26);
            textCopiesInStore.TabIndex = 73;
            // 
            // labelTotalCopies
            // 
            labelTotalCopies.AutoSize = true;
            labelTotalCopies.Location = new Point(70, 424);
            labelTotalCopies.Name = "labelTotalCopies";
            labelTotalCopies.Size = new Size(117, 20);
            labelTotalCopies.TabIndex = 72;
            labelTotalCopies.Text = "Copies in Store";
            // 
            // textYear
            // 
            textYear.Location = new Point(209, 366);
            textYear.Margin = new Padding(3, 4, 3, 4);
            textYear.Name = "textYear";
            textYear.Size = new Size(219, 26);
            textYear.TabIndex = 71;
            // 
            // labelYear
            // 
            labelYear.AutoSize = true;
            labelYear.Location = new Point(146, 369);
            labelYear.Name = "labelYear";
            labelYear.Size = new Size(41, 20);
            labelYear.TabIndex = 70;
            labelYear.Text = "Year";
            // 
            // labelCategory
            // 
            labelCategory.AutoSize = true;
            labelCategory.Location = new Point(108, 312);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(79, 20);
            labelCategory.TabIndex = 69;
            labelCategory.Text = "Category";
            // 
            // textDescription
            // 
            textDescription.Location = new Point(209, 144);
            textDescription.Margin = new Padding(3, 4, 3, 4);
            textDescription.Multiline = true;
            textDescription.Name = "textDescription";
            textDescription.Size = new Size(219, 139);
            textDescription.TabIndex = 68;
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Location = new Point(96, 147);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(91, 20);
            labelDescription.TabIndex = 67;
            labelDescription.Text = "Description";
            // 
            // textTitle
            // 
            textTitle.Location = new Point(209, 86);
            textTitle.Margin = new Padding(3, 4, 3, 4);
            textTitle.Name = "textTitle";
            textTitle.Size = new Size(219, 26);
            textTitle.TabIndex = 66;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Location = new Point(152, 89);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(35, 20);
            labelTitle.TabIndex = 65;
            labelTitle.Text = "Title";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(28, 34);
            label1.Name = "label1";
            label1.Size = new Size(218, 23);
            label1.TabIndex = 78;
            label1.Text = "Update Movie Details";
            // 
            // UpdateMovie
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(520, 622);
            Controls.Add(label1);
            Controls.Add(textPrice);
            Controls.Add(labelPrice);
            Controls.Add(comboBoxCategory);
            Controls.Add(btnUpdateMovie);
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
            Name = "UpdateMovie";
            Text = "UpdateMovie";
            Load += UpdateMovie_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textPrice;
        private Label labelPrice;
        private ComboBox comboBoxCategory;
        private Button btnUpdateMovie;
        private TextBox textCopiesInStore;
        private Label labelTotalCopies;
        private TextBox textYear;
        private Label labelYear;
        private Label labelCategory;
        private TextBox textDescription;
        private Label labelDescription;
        private TextBox textTitle;
        private Label labelTitle;
        private Label label1;
    }
}