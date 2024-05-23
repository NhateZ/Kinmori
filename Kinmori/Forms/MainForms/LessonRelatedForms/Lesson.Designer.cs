namespace Kinmori.Forms.MainForms.LessonRelatedForms
{
    partial class Lesson
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
            buttonQuit = new Button();
            buttonRun = new Button();
            SuspendLayout();
            // 
            // textBoxLesson
            // 
            textBoxLesson.BackColor = SystemColors.InactiveCaption;
            textBoxLesson.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLesson.ForeColor = Color.Black;
            textBoxLesson.Location = new Point(43, 25);
            textBoxLesson.Multiline = true;
            textBoxLesson.Name = "textBoxLesson";
            textBoxLesson.ReadOnly = true;
            textBoxLesson.Size = new Size(419, 379);
            textBoxLesson.TabIndex = 0;
            // 
            // buttonQuit
            // 
            buttonQuit.Location = new Point(468, 381);
            buttonQuit.Name = "buttonQuit";
            buttonQuit.Size = new Size(75, 23);
            buttonQuit.TabIndex = 1;
            buttonQuit.Text = "Quit";
            buttonQuit.UseVisualStyleBackColor = true;
            buttonQuit.Click += buttonQuit_Click;
            // 
            // buttonRun
            // 
            buttonRun.Location = new Point(468, 25);
            buttonRun.Name = "buttonRun";
            buttonRun.Size = new Size(100, 23);
            buttonRun.TabIndex = 2;
            buttonRun.Text = "Run example";
            buttonRun.UseVisualStyleBackColor = true;
            buttonRun.Click += buttonRun_Click;
            // 
            // Lesson
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(592, 450);
            Controls.Add(buttonRun);
            Controls.Add(buttonQuit);
            Controls.Add(textBoxLesson);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Lesson";
            Text = "Lesson";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxLesson;
        private Button buttonQuit;
        private Button buttonRun;
    }
}