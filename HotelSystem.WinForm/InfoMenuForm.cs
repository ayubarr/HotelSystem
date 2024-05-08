using HotelSystem.Domain.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
			IEnumerable<Guest>? guests = await GetGuests();

			listBoxNames.Items.Clear();
			listBoxNames.Items.Add("Имя гостя\t\t" +
				"Дата начала регистрации \t" +
				"Дата окончания регистрации\t" +
				"Номер гостя");
			foreach (var guest in guests)
			{

				string res = guest.FirstName + "\t\t\t" + guest.RegistrationStartDate + "\t\t" + guest.RegistrationEndDate + "\t\t" + guest.Id;
				listBoxNames.Items.Add(res);
				//Console.WriteLine(guest.FirstName); 
				guest.Payments
			}
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

			dataGridViewMoreInfoGuests.Visible = true;
			button_back.Visible = false;
			button_back2.Visible = true;
		}

		private void CreateDataTableGuest2(IEnumerable<Guest>? guests)
		{
			// Создаем DataTable и добавляем в него данные
			DataTable dataTable = new DataTable();

			DataColumn dataColumn = new DataColumn();
			dataColumn.DataType = typeof(string);
			dataColumn.ColumnName = "Фамилия";
			dataColumn.MaxLength = 500;
			dataTable.Columns.Add(dataColumn);

			dataColumn = new DataColumn();
			dataColumn.DataType = typeof(string);
			dataColumn.ColumnName = "Имя";
			dataColumn.MaxLength = 500;
			dataTable.Columns.Add(dataColumn);

			dataColumn = new DataColumn();
			dataColumn.DataType = typeof(string);
			dataColumn.ColumnName = "Отчество";
			dataColumn.MaxLength = 500;
			dataTable.Columns.Add(dataColumn);

			dataColumn = new DataColumn();
			dataColumn.DataType = typeof(string);
			dataColumn.ColumnName = "Начало регистрации";
			dataColumn.MaxLength = 500;
			dataTable.Columns.Add(dataColumn);

			dataColumn = new DataColumn();
			dataColumn.DataType = typeof(string);
			dataColumn.ColumnName = "Окончание регистрации";
			dataColumn.MaxLength = 500;
			dataTable.Columns.Add(dataColumn);

			dataColumn = new DataColumn();
			dataColumn.DataType = typeof(string);
			dataColumn.ColumnName = "Почта";
			dataColumn.MaxLength = 500;
			dataTable.Columns.Add(dataColumn);

			dataColumn = new DataColumn();
			dataColumn.DataType = typeof(string);
			dataColumn.ColumnName = "Номер телефона";
			dataColumn.MaxLength = 500;
			dataTable.Columns.Add(dataColumn);

			foreach (var guest in guests)
			{
				dataTable.Rows.Add(guest.LastName, guest.FirstName, guest.MiddleName, guest.RegistrationStartDate, guest.RegistrationEndDate, guest.Email, guest.PhoneNumber);
			}
			// Связываем DataGridView с DataTable
			dataGridViewMoreInfoGuests.DataSource = dataTable;
		}


		private async Task<IEnumerable<Guest>?> GetGuests()
		{
			IEnumerable<Guest>? res = null;
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
					res = JsonConvert.DeserializeObject<IEnumerable<Guest>>(json);
					if (res == null)
					{
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

		private void button_back2_click(object sender, EventArgs e)
		{
			dataGridViewMoreInfoGuests.Visible = false;
			button_back.Visible = true;
			button_back2.Visible = false;
		}

		private void listBoxNames_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
