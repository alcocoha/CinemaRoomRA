namespace BowValleyCinemaRoom
{
    partial class RegistersList
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
            dgRegisters = new DataGridView();
            label1 = new Label();
            textFilter = new TextBox();
            btnClean = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            label2 = new Label();
            radioId = new RadioButton();
            radioFirstName = new RadioButton();
            radioLastName = new RadioButton();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgRegisters).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgRegisters
            // 
            dgRegisters.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgRegisters.Location = new Point(16, 104);
            dgRegisters.Margin = new Padding(3, 4, 3, 4);
            dgRegisters.Name = "dgRegisters";
            dgRegisters.RowHeadersWidth = 62;
            dgRegisters.RowTemplate.Height = 25;
            dgRegisters.Size = new Size(998, 480);
            dgRegisters.TabIndex = 0;
            dgRegisters.CellClick += dgRegisters_CellContentClick;
            dgRegisters.CellContentClick += dgRegisters_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 62);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 1;
            // 
            // textFilter
            // 
            textFilter.Location = new Point(16, 63);
            textFilter.Margin = new Padding(3, 4, 3, 4);
            textFilter.Name = "textFilter";
            textFilter.Size = new Size(267, 26);
            textFilter.TabIndex = 2;
            textFilter.TextChanged += filter;
            // 
            // btnClean
            // 
            btnClean.BackColor = SystemColors.GradientActiveCaption;
            btnClean.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnClean.Location = new Point(307, 58);
            btnClean.Margin = new Padding(3, 4, 3, 4);
            btnClean.Name = "btnClean";
            btnClean.Size = new Size(102, 34);
            btnClean.TabIndex = 4;
            btnClean.Text = "Clear";
            btnClean.UseVisualStyleBackColor = false;
            btnClean.Click += btnClean_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = SystemColors.GradientActiveCaption;
            btnEdit.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnEdit.Location = new Point(796, 58);
            btnEdit.Margin = new Padding(3, 4, 3, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(106, 34);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.GradientActiveCaption;
            btnDelete.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(908, 58);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(106, 34);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 24);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 7;
            label2.Text = "Search by: ";
            // 
            // radioId
            // 
            radioId.AutoSize = true;
            radioId.Location = new Point(118, 22);
            radioId.Margin = new Padding(3, 4, 3, 4);
            radioId.Name = "radioId";
            radioId.Size = new Size(45, 24);
            radioId.TabIndex = 8;
            radioId.TabStop = true;
            radioId.Text = "Id";
            radioId.UseVisualStyleBackColor = true;
            // 
            // radioFirstName
            // 
            radioFirstName.AutoSize = true;
            radioFirstName.Location = new Point(187, 22);
            radioFirstName.Margin = new Padding(3, 4, 3, 4);
            radioFirstName.Name = "radioFirstName";
            radioFirstName.Size = new Size(100, 24);
            radioFirstName.TabIndex = 9;
            radioFirstName.TabStop = true;
            radioFirstName.Text = "FirstName";
            radioFirstName.UseVisualStyleBackColor = true;
            // 
            // radioLastName
            // 
            radioLastName.AutoSize = true;
            radioLastName.Location = new Point(307, 24);
            radioLastName.Margin = new Padding(3, 4, 3, 4);
            radioLastName.Name = "radioLastName";
            radioLastName.Size = new Size(102, 24);
            radioLastName.TabIndex = 10;
            radioLastName.TabStop = true;
            radioLastName.Text = "LastName";
            radioLastName.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(467, 17);
            pictureBox1.Margin = new Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(124, 81);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // RegistersList
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1028, 600);
            Controls.Add(pictureBox1);
            Controls.Add(radioLastName);
            Controls.Add(radioFirstName);
            Controls.Add(radioId);
            Controls.Add(label2);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnClean);
            Controls.Add(textFilter);
            Controls.Add(label1);
            Controls.Add(dgRegisters);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "RegistersList";
            Text = "Registers List";
            Load += RegistersList_Load;
            ((System.ComponentModel.ISupportInitialize)dgRegisters).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgRegisters;
        private Label label1;
        private TextBox textFilter;
        private Button btnClean;
        private Button btnEdit;
        private Button btnDelete;
        private Label label2;
        private RadioButton radioId;
        private RadioButton radioFirstName;
        private RadioButton radioLastName;
        private PictureBox pictureBox1;
    }
}