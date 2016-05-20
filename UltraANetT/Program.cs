using System;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.UserSkins;
using UltraANetT.Form;

namespace UltraANetT
{
    internal static class Program
    {
        private static AboutDevCompanion DevCompanion;

        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            DevCompanion = new AboutDevCompanion(1, false);
            DevCompanion.Run();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            SkinManager.EnableFormSkins();
            BonusSkins.Register();
            //UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");

            Application.Run(new Main());
        }
    }
}