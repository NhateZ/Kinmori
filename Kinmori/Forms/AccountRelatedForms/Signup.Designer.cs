namespace Kinmori.Forms.AccountRelatedForms
{
    partial class Signup
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
            buttonSignUp = new Button();
            labelPassword = new Label();
            labelEmail = new Label();
            textBoxPassword = new TextBox();
            textBoxEmail = new TextBox();
            labelUser = new Label();
            textBoxUser = new TextBox();
            SuspendLayout();
            // 
            // buttonSignUp
            // 
            buttonSignUp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSignUp.Location = new Point(175, 200);
            buttonSignUp.Name = "buttonSignUp";
            buttonSignUp.Size = new Size(140, 41);
            buttonSignUp.TabIndex = 10;
            buttonSignUp.Text = "Sign up";
            buttonSignUp.UseVisualStyleBackColor = true;
            buttonSignUp.Click += buttonSignUp_Click;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelPassword.Location = new Point(67, 133);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(76, 21);
            labelPassword.TabIndex = 9;
            labelPassword.Text = "Password";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelEmail.Location = new Point(67, 81);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(48, 21);
            labelEmail.TabIndex = 8;
            labelEmail.Text = "Email";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(67, 157);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(358, 23);
            textBoxPassword.TabIndex = 7;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(67, 105);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(358, 23);
            textBoxEmail.TabIndex = 6;
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelUser.Location = new Point(67, 31);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(81, 21);
            labelUser.TabIndex = 12;
            labelUser.Text = "Username";
            // 
            // textBoxUser
            // 
            textBoxUser.Location = new Point(67, 55);
            textBoxUser.Name = "textBoxUser";
            textBoxUser.Size = new Size(358, 23);
            textBoxUser.TabIndex = 0;
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(482, 260);
            Controls.Add(labelUser);
            Controls.Add(textBoxUser);
            Controls.Add(buttonSignUp);
            Controls.Add(labelPassword);
            Controls.Add(labelEmail);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxEmail);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Signup";
            Text = "Sign up";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSignUp;
        private Label labelPassword;
        private Label labelEmail;
        private TextBox textBoxPassword;
        private TextBox textBoxEmail;
        private Label labelUser;
        private TextBox textBoxUser;
    }
}