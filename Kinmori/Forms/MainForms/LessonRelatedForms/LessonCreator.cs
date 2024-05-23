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
    public partial class LessonCreator : Form
    {
        public LessonCreator()
        {
            InitializeComponent();
        }
        private List<command> commands = new List<command>();

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            List<Control> controls = new List<Control>
            {
                label1, label2, label3, label4, label5, label6, label7,
                textBoxAddB, textBoxCode, textBoxRemoveB, textBoxVariableName,
                comboBoxTypeSelector,
                buttonAddB, buttonRemoveB, buttonAddVariable
            };
            foreach (Control control in controls)
            {
                control.Enabled = !control.Enabled;
                control.Visible = !control.Visible;
            }
            if (!checkBox1.Checked)
            {
                label5.Enabled = false;
                textBoxFirstType.Enabled = false;
                label5.Visible = false;
                textBoxFirstType.Visible = false;
                label4.Enabled = false;
                textBoxFirstType.Enabled = false;
                label4.Visible = false;
                textBoxFirstType.Visible = false;
            }
        }

        private void buttonAddB_Click(object sender, EventArgs e)
        {
            try
            {
                int line = int.Parse(textBoxAddB.Text);
                string _command = $"b {line}";
                commands.Add(new command(_command));
            }
            catch 
            {
                MessageBox.Show("Make sure you inserted a number!");
            } 
        }

        private void buttonRemoveB_Click(object sender, EventArgs e)
        {
            try
            {
                int line = int.Parse(textBoxRemoveB.Text);
                string _command = $"d {line}";
                commands.Add(new command(_command));
            }
            catch
            {
                MessageBox.Show("Make sure you inserted a number!");
            }
        }
        private void buttonAddVariable_Click(object sender, EventArgs e)
        {

        }
        private void buttonUpload_Click(object sender, EventArgs e)
        {
            // To Implement
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Example code - Enable it if you want an C++ sequence of code to be enabled\nAdd breakpoint - adds a breakpoint at a specified line\n Remove breakpointt - removes a breakpoint at a specified line\n Add variable watch - adds a watch on a specific variable that will be animated (if possible)");
        }

        private void comboBoxTypeSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTypeSelector.SelectedIndex == 2 || comboBoxTypeSelector.SelectedIndex == 3 || comboBoxTypeSelector.SelectedIndex == 4)
            {
                label4.Enabled = true;
                textBoxFirstType.Enabled = true;
                label4.Visible = true;
                textBoxFirstType.Visible = true;
            }
            else
            {
                label4.Enabled = false;
                textBoxFirstType.Enabled = false;
                label4.Visible = false;
                textBoxFirstType.Visible = false;
            }
            if (comboBoxTypeSelector.SelectedIndex == 3)
            {
                label5.Enabled = true;
                textBoxSecondType.Enabled = true;
                label5.Visible = true;
                textBoxSecondType.Visible = true;
            }
            else
            {
                label5.Enabled = false;
                textBoxFirstType.Enabled = false;
                label5.Visible = false;
                textBoxFirstType.Visible = false;
            }
        }
    }
}
public class command
{
    public command() { }
    public command(string command) { this.SetCommand(command); }
    private string _command;
    public void SetCommand(string command)
    {
        this._command = command;
    }
    public string GetCommand()
    {
        return this._command;
    }
}
public class variable
{
    public variable() { }
    public variable(string _typename, string _nameofvariable) { this.typename = _typename; this.nameofvariable = _nameofvariable; }
    private string typename;
    private string nameofvariable;
    public void SetTypename(string _typename) { this.typename = _typename; }
    public string GetTypename(string _typename) { return this.typename;}
    public void SetNameOfVariable(string _nameofvariable) { this.nameofvariable = _nameofvariable; }
    public string GetNameOfVariable() { return this.nameofvariable;}
}