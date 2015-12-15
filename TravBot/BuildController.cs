using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravBot
{
    class BuildController : Controller
    {
        private MainView mainView;
        private BuildModel model;

        public BuildController(MainView mainView, BuildModel model)
        {
            this.mainView = mainView;
            this.model = model;
        }

        public void OnInit(object sender, Awesomium.Core.FrameEventArgs e)
        {
            if ( e.IsMainFrame )
            {
                //unsubscribing itself
                this.mainView.aBrowser.LoadingFrameComplete -= OnInit;
                

            }
        }
    }
}
