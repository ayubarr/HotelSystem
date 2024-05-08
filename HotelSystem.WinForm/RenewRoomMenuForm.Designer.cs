namespace HotelSystem.WinForm
{
	partial class RenewRoomMenuForm
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
			button_back_menu = new Button();
			button_Renew_Room = new Button();
			button_Eviction = new Button();
			button_Update = new Button();
			listBox_StandartRooms = new ListBox();
			listBox_LuxRooms = new ListBox();
			listBox_VipRooms = new ListBox();
			label_VipRooms = new Label();
			label_LuxRooms = new Label();
			label_StandartRooms = new Label();
			label_RegistrationStartDate = new Label();
			dateTimePicker_RegistrationStartDate = new DateTimePicker();
			SuspendLayout();
			// 
			// button_back_menu
			// 
			button_back_menu.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
			button_back_menu.Location = new Point(900, 609);
			button_back_menu.Name = "button_back_menu";
			button_back_menu.Size = new Size(152, 60);
			button_back_menu.TabIndex = 20;
			button_back_menu.Text = "Вернуться назад";
			button_back_menu.UseVisualStyleBackColor = true;
			button_back_menu.Click += Button_Back_Menu_Click;
			// 
			// button_Renew_Room
			// 
			button_Renew_Room.Location = new Point(15, 496);
			button_Renew_Room.Name = "button_Renew_Room";
			button_Renew_Room.Size = new Size(270, 77);
			button_Renew_Room.TabIndex = 21;
			button_Renew_Room.Text = "Продлить";
			button_Renew_Room.UseVisualStyleBackColor = true;
			button_Renew_Room.Click += Button_Renew_Room_Click;
			// 
			// button_Eviction
			// 
			button_Eviction.Location = new Point(15, 593);
			button_Eviction.Name = "button_Eviction";
			button_Eviction.Size = new Size(270, 77);
			button_Eviction.TabIndex = 22;
			button_Eviction.Text = "Выселить";
			button_Eviction.UseVisualStyleBackColor = true;
			button_Eviction.Click += Button_Eviction_Click;
			// 
			// button_Update
			// 
			button_Update.Location = new Point(310, 593);
			button_Update.Name = "button_Update";
			button_Update.Size = new Size(270, 77);
			button_Update.TabIndex = 30;
			button_Update.Text = "Обновить";
			button_Update.UseVisualStyleBackColor = true;
			button_Update.Click += Button_Update_Click;
			// 
			// listBox_StandartRooms
			// 
			listBox_StandartRooms.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
			listBox_StandartRooms.FormattingEnabled = true;
			listBox_StandartRooms.ItemHeight = 25;
			listBox_StandartRooms.Location = new Point(15, 137);
			listBox_StandartRooms.Name = "listBox_StandartRooms";
			listBox_StandartRooms.Size = new Size(270, 304);
			listBox_StandartRooms.TabIndex = 31;
			// 
			// listBox_LuxRooms
			// 
			listBox_LuxRooms.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
			listBox_LuxRooms.FormattingEnabled = true;
			listBox_LuxRooms.ItemHeight = 25;
			listBox_LuxRooms.Location = new Point(327, 137);
			listBox_LuxRooms.Name = "listBox_LuxRooms";
			listBox_LuxRooms.Size = new Size(253, 304);
			listBox_LuxRooms.TabIndex = 33;
			// 
			// listBox_VipRooms
			// 
			listBox_VipRooms.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
			listBox_VipRooms.FormattingEnabled = true;
			listBox_VipRooms.ItemHeight = 25;
			listBox_VipRooms.Location = new Point(639, 137);
			listBox_VipRooms.Name = "listBox_VipRooms";
			listBox_VipRooms.Size = new Size(270, 304);
			listBox_VipRooms.TabIndex = 35;
			// 
			// label_VipRooms
			// 
			label_VipRooms.AutoSize = true;
			label_VipRooms.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label_VipRooms.Location = new Point(639, 100);
			label_VipRooms.Name = "label_VipRooms";
			label_VipRooms.Size = new Size(91, 21);
			label_VipRooms.TabIndex = 38;
			label_VipRooms.Text = "Vip номера";
			label_VipRooms.Click += label_VipRooms_Click;
			// 
			// label_LuxRooms
			// 
			label_LuxRooms.AutoSize = true;
			label_LuxRooms.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label_LuxRooms.Location = new Point(327, 100);
			label_LuxRooms.Name = "label_LuxRooms";
			label_LuxRooms.Size = new Size(107, 21);
			label_LuxRooms.TabIndex = 37;
			label_LuxRooms.Text = "Люкс номера";
			// 
			// label_StandartRooms
			// 
			label_StandartRooms.AutoSize = true;
			label_StandartRooms.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label_StandartRooms.Location = new Point(12, 100);
			label_StandartRooms.Name = "label_StandartRooms";
			label_StandartRooms.Size = new Size(163, 21);
			label_StandartRooms.TabIndex = 36;
			label_StandartRooms.Text = "Стандартные номера";
			// 
			// label_RegistrationStartDate
			// 
			label_RegistrationStartDate.AutoSize = true;
			label_RegistrationStartDate.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
			label_RegistrationStartDate.Location = new Point(327, 513);
			label_RegistrationStartDate.Name = "label_RegistrationStartDate";
			label_RegistrationStartDate.Size = new Size(123, 25);
			label_RegistrationStartDate.TabIndex = 48;
			label_RegistrationStartDate.Text = "Продлить до";
			// 
			// dateTimePicker_RegistrationStartDate
			// 
			dateTimePicker_RegistrationStartDate.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
			dateTimePicker_RegistrationStartDate.Format = DateTimePickerFormat.Custom;
			dateTimePicker_RegistrationStartDate.Location = new Point(310, 541);
			dateTimePicker_RegistrationStartDate.Name = "dateTimePicker_RegistrationStartDate";
			dateTimePicker_RegistrationStartDate.Size = new Size(270, 32);
			dateTimePicker_RegistrationStartDate.TabIndex = 47;
			// 
			// RenewRoomMenuForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1064, 681);
			Controls.Add(label_RegistrationStartDate);
			Controls.Add(dateTimePicker_RegistrationStartDate);
			Controls.Add(label_VipRooms);
			Controls.Add(label_LuxRooms);
			Controls.Add(label_StandartRooms);
			Controls.Add(listBox_VipRooms);
			Controls.Add(listBox_LuxRooms);
			Controls.Add(listBox_StandartRooms);
			Controls.Add(button_Update);
			Controls.Add(button_Eviction);
			Controls.Add(button_Renew_Room);
			Controls.Add(button_back_menu);
			Name = "RenewRoomMenuForm";
			Text = "RenewRoomMenuForm";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button button_back_menu;
		private Button button_Renew_Room;
		private Button button_Eviction;
		private Button button_Update;
		private ListBox listBox_StandartRooms;
		private ListBox listBox_LuxRooms;
		private ListBox listBox_VipRooms;
		private Label label_VipRooms;
		private Label label_LuxRooms;
		private Label label_StandartRooms;
		private Label label_RegistrationStartDate;
		private DateTimePicker dateTimePicker_RegistrationStartDate;
	}
}