using Firebase.Auth.Providers;
using Firebase.Auth;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kinmori.Forms.AccountRelatedForms
{
    public partial class Signup : Form
    {
        private Tuple<Int16, Int16, string>[] texts = new Tuple<Int16, Int16, string>[]
        {
            // (Language, typeOfControl, text)
            new (0,0,"Username"),
            new (0,1,"Email"),
            new (0,2,"Password"),
            new (0,3,"Sign up"),
            new (1,0,"Nume utilizator"),
            new (1,1,"E-mail"),
            new (1,2,"Parolă"),
            new (1,3,"Înregistrare"),
        };
        public Signup(int languageSelectorIndex)
        {
            InitializeComponent();
            List<Control> controls = new List<Control> { labelUser, labelEmail, labelPassword, buttonSignUp };
            var translations =
                from text in texts
                where text.Item1 == languageSelectorIndex
                select text;
            foreach (var translation in translations)
            {
                controls[translation.Item2].Text = translation.Item3;
            }
        }


        private const string firebaseApiKey = "AIzaSyABMMrUPCB-qic7OcMEPaYx5QG9DVMpsiA";
        private const string firebaseProjectName = "kinmori-22902";
        private async void buttonSignUp_Click(object sender, EventArgs e)
        {
            string username = textBoxUser.Text;
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
                });
                try
                {
                    var userCredential = await client.CreateUserWithEmailAndPasswordAsync(email, password, username);
                    MessageBox.Show("Succesful sign up | Contul s-a înregistrat cu succes");
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Account with same email / username already exists | Numele de utilizator / e-mailul este deja utilizat pentru un alt cont.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Invalid email / E-mail invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
