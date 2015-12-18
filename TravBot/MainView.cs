using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Awesomium.Core;

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

        /// <summary>
        /// method gets source of given path
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public String getSourceOfPath(String path)
        {
            FrameEventHandler handler = null;
            handler = delegate (object sender, FrameEventArgs e)
            {
                if( e.IsMainFrame )
                    this.aBrowser.LoadingFrameComplete -= handler;
                //wait for main frame
            };
            this.aBrowser.LoadingFrameComplete += handler;
            this.aBrowser.Source = new Uri("http://" + this.serverAddr.Text + "/" + path);
            return getBrowserSource();
        }

        private void loginPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
