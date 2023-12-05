
using Microsoft.Win32;
using System.Media;

namespace BowValleyCinemaRoom
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            playSound();
            string firstName = textFirstName.Text;
            string lastName = textLastName.Text;
            string address = textAddress.Text;
            string birthday = $"{comboMonth.SelectedItem.ToString()}/{comboDay.SelectedItem.ToString()}/{comboYear.SelectedItem.ToString()}";
            string phone = textPhone.Text;
            string email = textEmail.Text;
            string password = textPassword.Text;
            string confirmPassword = textConfirmPassword.Text;
            string type = "isClient";

            RegisterQueries registerQueries = new RegisterQueries();

            var data = registerQueries.AddRegister(firstName, lastName, address, birthday, phone, email, password, confirmPassword, type);
            
            MessageBox.Show(data.Item2);

            if (data.Item1.Equals("success")) {
                this.Hide();
            }

        }

        private void Register_Load(object sender, EventArgs e)
        {

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
