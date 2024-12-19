using TCPClientWithUI;

namespace Client
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            // Visual Styles etkinle�tirilir
            Application.EnableVisualStyles();

            // Text rendering i�in uyumlu ayar yap�l�r
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            ApplicationConfiguration.Initialize();
            
        }
    }
}