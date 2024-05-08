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
            Visible = false;
        }

        private void button_GetInformation_Click(object sender, EventArgs e)
        {
            var form = new InfoMenuForm();
            form.Show();
            Visible = false;
        }

        private void button_Reservation_Click(object sender, EventArgs e)
        {
            var form = new ReservationForm();
            form.Show();
            Visible = false;
        }

        private void button_MainMenuExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            button_MainMenuExit_Click(sender, e);
        }

        private void button_EvictionFromRoom_Click(object sender, EventArgs e)
        {

        }
    }
}
