using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravBot
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            initMainWB();
            initTabs();
        }
        
        private void initTabs()
        {

        }


        /// <summary>
        /// initializer method for mainWB
        /// </summary>
        public void initMainWB ()
        {
            this.mainWB.Visible = false;
        }

        /// <summary>
        /// returns the source of current loaded page
        /// </summary>
        /// <returns></returns>
        public String getBrowserSource()
        {
            return aBrowser.HTML;
        }

        /// <summary>
        /// returns true if source contains text
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public Boolean checkIfBrowserContains(String text)
        {
            return getBrowserSource().Contains(text);
        }
    }
}
