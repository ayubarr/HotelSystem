namespace HotelSystem.WinForm
{
	partial class DelCreateRoomMenuForm1
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
			SuspendLayout();
			// 
			// button_back_menu
			// 
			button_back_menu.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
			button_back_menu.Location = new Point(900, 609);
			button_back_menu.Name = "button_back_menu";
			button_back_menu.Size = new Size(152, 60);
			button_back_menu.TabIndex = 21;
			button_back_menu.Text = "Вернуться назад";
			button_back_menu.UseVisualStyleBackColor = true;
			button_back_menu.Click += button_back_menu_Click;
			// 
			// DelCreateRoomMenuForm1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1064, 681);
			Controls.Add(button_back_menu);
			Name = "DelCreateRoomMenuForm1";
			Text = "DelCreateRoomMenuForm1";
			ResumeLayout(false);
		}

		#endregion

		private Button button_back_menu;
	}
}