using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiService.XmlDataManipulation.Interfaces
{
    public interface IReader<T> where T : class
    {
        IEnumerable<T> GetElements();
    }
}
