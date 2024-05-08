using HotelSystem.Domain.Models.Entities;
using Newtonsoft.Json;
using System.Data;

namespace HotelSystem.WinForm
{
    public partial class ProlongationAndEvictionForm : Form
    {
        public ProlongationAndEvictionForm()
        {
            InitializeComponent();
        }

        private async void ProlongationAndEvictionForm_Load(object sender, EventArgs e)
        {
            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    httpClient.DefaultRequestHeaders.Add("accept", "*/*");

                    var response = await httpClient.GetAsync("https://localhost:5001/api/Room/GetRooms");

                    if (!response.IsSuccessStatusCode)
                    {
                        throw new Exception(response.RequestMessage.ToString());
                    }
                    var json = await response.Content.ReadAsStringAsync();
                    var rooms = JsonConvert.DeserializeObject<IEnumerable<Room>>(json);

                    DataTable dataTable = new DataTable();
                    dataTable.Columns.Add("Номер комнаты");
                    dataTable.Columns.Add("Тип номера");
                    dataTable.Columns.Add("Тип номера(Число Комнат)");
                    dataTable.Columns.Add("Цена за проживание в номере за одну ночь");
                    dataTable.Columns.Add("забронирован ли номер");
                    dataTable.Columns.Add("Время начала брони");
                    dataTable.Columns.Add("Время окончания брони");
                    foreach (var room in rooms)
                    {
                        dataTable.Rows.Add(
                            room.Number,
                            room.Type,
                            room.AmountType,
                            room.Price,
                            room.IsBooked,
                            room.BookingStartDate,
                            room.BookingEndDate
                        );
                    }
                    dataGridViewRooms.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"При добавлении нового гостя возникла ошибка: \n\r{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button_back_Click(object sender, EventArgs e)
        {
            var form = new MainMenu();
            form.Show();
            Visible = false;
        }

        private void ProlongationAndEvictionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private async void button_Prolongation_Click(object sender, EventArgs e)
        {
            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    httpClient.DefaultRequestHeaders.Add("accept", "*/*");

                    var response = await httpClient.GetAsync("https://localhost:5001/api/Room/GetRooms");

                    if (!response.IsSuccessStatusCode)
                    {
                        throw new Exception(response.RequestMessage.ToString());
                    }
                    var json = await response.Content.ReadAsStringAsync();
                    var rooms = JsonConvert.DeserializeObject<IEnumerable<Room>>(json);

                    DataTable dataTable = new DataTable();
                    dataTable.Columns.Add("Номер комнаты");
                    dataTable.Columns.Add("Тип номера");
                    dataTable.Columns.Add("Тип номера(Число Комнат)");
                    dataTable.Columns.Add("Цена за проживание в номере за одну ночь");
                    dataTable.Columns.Add("забронирован ли номер");
                    dataTable.Columns.Add("Время начала брони");
                    dataTable.Columns.Add("Время окончания брони");
                    foreach (var room in rooms)
                    {
                        dataTable.Rows.Add(
                            room.Number,
                            room.Type,
                            room.AmountType,
                            room.Price,
                            room.IsBooked,
                            room.BookingStartDate,
                            room.BookingEndDate
                        );
                    }
                    dataGridViewRooms.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"При добавлении нового гостя возникла ошибка: \n\r{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
