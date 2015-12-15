using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravBot
{
    static class Program
    {

        public static readonly String version = "v0.1"; //version string

        static MainView mainView;
        static MainController mainController;
        static MainModel mainModel;

        static Boolean botPause = true;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Program.mainView = new MainView();
            Program.mainModel = new MainModel();
            Program.mainController = new MainController(Program.mainView, Program.mainModel);
            Application.Run(Program.mainView);
        }
    }
}
