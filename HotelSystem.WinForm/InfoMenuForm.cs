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
	public partial class InfoMenuForm : Form
	{
		public InfoMenuForm()
		{
			InitializeComponent();
		}

		private void button_back_click(object sender, EventArgs e)
		{
			var mainMenu = new MainMenu();
			mainMenu.Show();
			Close();
		}

		private void label_Prolongation_Click(object sender, EventArgs e)
		{

		}

		private void label_GetInformation_Click(object sender, EventArgs e)
		{

		}

		private void button_InfoPayments_Click(object sender, EventArgs e)
		{

		}

		private void button_InfoClients_Click(object sender, EventArgs e)
		{

		}

		private void button_InfoRooms_Click(object sender, EventArgs e)
		{

		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
