//using Final_SIM_Brasca.Vista;


//namespace Final_SIM_Brasca
//{
//    internal static class Program
//    {
//        /// <summary>
//        ///  The main entry point for the application.
//        /// </summary>
//        [STAThread]
//        static void Main()
//        {
//            // To customize application configuration such as set high DPI settings or default font,
//            // see https://aka.ms/applicationconfiguration.

//            ApplicationConfiguration.Initialize();
//            Application.Run(new PantallaSimulacion());
//        }
//    }
//}


using Final_SIM_Brasca.Vista;
//using System;
//using System.Windows.Forms;

namespace Final_SIM_Brasca
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Configuración de la aplicación para .NET Framework
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Iniciar la aplicación con la pantalla principal
            Application.Run(new PantallaSimulacion());
        }
    }
}