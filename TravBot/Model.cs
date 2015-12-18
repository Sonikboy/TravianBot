using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravBot
{
    public abstract class Model
    {

        /// <summary>
        /// parses string to int
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int stringToInt(String s)
        {
            String res = "";
            foreach (char c in s)
            {
                if ((c >= '0' && c <= '9') || c == '-')
                {
                    res += c;
                }
            }
            return int.Parse(res);
        }
    }
}
