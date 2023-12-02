using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BowValleyCinemaRoom
{
    public partial class User : Form
    {
        int RegisterID;
        public User(int registerId)
        {
            InitializeComponent();
            RegisterID = registerId;
        }

        private void moviesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Movies movies = new Movies(RegisterID);
            movies.MdiParent = this;
            movies.Show();
        }

        private void User_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateRegister updateMovie = new UpdateRegister(RegisterID);
            updateMovie.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Welcome to BowValleyCinemaRoom, your premier destination for all things cinematic! Immerse yourself in a world of entertainment as we bring you a carefully curated selection of movies, TV shows, and film-inspired merchandise. Whether you're a film buff, a casual viewer, or looking for the perfect gift, BowValleyCinemaRoom is your go-to source for an unparalleled cinematic experience", "About us", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
