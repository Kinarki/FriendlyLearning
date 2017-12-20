using HtmlAgilityPack;
using System;
using System.Linq;
using System.Net;

namespace WebScraperTester
{
    class Program
    {
        static void Main(string[] args)
        {
            var webClient = new WebClient();
            var html = webClient.DownloadString("https://a-z-animals.com/animals/pictures/");

            var htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(html);

            var nodes = htmlDocument
                .DocumentNode
                .Descendants("img")
                .Where(node =>
                    node.Attributes["src"] != null)
                .ToList();

            foreach (var node in nodes)
            {
                Console.WriteLine(node.Attributes["src"].Value);
            }
            Console.ReadLine();
        }
    }
}
