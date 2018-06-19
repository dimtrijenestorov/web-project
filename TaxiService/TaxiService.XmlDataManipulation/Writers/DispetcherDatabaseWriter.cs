using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiService.Entities.Models;
using TaxiService.MSSQLRepository.UnitOfWork;
using TaxiService.XmlDataManipulation.Interfaces;
using TaxiService.XmlDataManipulation.Readers;

namespace TaxiService.XmlDataManipulation.Writers
{
    public class DispetcherDatabaseWriter
    {
        private UnitOfWork _unitOfWork;
        private IReader<Dispetcher> _reader;

        public DispetcherDatabaseWriter(UnitOfWork uof, DispetcherXmlReader reader)
        {
            _unitOfWork = uof;
            _reader = reader;
        }
        
        public void SeedDatabase()
        {
            IEnumerable<Dispetcher> data = _reader.GetElements();
            _unitOfWork.UserRepository.AddRange(data);
            _unitOfWork.Complete();
        }
    }
}
