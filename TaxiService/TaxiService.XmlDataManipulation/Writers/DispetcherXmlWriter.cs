using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TaxiService.Entities.Models;
using TaxiService.XmlDataManipulation.Interfaces;

namespace TaxiService.XmlDataManipulation.Writers
{
    public class DispetchersWriter : IWriter
    {
        private string _path;

        public DispetchersWriter(string path)
        {
            _path = path;
        }

        public void CreateXml()
        {
            List<XElement> content = new List<XElement>();

            foreach (var item in GenerateDispetchers())
            {
                content.Add(new XElement("dispetcher",
                    new XElement("username", item.Username),
                    new XElement("password", item.Password),
                    new XElement("email", item.EMail),
                    new XElement("role", item.Role),
                    new XAttribute("banned", item.Banned)
                   ));
            }

            XElement dispetchers = new XElement("dispetchers", content);

            string filePath = Path.Combine(_path, "dispetcher.xml");

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.Write(dispetchers);
            }
        }

        private IEnumerable<Dispetcher> GenerateDispetchers()
        {
            List<Dispetcher> dispetchers = new List<Dispetcher>();

            for (int i = 1; i < 5; i++)
            {
                dispetchers.Add(new Dispetcher()
                {
                    Username = $"admin{i.ToString()}",
                    Password = $"admin",
                    EMail = $"admin{i.ToString()}@uns.ac.rs",
                    Role = "ADMIN",
                    Banned = false
                });
            }

            return dispetchers.ToList();
        }
    }
}
