using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kinmori.Forms.MainForms.LessonRelatedForms
{
    public partial class LessonMenu : Form
    {
        public LessonMenu()
        {
            InitializeComponent();
        }

        private void buttonJoin_Click(object sender, EventArgs e)
        {
            LessonCode form = new LessonCode();
            form.Icon = this.Icon;
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void buttonCreator_Click(object sender, EventArgs e)
        {
            LessonCreator form = new LessonCreator();
            form.Icon = this.Icon;
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}
