﻿namespace HotelSystem.WinForm
{
    partial class ProlongationAndEvictionForm
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
            dataGridViewRooms = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRooms).BeginInit();
            SuspendLayout();
            // 
            // button_back
            // 
            button_back.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button_back.Location = new Point(900, 609);
            button_back.Name = "button_back";
            button_back.Size = new Size(152, 60);
            button_back.TabIndex = 22;
            button_back.Text = "Вернуться назад";
            button_back.UseVisualStyleBackColor = true;
            button_back.Click += button_back_Click;
            // 
            // dataGridViewRooms
            // 
            dataGridViewRooms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRooms.Location = new Point(12, 12);
            dataGridViewRooms.Name = "dataGridViewRooms";
            dataGridViewRooms.RowTemplate.Height = 25;
            dataGridViewRooms.Size = new Size(1040, 509);
            dataGridViewRooms.TabIndex = 23;
            // 
            // ProlongationAndEvictionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 681);
            Controls.Add(dataGridViewRooms);
            Controls.Add(button_back);
            Name = "ProlongationAndEvictionForm";
            Text = "ProlongationAndEvictionForm";
            FormClosing += ProlongationAndEvictionForm_FormClosing;
            Load += ProlongationAndEvictionForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewRooms).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button_back;
        private DataGridView dataGridViewRooms;
    }
}