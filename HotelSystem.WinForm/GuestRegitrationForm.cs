using Newtonsoft.Json;
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
    public partial class GuestRegitrationForm : Form
    {
        public GuestRegitrationForm()
        {
            InitializeComponent();
        }

        private void GuestRegitrationForm_Load(object sender, EventArgs e)
        {
            dateTimePicker_RegistrationEndDate.Format = DateTimePickerFormat.Custom;
            dateTimePicker_RegistrationStartDate.CustomFormat = "dd.MM.yyyy HH:mm";
            dateTimePicker_RegistrationEndDate.Format = DateTimePickerFormat.Custom;
            dateTimePicker_RegistrationEndDate.CustomFormat = "dd.MM.yyyy HH:mm";

        }

        private async void button_GuestRegistr_Click(object sender, EventArgs e)
        {


            if (!CheckLoginAndPassword())
            {
                label_GuestInputError.Visible = true;
                return;
            }
            string jsonContent = JsonConvert.SerializeObject(new
            {
                FirstName = textBox_FirstName.Text,
                LastName = textBox_LastName.Text,
                MiddleName = textBox_MiddleName.Text,
                Email = textBox_Email.Text,
                PhoneNumber = textBox_PhoneNumber.Text,
                RegistrationStartDate = dateTimePicker_RegistrationStartDate,
                RegistrationEndDate = dateTimePicker_RegistrationEndDate
            });
            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    httpClient.DefaultRequestHeaders.Add("accept", "*/*");

                    HttpResponseMessage response = await httpClient.PostAsync("https://localhost:5001/api/Guest/CreateGuest",
                          new StringContent(jsonContent, Encoding.UTF8, "application/json"));

                    // Проверяем успешность запроса
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Клиент успешно добавлен", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"При добавлении нового гостя возникла ошибка:{response.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                // Обрабатываем исключение
                MessageBox.Show($"При добавлении нового гостя возникла ошибка: \n\r{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private bool CheckLoginAndPassword()
        {
            if (string.IsNullOrEmpty(textBox_FirstName.Text))
            {
                textBox_FirstName.BackColor = Color.FromArgb(255, 192, 192);
                return false;
            }
            if (string.IsNullOrEmpty(textBox_LastName.Text))
            {
                textBox_LastName.BackColor = Color.FromArgb(255, 192, 192);
                return false;
            }
            if (string.IsNullOrEmpty(textBox_MiddleName.Text))
            {
                textBox_MiddleName.BackColor = Color.FromArgb(255, 192, 192);
                return false;
            }
            if (dateTimePicker_RegistrationStartDate.Value < dateTimePicker_RegistrationEndDate.Value)
            {
                MessageBox.Show($"Дата начала регистрации не может быть раньше даты окончания регистрации", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(textBox_Email.Text))
            {
                textBox_Email.Text = "example@mail.com";
            }
            if (string.IsNullOrEmpty(textBox_PhoneNumber.Text))
            {
                textBox_PhoneNumber.Text = "+XXX-XXX-XXX";
            }

            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var mainMenu = new MainMenu();
            mainMenu.Show();
            Close();
            
        }
    }
}
