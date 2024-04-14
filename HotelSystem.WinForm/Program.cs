using System.Diagnostics;

namespace HotelSystem.WinForm
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            StartApi();
            ApplicationConfiguration.Initialize();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AuthForm());
        }

        static void StartApi()
        {
            // Путь к исполняемому файлу вашего API проекта
            string apiPath = @"C:\Users\Ayub\source\repos\HotelSystem\HotelSystem.API\bin\Debug\net6.0\HotelSystem.API.exe";

            // Запускаем процесс API проекта
            Process.Start(apiPath);
        }
    }
}