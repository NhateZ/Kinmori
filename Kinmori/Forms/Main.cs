using Kinmori.Forms.MainForms.LessonRelatedForms;
using Kinmori.Forms.MainForms.QuizForms
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kinmori.Forms
{
    public partial class Main : Form
    {
        private bool isGuest;
        private int languageSelectorIndex;
        public Main(int languageSelectorIndex, bool isGuest)
        {
            InitializeComponent();
            this.isGuest = isGuest;
            this.languageSelectorIndex = languageSelectorIndex;
        }

        private void buttonLessons_Click(object sender, EventArgs e)
        {
            LessonMenu lessonMenu = new LessonMenu();
            lessonMenu.Icon = this.Icon;
            this.Hide();
            lessonMenu.ShowDialog();
            this.Show();
        }

        private void buttonQuiz_Click(object sender, EventArgs e)
        {
            QuizMenu quizMenu = new QuizMenu();
            quizMenu.Icon = this.Icon;
            this.Hide();
            quizMenu.ShowDialog();
            this.Show();
        }
    }
}
