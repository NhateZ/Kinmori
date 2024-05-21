using System.CodeDom;
using System.Net.Mail;
using Firebase;
using Firebase.Auth;
using Firebase.Auth.Providers;
using Kinmori.Forms;

namespace Kinmori
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            languageSelector.SelectedIndex = 0;
        }

        private Tuple<Int16, Int16, string>[] texts = new Tuple<Int16, Int16, string>[]
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
            var translations =
                from text in texts
                where text.Item1 == languageSelector.SelectedIndex
                select text;
            foreach (var translation in translations)
            {
                controls[translation.Item2].Text = translation.Item3;
            }
        }

        private void buttonGuest_Click(object sender, EventArgs e)
        {
            Kinmori.Forms.Main form = new Kinmori.Forms.Main(languageSelector.SelectedIndex, true);
            form.Icon = this.Icon;
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            Kinmori.Forms.AccountRelatedForms.Signup form = new Forms.AccountRelatedForms.Signup(languageSelector.SelectedIndex);
            form.Icon = this.Icon;
            this.Hide();
            form.ShowDialog();
            this.Show();
        }


        private const string firebaseApiKey = "AIzaSyABMMrUPCB-qic7OcMEPaYx5QG9DVMpsiA";
        private const string firebaseProjectName = "kinmori-22902";
        private async void buttonLogIn_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text;
            string password = textBoxPassword.Text;
            try
            {
                MailAddress mailAddress = new MailAddress(email);
                FirebaseAuthClient client = new FirebaseAuthClient(new FirebaseAuthConfig
                {
                    ApiKey = firebaseApiKey,
                    AuthDomain = $"{firebaseProjectName}.firebaseapp.com",
                    Providers = new FirebaseAuthProvider[]
                    {
                            new EmailProvider()
                    }
                }); ;
                try
                {
                    var userCredential = await client.SignInWithEmailAndPasswordAsync(email, password);
                    Main form = new Main(languageSelector.SelectedIndex, false);
                    form.ShowDialog();
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Invalid account | Cont invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch
            {
                MessageBox.Show("Invalid email | E-mail invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}