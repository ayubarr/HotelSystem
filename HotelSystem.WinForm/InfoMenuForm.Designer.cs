namespace HotelSystem.WinForm
{
	partial class InfoMenuForm
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
			label_MainMenu = new Label();
			button_back = new Button();
			listBox1 = new ListBox();
			dataGridViewGuests = new DataGridView();
			button_InfoClients = new Button();
			label_Reservation = new Label();
			((System.ComponentModel.ISupportInitialize)dataGridViewGuests).BeginInit();
			SuspendLayout();
			// 
			// label_MainMenu
			// 
			label_MainMenu.AutoSize = true;
			label_MainMenu.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
			label_MainMenu.Location = new Point(302, 9);
			label_MainMenu.Name = "label_MainMenu";
			label_MainMenu.Size = new Size(419, 37);
			label_MainMenu.TabIndex = 3;
			label_MainMenu.Text = "Меню Для Поиска Информации";
			// 
			// button_back
			// 
			button_back.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
			button_back.Location = new Point(900, 609);
			button_back.Name = "button_back";
			button_back.Size = new Size(152, 60);
			button_back.TabIndex = 19;
			button_back.Text = "Вернуться назад";
			button_back.UseVisualStyleBackColor = true;
			button_back.Click += button_back_click;
			// 
			// listBox1
			// 
			listBox1.FormattingEnabled = true;
			listBox1.ItemHeight = 15;
			listBox1.Items.AddRange(new object[] { "Фамилия\t\tИмя\t\tОтчество" });
			listBox1.Location = new Point(34, 90);
			listBox1.Name = "listBox1";
			listBox1.Size = new Size(360, 199);
			listBox1.TabIndex = 28;
			// 
			// dataGridViewGuests
			// 
			dataGridViewGuests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewGuests.Location = new Point(34, 397);
			dataGridViewGuests.Name = "dataGridViewGuests";
			dataGridViewGuests.RowTemplate.Height = 25;
			dataGridViewGuests.Size = new Size(360, 177);
			dataGridViewGuests.TabIndex = 29;
			dataGridViewGuests.CellContentClick += dataGridViewGuests_CellContentClick;
			// 
			// button_InfoClients
			// 
			button_InfoClients.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			button_InfoClients.Location = new Point(34, 319);
			button_InfoClients.Margin = new Padding(3, 2, 3, 2);
			button_InfoClients.Name = "button_InfoClients";
			button_InfoClients.Size = new Size(360, 38);
			button_InfoClients.TabIndex = 20;
			button_InfoClients.Text = "Информация о клиентах";
			button_InfoClients.UseVisualStyleBackColor = true;
			button_InfoClients.Click += button_GetInfoGuests_Click;
			// 
			// label_Reservation
			// 
			label_Reservation.AutoSize = true;
			label_Reservation.FlatStyle = FlatStyle.System;
			label_Reservation.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
			label_Reservation.Location = new Point(95, 292);
			label_Reservation.Name = "label_Reservation";
			label_Reservation.Size = new Size(226, 25);
			label_Reservation.TabIndex = 21;
			label_Reservation.Text = "Информация о клиентах";
			// 
			// InfoMenuForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1064, 681);
			Controls.Add(dataGridViewGuests);
			Controls.Add(listBox1);
			Controls.Add(label_Reservation);
			Controls.Add(button_InfoClients);
			Controls.Add(button_back);
			Controls.Add(label_MainMenu);
			Name = "InfoMenuForm";
			Text = "InfoMenuForm";
			FormClosing += InfoMenuForm_FormClosing;
			((System.ComponentModel.ISupportInitialize)dataGridViewGuests).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label_MainMenu;
		private Button button_back;
		private ListBox listBox1;
		private DataGridView dataGridViewGuests;
		private Button button_InfoClients;
		private Label label_Reservation;
	}
}