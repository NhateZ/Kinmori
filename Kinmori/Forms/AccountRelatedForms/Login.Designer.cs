namespace Kinmori
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxEmail = new TextBox();
            textBoxPassword = new TextBox();
            labelEmail = new Label();
            labelPassword = new Label();
            buttonLogIn = new Button();
            buttonSignUp = new Button();
            buttonGuest = new Button();
            languageSelector = new ComboBox();
            SuspendLayout();
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(94, 66);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(358, 23);
            textBoxEmail.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(94, 118);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(358, 23);
            textBoxPassword.TabIndex = 1;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelEmail.Location = new Point(94, 42);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(48, 21);
            labelEmail.TabIndex = 2;
            labelEmail.Text = "Email";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelPassword.Location = new Point(94, 94);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(76, 21);
            labelPassword.TabIndex = 3;
            labelPassword.Text = "Password";
            // 
            // buttonLogIn
            // 
            buttonLogIn.Location = new Point(377, 147);
            buttonLogIn.Name = "buttonLogIn";
            buttonLogIn.Size = new Size(75, 23);
            buttonLogIn.TabIndex = 4;
            buttonLogIn.Text = "Log in";
            buttonLogIn.UseVisualStyleBackColor = true;
            buttonLogIn.Click += buttonLogIn_Click;
            // 
            // buttonSignUp
            // 
            buttonSignUp.Location = new Point(296, 147);
            buttonSignUp.Name = "buttonSignUp";
            buttonSignUp.Size = new Size(75, 23);
            buttonSignUp.TabIndex = 5;
            buttonSignUp.Text = "Sign up";
            buttonSignUp.UseVisualStyleBackColor = true;
            buttonSignUp.Click += buttonSignUp_Click;
            // 
            // buttonGuest
            // 
            buttonGuest.Location = new Point(188, 147);
            buttonGuest.Name = "buttonGuest";
            buttonGuest.Size = new Size(102, 23);
            buttonGuest.TabIndex = 6;
            buttonGuest.Text = "Log in as guest";
            buttonGuest.UseVisualStyleBackColor = true;
            buttonGuest.Click += buttonGuest_Click;
            // 
            // languageSelector
            // 
            languageSelector.FormattingEnabled = true;
            languageSelector.Items.AddRange(new object[] { "English", "Romanian" });
            languageSelector.Location = new Point(401, 12);
            languageSelector.Name = "languageSelector";
            languageSelector.Size = new Size(121, 23);
            languageSelector.TabIndex = 7;
            languageSelector.SelectedIndexChanged += languageSelector_SelectedIndexChanged;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(534, 193);
            Controls.Add(languageSelector);
            Controls.Add(buttonGuest);
            Controls.Add(buttonSignUp);
            Controls.Add(buttonLogIn);
            Controls.Add(labelPassword);
            Controls.Add(labelEmail);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxEmail);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Login";
            Text = "Log in";
            Load += LogIn_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxEmail;
        private TextBox textBoxPassword;
        private Label labelEmail;
        private Label labelPassword;
        private Button buttonLogIn;
        private Button buttonSignUp;
        private Button buttonGuest;
        private ComboBox languageSelector;
    }
}