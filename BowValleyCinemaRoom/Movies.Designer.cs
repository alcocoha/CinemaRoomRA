namespace BowValleyCinemaRoom
{
    partial class Movies
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
            dgMovies = new DataGridView();
            label1 = new Label();
            textMovie = new TextBox();
            btnSearchAMovie = new Button();
            listMovies = new ListBox();
            label2 = new Label();
            listPrices = new ListBox();
            button1 = new Button();
            labelTotalMovies = new Label();
            labelTotalPrice = new Label();
            btnRent = new Button();
            btnReset = new Button();
            ((System.ComponentModel.ISupportInitialize)dgMovies).BeginInit();
            SuspendLayout();
            // 
            // dgMovies
            // 
            dgMovies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgMovies.Location = new Point(14, 155);
            dgMovies.Margin = new Padding(3, 4, 3, 4);
            dgMovies.Name = "dgMovies";
            dgMovies.RowHeadersWidth = 51;
            dgMovies.RowTemplate.Height = 25;
            dgMovies.Size = new Size(526, 405);
            dgMovies.TabIndex = 0;
            dgMovies.CellClick += dataGridView1_CellContentClick;
            dgMovies.CellContentClick += dgMovies_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(14, 25);
            label1.Name = "label1";
            label1.Size = new Size(175, 23);
            label1.TabIndex = 1;
            label1.Text = "Movies Selection";
            // 
            // textMovie
            // 
            textMovie.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textMovie.Location = new Point(14, 96);
            textMovie.Margin = new Padding(3, 4, 3, 4);
            textMovie.Name = "textMovie";
            textMovie.Size = new Size(237, 26);
            textMovie.TabIndex = 2;
            // 
            // btnSearchAMovie
            // 
            btnSearchAMovie.BackColor = SystemColors.GradientActiveCaption;
            btnSearchAMovie.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearchAMovie.Location = new Point(262, 90);
            btnSearchAMovie.Margin = new Padding(3, 4, 3, 4);
            btnSearchAMovie.Name = "btnSearchAMovie";
            btnSearchAMovie.Size = new Size(132, 37);
            btnSearchAMovie.TabIndex = 3;
            btnSearchAMovie.Text = "Search";
            btnSearchAMovie.UseVisualStyleBackColor = false;
            btnSearchAMovie.Click += btnSearchAMovie_Click;
            // 
            // listMovies
            // 
            listMovies.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            listMovies.FormattingEnabled = true;
            listMovies.ItemHeight = 20;
            listMovies.Location = new Point(559, 155);
            listMovies.Margin = new Padding(3, 4, 3, 4);
            listMovies.Name = "listMovies";
            listMovies.Size = new Size(201, 224);
            listMovies.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(559, 119);
            label2.Name = "label2";
            label2.Size = new Size(134, 18);
            label2.TabIndex = 5;
            label2.Text = "Movies Selected:";
            // 
            // listPrices
            // 
            listPrices.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            listPrices.FormattingEnabled = true;
            listPrices.ItemHeight = 20;
            listPrices.Location = new Point(767, 155);
            listPrices.Margin = new Padding(3, 4, 3, 4);
            listPrices.Name = "listPrices";
            listPrices.Size = new Size(75, 224);
            listPrices.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(401, 90);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(87, 37);
            button1.TabIndex = 7;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // labelTotalMovies
            // 
            labelTotalMovies.AutoSize = true;
            labelTotalMovies.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelTotalMovies.Location = new Point(559, 396);
            labelTotalMovies.Name = "labelTotalMovies";
            labelTotalMovies.Size = new Size(114, 20);
            labelTotalMovies.TabIndex = 8;
            labelTotalMovies.Text = "Total movies: 0";
            // 
            // labelTotalPrice
            // 
            labelTotalPrice.AutoSize = true;
            labelTotalPrice.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelTotalPrice.Location = new Point(785, 396);
            labelTotalPrice.Name = "labelTotalPrice";
            labelTotalPrice.RightToLeft = RightToLeft.No;
            labelTotalPrice.Size = new Size(75, 20);
            labelTotalPrice.TabIndex = 9;
            labelTotalPrice.Text = "0.00 CAD";
            labelTotalPrice.TextAlign = ContentAlignment.TopRight;
            // 
            // btnRent
            // 
            btnRent.BackColor = SystemColors.GradientActiveCaption;
            btnRent.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRent.Location = new Point(559, 493);
            btnRent.Margin = new Padding(3, 4, 3, 4);
            btnRent.Name = "btnRent";
            btnRent.Size = new Size(283, 67);
            btnRent.TabIndex = 10;
            btnRent.Text = "Rent Movies";
            btnRent.UseVisualStyleBackColor = false;
            btnRent.Click += button2_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = SystemColors.GradientActiveCaption;
            btnReset.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnReset.Location = new Point(690, 437);
            btnReset.Margin = new Padding(3, 4, 3, 4);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(153, 37);
            btnReset.TabIndex = 11;
            btnReset.Text = "Reset list";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += button3_Click;
            // 
            // Movies
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(869, 636);
            Controls.Add(btnReset);
            Controls.Add(btnRent);
            Controls.Add(labelTotalPrice);
            Controls.Add(labelTotalMovies);
            Controls.Add(button1);
            Controls.Add(listPrices);
            Controls.Add(label2);
            Controls.Add(listMovies);
            Controls.Add(btnSearchAMovie);
            Controls.Add(textMovie);
            Controls.Add(label1);
            Controls.Add(dgMovies);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Movies";
            Text = "Movies";
            Load += Movies_Load;
            ((System.ComponentModel.ISupportInitialize)dgMovies).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgMovies;
        private Label label1;
        private TextBox textMovie;
        private Button btnSearchAMovie;
        private ListBox listMovies;
        private Label label2;
        private ListBox listPrices;
        private Button button1;
        private Label labelTotalMovies;
        private Label labelTotalPrice;
        private Button btnRent;
        private Button btnReset;
    }
}