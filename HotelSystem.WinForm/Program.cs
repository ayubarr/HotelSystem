using System.Diagnostics;
using System.Runtime.InteropServices;

namespace HotelSystem.WinForm
{
    internal static class Program
    {

        [DllImport("kernel32.dll")]
        private static extern bool FreeConsole();

        [DllImport("kernel32.dll")]
        private static extern IntPtr GetConsoleWindow();

        private static Process apiProcess;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
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
            // ���� � ������������ ����� ������ API �������
            string apiPath = @"..\..\..\..\HotelSystem.Api\bin\Debug\net6.0\HotelSystem.API.exe";

            //��������� ��� �������, ������� ����� �� �������� ������������
            var process = new Process();
            process.StartInfo.FileName = apiPath;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;

            // ��������� ������� API �������
            Process.Start(apiPath);
        }

        private static void OnProcessExit(object sender, EventArgs e)
        {
            // ��� �������� ���������� ��������� ������� API
            if (!apiProcess.HasExited)
            {
                apiProcess.Kill();
            }

            // ����������� �������
            FreeConsole();
        }
    }
}