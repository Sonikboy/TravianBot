using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravBot
{
    public class BrowserController : Controller
    {
        private MainView mainView;
        public BrowserController(MainView mainView)
        {
            this.mainView = mainView;
        }

        public void onSelected()
        {
            this.mainView.aBrowser.Source = new Uri("http://" + this.mainView.serverAddr.Text + "/dorf1.php");
            //TODO: pause when browser tab in use
        }
    }
}