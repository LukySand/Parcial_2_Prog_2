using Microsoft.VisualBasic.Logging;

namespace MemoTest
{
    internal static class Program
    {
        public static int Difficulty; // 0 is Easy difficulty, while 1 is hard difficulty
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Controladores.Conexion.OpenConnection();
            new Menu().ShowDialog();

            Application.Run(new Game(Difficulty));
            Controladores.Conexion.CloseConnection();
        }
    }
}