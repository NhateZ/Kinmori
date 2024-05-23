namespace Kinmori.Forms
{
    partial class Main
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
            buttonLessons = new Button();
            buttonQuiz = new Button();
            SuspendLayout();
            // 
            // buttonLessons
            // 
            buttonLessons.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLessons.Location = new Point(72, 42);
            buttonLessons.Name = "buttonLessons";
            buttonLessons.Size = new Size(93, 34);
            buttonLessons.TabIndex = 0;
            buttonLessons.Text = "Lessons";
            buttonLessons.UseVisualStyleBackColor = true;
            buttonLessons.Click += buttonLessons_Click;
            // 
            // buttonQuiz
            // 
            buttonQuiz.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonQuiz.Location = new Point(226, 42);
            buttonQuiz.Name = "buttonQuiz";
            buttonQuiz.Size = new Size(93, 34);
            buttonQuiz.TabIndex = 1;
            buttonQuiz.Text = "Quiz";
            buttonQuiz.UseVisualStyleBackColor = true;
            buttonQuiz.Click += buttonQuiz_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(393, 111);
            Controls.Add(buttonQuiz);
            Controls.Add(buttonLessons);
            Name = "Main";
            Text = "Kinmori";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonLessons;
        private Button buttonQuiz;
    }
}