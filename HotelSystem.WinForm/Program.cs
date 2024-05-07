using System.Diagnostics;
using System.Runtime.InteropServices;

namespace HotelSystem.WinForm
{
    internal static class Program
    {
        /// <summary>
        /// ��������� ��� ������� ��� ������� � ������ � ���
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
            // ���� � ������������ ����� ������ API �������
            string apiPath = @"..\..\..\..\HotelSystem.Api\bin\Debug\net6.0\HotelSystem.API.exe";

            //��������� ��� �������, ������� ����� �� �������� ������������
            apiProcess = new Process();
            apiProcess.StartInfo.FileName = apiPath;
            apiProcess.StartInfo.UseShellExecute = false;
            apiProcess.StartInfo.CreateNoWindow = true;

            // ��������� ������� API �������
            apiProcess.Start();
        }

        private static void OnProcessExit(object sender, EventArgs e)
        {
            // ��� �������� ���������� ��������� ������� API
            if (!apiProcess.HasExited)
                apiProcess.Kill();           
        }
    }
}