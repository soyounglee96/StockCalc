using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace StockCalc.Cui
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient web = new WebClient();
            HtmlDocument document = new HtmlDocument();
            web.Encoding = Encoding.Default;


            //string url = "https://finance.naver.com/sise/sise_market_sum.nhn?&page=" + 1; <--
            string url = "https://finance.naver.com/item/sise_day.nhn?code=005930";
            var html = web.DownloadString(url);

            document.LoadHtml(html);

            //*[@id="middle"]/div[1]/div[1]/div/span[1]
            //var code = document.DocumentNode.SelectSingleNode("//*[@id=\"middle\"]/div[1]/div[1]/div"); // 주소가 다름
            //var tbody = document.DocumentNode.SelectSingleNode("//*[@id=\"contentarea\"]/div[3]/table[1]/tbody"); <--
            var tbody = document.DocumentNode.SelectSingleNode("/html/body/table[1]"); //두번째 웹사이트

            var tr = tbody.ChildNodes.Where(x => x.GetAttributeValue("onmouseover", "").Equals("mouseOver(this)")).ToList();
            //var tr = tbody.ChildNodes.Where(x => x.Name == "tr").ToList();

            foreach (var i in tr)
            {
                var day = i.ChildNodes[3].FirstChild.InnerHtml;
                Console.WriteLine(day);
                //DateTime dateTime = DateTime.ParseExact(day,"yy.MM.dd",null);
                //var count = i.ChildNodes[3].FirstChild.InnerHtml;
            }
        }
    }
}
