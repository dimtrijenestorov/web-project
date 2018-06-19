using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiService.Entities.Models;
using TaxiService.MSSQLRepository.UnitOfWork;
using TaxiService.XmlDataManipulation.Interfaces;
using TaxiService.XmlDataManipulation.Readers;
using TaxiService.XmlDataManipulation.Writers;

namespace TaxiService.XMLReader
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"E:\FTN\WEB\Projekat\web-project\TaxiService\TaxiService.XMLReader\RWFiles";

            IWriter writer = new DispetchersWriter(path);

            UnitOfWork uof = new UnitOfWork(new MSSQLRepository.DatabaseContext());
            DispetcherXmlReader reader = new DispetcherXmlReader(path);

            DispetcherDatabaseWriter dispetcherDatabaseWriter = new DispetcherDatabaseWriter(uof, reader);

            dispetcherDatabaseWriter.SeedDatabase();

            writer.CreateXml();
        }
    }
}
