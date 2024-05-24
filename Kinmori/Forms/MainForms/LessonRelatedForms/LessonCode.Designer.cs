namespace Kinmori.Forms.MainForms.LessonRelatedForms
{
    partial class LessonCode
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
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // buttonJoin
            // 
            buttonJoin.Location = new Point(370, 52);
            buttonJoin.Name = "buttonJoin";
            buttonJoin.Size = new Size(118, 31);
            buttonJoin.TabIndex = 3;
            buttonJoin.Text = "Join";
            buttonJoin.UseVisualStyleBackColor = true;
            buttonJoin.Click += buttonJoin_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(12, 17);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(476, 29);
            textBox1.TabIndex = 2;
            // 
            // LessonCode
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(500, 101);
            Controls.Add(buttonJoin);
            Controls.Add(textBox1);
            Name = "LessonCode";
            Text = "Kinmori - LessonCode";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonJoin;
        private TextBox textBox1;
    }
}