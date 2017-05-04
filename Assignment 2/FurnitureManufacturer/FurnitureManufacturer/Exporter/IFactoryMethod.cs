using FurnitureManufacturer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureManufacturer.Exporter
{
    public interface IFactoryMethod
    {
        void saveFile(IList <Report> report);
    }
}