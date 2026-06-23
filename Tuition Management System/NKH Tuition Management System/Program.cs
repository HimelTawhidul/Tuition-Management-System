using System.Runtime.InteropServices;

namespace NKH_Tution
{
    internal static class Program
    {
        // Hide console window so no background terminal appears
        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        const int SW_HIDE = 0;

        [STAThread]
        static void Main()
        {
            // Hide console terminal window
            var handle = GetConsoleWindow();
            ShowWindow(handle, SW_HIDE);

            ApplicationConfiguration.Initialize();

            // Ensure all windows close when app exits
            Application.ApplicationExit += (s, e) =>
            {
                Environment.Exit(0);
            };

            Application.Run(new Login());
        }
    }
}
