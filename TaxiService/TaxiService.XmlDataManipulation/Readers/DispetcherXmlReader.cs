using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TaxiService.Entities.Models;
using TaxiService.XmlDataManipulation.Interfaces;

namespace TaxiService.XmlDataManipulation.Readers
{
    public class DispetcherXmlReader : IReader<Dispetcher>
    {
        private string _path;

        public DispetcherXmlReader(string path)
        {
            _path = path;
        }

        public IEnumerable<Dispetcher> GetElements()
        {
            string filePath = Path.Combine(_path, "dispetcher.xml");

            XElement root = XElement.Load(filePath);

            string dispetchersString = File.ReadAllText(filePath);

            XDocument xDocument = XDocument.Parse(dispetchersString);

            IEnumerable<Dispetcher> dispetchers = from x in xDocument.Descendants("dispetcher")
                                                  select new Dispetcher()
                                                  {
                                                      Username = (string)x.Element("username"),
                                                      Password = (string)x.Element("password"),
                                                      EMail = (string)x.Element("email"),
                                                      Banned = Convert.ToBoolean(x.Element("banned")),
                                                      Role = (string)x.Element("role")
                                                  };

            return dispetchers.ToList();
        }

    }
}
