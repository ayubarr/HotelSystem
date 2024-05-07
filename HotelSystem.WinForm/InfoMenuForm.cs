using HotelSystem.Domain.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Data;

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
			Visible = false;
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

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private async void button_InfoGuest_Click(object sender, EventArgs e)
		{
			try
			{
				using (HttpClient httpClient = new HttpClient())
				{
					httpClient.DefaultRequestHeaders.Add("accept", "*/*");

					var response = await httpClient.GetAsync("https://localhost:5001/api/Guest/GetGuests");

					// Проверяем успешность запроса
					if (!response.IsSuccessStatusCode)
					{
						throw new Exception(response.RequestMessage.ToString());
					}
					var json = await response.Content.ReadAsStringAsync();
					var guests = JsonConvert.DeserializeObject<IEnumerable<Guest>>(json);

					foreach (var guest in guests)
					{
						string res = guest.MiddleName + "\t\t" + guest.FirstName + "\t\t" + guest.LastName;
						listBox1.Items.Add(res);
						//Console.WriteLine(guest.FirstName); 
					}
				}

			}
			catch (Exception ex)
			{
				// Обрабатываем исключение
				MessageBox.Show($"При добавлении нового гостя возникла ошибка: \n\r{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private async void CreateDataGuestTable(IEnumerable<Guest>? guests)
		{
			// Создаем DataTable и добавляем в него данные
			DataTable dTGuest = new DataTable();

			dTGuest.Columns.Add("Фамилия");
			dTGuest.Columns.Add("Имя");
			dTGuest.Columns.Add("Отчество");
			foreach (var guest in guests)
			{
				
				dTGuest.Rows.Add(guest.MiddleName, guest.FirstName, guest.LastName);
			}

			// Связываем DataGridView с DataTable
			dataGridView1.DataSource = dTGuest;
		}

		private void InfoMenuForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			Environment.Exit(0);
		}
	}
}
