namespace Kinmori.Forms.MainForms.QuizForms
{
    partial class QuizMenu
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
            buttonCreator = new Button();
            buttonJoin = new Button();
            SuspendLayout();
            // 
            // buttonCreator
            // 
            buttonCreator.Location = new Point(200, 48);
            buttonCreator.Name = "buttonCreator";
            buttonCreator.Size = new Size(131, 37);
            buttonCreator.TabIndex = 3;
            buttonCreator.Text = "Quiz creator";
            buttonCreator.UseVisualStyleBackColor = true;
            buttonCreator.Click += buttonCreator_Click;
            // 
            // buttonJoin
            // 
            buttonJoin.Location = new Point(63, 48);
            buttonJoin.Name = "buttonJoin";
            buttonJoin.Size = new Size(131, 37);
            buttonJoin.TabIndex = 2;
            buttonJoin.Text = "Quiz code";
            buttonJoin.UseVisualStyleBackColor = true;
            buttonJoin.Click += buttonJoin_Click;
            // 
            // QuizMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(395, 132);
            Controls.Add(buttonCreator);
            Controls.Add(buttonJoin);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "QuizMenu";
            Text = "Kinmori - QuizMenu";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonCreator;
        private Button buttonJoin;
    }
}