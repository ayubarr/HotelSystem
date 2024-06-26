﻿namespace HotelSystem.WinForm
{
    partial class ReservationForm
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
            button_back = new Button();
            listBox_StandartRooms = new ListBox();
            label_ReservationMenu = new Label();
            label_StandartRooms = new Label();
            label_LuxRooms = new Label();
            listBox_LuxRooms = new ListBox();
            label_VipRooms = new Label();
            listBox_VipRooms = new ListBox();
            button_Reservation = new Button();
            textBox_GuestCode = new TextBox();
            label_GuestCode = new Label();
            textBox_PaymentSum = new TextBox();
            label_PaymentSumm = new Label();
            label_GuestInputError = new Label();
            label_RegistrationEndDate = new Label();
            dateTimePicker_RegistrationEndDate = new DateTimePicker();
            label_RegistrationStartDate = new Label();
            dateTimePicker_RegistrationStartDate = new DateTimePicker();
            button_DeleteRoom = new Button();
            button_CreateRoom = new Button();
            label1 = new Label();
            textBox_RoomNumber = new TextBox();
            label2 = new Label();
            listBox_RoomType = new ListBox();
            label_GuestInputError2 = new Label();
            SuspendLayout();
            // 
            // button_back
            // 
            button_back.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button_back.Location = new Point(900, 609);
            button_back.Name = "button_back";
            button_back.Size = new Size(152, 60);
            button_back.TabIndex = 21;
            button_back.Text = "Вернуться назад";
            button_back.UseVisualStyleBackColor = true;
            button_back.Click += button_back_Click;
            // 
            // listBox_StandartRooms
            // 
            listBox_StandartRooms.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            listBox_StandartRooms.FormattingEnabled = true;
            listBox_StandartRooms.ItemHeight = 25;
            listBox_StandartRooms.Location = new Point(14, 91);
            listBox_StandartRooms.Name = "listBox_StandartRooms";
            listBox_StandartRooms.Size = new Size(177, 304);
            listBox_StandartRooms.TabIndex = 29;
            listBox_StandartRooms.SelectedIndexChanged += listBox_StandartRooms_SelectedIndexChanged;
            // 
            // label_ReservationMenu
            // 
            label_ReservationMenu.AutoSize = true;
            label_ReservationMenu.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label_ReservationMenu.Location = new Point(350, 9);
            label_ReservationMenu.Name = "label_ReservationMenu";
            label_ReservationMenu.Size = new Size(320, 37);
            label_ReservationMenu.TabIndex = 30;
            label_ReservationMenu.Text = "Бронирование номеров";
            // 
            // label_StandartRooms
            // 
            label_StandartRooms.AutoSize = true;
            label_StandartRooms.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_StandartRooms.Location = new Point(14, 63);
            label_StandartRooms.Name = "label_StandartRooms";
            label_StandartRooms.Size = new Size(163, 21);
            label_StandartRooms.TabIndex = 31;
            label_StandartRooms.Text = "Стандартные номера";
            // 
            // label_LuxRooms
            // 
            label_LuxRooms.AutoSize = true;
            label_LuxRooms.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_LuxRooms.Location = new Point(197, 67);
            label_LuxRooms.Name = "label_LuxRooms";
            label_LuxRooms.Size = new Size(107, 21);
            label_LuxRooms.TabIndex = 33;
            label_LuxRooms.Text = "Люкс номера";
            // 
            // listBox_LuxRooms
            // 
            listBox_LuxRooms.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            listBox_LuxRooms.FormattingEnabled = true;
            listBox_LuxRooms.ItemHeight = 25;
            listBox_LuxRooms.Location = new Point(197, 91);
            listBox_LuxRooms.Name = "listBox_LuxRooms";
            listBox_LuxRooms.Size = new Size(177, 304);
            listBox_LuxRooms.TabIndex = 32;
            listBox_LuxRooms.SelectedIndexChanged += listBox_LuxRooms_SelectedIndexChanged;
            // 
            // label_VipRooms
            // 
            label_VipRooms.AutoSize = true;
            label_VipRooms.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_VipRooms.Location = new Point(380, 67);
            label_VipRooms.Name = "label_VipRooms";
            label_VipRooms.Size = new Size(91, 21);
            label_VipRooms.TabIndex = 35;
            label_VipRooms.Text = "Vip номера";
            // 
            // listBox_VipRooms
            // 
            listBox_VipRooms.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            listBox_VipRooms.FormattingEnabled = true;
            listBox_VipRooms.ItemHeight = 25;
            listBox_VipRooms.Location = new Point(380, 91);
            listBox_VipRooms.Name = "listBox_VipRooms";
            listBox_VipRooms.Size = new Size(177, 304);
            listBox_VipRooms.TabIndex = 34;
            listBox_VipRooms.SelectedIndexChanged += listBox_VipRooms_SelectedIndexChanged;
            // 
            // button_Reservation
            // 
            button_Reservation.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_Reservation.Location = new Point(180, 579);
            button_Reservation.Name = "button_Reservation";
            button_Reservation.Size = new Size(181, 54);
            button_Reservation.TabIndex = 36;
            button_Reservation.Text = "Забронировать номер";
            button_Reservation.UseVisualStyleBackColor = true;
            button_Reservation.Click += button_Reservation_Click;
            // 
            // textBox_GuestCode
            // 
            textBox_GuestCode.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_GuestCode.Location = new Point(14, 466);
            textBox_GuestCode.Name = "textBox_GuestCode";
            textBox_GuestCode.Size = new Size(405, 32);
            textBox_GuestCode.TabIndex = 39;
            // 
            // label_GuestCode
            // 
            label_GuestCode.AutoSize = true;
            label_GuestCode.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label_GuestCode.Location = new Point(14, 438);
            label_GuestCode.Name = "label_GuestCode";
            label_GuestCode.Size = new Size(407, 25);
            label_GuestCode.TabIndex = 37;
            label_GuestCode.Text = "Номер гостя, зарегестрированного в системе";
            // 
            // textBox_PaymentSum
            // 
            textBox_PaymentSum.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_PaymentSum.Location = new Point(12, 535);
            textBox_PaymentSum.Name = "textBox_PaymentSum";
            textBox_PaymentSum.Size = new Size(405, 32);
            textBox_PaymentSum.TabIndex = 41;
            // 
            // label_PaymentSumm
            // 
            label_PaymentSumm.AutoSize = true;
            label_PaymentSumm.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label_PaymentSumm.Location = new Point(14, 507);
            label_PaymentSumm.Name = "label_PaymentSumm";
            label_PaymentSumm.Size = new Size(179, 25);
            label_PaymentSumm.TabIndex = 40;
            label_PaymentSumm.Text = "Оплаченная сумма";
            // 
            // label_GuestInputError
            // 
            label_GuestInputError.AutoSize = true;
            label_GuestInputError.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_GuestInputError.ForeColor = Color.Red;
            label_GuestInputError.Location = new Point(62, 417);
            label_GuestInputError.Name = "label_GuestInputError";
            label_GuestInputError.Size = new Size(451, 21);
            label_GuestInputError.TabIndex = 42;
            label_GuestInputError.Text = "Заполните обязательные поля, и выберите свободный номер";
            label_GuestInputError.Visible = false;
            // 
            // label_RegistrationEndDate
            // 
            label_RegistrationEndDate.AutoSize = true;
            label_RegistrationEndDate.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label_RegistrationEndDate.Location = new Point(427, 507);
            label_RegistrationEndDate.Name = "label_RegistrationEndDate";
            label_RegistrationEndDate.Size = new Size(225, 25);
            label_RegistrationEndDate.TabIndex = 46;
            label_RegistrationEndDate.Text = "Окончание регистрации";
            // 
            // dateTimePicker_RegistrationEndDate
            // 
            dateTimePicker_RegistrationEndDate.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker_RegistrationEndDate.Location = new Point(427, 535);
            dateTimePicker_RegistrationEndDate.Name = "dateTimePicker_RegistrationEndDate";
            dateTimePicker_RegistrationEndDate.Size = new Size(291, 32);
            dateTimePicker_RegistrationEndDate.TabIndex = 45;
            // 
            // label_RegistrationStartDate
            // 
            label_RegistrationStartDate.AutoSize = true;
            label_RegistrationStartDate.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label_RegistrationStartDate.Location = new Point(427, 438);
            label_RegistrationStartDate.Name = "label_RegistrationStartDate";
            label_RegistrationStartDate.Size = new Size(192, 25);
            label_RegistrationStartDate.TabIndex = 44;
            label_RegistrationStartDate.Text = "Начало регистрации";
            // 
            // dateTimePicker_RegistrationStartDate
            // 
            dateTimePicker_RegistrationStartDate.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker_RegistrationStartDate.Format = DateTimePickerFormat.Custom;
            dateTimePicker_RegistrationStartDate.Location = new Point(427, 466);
            dateTimePicker_RegistrationStartDate.Name = "dateTimePicker_RegistrationStartDate";
            dateTimePicker_RegistrationStartDate.Size = new Size(291, 32);
            dateTimePicker_RegistrationStartDate.TabIndex = 43;
            // 
            // button_DeleteRoom
            // 
            button_DeleteRoom.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_DeleteRoom.Location = new Point(12, 579);
            button_DeleteRoom.Name = "button_DeleteRoom";
            button_DeleteRoom.Size = new Size(148, 54);
            button_DeleteRoom.TabIndex = 47;
            button_DeleteRoom.Text = "Удалить номер";
            button_DeleteRoom.UseVisualStyleBackColor = true;
            button_DeleteRoom.Click += button_DeleteRoom_Click;
            // 
            // button_CreateRoom
            // 
            button_CreateRoom.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_CreateRoom.Location = new Point(746, 322);
            button_CreateRoom.Name = "button_CreateRoom";
            button_CreateRoom.Size = new Size(148, 48);
            button_CreateRoom.TabIndex = 48;
            button_CreateRoom.Text = "Добавить номер";
            button_CreateRoom.UseVisualStyleBackColor = true;
            button_CreateRoom.Click += button_CreateRoom_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(727, 103);
            label1.Name = "label1";
            label1.Size = new Size(136, 21);
            label1.TabIndex = 50;
            label1.Text = "Название номера";
            // 
            // textBox_RoomNumber
            // 
            textBox_RoomNumber.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_RoomNumber.Location = new Point(727, 127);
            textBox_RoomNumber.Name = "textBox_RoomNumber";
            textBox_RoomNumber.Size = new Size(193, 32);
            textBox_RoomNumber.TabIndex = 51;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(729, 176);
            label2.Name = "label2";
            label2.Size = new Size(94, 21);
            label2.TabIndex = 52;
            label2.Text = "Тип номера";
            // 
            // listBox_RoomType
            // 
            listBox_RoomType.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            listBox_RoomType.FormattingEnabled = true;
            listBox_RoomType.ItemHeight = 25;
            listBox_RoomType.Items.AddRange(new object[] { "Стандарт", "Люкс", "VIP" });
            listBox_RoomType.Location = new Point(729, 200);
            listBox_RoomType.Name = "listBox_RoomType";
            listBox_RoomType.Size = new Size(191, 104);
            listBox_RoomType.TabIndex = 53;
            // 
            // label_GuestInputError2
            // 
            label_GuestInputError2.AutoSize = true;
            label_GuestInputError2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_GuestInputError2.ForeColor = Color.Red;
            label_GuestInputError2.Location = new Point(713, 298);
            label_GuestInputError2.Name = "label_GuestInputError2";
            label_GuestInputError2.Size = new Size(228, 21);
            label_GuestInputError2.TabIndex = 54;
            label_GuestInputError2.Text = "Заполните обязательные поля";
            label_GuestInputError2.Visible = false;
            // 
            // ReservationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 681);
            Controls.Add(label_GuestInputError2);
            Controls.Add(listBox_RoomType);
            Controls.Add(label2);
            Controls.Add(textBox_RoomNumber);
            Controls.Add(label1);
            Controls.Add(button_CreateRoom);
            Controls.Add(button_DeleteRoom);
            Controls.Add(label_RegistrationEndDate);
            Controls.Add(dateTimePicker_RegistrationEndDate);
            Controls.Add(label_RegistrationStartDate);
            Controls.Add(dateTimePicker_RegistrationStartDate);
            Controls.Add(label_GuestInputError);
            Controls.Add(textBox_PaymentSum);
            Controls.Add(label_PaymentSumm);
            Controls.Add(textBox_GuestCode);
            Controls.Add(label_GuestCode);
            Controls.Add(button_Reservation);
            Controls.Add(label_VipRooms);
            Controls.Add(listBox_VipRooms);
            Controls.Add(label_LuxRooms);
            Controls.Add(listBox_LuxRooms);
            Controls.Add(label_StandartRooms);
            Controls.Add(label_ReservationMenu);
            Controls.Add(listBox_StandartRooms);
            Controls.Add(button_back);
            Name = "ReservationForm";
            Text = "ReservationForm";
            FormClosing += ReservationForm_FormClosing;
            Load += ReservationForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_back;
        private ListBox listBox_StandartRooms;
        private Label label_ReservationMenu;
        private Label label_StandartRooms;
        private Label label_LuxRooms;
        private ListBox listBox_LuxRooms;
        private Label label_VipRooms;
        private ListBox listBox_VipRooms;
        private Button button_Reservation;
        private TextBox textBox_GuestCode;
        private Label label_GuestCode;
        private TextBox textBox_PaymentSum;
        private Label label_PaymentSumm;
        private Label label_GuestInputError;
        private Label label_RegistrationEndDate;
        private DateTimePicker dateTimePicker_RegistrationEndDate;
        private Label label_RegistrationStartDate;
        private DateTimePicker dateTimePicker_RegistrationStartDate;
        private Button button_DeleteRoom;
        private Button button_CreateRoom;
        private Label label1;
        private TextBox textBox_RoomNumber;
        private Label label2;
        private ListBox listBox_RoomType;
        private Label label_GuestInputError2;
    }
}