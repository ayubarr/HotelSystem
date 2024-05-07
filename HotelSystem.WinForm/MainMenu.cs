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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void button_ClientRegistration_Click(object sender, EventArgs e)
        {
            var form = new GuestRegitrationForm();
            form.Show();
            Close();
        }

        private void button_GetInformation_Click(object sender, EventArgs e)
        {
            var form = new InfoMenuForm();
            form.Show();
            Close();
        }

        private void button_Reservation_Click(object sender, EventArgs e)
        {
            var form = new ReservationForm();
            form.Show();
            Close();
        }

        private void button_MainMenuExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
