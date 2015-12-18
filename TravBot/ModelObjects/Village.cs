using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravBot.ModelObjects
{
    public class Village
    {

        public String name { get; private set; }
        public int X { get; private set; }
        public int Y { get; private set; }
        public String link { get; private set; }
        public Village(String name, int x, int y)
        {
            this.name = name;
            this.X = x;
            this.Y = y;
            System.Diagnostics.Debug.WriteLine("Created Village object name: " + this.name + " (" + this.X + ", " + this.Y + ")");
        }

        public void initVillageLink(String lnk)
        {
            this.link = lnk.Substring(9, lnk.IndexOf(';') - 9);
            System.Diagnostics.Debug.WriteLine("Added link for '" + this.name + "' link: " + this.link);
        }
    }
}
