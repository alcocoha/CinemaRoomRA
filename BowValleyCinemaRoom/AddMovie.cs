using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BowValleyCinemaRoom
{
    public partial class AddMovie : Form
    {
        public AddMovie()
        {
            InitializeComponent();
        }

        private void AddMovie_Load(object sender, EventArgs e)
        {

        }

        private void btnRegisterMovie_Click(object sender, EventArgs e)
        {
            MessageBox.Show("FOFOOF");
            //AddMovie(string title, string category, string description, string year, int totalCopies, int price)
            //playSound();

            try
            {
                validateFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return;
            }

            string title = textTitle.Text;
            string category = comboBoxCategory.SelectedItem.ToString();
            string description = textDescription.Text;
            string year = textYear.Text;
            int totalCopies = Int32.Parse(textCopiesInStore.Text);
            int price = Int32.Parse(textPrice.Text);
            string poster = textPoster.Text;
            string trailer = textTrailer.Text;

            MovieQueries movieQueries = new MovieQueries();



            var data = movieQueries.AddMovie(title, category, description, year, totalCopies, price, poster, trailer);

            MessageBox.Show(data.Item2);

            if (data.Item1.Equals("success"))
            {
                textTitle.Clear();
                textDescription.Clear();
                comboBoxCategory.SelectedIndex = -1;
                textYear.Clear();
                textCopiesInStore.Clear();
                textPrice.Clear();
                textPoster.Clear();
                textTrailer.Clear();
            }
        }
        private void validateFields()
        {
            if (textTitle.Text == "")
            {
                throw new ErrorHandler.EmptyFieldException("Title");
            }
            if (textDescription.Text == "")
            {
                throw new ErrorHandler.EmptyFieldException("Description");
            }
            if (comboBoxCategory.SelectedItem == "")
            {
                throw new ErrorHandler.EmptyFieldException("Category");
            }
            if (textYear.Text == "")
            {
                throw new ErrorHandler.EmptyFieldException("Year");
            }
            if (textCopiesInStore.Text == "")
            {
                throw new ErrorHandler.EmptyFieldException("Copies in Store");
            }
            if (textPrice.Text == "")
            {
                throw new ErrorHandler.EmptyFieldException("Price");
            }
            if (textPoster.Text == "")
            {
                throw new ErrorHandler.EmptyFieldException("Poster");
            }
            if (textTrailer.Text == "")
            {
                throw new ErrorHandler.EmptyFieldException("Trailer");
            }
        }

        public void playSound()
        {
            bool found = false;
            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"AppEvents\Schemes\Apps\.Default\Notification.Default\.Current"))
                {
                    if (key != null)
                    {
                        Object o = key.GetValue(null); // pass null to get (Default)
                        if (o != null)
                        {
                            SoundPlayer theSound = new SoundPlayer((String)o);
                            theSound.Play();
                            found = true;
                        }
                    }
                }
            }
            catch
            { }
            if (!found)
                SystemSounds.Beep.Play();
        }
    }
}
