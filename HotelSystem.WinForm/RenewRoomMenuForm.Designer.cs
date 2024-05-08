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
			listBoxNames = new ListBox();
			button_Update = new Button();
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
			button_Renew_Room.Location = new Point(71, 514);
			button_Renew_Room.Name = "button_Renew_Room";
			button_Renew_Room.Size = new Size(214, 77);
			button_Renew_Room.TabIndex = 21;
			button_Renew_Room.Text = "Продлить";
			button_Renew_Room.UseVisualStyleBackColor = true;
			button_Renew_Room.Click += Button_Renew_Room_Click;
			// 
			// button_Eviction
			// 
			button_Eviction.Location = new Point(318, 514);
			button_Eviction.Name = "button_Eviction";
			button_Eviction.Size = new Size(214, 77);
			button_Eviction.TabIndex = 22;
			button_Eviction.Text = "Выселить";
			button_Eviction.UseVisualStyleBackColor = true;
			button_Eviction.Click += Button_Eviction_Click;
			// 
			// listBoxNames
			// 
			listBoxNames.FormattingEnabled = true;
			listBoxNames.ItemHeight = 15;
			listBoxNames.Items.AddRange(new object[] { "Нажмите на \"Обновить\" чтобы отобразить информацию в этом окне", "", "", "", "" });
			listBoxNames.Location = new Point(71, 48);
			listBoxNames.Name = "listBoxNames";
			listBoxNames.Size = new Size(782, 439);
			listBoxNames.TabIndex = 29;
			// 
			// button_Update
			// 
			button_Update.Location = new Point(639, 514);
			button_Update.Name = "button_Update";
			button_Update.Size = new Size(214, 77);
			button_Update.TabIndex = 30;
			button_Update.Text = "Обновить";
			button_Update.UseVisualStyleBackColor = true;
			button_Update.Click += Button_Update_Click;
			// 
			// RenewRoomMenuForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1064, 681);
			Controls.Add(button_Update);
			Controls.Add(listBoxNames);
			Controls.Add(button_Eviction);
			Controls.Add(button_Renew_Room);
			Controls.Add(button_back_menu);
			Name = "RenewRoomMenuForm";
			Text = "RenewRoomMenuForm";
			ResumeLayout(false);
		}

		#endregion

		private Button button_back_menu;
		private Button button_Renew_Room;
		private Button button_Eviction;
		private ListBox listBoxNames;
		private Button button_Update;
	}
}