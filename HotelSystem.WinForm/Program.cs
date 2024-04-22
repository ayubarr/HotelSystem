using System.Diagnostics;

namespace HotelSystem.WinForm
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        internal static void Main()
        {
            StartApi();
            ApplicationConfiguration.Initialize();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AuthForm());
        }

        private static void StartApi()
        {
            // ���� � ������������ ����� ������ API �������
            string apiPath = @"..\..\..\..\HotelSystem.Api\bin\Debug\net6.0\HotelSystem.API.exe";

            // ��������� ������� API �������
            Process.Start(apiPath);
        }
    }
}