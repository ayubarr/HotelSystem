using HotelSystem.Domain.Models.Entities;
using HotelSystem.Domain.Models.Enums;
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

		private const string DateTimeFormatApi = "yyyy-MM-ddTHH:mm:ss.fffZ";
		private const string DateTimeFormatWinForm = "dd.MM.yyyy HH:mm";

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
			//dateTimePicker_RegistrationEndDate.Format = DateTimePickerFormat.Custom;
			//dateTimePicker_RegistrationStartDate.CustomFormat = DateTimeFormatWinForm;
			//dateTimePicker_RegistrationEndDate.Format = DateTimePickerFormat.Custom;
			//dateTimePicker_RegistrationEndDate.CustomFormat = DateTimeFormatWinForm;
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


					foreach (var room in rooms)
					{
						string res = room.Number;
						listBox_LuxRooms.Items.Add(res);

						//string res = room.Number += room.IsBooked ? "(Занято)" : "";
						//switch (room.Type)
						//{
						//	case RoomType.Luxe:
						//		listBox_LuxRooms.Items.Add(res);
						//		break;
						//	case RoomType.Vip:
						//		listBox_VipRooms.Items.Add(res);
						//		break;

						//	default:
						//		listBox_StandartRooms.Items.Add(res);
						//		break;
						//}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"При добавлении нового гостя возникла ошибка: \n\r{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private async Task<IEnumerable<Room>?> GetRooms()
		{
			return null;
		}

		private void label_VipRooms_Click(object sender, EventArgs e)
		{

		}
	}
}
