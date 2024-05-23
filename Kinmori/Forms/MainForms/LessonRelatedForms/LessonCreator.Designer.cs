namespace Kinmori.Forms.MainForms.LessonRelatedForms
{
    partial class LessonCreator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxLesson = new TextBox();
            checkBox1 = new CheckBox();
            textBoxCode = new TextBox();
            textBoxAddB = new TextBox();
            textBoxRemoveB = new TextBox();
            label1 = new Label();
            label2 = new Label();
            buttonAddB = new Button();
            buttonRemoveB = new Button();
            buttonUpload = new Button();
            buttonHelp = new Button();
            buttonAddVariable = new Button();
            label3 = new Label();
            textBoxVariableName = new TextBox();
            comboBoxTypeSelector = new ComboBox();
            textBoxFirstType = new TextBox();
            textBoxSecondType = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // textBoxLesson
            // 
            textBoxLesson.BackColor = SystemColors.ControlLightLight;
            textBoxLesson.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLesson.ForeColor = Color.Black;
            textBoxLesson.Location = new Point(12, 24);
            textBoxLesson.Multiline = true;
            textBoxLesson.Name = "textBoxLesson";
            textBoxLesson.Size = new Size(377, 379);
            textBoxLesson.TabIndex = 1;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Location = new Point(455, 24);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(100, 19);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "Example code";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // textBoxCode
            // 
            textBoxCode.BackColor = SystemColors.ControlLight;
            textBoxCode.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCode.ForeColor = Color.Black;
            textBoxCode.Location = new Point(455, 49);
            textBoxCode.Multiline = true;
            textBoxCode.Name = "textBoxCode";
            textBoxCode.Size = new Size(211, 354);
            textBoxCode.TabIndex = 3;
            // 
            // textBoxAddB
            // 
            textBoxAddB.Location = new Point(693, 54);
            textBoxAddB.Name = "textBoxAddB";
            textBoxAddB.Size = new Size(133, 23);
            textBoxAddB.TabIndex = 4;
            // 
            // textBoxRemoveB
            // 
            textBoxRemoveB.Location = new Point(693, 127);
            textBoxRemoveB.Name = "textBoxRemoveB";
            textBoxRemoveB.Size = new Size(133, 23);
            textBoxRemoveB.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(693, 32);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 6;
            label1.Text = "Add breakpoint:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(693, 109);
            label2.Name = "label2";
            label2.Size = new Size(113, 15);
            label2.TabIndex = 7;
            label2.Text = "Remove breakpoint:";
            // 
            // buttonAddB
            // 
            buttonAddB.Location = new Point(751, 83);
            buttonAddB.Name = "buttonAddB";
            buttonAddB.Size = new Size(75, 23);
            buttonAddB.TabIndex = 8;
            buttonAddB.Text = "Add";
            buttonAddB.UseVisualStyleBackColor = true;
            buttonAddB.Click += buttonAddB_Click;
            // 
            // buttonRemoveB
            // 
            buttonRemoveB.Location = new Point(751, 156);
            buttonRemoveB.Name = "buttonRemoveB";
            buttonRemoveB.Size = new Size(75, 23);
            buttonRemoveB.TabIndex = 9;
            buttonRemoveB.Text = "Remove";
            buttonRemoveB.UseVisualStyleBackColor = true;
            buttonRemoveB.Click += buttonRemoveB_Click;
            // 
            // buttonUpload
            // 
            buttonUpload.Location = new Point(672, 380);
            buttonUpload.Name = "buttonUpload";
            buttonUpload.Size = new Size(75, 23);
            buttonUpload.TabIndex = 10;
            buttonUpload.Text = "Upload";
            buttonUpload.UseVisualStyleBackColor = true;
            buttonUpload.Click += buttonUpload_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.Location = new Point(561, 20);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(75, 23);
            buttonHelp.TabIndex = 11;
            buttonHelp.Text = "Open help";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonAddVariable
            // 
            buttonAddVariable.Location = new Point(751, 307);
            buttonAddVariable.Name = "buttonAddVariable";
            buttonAddVariable.Size = new Size(75, 23);
            buttonAddVariable.TabIndex = 14;
            buttonAddVariable.Text = "Add";
            buttonAddVariable.UseVisualStyleBackColor = true;
            buttonAddVariable.Click += buttonAddVariable_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(693, 182);
            label3.Name = "label3";
            label3.Size = new Size(111, 15);
            label3.TabIndex = 13;
            label3.Text = "Add variable watch:";
            // 
            // textBoxVariableName
            // 
            textBoxVariableName.Location = new Point(693, 278);
            textBoxVariableName.Name = "textBoxVariableName";
            textBoxVariableName.Size = new Size(133, 23);
            textBoxVariableName.TabIndex = 12;
            // 
            // comboBoxTypeSelector
            // 
            comboBoxTypeSelector.FormattingEnabled = true;
            comboBoxTypeSelector.Items.AddRange(new object[] { "- Not functional yet - C-style array", "Vector", "List", "Map", "Set", "Deque", "Stack", "Queue", "Priority queue" });
            comboBoxTypeSelector.Location = new Point(693, 226);
            comboBoxTypeSelector.Name = "comboBoxTypeSelector";
            comboBoxTypeSelector.Size = new Size(133, 23);
            comboBoxTypeSelector.TabIndex = 15;
            comboBoxTypeSelector.SelectedIndexChanged += comboBoxTypeSelector_SelectedIndexChanged;
            // 
            // textBoxFirstType
            // 
            textBoxFirstType.Enabled = false;
            textBoxFirstType.Location = new Point(832, 226);
            textBoxFirstType.Name = "textBoxFirstType";
            textBoxFirstType.Size = new Size(100, 23);
            textBoxFirstType.TabIndex = 16;
            textBoxFirstType.Visible = false;
            // 
            // textBoxSecondType
            // 
            textBoxSecondType.Enabled = false;
            textBoxSecondType.Location = new Point(938, 226);
            textBoxSecondType.Name = "textBoxSecondType";
            textBoxSecondType.Size = new Size(100, 23);
            textBoxSecondType.TabIndex = 17;
            textBoxSecondType.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Enabled = false;
            label4.Location = new Point(832, 208);
            label4.Name = "label4";
            label4.Size = new Size(92, 15);
            label4.TabIndex = 18;
            label4.Text = "Primitive type 1:";
            label4.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Enabled = false;
            label5.Location = new Point(938, 208);
            label5.Name = "label5";
            label5.Size = new Size(92, 15);
            label5.TabIndex = 19;
            label5.Text = "Primitive type 2:";
            label5.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(693, 208);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 20;
            label6.Text = "Type";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(693, 260);
            label7.Name = "label7";
            label7.Size = new Size(84, 15);
            label7.TabIndex = 21;
            label7.Text = "Variable name:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 6);
            label8.Name = "label8";
            label8.Size = new Size(69, 15);
            label8.TabIndex = 22;
            label8.Text = "Lesson text:";
            // 
            // LessonCreator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1052, 450);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBoxSecondType);
            Controls.Add(textBoxFirstType);
            Controls.Add(comboBoxTypeSelector);
            Controls.Add(buttonAddVariable);
            Controls.Add(label3);
            Controls.Add(textBoxVariableName);
            Controls.Add(buttonHelp);
            Controls.Add(buttonUpload);
            Controls.Add(buttonRemoveB);
            Controls.Add(buttonAddB);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxRemoveB);
            Controls.Add(textBoxAddB);
            Controls.Add(textBoxCode);
            Controls.Add(checkBox1);
            Controls.Add(textBoxLesson);
            MaximizeBox = false;
            Name = "LessonCreator";
            Text = "Kinmori - LessonCreator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxLesson;
        private CheckBox checkBox1;
        private TextBox textBoxCode;
        private TextBox textBoxAddB;
        private TextBox textBoxRemoveB;
        private Label label1;
        private Label label2;
        private Button buttonAddB;
        private Button buttonRemoveB;
        private Button buttonUpload;
        private Button buttonHelp;
        private Button buttonAddVariable;
        private Label label3;
        private TextBox textBoxVariableName;
        private ComboBox comboBoxTypeSelector;
        private TextBox textBoxFirstType;
        private TextBox textBoxSecondType;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}