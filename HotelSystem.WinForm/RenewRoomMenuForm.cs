using HotelSystem.Domain.Models.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelSystem.WinForm
{
	public partial class RenewRoomMenuForm : Form
	{
		public RenewRoomMenuForm()
		{
			InitializeComponent();
		}

		private void Button_Eviction_Click(object sender, EventArgs e)
		{

		}

		private void Button_Renew_Room_Click(object sender, EventArgs e)
		{

		}

		private void Button_Back_Menu_Click(object sender, EventArgs e)
		{
			new MainMenu().Show();
			Visible = false;
		}

		private async void Button_Update_Click(object sender, EventArgs e)
		{
			try
			{
				using (HttpClient httpClient = new HttpClient())
				{
					httpClient.DefaultRequestHeaders.Add("accept", "*/*");

					HttpResponseMessage response = await httpClient.GetAsync("https://localhost:5001/api/Rooms/GetRooms");

					// Проверяем успешность запроса
					if (!response.IsSuccessStatusCode)
					{
						MessageBox.Show("При получении комнат произошла ошибка", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					var json = await response.Content.ReadAsStringAsync();
					IEnumerable<Room>? rooms = JsonConvert.DeserializeObject<IEnumerable<Room>?>(json);

					foreach (Room room in rooms)
					{
						
					}
				}
			}
			catch (Exception ex)
			{
				// Обрабатываем исключение
				MessageBox.Show($"При получении комнат возникла ошибка: \n\r{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		private async Task<IEnumerable<Room>?> GetRooms()
		{
			return null;
		} 
	}
}
