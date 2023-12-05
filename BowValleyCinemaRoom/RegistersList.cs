using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BowValleyCinemaRoom
{
    public partial class RegistersList : Form
    {
        public RegistersList()
        {
            InitializeComponent();
        }

        private void RegistersList_Load(object sender, EventArgs e)
        {
            radioId.Checked = true;
            RegisterQueries registerQueries = new RegisterQueries();
            dgRegisters.DataSource = registerQueries.GetRegisters();

            //Get user ID
            int personId = Convert.ToInt32(dgRegisters.Rows[0].Cells["RegisterID"].Value);

            SetImageByPersonId(personId);

        }

        //Apply images to users by Id

        private void SetImageByPersonId(int personId) {
            if (personId == 1)
            {
                pictureBox1.Image = Properties.Resources.TomCruise;
                //image source:https://en.wikipedia.org/wiki/Tom_Cruise
            }
            else if (personId == 2)
            {

                pictureBox1.Image = Properties.Resources.Javier_Bardem;
                //image source:https://en.wikipedia.org/wiki/Javier_Bardem

            }
            else if (personId == 3) {


                pictureBox1.Image = Properties.Resources.LeonardoDicaprio;

                //image source:https://en.wikipedia.org/wiki/Leonardo_DiCaprio



            }
            else if (personId == 4)
            {


                pictureBox1.Image = Properties.Resources.BradPitt;

                //image source:https://en.wikipedia.org/wiki/Brad_Pitt



            }
            else if (personId == 10)
            {


                pictureBox1.Image = Properties.Resources.NicoleKidman;
                //image source:https://en.wikipedia.org/wiki/Nicole_Kidman


            }
            else if (personId == 6)
            {


                pictureBox1.Image = Properties.Resources.AnthonyHopkins;

                //image source:https://en.wikipedia.org/wiki/Anthony_Hopkins

            }
            else if (personId == 11)
            {


                pictureBox1.Image = Properties.Resources.LaurenceFishburne;
                //image source:https://en.wikipedia.org/wiki/Laurence_Fishburne


            }
            //else if (personId == 12)
            //{


               // pictureBox1.Image = Properties.Resources.LucyLiu;
                //image source:https://en.wikipedia.org/wiki/Lucy_Liu


           // }


            else
            {
                pictureBox1.Image = Properties.Resources.Katie;
                //image source:https://en.wikipedia.org/wiki/Katie_Holmes
            }

        }




        private void btnClean_Click(object sender, EventArgs e)
        {
            textFilter.Clear();
            RegisterQueries registerQueries = new RegisterQueries();
            dgRegisters.DataSource = registerQueries.GetRegisters();
        }

        private void filter(object sender, EventArgs e)
        {
            if (radioId.Checked == true) {
                RegisterQueries registerQueries = new RegisterQueries();
                dgRegisters.DataSource = registerQueries.FilterRegisterBy("spGetRegisterById", "@Id", textFilter.Text);
            }
            else if (radioFirstName.Checked == true) {
                RegisterQueries registerQueries = new RegisterQueries();
                dgRegisters.DataSource = registerQueries.FilterRegisterBy("spGetRegisterByFirstName", "@FirstName", textFilter.Text);
            }
            else if (radioLastName.Checked == true) {
                RegisterQueries registerQueries = new RegisterQueries();
                dgRegisters.DataSource = registerQueries.FilterRegisterBy("spGetRegisterByLastName", "@LastName", textFilter.Text);
            }

        }

        private void dgRegisters_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) {
                DataGridViewRow row = this.dgRegisters.Rows[e.RowIndex];
                //
                int personId = Convert.ToInt32(row.Cells["RegisterID"].Value);

                if (radioId.Checked == true)
                {
                    textFilter.Text = row.Cells["RegisterID"].Value.ToString();
                   
                }
                else if (radioFirstName.Checked == true)
                {
                    textFilter.Text = row.Cells["FirstName"].Value.ToString();
                }
                else if (radioLastName.Checked == true)
                {
                    textFilter.Text = row.Cells["LastName"].Value.ToString();
                }
                SetImageByPersonId(personId);



            }


        }
       

        private void btnEdit_Click(object sender, EventArgs e)
        {
            UpdateRegister updateMovie = new UpdateRegister(Convert.ToInt32(dgRegisters.CurrentCell.Value));
            updateMovie.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            RegisterQueries registerQueries = new RegisterQueries();
            var data = registerQueries.DeleteRegisterById(Convert.ToInt32(dgRegisters.CurrentCell.Value));
            //MessageBox.Show(data.ToString());
            if (data.Item1 == "success")
            {
                MessageBox.Show("Register successfully deleted!");
                dgRegisters.DataSource = registerQueries.GetRegisters();
            }
        }
    }
}
