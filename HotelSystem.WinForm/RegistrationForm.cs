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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            richTextBox_LoginRegistration.BackColor = SystemColors.Window;
            richTextBox_PasswordRegistration.BackColor = SystemColors.Window;
            richTextBox_ConfirmRegistration.BackColor = SystemColors.Window;
            label_ErrorLogin.Visible = false;
            label_ErrorPassword.Visible = false;
            label_ErrorConfirm.Visible = false;
        }

        private async void button_Registration_Click(object sender, EventArgs e)
        {
            if (!CheckLoginAndPassword()) return;

            // Формируем JSON-строку с полученными значениями
            string jsonContent = $@"{{
            ""userName"": ""{richTextBox_LoginRegistration.Text}"",
            ""password"": ""{richTextBox_PasswordRegistration.Text}"",
            ""email"": ""user@example.com""
            }}";


            //Отправляем запрос на API
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Add("accept", "*/*");

                    HttpResponseMessage response = await client.PostAsync("https://localhost:5001/api/Employee/register",
                        new StringContent(jsonContent, Encoding.UTF8, "application/json"));

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("User registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();   
                    }
                    else
                    {
                        MessageBox.Show($"Registration failed with status code {response.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }     
        }

        private bool CheckLoginAndPassword()
        {
            if (string.IsNullOrEmpty(richTextBox_LoginRegistration.Text))
            {
                richTextBox_LoginRegistration.BackColor = Color.FromArgb(255, 192, 192);
                label_ErrorLogin.Visible = true;
                return false;

            }
            if (string.IsNullOrEmpty(richTextBox_PasswordRegistration.Text))
            {
                richTextBox_PasswordRegistration.BackColor = Color.FromArgb(255, 192, 192);
                label_ErrorPassword.Visible = true;
                return false;
            }
            if (string.IsNullOrEmpty(richTextBox_ConfirmRegistration.Text))
            {
                richTextBox_ConfirmRegistration.BackColor = Color.FromArgb(255, 192, 192);
                label_ErrorPassword.Visible = true;
                return false;
            }
            if (!string.Equals(richTextBox_ConfirmRegistration.Text, richTextBox_PasswordRegistration.Text)) {
                MessageBox.Show($"Пароли должны совпадать", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            button_Registration.Enabled = false;
            return true;
        }
    }
}
