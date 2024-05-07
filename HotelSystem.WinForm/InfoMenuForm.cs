namespace HotelSystem.WinForm
{
    public partial class InfoMenuForm : Form
    {
        public InfoMenuForm()
        {
            InitializeComponent();
        }

        private void button_back_click(object sender, EventArgs e)
        {
            var mainMenu = new MainMenu();
            mainMenu.Show();
            Close();
        }

        private void label_Prolongation_Click(object sender, EventArgs e)
        {

        }

        private void label_GetInformation_Click(object sender, EventArgs e)
        {

        }

        private void button_InfoPayments_Click(object sender, EventArgs e)
        {

        }

        private void button_InfoClients_Click(object sender, EventArgs e)
        {

        }

        private async void button_InfoRooms_Click(object sender, EventArgs e)
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
            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    httpClient.DefaultRequestHeaders.Add("accept", "*/*");

                    HttpResponseMessage response = await httpClient.GetAsync("https://localhost:5001/api/Guest/GetGuests");

                    // Проверяем успешность запроса
                    if (!response.IsSuccessStatusCode)
                    {
                        throw new Exception(response.RequestMessage.ToString());
                    }
                    var resultInfo = response.Content.ToString();

                }

            }
            catch (Exception ex)
            {
                // Обрабатываем исключение
                MessageBox.Show($"При добавлении нового гостя возникла ошибка: \n\r{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InfoMenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }


        //private bool CheckLoginAndPassword()
        //{
        //	if (string.IsNullOrEmpty(textBox_FirstName.Text))
        //	{
        //		textBox_FirstName.BackColor = Color.FromArgb(255, 192, 192);
        //		return false;
        //	}
        //	if (string.IsNullOrEmpty(textBox_LastName.Text))
        //	{
        //		textBox_LastName.BackColor = Color.FromArgb(255, 192, 192);
        //		return false;
        //	}
        //	if (string.IsNullOrEmpty(textBox_MiddleName.Text))
        //	{
        //		textBox_MiddleName.BackColor = Color.FromArgb(255, 192, 192);
        //		return false;
        //	}
        //	if (dateTimePicker_RegistrationStartDate.Value < dateTimePicker_RegistrationEndDate.Value)
        //	{
        //		MessageBox.Show($"Дата начала регистрации не может быть раньше даты окончания регистрации", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //		return false;
        //	}
        //	if (string.IsNullOrEmpty(textBox_Email.Text))
        //	{
        //		textBox_Email.Text = "example@mail.com";
        //	}
        //	if (string.IsNullOrEmpty(textBox_PhoneNumber.Text))
        //	{
        //		textBox_PhoneNumber.Text = "+XXX-XXX-XXX";
        //	}

        //	return true;
        //}
    }
}
