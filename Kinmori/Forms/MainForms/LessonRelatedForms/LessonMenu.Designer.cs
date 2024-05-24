namespace Kinmori.Forms.MainForms.LessonRelatedForms
{
    partial class LessonMenu
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
            buttonJoin = new Button();
            buttonCreator = new Button();
            SuspendLayout();
            // 
            // buttonJoin
            // 
            buttonJoin.Location = new Point(27, 39);
            buttonJoin.Name = "buttonJoin";
            buttonJoin.Size = new Size(131, 37);
            buttonJoin.TabIndex = 0;
            buttonJoin.Text = "Lesson code";
            buttonJoin.UseVisualStyleBackColor = true;
            buttonJoin.Click += buttonJoin_Click;
            // 
            // buttonCreator
            // 
            buttonCreator.Location = new Point(164, 39);
            buttonCreator.Name = "buttonCreator";
            buttonCreator.Size = new Size(131, 37);
            buttonCreator.TabIndex = 1;
            buttonCreator.Text = "Lesson creator";
            buttonCreator.UseVisualStyleBackColor = true;
            buttonCreator.Click += buttonCreator_Click;
            // 
            // LessonMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(329, 103);
            Controls.Add(buttonCreator);
            Controls.Add(buttonJoin);
            Cursor = Cursors.Default;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "LessonMenu";
            Text = "Kinmori - Lesson Menu";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonJoin;
        private Button buttonCreator;
    }
}