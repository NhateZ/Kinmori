using System.CodeDom;
using System.Net.Mail;

namespace Kinmori
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            languageSelector.SelectedIndex = 0;
        }

        private Tuple<Int16, Int16, string>[] text = new Tuple<Int16, Int16, string>[]
        {
            // (Language, typeOfControl, text)
            new (0,0,"Email"),
            new (0,1,"Password"),
            new (0,2,"Log in as guest"),
            new (0,3,"Sign up"),
            new (0,4,"Log in"),
            new (1,0,"E-mail"),
            new (1,1,"Parolã"),
            new (1,2,"Logare ca guest"),
            new (1,3,"Înregistrare"),
            new (1,4,"Logare")
        };

        private void LogIn_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.logo;
        }
        private void languageSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Control> controls = new List<Control> { labelEmail, labelPassword, buttonGuest, buttonSignUp, buttonLogIn };
            var selectedTranslation =
                from translation in text
                where translation.Item1 == languageSelector.SelectedIndex
                select translation;
            foreach (var translation in selectedTranslation)
            {
                controls[translation.Item2].Text = translation.Item3;
            }
        }

        private void buttonGuest_Click(object sender, EventArgs e)
        {

        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text;
            string password = textBoxPassword.Text;

            try
            {
                MailAddress mailAddress = new MailAddress(email);
            }
            catch
            {
                MessageBox.Show("Invalid email / E-mail invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}