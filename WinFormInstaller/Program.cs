using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormInstaller.Controllers;
using WinFormInstaller.DataModels;

namespace WinFormInstaller
{
    static class Program
    {
        #region private variables

        private static WeatherMap weatherMap = new WeatherMap();
        private static ImageConfigurationController imgConfig = new ImageConfigurationController();
        
        #endregion private variables

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(weatherMap, imgConfig));
        }
    }
}
