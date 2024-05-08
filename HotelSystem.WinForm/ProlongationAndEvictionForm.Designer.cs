namespace HotelSystem.WinForm
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
            button_Prolongation = new Button();
            label_Prolongation = new Label();
            button_Eviction = new Button();
            label1 = new Label();
            dateTimePicker_ProlongationDate = new DateTimePicker();
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
            dataGridViewRooms.Location = new Point(129, 22);
            dataGridViewRooms.Name = "dataGridViewRooms";
            dataGridViewRooms.RowTemplate.Height = 25;
            dataGridViewRooms.Size = new Size(756, 509);
            dataGridViewRooms.TabIndex = 23;
            // 
            // button_Prolongation
            // 
            button_Prolongation.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_Prolongation.Location = new Point(38, 609);
            button_Prolongation.Name = "button_Prolongation";
            button_Prolongation.Size = new Size(224, 60);
            button_Prolongation.TabIndex = 24;
            button_Prolongation.Text = "Продлить";
            button_Prolongation.UseVisualStyleBackColor = true;
            button_Prolongation.Click += button_Prolongation_Click;
            // 
            // label_Prolongation
            // 
            label_Prolongation.AutoSize = true;
            label_Prolongation.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_Prolongation.Location = new Point(38, 543);
            label_Prolongation.Name = "label_Prolongation";
            label_Prolongation.Size = new Size(224, 21);
            label_Prolongation.TabIndex = 25;
            label_Prolongation.Text = "Продлить выбранные номера";
            // 
            // button_Eviction
            // 
            button_Eviction.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_Eviction.Location = new Point(533, 610);
            button_Eviction.Name = "button_Eviction";
            button_Eviction.Size = new Size(224, 60);
            button_Eviction.TabIndex = 27;
            button_Eviction.Text = "Выселить";
            button_Eviction.UseVisualStyleBackColor = true;
            button_Eviction.Click += button_Eviction_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(533, 582);
            label1.Name = "label1";
            label1.Size = new Size(241, 21);
            label1.TabIndex = 28;
            label1.Text = "Освободить выбранные номера";
            // 
            // dateTimePicker_ProlongationDate
            // 
            dateTimePicker_ProlongationDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker_ProlongationDate.Location = new Point(38, 576);
            dateTimePicker_ProlongationDate.Name = "dateTimePicker_ProlongationDate";
            dateTimePicker_ProlongationDate.Size = new Size(224, 29);
            dateTimePicker_ProlongationDate.TabIndex = 29;
            // 
            // ProlongationAndEvictionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 681);
            Controls.Add(dateTimePicker_ProlongationDate);
            Controls.Add(label1);
            Controls.Add(button_Eviction);
            Controls.Add(label_Prolongation);
            Controls.Add(button_Prolongation);
            Controls.Add(dataGridViewRooms);
            Controls.Add(button_back);
            Name = "ProlongationAndEvictionForm";
            Text = "ProlongationAndEvictionForm";
            FormClosing += ProlongationAndEvictionForm_FormClosing;
            Load += ProlongationAndEvictionForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewRooms).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_back;
        private DataGridView dataGridViewRooms;
        private Button button_Prolongation;
        private Label label_Prolongation;
        private Button button_Eviction;
        private Label label1;
        private DateTimePicker dateTimePicker_ProlongationDate;
    }
}