namespace HotelSystem.WinForm
{
    partial class MainMenu
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
            button_Reservation = new Button();
            label_Reservation = new Label();
            label_MainMenu = new Label();
            button_ClientRegistration = new Button();
            label_ClientRegistration = new Label();
            button_Prolongation = new Button();
            label_Prolongation = new Label();
            button_GetInformation = new Button();
            label_GetInformation = new Label();
            SuspendLayout();
            // 
            // button_Reservation
            // 
            button_Reservation.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_Reservation.Location = new Point(38, 218);
            button_Reservation.Name = "button_Reservation";
            button_Reservation.Size = new Size(412, 51);
            button_Reservation.TabIndex = 0;
            button_Reservation.Text = "Забронировать";
            button_Reservation.UseVisualStyleBackColor = true;
            // 
            // label_Reservation
            // 
            label_Reservation.AutoSize = true;
            label_Reservation.FlatStyle = FlatStyle.System;
            label_Reservation.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label_Reservation.Location = new Point(108, 183);
            label_Reservation.Name = "label_Reservation";
            label_Reservation.Size = new Size(269, 32);
            label_Reservation.TabIndex = 1;
            label_Reservation.Text = "Бронирование номера";
            // 
            // label_MainMenu
            // 
            label_MainMenu.AutoSize = true;
            label_MainMenu.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label_MainMenu.Location = new Point(499, 9);
            label_MainMenu.Name = "label_MainMenu";
            label_MainMenu.Size = new Size(246, 46);
            label_MainMenu.TabIndex = 2;
            label_MainMenu.Text = "Главное меню";
            // 
            // button_ClientRegistration
            // 
            button_ClientRegistration.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_ClientRegistration.Location = new Point(763, 218);
            button_ClientRegistration.Name = "button_ClientRegistration";
            button_ClientRegistration.Size = new Size(412, 51);
            button_ClientRegistration.TabIndex = 3;
            button_ClientRegistration.Text = "Зарегестрировать";
            button_ClientRegistration.UseVisualStyleBackColor = true;
            // 
            // label_ClientRegistration
            // 
            label_ClientRegistration.AutoSize = true;
            label_ClientRegistration.FlatStyle = FlatStyle.System;
            label_ClientRegistration.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label_ClientRegistration.Location = new Point(856, 183);
            label_ClientRegistration.Name = "label_ClientRegistration";
            label_ClientRegistration.Size = new Size(255, 32);
            label_ClientRegistration.TabIndex = 4;
            label_ClientRegistration.Text = "Регистрация жильцов";
            // 
            // button_Prolongation
            // 
            button_Prolongation.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_Prolongation.Location = new Point(38, 376);
            button_Prolongation.Name = "button_Prolongation";
            button_Prolongation.Size = new Size(412, 51);
            button_Prolongation.TabIndex = 5;
            button_Prolongation.Text = "Продлить";
            button_Prolongation.UseVisualStyleBackColor = true;
            // 
            // label_Prolongation
            // 
            label_Prolongation.AutoSize = true;
            label_Prolongation.FlatStyle = FlatStyle.System;
            label_Prolongation.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label_Prolongation.Location = new Point(119, 341);
            label_Prolongation.Name = "label_Prolongation";
            label_Prolongation.Size = new Size(230, 32);
            label_Prolongation.TabIndex = 6;
            label_Prolongation.Text = "Продление номера";
            // 
            // button_GetInformation
            // 
            button_GetInformation.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_GetInformation.Location = new Point(763, 376);
            button_GetInformation.Name = "button_GetInformation";
            button_GetInformation.Size = new Size(412, 51);
            button_GetInformation.TabIndex = 7;
            button_GetInformation.Text = "Информация";
            button_GetInformation.UseVisualStyleBackColor = true;
            // 
            // label_GetInformation
            // 
            label_GetInformation.AutoSize = true;
            label_GetInformation.FlatStyle = FlatStyle.System;
            label_GetInformation.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label_GetInformation.Location = new Point(856, 341);
            label_GetInformation.Name = "label_GetInformation";
            label_GetInformation.Size = new Size(232, 32);
            label_GetInformation.TabIndex = 8;
            label_GetInformation.Text = "Поиск информации";
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1216, 908);
            Controls.Add(label_GetInformation);
            Controls.Add(button_GetInformation);
            Controls.Add(label_Prolongation);
            Controls.Add(button_Prolongation);
            Controls.Add(label_ClientRegistration);
            Controls.Add(button_ClientRegistration);
            Controls.Add(label_MainMenu);
            Controls.Add(label_Reservation);
            Controls.Add(button_Reservation);
            Name = "MainMenu";
            Text = "MainMenu";
            Load += MainMenu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_Reservation;
        private Label label_Reservation;
        private Label label_MainMenu;
        private Button button_ClientRegistration;
        private Label label_ClientRegistration;
        private Button button_Prolongation;
        private Label label_Prolongation;
        private Button button_GetInformation;
        private Label label_GetInformation;
    }
}