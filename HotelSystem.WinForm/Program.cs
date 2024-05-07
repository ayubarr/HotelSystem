using System.Diagnostics;
using System.Runtime.InteropServices;

namespace HotelSystem.WinForm
{
    internal static class Program
    {
        /// <summary>
        /// Процессор для запуска Апи проекта и работы с ним
        /// </summary>
        private static Process apiProcess;

        [STAThread]
        internal static void Main()
        {
            StartApi();
            AppDomain.CurrentDomain.ProcessExit += new EventHandler(OnProcessExit);

            ApplicationConfiguration.Initialize();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AuthForm());
        }

        private static void StartApi()
        {
            // Путь к исполняемому файлу вашего API проекта
            string apiPath = @"..\..\..\..\HotelSystem.Api\bin\Debug\net6.0\HotelSystem.API.exe";

            //Настройки для запуска, который будет не заметным пользователю
            apiProcess = new Process();
            apiProcess.StartInfo.FileName = apiPath;
            apiProcess.StartInfo.UseShellExecute = false;
            apiProcess.StartInfo.CreateNoWindow = true;

            // Запускаем процесс API проекта
            apiProcess.Start();
        }

        private static void OnProcessExit(object sender, EventArgs e)
        {
            // При закрытии приложения завершаем процесс API
            if (!apiProcess.HasExited)
                apiProcess.Kill();           
        }
    }
}