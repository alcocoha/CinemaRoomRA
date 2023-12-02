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
            dgRegisters.Location = new Point(17, 130);
            dgRegisters.Margin = new Padding(4, 5, 4, 5);
            dgRegisters.Name = "dgRegisters";
            dgRegisters.RowHeadersWidth = 62;
            dgRegisters.RowTemplate.Height = 25;
            dgRegisters.Size = new Size(1109, 600);
            dgRegisters.TabIndex = 0;
            dgRegisters.CellClick += dgRegisters_CellContentClick;
            dgRegisters.CellContentClick += dgRegisters_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 77);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 1;
            // 
            // textFilter
            // 
            textFilter.Location = new Point(17, 72);
            textFilter.Margin = new Padding(4, 5, 4, 5);
            textFilter.Name = "textFilter";
            textFilter.Size = new Size(297, 31);
            textFilter.TabIndex = 2;
            textFilter.TextChanged += filter;
            // 
            // btnClean
            // 
            btnClean.Location = new Point(341, 72);
            btnClean.Margin = new Padding(4, 5, 4, 5);
            btnClean.Name = "btnClean";
            btnClean.Size = new Size(107, 38);
            btnClean.TabIndex = 4;
            btnClean.Text = "Clean";
            btnClean.UseVisualStyleBackColor = true;
            btnClean.Click += btnClean_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(903, 77);
            btnEdit.Margin = new Padding(4, 5, 4, 5);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(107, 38);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(1019, 77);
            btnDelete.Margin = new Padding(4, 5, 4, 5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(107, 38);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 30);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(98, 25);
            label2.TabIndex = 7;
            label2.Text = "Search by: ";
            // 
            // radioId
            // 
            radioId.AutoSize = true;
            radioId.Location = new Point(131, 28);
            radioId.Margin = new Padding(4, 5, 4, 5);
            radioId.Name = "radioId";
            radioId.Size = new Size(53, 29);
            radioId.TabIndex = 8;
            radioId.TabStop = true;
            radioId.Text = "Id";
            radioId.UseVisualStyleBackColor = true;
            // 
            // radioFirstName
            // 
            radioFirstName.AutoSize = true;
            radioFirstName.Location = new Point(207, 28);
            radioFirstName.Margin = new Padding(4, 5, 4, 5);
            radioFirstName.Name = "radioFirstName";
            radioFirstName.Size = new Size(117, 29);
            radioFirstName.TabIndex = 9;
            radioFirstName.TabStop = true;
            radioFirstName.Text = "FirstName";
            radioFirstName.UseVisualStyleBackColor = true;
            // 
            // radioLastName
            // 
            radioLastName.AutoSize = true;
            radioLastName.Location = new Point(341, 30);
            radioLastName.Margin = new Padding(4, 5, 4, 5);
            radioLastName.Name = "radioLastName";
            radioLastName.Size = new Size(115, 29);
            radioLastName.TabIndex = 10;
            radioLastName.TabStop = true;
            radioLastName.Text = "LastName";
            radioLastName.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(519, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(137, 101);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // RegistersList
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
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
            Margin = new Padding(4, 5, 4, 5);
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