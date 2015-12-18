using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravBot.ModelObjects;
using HtmlAgilityPack;
using System.Text.RegularExpressions;

namespace TravBot
{
    public class MainModel : Model
    {
        private List<Village> villageList;
        public MainModel()
        {
            villageList = new List<Village>();
        }

        /// <summary>
        /// creates village objects and initialize them with cords name and path
        /// </summary>
        /// <param name="getSourceOfPath"></param>
        public void load_villageData(Func<String, String> getSourceOfPath)
        {
            HtmlDocument htmldoc = new HtmlDocument();
            htmldoc.LoadHtml(getSourceOfPath("dorf1.php"));
            //init name and cords
            String vil = htmldoc.DocumentNode.SelectNodes("//div[@class='name']/ancestor::li/ancestor::ul/ancestor::div[@class='innerBox content']")[0].InnerText;
            vil = Regex.Replace(vil, @"\s{2,}", "");
            vil = Regex.Replace(vil, @"\)", ")" + (char)2);
            String[] villages = vil.Split((char)2);
            foreach (String s in villages)
            {
                foreach (Match match in Regex.Matches(s, @"(?:(.+?)\((.+?)\|(.+?)\))"))
                {
                    villageList.Add(new Village(match.Groups[1].Value, this.stringToInt(match.Groups[2].Value), this.stringToInt(match.Groups[3].Value)));

                }
            }
            String lnk = htmldoc.DocumentNode.SelectNodes("//a/ancestor::li/ancestor::ul/ancestor::div[@class='innerBox content']")[0].InnerHtml;
            int i = 0;
            foreach (Match match in Regex.Matches(lnk, "<a href=\"(.*?)\""))
            {
                villageList[i].initVillageLink(match.Value);
                i++;
            }

        }
    }
}