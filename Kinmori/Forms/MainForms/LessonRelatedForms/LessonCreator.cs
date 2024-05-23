using Microsoft.VisualBasic;
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
        static private readonly string[] printingSystem =
        {
            "NOT IMPLEMENTED",
            "pvector",
            "plist",
            "pmap",
            "pset",
            "pdeque",
            "pstack",
            "pqueue",
            "ppqueue"
        };
        public LessonCreator()
        {
            InitializeComponent();
            label5.Enabled = false;
            textBoxSecondType.Enabled = false;
            label5.Visible = false;
            textBoxSecondType.Visible = false;
            textBoxSecondType.Text = string.Empty;
            label4.Enabled = false;
            textBoxFirstType.Enabled = false;
            label4.Visible = false;
            textBoxFirstType.Visible = false;
            textBoxFirstType.Text = string.Empty;
        }
        private List<command> commands = new List<command>();
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            List<Control> controls = new List<Control>
            {
                label1, label2, label3, label6, label7,
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
                UInt128 line = UInt128.Parse(textBoxAddB.Text);
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
                UInt128 line = UInt128.Parse(textBoxRemoveB.Text);
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
            string _command = $"{printingSystem[comboBoxTypeSelector.SelectedIndex]}";
            if (comboBoxTypeSelector.SelectedIndex >= 2 && comboBoxTypeSelector.SelectedIndex <= 4)
            {
                _command += " int";
            }
            if (comboBoxTypeSelector.SelectedIndex == 3)
            {
                _command += " int";
            }
        }
        private void buttonUpload_Click(object sender, EventArgs e)
        {

        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Example code - Enable it if you want an C++ sequence of code to be enabled\nAdd breakpoint - adds a breakpoint at a specified line\nRemove breakpointt - removes a breakpoint at a specified line\nAdd variable watch - adds a watch on a specific variable that will be animated (if possible)");
        }

        private void comboBoxTypeSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            ;
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