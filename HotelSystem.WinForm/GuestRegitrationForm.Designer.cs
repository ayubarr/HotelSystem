namespace HotelSystem.WinForm
{
    partial class GuestRegitrationForm
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
            button_GuestRegistration = new Button();
            label_GuestRegistr = new Label();
            SuspendLayout();
            // 
            // button_GuestRegistration
            // 
            button_GuestRegistration.Location = new Point(402, 506);
            button_GuestRegistration.Margin = new Padding(3, 4, 3, 4);
            button_GuestRegistration.Name = "button_GuestRegistration";
            button_GuestRegistration.Size = new Size(358, 56);
            button_GuestRegistration.TabIndex = 0;
            button_GuestRegistration.Text = "Зарегестрировать гостя";
            button_GuestRegistration.UseVisualStyleBackColor = true;
            button_GuestRegistration.Click += button_GuestRegistr_Click;
            // 
            // label_GuestRegistr
            // 
            label_GuestRegistr.AutoSize = true;
            label_GuestRegistr.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label_GuestRegistr.Location = new Point(302, 9);
            label_GuestRegistr.Name = "label_GuestRegistr";
            label_GuestRegistr.Size = new Size(554, 41);
            label_GuestRegistr.TabIndex = 1;
            label_GuestRegistr.Text = "Регистрация новых жильцов в системе";
            // 
            // GuestRegitrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1216, 908);
            Controls.Add(label_GuestRegistr);
            Controls.Add(button_GuestRegistration);
            Margin = new Padding(3, 4, 3, 4);
            Name = "GuestRegitrationForm";
            Text = "GuestRegitrationForm";
            Load += GuestRegitrationForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_GuestRegistration;
        private Label label_GuestRegistr;
    }
}