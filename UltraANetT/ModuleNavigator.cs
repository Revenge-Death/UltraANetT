using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UltraANetT
{
    public class ModuleNavigator
    {
        PanelControl pcPanel;
        public ModuleNavigator(PanelControl panel)
        {
            pcPanel = panel;
            
        }

        public void AutoTest(XtraUserControl Module)
        {
            pcPanel.Controls.Clear();
            pcPanel.Controls.Add(Module);
        }

        //public void AutoTest(XtraUserControl Module)
        //{
        //    pcPanel.Controls.Clear();
        //    pcPanel.Controls.Add(Module);
        //}
    }
}
