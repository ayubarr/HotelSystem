using HotelSystem.Domain.Models.Entities;
using Newtonsoft.Json;

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

        private void ReservationForm_Load(object sender, EventArgs e)
        {
            //if (!CheckLoginAndPassword())
            //{
            //	label_GuestInputError.Visible = true;
            //	return;
            //}
            //string jsonContent = JsonConvert.SerializeObject(new
            //{
            //	FirstName = listBox1.Text,
            //});
            //try
            //{
            //    using (HttpClient httpClient = new HttpClient())
            //    {
            //        httpClient.DefaultRequestHeaders.Add("accept", "*/*");

            //        var response = await httpClient.GetAsync("https://localhost:5001/api/Guest/GetGuests");

            //        // Проверяем успешность запроса
            //        if (!response.IsSuccessStatusCode)
            //        {
            //            throw new Exception(response.RequestMessage.ToString());
            //        }
            //        var json = await response.Content.ReadAsStringAsync();
            //        var guests = JsonConvert.DeserializeObject<IEnumerable<Guest>>(json);

            //    }

            //}
            //catch (Exception ex)
            //{
            //    // Обрабатываем исключение
            //    MessageBox.Show($"При добавлении нового гостя возникла ошибка: \n\r{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
    }
}
