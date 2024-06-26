﻿namespace HotelSystem.WinForm
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
			listBoxNames = new ListBox();
			button_InfoGuests = new Button();
			label_Reservation = new Label();
			button_MoreInfoGuests = new Button();
			dataGridViewMoreInfoGuests = new DataGridView();
			button_back2 = new Button();
			((System.ComponentModel.ISupportInitialize)dataGridViewMoreInfoGuests).BeginInit();
			SuspendLayout();
			// 
			// label_MainMenu
			// 
			label_MainMenu.AutoSize = true;
			label_MainMenu.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
			label_MainMenu.Location = new Point(171, 9);
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
			// listBoxNames
			// 
			listBoxNames.FormattingEnabled = true;
			listBoxNames.ItemHeight = 15;
			listBoxNames.Items.AddRange(new object[] { "Нажмите на \"Информация о клиентах\" чтобы отобразить информацию в этом окне", "", "", "", "", "" });
			listBoxNames.Location = new Point(60, 126);
			listBoxNames.Name = "listBoxNames";
			listBoxNames.Size = new Size(661, 439);
			listBoxNames.TabIndex = 28;
			listBoxNames.SelectedIndexChanged += listBoxNames_SelectedIndexChanged;
			// 
			// button_InfoGuests
			// 
			button_InfoGuests.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			button_InfoGuests.Location = new Point(60, 609);
			button_InfoGuests.Margin = new Padding(3, 2, 3, 2);
			button_InfoGuests.Name = "button_InfoGuests";
			button_InfoGuests.Size = new Size(321, 60);
			button_InfoGuests.TabIndex = 20;
			button_InfoGuests.Text = "Информация о клиентах";
			button_InfoGuests.UseVisualStyleBackColor = true;
			button_InfoGuests.Click += button_GetInfoGuests_Click;
			// 
			// label_Reservation
			// 
			label_Reservation.AutoSize = true;
			label_Reservation.FlatStyle = FlatStyle.System;
			label_Reservation.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
			label_Reservation.Location = new Point(259, 81);
			label_Reservation.Name = "label_Reservation";
			label_Reservation.Size = new Size(226, 25);
			label_Reservation.TabIndex = 21;
			label_Reservation.Text = "Информация о клиентах";
			// 
			// button_MoreInfoGuests
			// 
			button_MoreInfoGuests.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			button_MoreInfoGuests.Location = new Point(417, 609);
			button_MoreInfoGuests.Margin = new Padding(3, 2, 3, 2);
			button_MoreInfoGuests.Name = "button_MoreInfoGuests";
			button_MoreInfoGuests.Size = new Size(304, 60);
			button_MoreInfoGuests.TabIndex = 30;
			button_MoreInfoGuests.Text = "Подробная информация о клиентах";
			button_MoreInfoGuests.UseVisualStyleBackColor = true;
			button_MoreInfoGuests.Click += button_GetMoreInfoGuests_Click;
			// 
			// dataGridViewMoreInfoGuests
			// 
			dataGridViewMoreInfoGuests.AllowUserToAddRows = false;
			dataGridViewMoreInfoGuests.AllowUserToDeleteRows = false;
			dataGridViewMoreInfoGuests.AllowUserToResizeColumns = false;
			dataGridViewMoreInfoGuests.AllowUserToResizeRows = false;
			dataGridViewMoreInfoGuests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewMoreInfoGuests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewMoreInfoGuests.Location = new Point(-1, -1);
			dataGridViewMoreInfoGuests.Name = "dataGridViewMoreInfoGuests";
			dataGridViewMoreInfoGuests.ReadOnly = true;
			dataGridViewMoreInfoGuests.RowHeadersVisible = false;
			dataGridViewMoreInfoGuests.RowTemplate.Height = 25;
			dataGridViewMoreInfoGuests.Size = new Size(895, 679);
			dataGridViewMoreInfoGuests.TabIndex = 31;
			dataGridViewMoreInfoGuests.TabStop = false;
			dataGridViewMoreInfoGuests.Visible = false;
			// 
			// button_back2
			// 
			button_back2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
			button_back2.Location = new Point(900, 609);
			button_back2.Name = "button_back2";
			button_back2.Size = new Size(152, 60);
			button_back2.TabIndex = 32;
			button_back2.Text = "Вернуться назад";
			button_back2.UseVisualStyleBackColor = true;
			button_back2.Visible = false;
			button_back2.Click += button_back2_click;
			// 
			// InfoMenuForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1064, 681);
			Controls.Add(dataGridViewMoreInfoGuests);
			Controls.Add(button_back2);
			Controls.Add(button_MoreInfoGuests);
			Controls.Add(listBoxNames);
			Controls.Add(label_Reservation);
			Controls.Add(button_InfoGuests);
			Controls.Add(button_back);
			Controls.Add(label_MainMenu);
			Name = "InfoMenuForm";
			Text = "InfoMenuForm";
			FormClosing += InfoMenuForm_FormClosing;
			((System.ComponentModel.ISupportInitialize)dataGridViewMoreInfoGuests).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label_MainMenu;
		private Button button_back;
		private ListBox listBoxNames;
		private Button button_InfoGuests;
		private Label label_Reservation;
		private Button button_MoreInfoGuests;
		private DataGridView dataGridViewMoreInfoGuests;
		private Button button_back2;
	}
}