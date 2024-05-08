using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelSystem.WinForm
{
	public partial class DelCreateRoomMenuForm1 : Form
	{
		public DelCreateRoomMenuForm1()
		{
			InitializeComponent();
		}

		private void button_back_menu_Click(object sender, EventArgs e)
		{
			new MainMenu().Show();
			Visible = false;
		}
	}
}
