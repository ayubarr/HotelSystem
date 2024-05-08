using HotelSystem.ApiModels.DTOs.EntitiesDTOs.Payment;
using HotelSystem.Domain.Models.Entities;
using HotelSystem.Domain.Models.Enums;
using Newtonsoft.Json;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace HotelSystem.WinForm
{
    public partial class ReservationForm : Form
    {
        public ReservationForm()
        {
            InitializeComponent();
        }
       private const string DateTimeFormatApi = "yyyy-MM-ddTHH:mm:ss.fffZ";
        private const string DateTimeFormatWinForm = "dd.MM.yyyy HH:mm";

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

        private async void ReservationForm_Load(object sender, EventArgs e)
        {
            try
            {
                dateTimePicker_RegistrationEndDate.Format = DateTimePickerFormat.Custom;
                dateTimePicker_RegistrationStartDate.CustomFormat = DateTimeFormatWinForm;
                dateTimePicker_RegistrationEndDate.Format = DateTimePickerFormat.Custom;
                dateTimePicker_RegistrationEndDate.CustomFormat = DateTimeFormatWinForm;

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


                    foreach (var room in rooms)
                    {
                        string res = room.Number += room.IsBooked ? "(Занято)" : "";
                        switch (room.Type)
                        {
                            case RoomType.Luxe:
                                listBox_LuxRooms.Items.Add(res);
                                break;
                            case RoomType.Vip:
                                listBox_VipRooms.Items.Add(res);
                                break;

                            default:
                                listBox_StandartRooms.Items.Add(res);
                                break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"При добавлении нового гостя возникла ошибка: \n\r{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBox_StandartRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_StandartRooms.SelectedIndex != -1)
            {
                listBox_LuxRooms.SelectedIndex = -1;
                listBox_VipRooms.SelectedIndex = -1;
            }

        }

        private void listBox_LuxRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_LuxRooms.SelectedIndex != -1)
            {
                listBox_StandartRooms.SelectedIndex = -1;
                listBox_VipRooms.SelectedIndex = -1;
            }
        }

        private void listBox_VipRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_VipRooms.SelectedIndex != -1)
            {
                listBox_StandartRooms.SelectedIndex = -1;
                listBox_LuxRooms.SelectedIndex = -1;
            }
        }

        private async void button_Reservation_Click(object sender, EventArgs e)
        {
            if (!CheckGuestCodeAndAmount()) return;

            var selectedRoom = 
                listBox_StandartRooms.SelectedIndex != -1 ? listBox_StandartRooms.SelectedItem
                : listBox_LuxRooms.SelectedIndex != -1 ? listBox_StandartRooms.SelectedItem
                : listBox_VipRooms.SelectedIndex != -1 ? listBox_VipRooms.SelectedItem : "";

            selectedRoom = selectedRoom.ToString().Replace("(Занято)", "").Trim();

            DateTime RegistrationStartDateTime = DateTime.ParseExact(dateTimePicker_RegistrationStartDate.Text, DateTimeFormatWinForm, CultureInfo.InvariantCulture);
            string RegistrationStartDate = RegistrationStartDateTime.ToString(DateTimeFormatApi);

            DateTime RegistrationEndDateTime = DateTime.ParseExact(dateTimePicker_RegistrationStartDate.Text, DateTimeFormatWinForm, CultureInfo.InvariantCulture);
            string RegistrationEndDate = RegistrationEndDateTime.ToString(DateTimeFormatApi);

            // Получаем данные для платежа
            uint guestId = Convert.ToUInt32(textBox_GuestCode.Text);
            decimal amount = Convert.ToDecimal(textBox_PaymentSum.Text);
            var date = DateTime.Now;
            string description = "оплата за бронь";


            // Формируем JSON-строку с полученными значениями
            string jsonContent = JsonConvert.SerializeObject(new
            {
                GuestId = guestId,
                Amount = amount,
                Date = date,
                Description = description,
            });

            string url = $"https://localhost:5001/api/Room/ReservationRoom?roomNumber={selectedRoom}&bookingStartDate={RegistrationStartDate}&bookingEndDate={RegistrationEndDate}";


            // Создаем экземпляр HttpClient
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Add("accept", "*/*");

                    HttpResponseMessage response = await client.PutAsync(url, new StringContent(jsonContent, Encoding.UTF8, "application/json"));

                    // Проверяем успешность запроса
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Вы успешно Забронировали комнату", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Visible = false;
                        var MainMenuForm = new MainMenu();
                        MainMenuForm.Show();
                    }
                    else
                    {
                        // Обрабатываем ошибку
                        MessageBox.Show($"Ошибка авторизации {response.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    // Обрабатываем исключение
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    button_Reservation.Enabled = true;
                    button_back.Enabled = true;
                }
            }
        }

        private bool CheckGuestCodeAndAmount()
        {
            if (string.IsNullOrEmpty(textBox_GuestCode.Text))
            {
                textBox_GuestCode.BackColor = Color.FromArgb(255, 192, 192);
                label_GuestInputError.Visible = true;

                return false;

            }
            if (string.IsNullOrEmpty(textBox_PaymentSum.Text))
            {
                textBox_PaymentSum.BackColor = Color.FromArgb(255, 192, 192);
                label_GuestInputError.Visible = true;

                return false;
            }

            if (listBox_VipRooms.SelectedIndex == -1
                && listBox_StandartRooms.SelectedIndex == -1 
                && listBox_LuxRooms.SelectedIndex == -1)
            {
                label_GuestInputError.Visible = true;
                return false;
            }

            button_Reservation.Enabled = false;
            button_back.Enabled = false;
            label_GuestInputError.Visible = false;

            return true;
        }
    }
}
