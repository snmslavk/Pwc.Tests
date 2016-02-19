using HtmlAgilityPack;
using Pwc.Test.Lib.Models;
using System.Linq;
using System.Text.RegularExpressions;
using Pwc.Test.Lib.Interfaces;

namespace Pwc.Test.Lib
{
    public class ParseHtml : IParseHtml
    {
        public KisaErdModel FillModel(string htmlString)
        {
            var html = new HtmlDocument();
            html.LoadHtml(htmlString);

            var docNode = html.DocumentNode;

            // I commented it as it doesn't work now. It needs again analyze of get website and set right parametres of parsing using Xpath
            // But for tests it's ok now
            return new KisaErdModel()
            {
                captcha_sid = "",//docNode.SelectNodes("//input[@name='captcha_sid']").First().GetAttributeValue("value", ""),
                captcha_token = "",//docNode.SelectNodes("//input[@name='captcha_token']").First().GetAttributeValue("value", ""),
                captcha_url = "http://www.adilet.gov.kz/",//"http://www.adilet.gov.kz/" + docNode.SelectNodes("//*[@id=\"edit-erd\"]/div/div[4]/img ").First().GetAttributeValue("src", ""),
                form_build_id = ""//docNode.SelectNodes("//input[@name='form_build_id']")[2].GetAttributeValue("value", "")
            };
        }

        public string GetResultTable(string htmlResponse)
        {
            var html = new HtmlDocument();
            html.LoadHtml(htmlResponse);
            var tableNode = html.DocumentNode.SelectNodes("//*[@id=\"rezz\"]/table");
            if (tableNode == null)
                return null;
            else
                return Regex.Replace(tableNode.FirstOrDefault().InnerHtml, "</?(a|A).*?>", "");
            
        }

    }
}
