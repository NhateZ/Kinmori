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
    public partial class QuizCreator : Form
    {
        public QuizCreator()
        {
            InitializeComponent();
        }
        private List<Question> quiz = new List<Question>();
        private void QuizCreator_Load(object sender, EventArgs e)
        {
            comboBoxAnswer.SelectedIndex = 0;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Are you sure you want to add the question?\nEști sigur că vrei să adaugi întrebarea?", "Kinmori", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                Question question = new Question();
                question.setRightAnswer(comboBoxAnswer.SelectedIndex);
                question.setTextQuestion(textBox5.Text);
                question.Push(new Tuple<bool, string>(checkBox1.Checked, textBox1.Text));
                question.Push(new Tuple<bool, string>(checkBox2.Checked, textBox2.Text));
                question.Push(new Tuple<bool, string>(checkBox3.Checked, textBox3.Text));
                question.Push(new Tuple<bool, string>(checkBox4.Checked, textBox4.Text));
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                checkBox1.Checked = true;
                checkBox2.Checked = true;
                checkBox3.Checked = true;
                checkBox4.Checked = true;
                quiz.Add(question);
            }
        }
        private void buttonUpload_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Are you sure you want to upload?\nEști sigur că vrei să uploadezi?","Upload",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                // To Implement


                
                this.Close();
            }
        }

        private void comboBoxAnswer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    
}
public class Question
{
    private int RightAnswer;
    private string TextQuestion;
    private List<Tuple<bool, string>> questions;
    public void Push (Tuple<bool, string> question) 
    {
        questions.Add(question);
    }
    public void setRightAnswer (int rightAnswer)
    {
        this.RightAnswer = rightAnswer;
    }
    public void setTextQuestion (string textQuestion)
    { 
        this.TextQuestion = textQuestion; 
    }

}