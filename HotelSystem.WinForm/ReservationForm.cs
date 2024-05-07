namespace HotelSystem.WinForm
{
    public partial class ReservationForm : Form
    {
        public ReservationForm()
        {
            InitializeComponent();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            var form = new MainMenu();
            form.Show();
            Visible = false;
        }

        private void ReservationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
