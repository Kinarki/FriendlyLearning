using FriendlyLearning.Models.cs.Domain;
using FriendlyLearning.Services;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace FriendlyLearning.services
{
    public class ScraperService : BaseService, IScraperService
    {
        public AnimalModels GetAll()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            AnimalModels animal = new AnimalModels();
            animal.Info = new List<AnimalModel>();

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
            return animal;
        }
    }
}
