using XIIRPL1_08_Ticketing.MasterForm;

namespace XIIRPL1_08_Ticketing
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
            ApplicationConfiguration.Initialize();
            //Login login = new Login();
            //login.Show();

            //FrmMasterBD frmMasterBD = new FrmMasterBD();
            //frmMasterBD.Show();

            FrmMasterMK frmMasterMK = new FrmMasterMK();
            frmMasterMK.Show();

            //FrmMasterKP frmMasterKP = new FrmMasterKP();
            //frmMasterKP.Show();

            //FrmMasterJP frmMasterJP = new FrmMasterJP();
            //frmMasterJP.Show();
            Application.Run();
        }
    }
}