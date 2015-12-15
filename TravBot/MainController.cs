using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Awesomium.Core;
using System.Threading;

namespace TravBot
{
    public class MainController : Controller
    {

        private MainView mainView;
        private MainModel mainModel;

        //Controllers
        private BrowserController browserCtrl;
        private BuildController buildCtrl;

        public MainController(MainView mainView, MainModel mainModel)
        {
            this.mainView = mainView;
            this.mainModel = mainModel;
            this.browserCtrl = new BrowserController(this.mainView);
            this.buildCtrl = new BuildController(this.mainView, new BuildModel());
            initEvents();
        }

        public void initEvents()
        {
            this.mainView.login.Click += loginEvent;
            this.mainView.tabs.Selected += new TabControlEventHandler(tabControl_Selected);
        }



        /// <summary>
        /// event on tabs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControl_Selected(object sender, TabControlEventArgs e)
        {
            if(e.TabPage.Name == this.mainView.browser.Name)
            {
                browserCtrl.onSelected();
            }
        }

        #region loadVillageData
        private void villageData_Load(object sender, Awesomium.Core.FrameEventArgs e)
        {

            this.mainView.aBrowser.LoadingFrameComplete -= villageData_Load;


        }
        #endregion


        #region loginStuff
        /// <summary>
        /// login event fires when button pushed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loginEvent(object sender, EventArgs e)
        {
            //check for empty fields
            if (this.mainView.userPass.Text == "" || this.mainView.userName.Text == "" || this.mainView.serverAddr.Text == "")
            {
                MessageBox.Show("Fil user, pass and serverAddr!"); return;
            }

            //check if logged inn
            Awesomium.Core.FrameEventHandler loginHandler2 = null;
            loginHandler2 = delegate (object s, Awesomium.Core.FrameEventArgs evt)
            {
                if( evt.IsMainFrame )
                {
                    this.mainView.aBrowser.LoadingFrameComplete -= loginHandler2;
                    if (this.mainView.checkIfBrowserContains("resources.production"))
                    {
                        //login succes disabele fields
                        this.mainView.userPass.Enabled = false;
                        this.mainView.userName.Enabled = false;
                        this.mainView.serverAddr.Enabled = false;
                        this.mainView.login.Enabled = false;

                        //subscribing to buildInit event
                        this.mainView.aBrowser.LoadingFrameComplete += this.villageData_Load;
                        this.mainView.aBrowser.Source = new Uri("http://" + this.mainView.serverAddr.Text + "/dorf1.php");
                    }
                }
            };

            //execute login query
            Awesomium.Core.FrameEventHandler loginHandler = null;
            loginHandler = delegate (object s, Awesomium.Core.FrameEventArgs evt)
            {
                if( evt.IsMainFrame )
                {
                    this.mainView.aBrowser.LoadingFrameComplete -= loginHandler;
                    this.mainView.aBrowser.LoadingFrameComplete += loginHandler2;
                    this.mainView.aBrowser.ExecuteJavascript("document.getElementsByName('name')[0].value = '" + this.mainView.userName.Text + "';");
                    this.mainView.aBrowser.ExecuteJavascript("document.getElementsByName('password')[0].value = '" + this.mainView.userPass.Text + "';");
                    this.mainView.aBrowser.ExecuteJavascript("document.getElementById('s1').click();");
                }
            };

            this.mainView.aBrowser.LoadingFrameComplete += loginHandler;
            this.mainView.aBrowser.Source = new Uri("http://" + this.mainView.serverAddr.Text);
        }

        #endregion

    }
}
