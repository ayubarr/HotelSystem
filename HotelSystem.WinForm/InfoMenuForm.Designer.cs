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
            label_GetInformation = new Label();
            button_GetInformation = new Button();
            label_Prolongation = new Label();
            button_InfoRooms = new Button();
            label_ClientRegistration = new Label();
            button_InfoPayments = new Button();
            label_Reservation = new Label();
            button_InfoClients = new Button();
            listBox1 = new ListBox();
            dataGridView1 = new DataGridView();
            Фамилия = new DataGridViewTextBoxColumn();
            Имя = new DataGridViewTextBoxColumn();
            Отчество = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            // label_GetInformation
            // 
            label_GetInformation.AutoSize = true;
            label_GetInformation.FlatStyle = FlatStyle.System;
            label_GetInformation.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label_GetInformation.Location = new Point(742, 264);
            label_GetInformation.Name = "label_GetInformation";
            label_GetInformation.Size = new Size(259, 25);
            label_GetInformation.TabIndex = 27;
            label_GetInformation.Text = "Информация о Сотрудниках";
            label_GetInformation.Click += label_GetInformation_Click;
            // 
            // button_GetInformation
            // 
            button_GetInformation.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_GetInformation.Location = new Point(661, 290);
            button_GetInformation.Margin = new Padding(3, 2, 3, 2);
            button_GetInformation.Name = "button_GetInformation";
            button_GetInformation.Size = new Size(360, 38);
            button_GetInformation.TabIndex = 26;
            button_GetInformation.Text = "Информация о Сотрудниках";
            button_GetInformation.UseVisualStyleBackColor = true;
            // 
            // label_Prolongation
            // 
            label_Prolongation.AutoSize = true;
            label_Prolongation.FlatStyle = FlatStyle.System;
            label_Prolongation.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label_Prolongation.Location = new Point(97, 264);
            label_Prolongation.Name = "label_Prolongation";
            label_Prolongation.Size = new Size(229, 25);
            label_Prolongation.TabIndex = 25;
            label_Prolongation.Text = "Информация о комнатах";
            label_Prolongation.Click += label_Prolongation_Click;
            // 
            // button_InfoRooms
            // 
            button_InfoRooms.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_InfoRooms.Location = new Point(26, 290);
            button_InfoRooms.Margin = new Padding(3, 2, 3, 2);
            button_InfoRooms.Name = "button_InfoRooms";
            button_InfoRooms.Size = new Size(360, 38);
            button_InfoRooms.TabIndex = 24;
            button_InfoRooms.Text = "Информация о комнатах";
            button_InfoRooms.UseVisualStyleBackColor = true;
            button_InfoRooms.Click += button_InfoRooms_Click;
            // 
            // label_ClientRegistration
            // 
            label_ClientRegistration.AutoSize = true;
            label_ClientRegistration.FlatStyle = FlatStyle.System;
            label_ClientRegistration.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label_ClientRegistration.Location = new Point(742, 58);
            label_ClientRegistration.Name = "label_ClientRegistration";
            label_ClientRegistration.Size = new Size(219, 25);
            label_ClientRegistration.TabIndex = 23;
            label_ClientRegistration.Text = "Информация об оплате";
            // 
            // button_InfoPayments
            // 
            button_InfoPayments.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_InfoPayments.Location = new Point(661, 85);
            button_InfoPayments.Margin = new Padding(3, 2, 3, 2);
            button_InfoPayments.Name = "button_InfoPayments";
            button_InfoPayments.Size = new Size(360, 38);
            button_InfoPayments.TabIndex = 22;
            button_InfoPayments.Text = "Информация об оплате";
            button_InfoPayments.UseVisualStyleBackColor = true;
            button_InfoPayments.Click += button_InfoPayments_Click;
            // 
            // label_Reservation
            // 
            label_Reservation.AutoSize = true;
            label_Reservation.FlatStyle = FlatStyle.System;
            label_Reservation.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label_Reservation.Location = new Point(87, 58);
            label_Reservation.Name = "label_Reservation";
            label_Reservation.Size = new Size(226, 25);
            label_Reservation.TabIndex = 21;
            label_Reservation.Text = "Информация о клиентах";
            // 
            // button_InfoClients
            // 
            button_InfoClients.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_InfoClients.Location = new Point(26, 85);
            button_InfoClients.Margin = new Padding(3, 2, 3, 2);
            button_InfoClients.Name = "button_InfoClients";
            button_InfoClients.Size = new Size(360, 38);
            button_InfoClients.TabIndex = 20;
            button_InfoClients.Text = "Информация о клиентах";
            button_InfoClients.UseVisualStyleBackColor = true;
            button_InfoClients.Click += button_InfoClients_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "Фамилия\t\tИмя\t\tОтчество" });
            listBox1.Location = new Point(12, 346);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(425, 199);
            listBox1.TabIndex = 28;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Фамилия, Имя, Отчество });
            dataGridView1.Location = new Point(527, 346);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(343, 177);
            dataGridView1.TabIndex = 29;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Фамилия
            // 
            Фамилия.HeaderText = "Фамилия";
            Фамилия.Name = "Фамилия";
            Фамилия.ReadOnly = true;
            // 
            // Имя
            // 
            Имя.HeaderText = "Имя";
            Имя.Name = "Имя";
            Имя.ReadOnly = true;
            // 
            // Отчество
            // 
            Отчество.HeaderText = "Отчество";
            Отчество.Name = "Отчество";
            // 
            // InfoMenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 681);
            Controls.Add(dataGridView1);
            Controls.Add(listBox1);
            Controls.Add(label_GetInformation);
            Controls.Add(button_GetInformation);
            Controls.Add(label_Prolongation);
            Controls.Add(button_InfoRooms);
            Controls.Add(label_ClientRegistration);
            Controls.Add(button_InfoPayments);
            Controls.Add(label_Reservation);
            Controls.Add(button_InfoClients);
            Controls.Add(button_back);
            Controls.Add(label_MainMenu);
            Name = "InfoMenuForm";
            Text = "InfoMenuForm";
            FormClosing += InfoMenuForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_MainMenu;
		private Button button_back;
		private Label label_GetInformation;
		private Button button_GetInformation;
		private Label label_Prolongation;
		private Button button_InfoRooms;
		private Label label_ClientRegistration;
		private Button button_InfoPayments;
		private Label label_Reservation;
		private Button button_InfoClients;
		private ListBox listBox1;
		private DataGridView dataGridView1;
		private DataGridViewTextBoxColumn Фамилия;
		private DataGridViewTextBoxColumn Имя;
		private DataGridViewTextBoxColumn Отчество;
	}
}