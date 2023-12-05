namespace BowValleyCinemaRoom
{
    partial class MovieList
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
            components = new System.ComponentModel.Container();
            radioYear = new RadioButton();
            radioCategory = new RadioButton();
            radioTitle = new RadioButton();
            label2 = new Label();
            btnDelete = new Button();
            btnEdit = new Button();
            btnClean = new Button();
            textFilter = new TextBox();
            label1 = new Label();
            dgMovies = new DataGridView();
            contextMenuStrip2 = new ContextMenuStrip(components);
            Edit = new ToolStripMenuItem();
            Delete = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgMovies).BeginInit();
            contextMenuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // radioYear
            // 
            radioYear.AutoSize = true;
            radioYear.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            radioYear.Location = new Point(307, 21);
            radioYear.Margin = new Padding(3, 4, 3, 4);
            radioYear.Name = "radioYear";
            radioYear.Size = new Size(62, 24);
            radioYear.TabIndex = 20;
            radioYear.TabStop = true;
            radioYear.Text = "Year";
            radioYear.UseVisualStyleBackColor = true;
            // 
            // radioCategory
            // 
            radioCategory.AutoSize = true;
            radioCategory.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            radioCategory.Location = new Point(187, 20);
            radioCategory.Margin = new Padding(3, 4, 3, 4);
            radioCategory.Name = "radioCategory";
            radioCategory.Size = new Size(100, 24);
            radioCategory.TabIndex = 19;
            radioCategory.TabStop = true;
            radioCategory.Text = "Category";
            radioCategory.UseVisualStyleBackColor = true;
            // 
            // radioTitle
            // 
            radioTitle.AutoSize = true;
            radioTitle.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            radioTitle.Location = new Point(118, 20);
            radioTitle.Margin = new Padding(3, 4, 3, 4);
            radioTitle.Name = "radioTitle";
            radioTitle.Size = new Size(56, 24);
            radioTitle.TabIndex = 18;
            radioTitle.TabStop = true;
            radioTitle.Text = "Title";
            radioTitle.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(16, 21);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 17;
            label2.Text = "Search by: ";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.GradientActiveCaption;
            btnDelete.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(1041, 54);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(97, 39);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = SystemColors.GradientActiveCaption;
            btnEdit.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnEdit.Location = new Point(936, 54);
            btnEdit.Margin = new Padding(3, 4, 3, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(97, 39);
            btnEdit.TabIndex = 15;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnClean
            // 
            btnClean.BackColor = SystemColors.GradientActiveCaption;
            btnClean.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnClean.Location = new Point(307, 50);
            btnClean.Margin = new Padding(3, 4, 3, 4);
            btnClean.Name = "btnClean";
            btnClean.Size = new Size(97, 39);
            btnClean.TabIndex = 14;
            btnClean.Text = "Clear";
            btnClean.UseVisualStyleBackColor = false;
            btnClean.Click += btnClean_Click;
            // 
            // textFilter
            // 
            textFilter.Location = new Point(16, 55);
            textFilter.Margin = new Padding(3, 4, 3, 4);
            textFilter.Name = "textFilter";
            textFilter.Size = new Size(267, 26);
            textFilter.TabIndex = 13;
            textFilter.TextChanged += textFilter_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 59);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 12;
            // 
            // dgMovies
            // 
            dgMovies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgMovies.ContextMenuStrip = contextMenuStrip2;
            dgMovies.Location = new Point(16, 101);
            dgMovies.Margin = new Padding(3, 4, 3, 4);
            dgMovies.Name = "dgMovies";
            dgMovies.RowHeadersWidth = 51;
            dgMovies.RowTemplate.Height = 25;
            dgMovies.Size = new Size(1124, 480);
            dgMovies.TabIndex = 11;
            dgMovies.CellContentClick += dgMovies_CellContentClick_1;
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.ImageScalingSize = new Size(20, 20);
            contextMenuStrip2.Items.AddRange(new ToolStripItem[] { Edit, Delete });
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(123, 52);
            // 
            // Edit
            // 
            Edit.Name = "Edit";
            Edit.Size = new Size(122, 24);
            Edit.Text = "Edit";
            // 
            // Delete
            // 
            Delete.Name = "Delete";
            Delete.Size = new Size(122, 24);
            Delete.Text = "Delete";
            // 
            // MovieList
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1154, 600);
            Controls.Add(radioYear);
            Controls.Add(radioCategory);
            Controls.Add(radioTitle);
            Controls.Add(label2);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnClean);
            Controls.Add(textFilter);
            Controls.Add(label1);
            Controls.Add(dgMovies);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MovieList";
            Text = "MovieList";
            Load += MovieList_Load;
            ((System.ComponentModel.ISupportInitialize)dgMovies).EndInit();
            contextMenuStrip2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioYear;
        private RadioButton radioCategory;
        private RadioButton radioTitle;
        private Label label2;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnClean;
        private TextBox textFilter;
        private Label label1;
        private DataGridView dgMovies;
        private ContextMenuStrip contextMenuStrip1;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem Edit;
        private ToolStripMenuItem Delete;
    }
}