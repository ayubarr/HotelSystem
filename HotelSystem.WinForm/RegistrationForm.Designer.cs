namespace HotelSystem.WinForm
{
    partial class RegistrationForm
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
            label_entryRegistration = new Label();
            richTextBox_PasswordRegistration = new RichTextBox();
            richTextBox_LoginRegistration = new RichTextBox();
            label_PasswordRegistration = new Label();
            label_loginRegistration = new Label();
            richTextBox_ConfirmRegistration = new RichTextBox();
            label_ConfirmRegistration = new Label();
            button_Registration = new Button();
            label_ErrorLogin = new Label();
            label_ErrorPassword = new Label();
            label_ErrorConfirm = new Label();
            SuspendLayout();
            // 
            // label_entryRegistration
            // 
            label_entryRegistration.AutoSize = true;
            label_entryRegistration.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label_entryRegistration.Location = new Point(390, 12);
            label_entryRegistration.Name = "label_entryRegistration";
            label_entryRegistration.Size = new Size(378, 81);
            label_entryRegistration.TabIndex = 1;
            label_entryRegistration.Text = "Регистрация";
            // 
            // richTextBox_PasswordRegistration
            // 
            richTextBox_PasswordRegistration.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox_PasswordRegistration.Location = new Point(258, 323);
            richTextBox_PasswordRegistration.Margin = new Padding(3, 4, 3, 4);
            richTextBox_PasswordRegistration.Name = "richTextBox_PasswordRegistration";
            richTextBox_PasswordRegistration.Size = new Size(619, 51);
            richTextBox_PasswordRegistration.TabIndex = 10;
            richTextBox_PasswordRegistration.Text = "";
            // 
            // richTextBox_LoginRegistration
            // 
            richTextBox_LoginRegistration.BackColor = SystemColors.Window;
            richTextBox_LoginRegistration.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox_LoginRegistration.ForeColor = SystemColors.WindowText;
            richTextBox_LoginRegistration.Location = new Point(258, 181);
            richTextBox_LoginRegistration.Margin = new Padding(3, 4, 3, 4);
            richTextBox_LoginRegistration.Name = "richTextBox_LoginRegistration";
            richTextBox_LoginRegistration.Size = new Size(619, 51);
            richTextBox_LoginRegistration.TabIndex = 9;
            richTextBox_LoginRegistration.Text = "";
            // 
            // label_PasswordRegistration
            // 
            label_PasswordRegistration.AutoSize = true;
            label_PasswordRegistration.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label_PasswordRegistration.Location = new Point(258, 269);
            label_PasswordRegistration.Name = "label_PasswordRegistration";
            label_PasswordRegistration.Size = new Size(136, 46);
            label_PasswordRegistration.TabIndex = 8;
            label_PasswordRegistration.Text = "Пароль";
            // 
            // label_loginRegistration
            // 
            label_loginRegistration.AutoSize = true;
            label_loginRegistration.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label_loginRegistration.Location = new Point(258, 128);
            label_loginRegistration.Name = "label_loginRegistration";
            label_loginRegistration.Size = new Size(116, 46);
            label_loginRegistration.TabIndex = 7;
            label_loginRegistration.Text = "Логин";
            // 
            // richTextBox_ConfirmRegistration
            // 
            richTextBox_ConfirmRegistration.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox_ConfirmRegistration.Location = new Point(258, 464);
            richTextBox_ConfirmRegistration.Margin = new Padding(3, 4, 3, 4);
            richTextBox_ConfirmRegistration.Name = "richTextBox_ConfirmRegistration";
            richTextBox_ConfirmRegistration.Size = new Size(619, 51);
            richTextBox_ConfirmRegistration.TabIndex = 10;
            richTextBox_ConfirmRegistration.Text = "";
            // 
            // label_ConfirmRegistration
            // 
            label_ConfirmRegistration.AutoSize = true;
            label_ConfirmRegistration.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label_ConfirmRegistration.Location = new Point(258, 411);
            label_ConfirmRegistration.Name = "label_ConfirmRegistration";
            label_ConfirmRegistration.Size = new Size(394, 46);
            label_ConfirmRegistration.TabIndex = 12;
            label_ConfirmRegistration.Text = "Подтверждение пароля";
            // 
            // button_Registration
            // 
            button_Registration.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button_Registration.Location = new Point(443, 568);
            button_Registration.Margin = new Padding(3, 4, 3, 4);
            button_Registration.Name = "button_Registration";
            button_Registration.Size = new Size(247, 67);
            button_Registration.TabIndex = 13;
            button_Registration.Text = "Зарегестрировать";
            button_Registration.UseCompatibleTextRendering = true;
            button_Registration.UseVisualStyleBackColor = true;
            button_Registration.Click += button_Registration_Click;
            // 
            // label_ErrorLogin
            // 
            label_ErrorLogin.AutoSize = true;
            label_ErrorLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_ErrorLogin.ForeColor = Color.Red;
            label_ErrorLogin.Location = new Point(473, 237);
            label_ErrorLogin.Name = "label_ErrorLogin";
            label_ErrorLogin.Size = new Size(194, 28);
            label_ErrorLogin.TabIndex = 14;
            label_ErrorLogin.Text = "Заполните это поле";
            // 
            // label_ErrorPassword
            // 
            label_ErrorPassword.AutoSize = true;
            label_ErrorPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_ErrorPassword.ForeColor = Color.Red;
            label_ErrorPassword.Location = new Point(473, 379);
            label_ErrorPassword.Name = "label_ErrorPassword";
            label_ErrorPassword.Size = new Size(194, 28);
            label_ErrorPassword.TabIndex = 15;
            label_ErrorPassword.Text = "Заполните это поле";
            // 
            // label_ErrorConfirm
            // 
            label_ErrorConfirm.AutoSize = true;
            label_ErrorConfirm.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_ErrorConfirm.ForeColor = Color.Red;
            label_ErrorConfirm.Location = new Point(473, 520);
            label_ErrorConfirm.Name = "label_ErrorConfirm";
            label_ErrorConfirm.Size = new Size(194, 28);
            label_ErrorConfirm.TabIndex = 16;
            label_ErrorConfirm.Text = "Заполните это поле";
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1216, 908);
            Controls.Add(label_ErrorConfirm);
            Controls.Add(label_ErrorPassword);
            Controls.Add(label_ErrorLogin);
            Controls.Add(button_Registration);
            Controls.Add(label_ConfirmRegistration);
            Controls.Add(richTextBox_ConfirmRegistration);
            Controls.Add(richTextBox_PasswordRegistration);
            Controls.Add(richTextBox_LoginRegistration);
            Controls.Add(label_PasswordRegistration);
            Controls.Add(label_loginRegistration);
            Controls.Add(label_entryRegistration);
            Margin = new Padding(3, 4, 3, 4);
            Name = "RegistrationForm";
            Text = "RegistrationForm";
            Load += RegistrationForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_entryRegistration;
        private RichTextBox richTextBox_PasswordRegistration;
        private RichTextBox richTextBox_LoginRegistration;
        private Label label_PasswordRegistration;
        private Label label_loginRegistration;
        private RichTextBox richTextBox_ConfirmRegistration;
        private Label label_ConfirmRegistration;
        private Button button_Registration;
        private Label label_ErrorLogin;
        private Label label_ErrorPassword;
        private Label label_ErrorConfirm;
    }
}