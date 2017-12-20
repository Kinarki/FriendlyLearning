using FriendlyLearning.Models.cs.Domain;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace FriendlyLearning.Services
{
    public class ScraperService : BaseService
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
                    node.Attributes["src"] != null &&
                    node.Attributes["title"] != null)
                .ToList();

            foreach (var node in nodes)
            {
                AnimalModel item = new AnimalModel();
                item.AnimalName = node.Attributes["title"].Value;
                item.Src = node.Attributes["src"].Value;
                animal.Info.Add(item);
            }
            return animal;
        }
    }
}
