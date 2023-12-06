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
            this.dgMovies = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textMovie = new System.Windows.Forms.TextBox();
            this.btnSearchAMovie = new System.Windows.Forms.Button();
            this.listMovies = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listPrices = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelTotalMovies = new System.Windows.Forms.Label();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.btnRent = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.posterPicture = new System.Windows.Forms.PictureBox();
            this.btnTrailer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgMovies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posterPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // dgMovies
            // 
            this.dgMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMovies.Location = new System.Drawing.Point(12, 116);
            this.dgMovies.Name = "dgMovies";
            this.dgMovies.RowHeadersWidth = 51;
            this.dgMovies.RowTemplate.Height = 25;
            this.dgMovies.Size = new System.Drawing.Size(460, 358);
            this.dgMovies.TabIndex = 0;
            this.dgMovies.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgMovies.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMovies_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Movies Selection";
            // 
            // textMovie
            // 
            this.textMovie.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textMovie.Location = new System.Drawing.Point(12, 72);
            this.textMovie.Name = "textMovie";
            this.textMovie.Size = new System.Drawing.Size(208, 22);
            this.textMovie.TabIndex = 2;
            // 
            // btnSearchAMovie
            // 
            this.btnSearchAMovie.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSearchAMovie.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearchAMovie.Location = new System.Drawing.Point(229, 68);
            this.btnSearchAMovie.Name = "btnSearchAMovie";
            this.btnSearchAMovie.Size = new System.Drawing.Size(116, 28);
            this.btnSearchAMovie.TabIndex = 3;
            this.btnSearchAMovie.Text = "Search";
            this.btnSearchAMovie.UseVisualStyleBackColor = false;
            this.btnSearchAMovie.Click += new System.EventHandler(this.btnSearchAMovie_Click);
            // 
            // listMovies
            // 
            this.listMovies.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listMovies.FormattingEnabled = true;
            this.listMovies.ItemHeight = 17;
            this.listMovies.Location = new System.Drawing.Point(709, 116);
            this.listMovies.Name = "listMovies";
            this.listMovies.Size = new System.Drawing.Size(176, 157);
            this.listMovies.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(709, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Movies Selected:";
            // 
            // listPrices
            // 
            this.listPrices.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listPrices.FormattingEnabled = true;
            this.listPrices.ItemHeight = 17;
            this.listPrices.Location = new System.Drawing.Point(891, 116);
            this.listPrices.Name = "listPrices";
            this.listPrices.Size = new System.Drawing.Size(66, 157);
            this.listPrices.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(351, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 28);
            this.button1.TabIndex = 7;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelTotalMovies
            // 
            this.labelTotalMovies.AutoSize = true;
            this.labelTotalMovies.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTotalMovies.Location = new System.Drawing.Point(709, 297);
            this.labelTotalMovies.Name = "labelTotalMovies";
            this.labelTotalMovies.Size = new System.Drawing.Size(96, 17);
            this.labelTotalMovies.TabIndex = 8;
            this.labelTotalMovies.Text = "Total movies: 0";
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.AutoSize = true;
            this.labelTotalPrice.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTotalPrice.Location = new System.Drawing.Point(907, 297);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelTotalPrice.Size = new System.Drawing.Size(62, 17);
            this.labelTotalPrice.TabIndex = 9;
            this.labelTotalPrice.Text = "0.00 CAD";
            this.labelTotalPrice.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnRent
            // 
            this.btnRent.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnRent.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRent.Location = new System.Drawing.Point(709, 370);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(248, 50);
            this.btnRent.TabIndex = 10;
            this.btnRent.Text = "Rent Movies";
            this.btnRent.UseVisualStyleBackColor = false;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnReset.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReset.Location = new System.Drawing.Point(824, 328);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(134, 28);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset list";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // posterPicture
            // 
            this.posterPicture.Location = new System.Drawing.Point(478, 116);
            this.posterPicture.Name = "posterPicture";
            this.posterPicture.Size = new System.Drawing.Size(225, 304);
            this.posterPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.posterPicture.TabIndex = 12;
            this.posterPicture.TabStop = false;
            // 
            // btnTrailer
            // 
            this.btnTrailer.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnTrailer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTrailer.Location = new System.Drawing.Point(478, 426);
            this.btnTrailer.Name = "btnTrailer";
            this.btnTrailer.Size = new System.Drawing.Size(225, 50);
            this.btnTrailer.TabIndex = 13;
            this.btnTrailer.Text = "Trailer";
            this.btnTrailer.UseVisualStyleBackColor = false;
            this.btnTrailer.Click += new System.EventHandler(this.btnTrailer_Click);
            // 
            // Movies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(982, 526);
            this.Controls.Add(this.btnTrailer);
            this.Controls.Add(this.posterPicture);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnRent);
            this.Controls.Add(this.labelTotalPrice);
            this.Controls.Add(this.labelTotalMovies);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listPrices);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listMovies);
            this.Controls.Add(this.btnSearchAMovie);
            this.Controls.Add(this.textMovie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgMovies);
            this.Name = "Movies";
            this.Text = "Movies";
            this.Load += new System.EventHandler(this.Movies_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMovies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posterPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private PictureBox posterPicture;
        private Button btnTrailer;
    }
}