namespace HotelSystem.WinForm
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
            listBox_StandartRooms.Items.AddRange(new object[] { "Номер 1", "Номер 2", "Номер 3", "Номер 4", "Номер 5", "Номер 6" });
            listBox_StandartRooms.Location = new Point(12, 91);
            listBox_StandartRooms.Name = "listBox_StandartRooms";
            listBox_StandartRooms.Size = new Size(163, 179);
            listBox_StandartRooms.TabIndex = 29;
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
            label_StandartRooms.Location = new Point(12, 63);
            label_StandartRooms.Name = "label_StandartRooms";
            label_StandartRooms.Size = new Size(163, 21);
            label_StandartRooms.TabIndex = 31;
            label_StandartRooms.Text = "Стандартные номера";
            // 
            // label_LuxRooms
            // 
            label_LuxRooms.AutoSize = true;
            label_LuxRooms.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_LuxRooms.Location = new Point(220, 63);
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
            listBox_LuxRooms.Items.AddRange(new object[] { "Номер 1", "Номер 2", "Номер 3", "Номер 4", "Номер 5", "Номер 6" });
            listBox_LuxRooms.Location = new Point(220, 91);
            listBox_LuxRooms.Name = "listBox_LuxRooms";
            listBox_LuxRooms.Size = new Size(163, 179);
            listBox_LuxRooms.TabIndex = 32;
            // 
            // label_VipRooms
            // 
            label_VipRooms.AutoSize = true;
            label_VipRooms.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_VipRooms.Location = new Point(432, 63);
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
            listBox_VipRooms.Items.AddRange(new object[] { "Номер 1", "Номер 2", "Номер 3", "Номер 4", "Номер 5", "Номер 6" });
            listBox_VipRooms.Location = new Point(432, 91);
            listBox_VipRooms.Name = "listBox_VipRooms";
            listBox_VipRooms.Size = new Size(163, 179);
            listBox_VipRooms.TabIndex = 34;
            // 
            // ReservationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 681);
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
    }
}