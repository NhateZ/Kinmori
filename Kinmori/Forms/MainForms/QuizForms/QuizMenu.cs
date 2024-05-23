using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kinmori.Forms.MainForms.QuizForms
{
    public partial class QuizMenu : Form
    {
        public QuizMenu()
        {
            InitializeComponent();
        }

        private void buttonCreator_Click(object sender, EventArgs e)
        {
            QuizCreator form = new QuizCreator();
            form.Icon = this.Icon;
            form.ShowDialog();
            this.Close();
        }

        private void buttonJoin_Click(object sender, EventArgs e)
        {
            QuizCode form = new QuizCode();
            form.Icon = this.Icon;
            form.ShowDialog();
            this.Close();
        }
    }
}
