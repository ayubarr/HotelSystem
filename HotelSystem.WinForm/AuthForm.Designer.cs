namespace HotelSystem.WinForm
{
    partial class AuthForm
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
            label_entry = new Label();
            label_login = new Label();
            label2 = new Label();
            checkBox_SaveUser = new CheckBox();
            richTextBox_Login = new RichTextBox();
            richTextBox_Password = new RichTextBox();
            button_Login = new Button();
            label_ErrorLogin = new Label();
            label_ErrorPassword = new Label();
            label1 = new Label();
            button_GoToRegistration = new Button();
            SuspendLayout();
            // 
            // label_entry
            // 
            label_entry.AutoSize = true;
            label_entry.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label_entry.Location = new Point(439, 27);
            label_entry.Name = "label_entry";
            label_entry.Size = new Size(132, 65);
            label_entry.TabIndex = 0;
            label_entry.Text = "Вход";
            // 
            // label_login
            // 
            label_login.AutoSize = true;
            label_login.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label_login.Location = new Point(253, 140);
            label_login.Name = "label_login";
            label_login.Size = new Size(93, 37);
            label_login.TabIndex = 1;
            label_login.Text = "Логин";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(253, 246);
            label2.Name = "label2";
            label2.Size = new Size(110, 37);
            label2.TabIndex = 2;
            label2.Text = "Пароль";
            // 
            // checkBox_SaveUser
            // 
            checkBox_SaveUser.AutoSize = true;
            checkBox_SaveUser.BackColor = SystemColors.ButtonFace;
            checkBox_SaveUser.BackgroundImageLayout = ImageLayout.Zoom;
            checkBox_SaveUser.Location = new Point(253, 331);
            checkBox_SaveUser.Name = "checkBox_SaveUser";
            checkBox_SaveUser.Size = new Size(118, 19);
            checkBox_SaveUser.TabIndex = 3;
            checkBox_SaveUser.Text = "Запомнить меня";
            checkBox_SaveUser.UseVisualStyleBackColor = false;
            // 
            // richTextBox_Login
            // 
            richTextBox_Login.BackColor = SystemColors.Window;
            richTextBox_Login.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox_Login.ForeColor = SystemColors.WindowText;
            richTextBox_Login.Location = new Point(253, 180);
            richTextBox_Login.Name = "richTextBox_Login";
            richTextBox_Login.Size = new Size(542, 39);
            richTextBox_Login.TabIndex = 5;
            richTextBox_Login.Text = "";
            // 
            // richTextBox_Password
            // 
            richTextBox_Password.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox_Password.Location = new Point(253, 286);
            richTextBox_Password.Name = "richTextBox_Password";
            richTextBox_Password.Size = new Size(542, 39);
            richTextBox_Password.TabIndex = 6;
            richTextBox_Password.Text = "";
            // 
            // button_Login
            // 
            button_Login.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button_Login.Location = new Point(408, 375);
            button_Login.Name = "button_Login";
            button_Login.Size = new Size(200, 50);
            button_Login.TabIndex = 8;
            button_Login.Text = "Войти";
            button_Login.UseCompatibleTextRendering = true;
            button_Login.UseVisualStyleBackColor = true;
            button_Login.Click += button_Login_Click;
            // 
            // label_ErrorLogin
            // 
            label_ErrorLogin.AutoSize = true;
            label_ErrorLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_ErrorLogin.ForeColor = Color.Red;
            label_ErrorLogin.Location = new Point(446, 223);
            label_ErrorLogin.Name = "label_ErrorLogin";
            label_ErrorLogin.Size = new Size(151, 21);
            label_ErrorLogin.TabIndex = 9;
            label_ErrorLogin.Text = "Заполните это поле";
            // 
            // label_ErrorPassword
            // 
            label_ErrorPassword.AutoSize = true;
            label_ErrorPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_ErrorPassword.ForeColor = Color.Red;
            label_ErrorPassword.Location = new Point(439, 327);
            label_ErrorPassword.Name = "label_ErrorPassword";
            label_ErrorPassword.Size = new Size(151, 21);
            label_ErrorPassword.TabIndex = 10;
            label_ErrorPassword.Text = "Заполните это поле";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(446, 450);
            label1.Name = "label1";
            label1.Size = new Size(111, 21);
            label1.TabIndex = 11;
            label1.Text = "Нет аккаунта?";
            // 
            // button_GoToRegistration
            // 
            button_GoToRegistration.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button_GoToRegistration.Location = new Point(365, 474);
            button_GoToRegistration.Name = "button_GoToRegistration";
            button_GoToRegistration.Size = new Size(290, 46);
            button_GoToRegistration.TabIndex = 12;
            button_GoToRegistration.Text = "Зарегестрировать Аккаунт";
            button_GoToRegistration.UseVisualStyleBackColor = true;
            button_GoToRegistration.Click += button_GoToRegistration_Click;
            // 
            // AuthForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 681);
            Controls.Add(button_GoToRegistration);
            Controls.Add(label1);
            Controls.Add(label_ErrorPassword);
            Controls.Add(label_ErrorLogin);
            Controls.Add(button_Login);
            Controls.Add(richTextBox_Password);
            Controls.Add(richTextBox_Login);
            Controls.Add(checkBox_SaveUser);
            Controls.Add(label2);
            Controls.Add(label_login);
            Controls.Add(label_entry);
            Name = "AuthForm";
            Text = "Hotel System";
            FormClosing += AuthForm_FormClosing;
            Load += AuthForm_Load;
            Click += AuthForm_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_entry;
        private Label label_login;
        private Label label2;
        private CheckBox checkBox_SaveUser;
        private RichTextBox richTextBox_Login;
        private RichTextBox richTextBox_Password;
        private Button button_Login;
        private Label label_ErrorLogin;
        private Label label_ErrorPassword;
        private Label label1;
        private Button button_GoToRegistration;
    }
}
