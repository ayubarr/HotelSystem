using HotelSystem.Domain.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
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

		private async void button_GetInfoGuests_Click(object sender, EventArgs e)
		{
			try
			{
				using (HttpClient httpClient = new HttpClient())
				{
					httpClient.DefaultRequestHeaders.Add("accept", "*");

					var response = await httpClient.GetAsync("https://localhost:5001/api/Guest/GetGuests");

					// Проверяем успешность запроса
					if (!response.IsSuccessStatusCode)
					{
						throw new Exception(response.RequestMessage.ToString());
					}
					var json = await response.Content.ReadAsStringAsync();
					var guests = JsonConvert.DeserializeObject<IEnumerable<Guest>>(json);

					CreateDataTableGuest(guests);


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

		private void CreateDataTableGuest(IEnumerable<Guest>? guests)
		{
			// Создаем DataTable и добавляем в него данные
			DataTable dataTable = new DataTable();
			dataTable.Columns.Add("Фамилия");
			dataTable.Columns.Add("Имя");
			dataTable.Columns.Add("Отчество");
			foreach (var guest in guests)
			{
				dataTable.Rows.Add(guest.LastName, guest.FirstName, guest.MiddleName);
			}
			// Связываем DataGridView с DataTable
			dataGridViewGuests.DataSource = dataTable;
		}

		private void CreateDataTableGuest2(IEnumerable<Guest>? guests)
		{
			// Создаем DataTable и добавляем в него данные
			DataTable dataTable = new DataTable();
			dataTable.Columns.Add("Фамилия");
			dataTable.Columns.Add("Имя");
			dataTable.Columns.Add("Отчество");
			dataTable.Columns.Add("Начало регистрации");
			dataTable.Columns.Add("Окончание регистрации");

			foreach (var guest in guests)
			{
				dataTable.Rows.Add(guest.LastName, guest.FirstName, guest.MiddleName, guest.RegistrationStartDate, guest.RegistrationEndDate);
			}
			// Связываем DataGridView с DataTable
			dataGridViewMoreInfoGuests.DataSource = dataTable;
		}

		private void InfoMenuForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			Environment.Exit(0);
		}

		private void dataGridViewGuests_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private async void button_GetMoreInfoGuests_Click(object sender, EventArgs e)
		{
			IEnumerable<Guest>? guests = await GetGuests();
			CreateDataTableGuest2(guests);
		}

		private async Task<IEnumerable<Guest>?> GetGuests()
		{
			IEnumerable<Guest>? res = null;
			try
			{
				using (HttpClient httpClient = new HttpClient())
				{
					httpClient.DefaultRequestHeaders.Add("accept", "*");

					var response = await httpClient.GetAsync("https://localhost:5001/api/Guest/GetGuests");

					// Проверяем успешность запроса
					if (!response.IsSuccessStatusCode)
					{
						throw new Exception(response.RequestMessage.ToString());
					}
					var json = await response.Content.ReadAsStringAsync();
					res = JsonConvert.DeserializeObject<IEnumerable<Guest>>(json);
					if (res == null){
						MessageBox.Show($"При получении информации возникла ошибка: \n\r <IEnumerable<Guest> == null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return res;
					}
				}
				
			}
			catch (Exception ex)
			{
				// Обрабатываем исключение
				MessageBox.Show($"При получении информации возникла ошибка: \n\r{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return res;
		} 
	}
}
