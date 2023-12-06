namespace BowValleyCinemaRoom
{
    partial class Trailer
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
            this.videoView1 = new LibVLCSharp.WinForms.VideoView();
            ((System.ComponentModel.ISupportInitialize)(this.videoView1)).BeginInit();
            this.SuspendLayout();
            // 
            // videoView1
            // 
            this.videoView1.BackColor = System.Drawing.Color.Black;
            this.videoView1.Location = new System.Drawing.Point(116, 42);
            this.videoView1.MediaPlayer = null;
            this.videoView1.Name = "videoView1";
            this.videoView1.Size = new System.Drawing.Size(587, 337);
            this.videoView1.TabIndex = 0;
            this.videoView1.Text = "videoView1";
            // 
            // Trailer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.videoView1);
            this.Name = "Trailer";
            this.Text = "Trailer";
            this.Load += new System.EventHandler(this.Trailer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.videoView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private LibVLCSharp.WinForms.VideoView videoView1;
    }
}