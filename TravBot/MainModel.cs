using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravBot.ModelObjects;

namespace TravBot
{
    public class MainModel : Model
    {
        private List<Village> villageList;
        public MainModel()
        {
            villageList = new List<Village>();
        }


        public void addVillage(Village v)
        {
            villageList.Add(v);
        }



    }
}
