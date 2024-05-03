namespace HotelSystem.WinForm
{
    partial class GuestRegitrationForm
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
            button_GuestRegistration = new Button();
            label_GuestRegistr = new Label();
            label_LastName = new Label();
            label_FirstName = new Label();
            label_MiddleName = new Label();
            textBox_LastName = new TextBox();
            textBox_FirstName = new TextBox();
            textBox_MiddleName = new TextBox();
            textBox_PhoneNumber = new TextBox();
            textBox_Email = new TextBox();
            label_PhoneNumber = new Label();
            label_Email = new Label();
            dateTimePicker_RegistrationStartDate = new DateTimePicker();
            label_RegistrationStartDate = new Label();
            label_RegistrationEndDate = new Label();
            dateTimePicker_RegistrationEndDate = new DateTimePicker();
            label1 = new Label();
            label_GuestInputError = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // button_GuestRegistration
            // 
            button_GuestRegistration.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button_GuestRegistration.Location = new Point(363, 531);
            button_GuestRegistration.Name = "button_GuestRegistration";
            button_GuestRegistration.Size = new Size(313, 42);
            button_GuestRegistration.TabIndex = 0;
            button_GuestRegistration.Text = "Зарегестрировать гостя";
            button_GuestRegistration.UseVisualStyleBackColor = true;
            button_GuestRegistration.Click += button_GuestRegistr_Click;
            // 
            // label_GuestRegistr
            // 
            label_GuestRegistr.AutoSize = true;
            label_GuestRegistr.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label_GuestRegistr.Location = new Point(264, 7);
            label_GuestRegistr.Name = "label_GuestRegistr";
            label_GuestRegistr.Size = new Size(447, 32);
            label_GuestRegistr.TabIndex = 1;
            label_GuestRegistr.Text = "Регистрация новых жильцов в системе";
            // 
            // label_LastName
            // 
            label_LastName.AutoSize = true;
            label_LastName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label_LastName.Location = new Point(83, 78);
            label_LastName.Name = "label_LastName";
            label_LastName.Size = new Size(143, 25);
            label_LastName.TabIndex = 2;
            label_LastName.Text = "Фамилия Гостя";
            // 
            // label_FirstName
            // 
            label_FirstName.AutoSize = true;
            label_FirstName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label_FirstName.Location = new Point(83, 136);
            label_FirstName.Name = "label_FirstName";
            label_FirstName.Size = new Size(101, 25);
            label_FirstName.TabIndex = 3;
            label_FirstName.Text = "Имя Гостя";
            // 
            // label_MiddleName
            // 
            label_MiddleName.AutoSize = true;
            label_MiddleName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label_MiddleName.Location = new Point(83, 197);
            label_MiddleName.Name = "label_MiddleName";
            label_MiddleName.Size = new Size(145, 25);
            label_MiddleName.TabIndex = 4;
            label_MiddleName.Text = "Отчество Гостя";
            // 
            // textBox_LastName
            // 
            textBox_LastName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_LastName.Location = new Point(83, 106);
            textBox_LastName.Name = "textBox_LastName";
            textBox_LastName.Size = new Size(401, 32);
            textBox_LastName.TabIndex = 5;
            // 
            // textBox_FirstName
            // 
            textBox_FirstName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_FirstName.Location = new Point(83, 164);
            textBox_FirstName.Name = "textBox_FirstName";
            textBox_FirstName.Size = new Size(401, 32);
            textBox_FirstName.TabIndex = 6;
            // 
            // textBox_MiddleName
            // 
            textBox_MiddleName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_MiddleName.Location = new Point(83, 225);
            textBox_MiddleName.Name = "textBox_MiddleName";
            textBox_MiddleName.Size = new Size(401, 32);
            textBox_MiddleName.TabIndex = 7;
            // 
            // textBox_PhoneNumber
            // 
            textBox_PhoneNumber.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_PhoneNumber.Location = new Point(83, 410);
            textBox_PhoneNumber.Name = "textBox_PhoneNumber";
            textBox_PhoneNumber.Size = new Size(401, 32);
            textBox_PhoneNumber.TabIndex = 11;
            // 
            // textBox_Email
            // 
            textBox_Email.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_Email.Location = new Point(83, 349);
            textBox_Email.Name = "textBox_Email";
            textBox_Email.Size = new Size(401, 32);
            textBox_Email.TabIndex = 10;
            // 
            // label_PhoneNumber
            // 
            label_PhoneNumber.AutoSize = true;
            label_PhoneNumber.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label_PhoneNumber.Location = new Point(83, 382);
            label_PhoneNumber.Name = "label_PhoneNumber";
            label_PhoneNumber.Size = new Size(210, 25);
            label_PhoneNumber.TabIndex = 9;
            label_PhoneNumber.Text = "Номер телефона Гостя";
            // 
            // label_Email
            // 
            label_Email.AutoSize = true;
            label_Email.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label_Email.Location = new Point(83, 321);
            label_Email.Name = "label_Email";
            label_Email.Size = new Size(118, 25);
            label_Email.TabIndex = 8;
            label_Email.Text = "Почта Гостя";
            // 
            // dateTimePicker_RegistrationStartDate
            // 
            dateTimePicker_RegistrationStartDate.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker_RegistrationStartDate.Format = DateTimePickerFormat.Custom;
            dateTimePicker_RegistrationStartDate.Location = new Point(639, 106);
            dateTimePicker_RegistrationStartDate.Name = "dateTimePicker_RegistrationStartDate";
            dateTimePicker_RegistrationStartDate.Size = new Size(291, 32);
            dateTimePicker_RegistrationStartDate.TabIndex = 12;
            // 
            // label_RegistrationStartDate
            // 
            label_RegistrationStartDate.AutoSize = true;
            label_RegistrationStartDate.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label_RegistrationStartDate.Location = new Point(639, 78);
            label_RegistrationStartDate.Name = "label_RegistrationStartDate";
            label_RegistrationStartDate.Size = new Size(192, 25);
            label_RegistrationStartDate.TabIndex = 13;
            label_RegistrationStartDate.Text = "Начало регистрации";
            // 
            // label_RegistrationEndDate
            // 
            label_RegistrationEndDate.AutoSize = true;
            label_RegistrationEndDate.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label_RegistrationEndDate.Location = new Point(639, 197);
            label_RegistrationEndDate.Name = "label_RegistrationEndDate";
            label_RegistrationEndDate.Size = new Size(225, 25);
            label_RegistrationEndDate.TabIndex = 15;
            label_RegistrationEndDate.Text = "Окончание регистрации";
            // 
            // dateTimePicker_RegistrationEndDate
            // 
            dateTimePicker_RegistrationEndDate.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker_RegistrationEndDate.Location = new Point(639, 225);
            dateTimePicker_RegistrationEndDate.Name = "dateTimePicker_RegistrationEndDate";
            dateTimePicker_RegistrationEndDate.Size = new Size(291, 32);
            dateTimePicker_RegistrationEndDate.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(148, 289);
            label1.Name = "label1";
            label1.Size = new Size(269, 19);
            label1.TabIndex = 16;
            label1.Text = "Контакная Информация(не обязательно)";
            // 
            // label_GuestInputError
            // 
            label_GuestInputError.AutoSize = true;
            label_GuestInputError.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_GuestInputError.ForeColor = Color.Red;
            label_GuestInputError.Location = new Point(416, 486);
            label_GuestInputError.Name = "label_GuestInputError";
            label_GuestInputError.Size = new Size(228, 21);
            label_GuestInputError.TabIndex = 17;
            label_GuestInputError.Text = "Заполните обязательные поля";
            label_GuestInputError.Visible = false;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(900, 609);
            button1.Name = "button1";
            button1.Size = new Size(152, 60);
            button1.TabIndex = 18;
            button1.Text = "Вернуться назад";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // GuestRegitrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 681);
            Controls.Add(button1);
            Controls.Add(label_GuestInputError);
            Controls.Add(label1);
            Controls.Add(label_RegistrationEndDate);
            Controls.Add(dateTimePicker_RegistrationEndDate);
            Controls.Add(label_RegistrationStartDate);
            Controls.Add(dateTimePicker_RegistrationStartDate);
            Controls.Add(textBox_PhoneNumber);
            Controls.Add(textBox_Email);
            Controls.Add(label_PhoneNumber);
            Controls.Add(label_Email);
            Controls.Add(textBox_MiddleName);
            Controls.Add(textBox_FirstName);
            Controls.Add(textBox_LastName);
            Controls.Add(label_MiddleName);
            Controls.Add(label_FirstName);
            Controls.Add(label_LastName);
            Controls.Add(label_GuestRegistr);
            Controls.Add(button_GuestRegistration);
            Name = "GuestRegitrationForm";
            Text = "GuestRegitrationForm";
            Load += GuestRegitrationForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_GuestRegistration;
        private Label label_GuestRegistr;
        private Label label_LastName;
        private Label label_FirstName;
        private Label label_MiddleName;
        private TextBox textBox_LastName;
        private TextBox textBox_FirstName;
        private TextBox textBox_MiddleName;
        private TextBox textBox_PhoneNumber;
        private TextBox textBox_Email;
        private Label label_PhoneNumber;
        private Label label_Email;
        private DateTimePicker dateTimePicker_RegistrationStartDate;
        private Label label_RegistrationStartDate;
        private Label label_RegistrationEndDate;
        private DateTimePicker dateTimePicker_RegistrationEndDate;
        private Label label1;
        private Label label_GuestInputError;
        private Button button1;
    }
}