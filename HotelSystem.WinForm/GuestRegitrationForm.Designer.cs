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
            button_GuestRegistr = new Button();
            SuspendLayout();
            // 
            // button_GuestRegistr
            // 
            button_GuestRegistr.Location = new Point(324, 463);
            button_GuestRegistr.Name = "button_GuestRegistr";
            button_GuestRegistr.Size = new Size(313, 42);
            button_GuestRegistr.TabIndex = 0;
            button_GuestRegistr.Text = "button1";
            button_GuestRegistr.UseVisualStyleBackColor = true;
            button_GuestRegistr.Click += button_GuestRegistr_Click;
            // 
            // GuestRegitrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 681);
            Controls.Add(button_GuestRegistr);
            Name = "GuestRegitrationForm";
            Text = "GuestRegitrationForm";
            Load += GuestRegitrationForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button_GuestRegistr;
    }
}