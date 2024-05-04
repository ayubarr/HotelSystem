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
            button_room1 = new Button();
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
            // button_room1
            // 
            button_room1.Location = new Point(414, 272);
            button_room1.Name = "button_room1";
            button_room1.Size = new Size(89, 33);
            button_room1.TabIndex = 22;
            button_room1.Text = "button1";
            button_room1.UseVisualStyleBackColor = true;
            // 
            // ReservationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 681);
            Controls.Add(button_room1);
            Controls.Add(button_back);
            Name = "ReservationForm";
            Text = "ReservationForm";
            ResumeLayout(false);
        }

        #endregion

        private Button button_back;
        private Button button_room1;
    }
}