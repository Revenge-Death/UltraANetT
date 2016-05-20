using System;
using DevExpress.XtraSplashScreen;

namespace UltraANetT.Form
{
    public partial class LoadScreen : SplashScreen
    {
        public enum SplashScreenCommand
        {
        }

        public LoadScreen()
        {
            InitializeComponent();
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion
    }
}