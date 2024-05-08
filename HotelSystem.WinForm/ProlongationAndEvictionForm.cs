using HotelSystem.Domain.Models.Entities;
using Newtonsoft.Json;
using System.Data;
using System.Globalization;
using System.Net.Http.Json;
using System.Text;

namespace HotelSystem.WinForm
{
    public partial class ProlongationAndEvictionForm : Form
    {
        public ProlongationAndEvictionForm()
        {
            InitializeComponent();
        }

        private const string DateTimeFormatApi = "yyyy-MM-ddTHH:mm:ss.fffZ";
        private const string DateTimeFormatWinForm = "dd.MM.yyyy HH:mm";

        private async void ProlongationAndEvictionForm_Load(object sender, EventArgs e)
        {
            dateTimePicker_ProlongationDate.Format = DateTimePickerFormat.Custom;
            dateTimePicker_ProlongationDate.CustomFormat = DateTimeFormatWinForm;
            dataGridViewRooms.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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
            if (dataGridViewRooms.SelectedRows.Count < 0 || dateTimePicker_ProlongationDate.Text == null) return;

            List<string> selectedRoomNumbers = new List<string>();
            foreach (DataGridViewRow row in dataGridViewRooms.SelectedRows)
            {
                string roomNumber = row.Cells["Номер комнаты"].Value.ToString();
                selectedRoomNumbers.Add(roomNumber);
            }

            DateTime ProlongationDateTime = DateTime.ParseExact(dateTimePicker_ProlongationDate.Text, DateTimeFormatWinForm, CultureInfo.InvariantCulture);
            string ProlongationDate = ProlongationDateTime.ToString(DateTimeFormatApi);

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    foreach (var selectedRoom in selectedRoomNumbers)
                    {

                        string url = $"https://localhost:5001/api/Room/ProlongationRoom?roomNumber={selectedRoom}&newBookingEndDate={ProlongationDate}";

                        client.DefaultRequestHeaders.Add("accept", "*/*");
                        HttpResponseMessage response = await client.PutAsync(url, new StringContent("", Encoding.UTF8, "application/json"));

                        // Проверяем успешность запроса
                        if (response.IsSuccessStatusCode)
                        {
                            continue;
                        }
                        else
                        {
                            throw new Exception($"Комната не продлилась {response.RequestMessage}") ;
                        }
                    }

                    MessageBox.Show("Вы успешно продлили номер", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ProlongationAndEvictionForm_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"При продлении номера возникла ошибка: \n\r{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void button_Eviction_Click(object sender, EventArgs e)
        {
            List<string> selectedRoomNumbers = new List<string>();
            foreach (DataGridViewRow row in dataGridViewRooms.SelectedRows)
            {
                string roomNumber = row.Cells["Номер комнаты"].Value.ToString();
                selectedRoomNumbers.Add(roomNumber);
            }

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    foreach (var selectedRoom in selectedRoomNumbers)
                    {

                        string url = $"https://localhost:5001/api/Room/EvictionFromRoom?roomNumber={selectedRoom}";

                        client.DefaultRequestHeaders.Add("accept", "*/*");
                        HttpResponseMessage response = await client.PutAsync(url, new StringContent("", Encoding.UTF8, "application/json"));

                        // Проверяем успешность запроса
                        if (response.IsSuccessStatusCode)
                        {
                            continue;
                        }
                        else
                        {
                            throw new Exception($"Комната не разбронировалась: {response.RequestMessage}");
                        }
                    }

                    MessageBox.Show("Вы успешно освободили номер", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ProlongationAndEvictionForm_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"При освобождении комнаты возникла ошибка: \n\r{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
