using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureManufacturer.Exporter
{
    public static class FactoryMethod
    {
        
        public static IFactoryMethod getFormat(String tip)
        {
            if (tip.Equals("XML"))
            {
                return new XMLFormat();
            }
    
            else if (tip.Equals("CSV"))
            {
                return new CSVFormat();
            }
            return null;
        }
    }
}
