using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;

namespace AQMS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");
        
            SplashScreen1 mSplashForm = new SplashScreen1();
            mSplashForm.ShowDialog();
            if (mSplashForm.DialogResult == DialogResult.Cancel)
            {
                Application.Run(new SysSetting());
            }
            else if (mSplashForm.DialogResult == DialogResult.OK)
            {
                Application.Run(new MainForm());
            }         
        }
    }
}
