using Newtonsoft.Json;
using System.Text;

namespace HotelSystem.WinForm
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        private async void button_Login_Click(object sender, EventArgs e)
        {
            if (!CheckLoginAndPassword()) return;


            // Формируем JSON-строку с полученными значениями
            string jsonContent = JsonConvert.SerializeObject(new
            {
                username = richTextBox_Login.Text,
                password = richTextBox_Password.Text
            });



            // Создаем экземпляр HttpClient
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Add("accept", "*/*");

                    HttpResponseMessage response = await client.PostAsync("https://localhost:5001/api/Employee/login",
                        new StringContent(jsonContent, Encoding.UTF8, "application/json"));

                    // Проверяем успешность запроса
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("User registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Visible = false;
                        var mainMenu = new MainMenu();
                        mainMenu.Show();
                    }
                    else
                    {
                        // Обрабатываем ошибку
                        MessageBox.Show($"Registration failed with status code {response.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    // Обрабатываем исключение
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AuthForm_Load(object sender, EventArgs e)
        {
            richTextBox_Login.BackColor = SystemColors.Window;
            richTextBox_Password.BackColor = SystemColors.Window;
            label_ErrorLogin.Visible = false;
            label_ErrorPassword.Visible = false;
        }

        private void AuthForm_Click(object sender, EventArgs e)
        {
            AuthForm_Load(sender, e);
        }



        private bool CheckLoginAndPassword()
        {
            if (string.IsNullOrEmpty(richTextBox_Login.Text))
            {
                richTextBox_Login.BackColor = Color.FromArgb(255, 192, 192);
                label_ErrorLogin.Visible = true;
                return false;

            }
            if (string.IsNullOrEmpty(richTextBox_Password.Text))
            {
                richTextBox_Password.BackColor = Color.FromArgb(255, 192, 192);
                label_ErrorPassword.Visible = true;
                return false;
            }
            button_Login.Enabled = false;
            button_GoToRegistration.Enabled = false;
            return true;
        }

        #region Registration
        private bool registrationFormOpened = false;
        private RegistrationForm registrationForm;
        private void button_GoToRegistration_Click(object sender, EventArgs e)
        {
            OpenRegistrationForm();
        }

        // Метод, который будет открывать форму регистрации
        private void OpenRegistrationForm()
        {
            // Если форма регистрации уже открыта, то просто делаем ее активной
            if (registrationFormOpened && registrationForm != null)
            {
                registrationForm.Activate();
            }
            else
            {
                // Иначе создаем новый экземпляр формы регистрации и открываем ее
                registrationForm = new RegistrationForm();
                registrationForm.Show();
                // Устанавливаем флаг, что форма регистрации открыта
                registrationFormOpened = true;
            }
        }
        #endregion

        private void AuthForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
