using FurnitureManufacturer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;

namespace FurnitureManufacturer.Exporter
{
    public class CSVFormat : IFactoryMethod
    {
        public void saveFile(IList<Report> report)
        {
            string path = @"E:\An III\Sem II\PS\Assign 2 - Final\FurnitureManufacturer\csv.txt";

            var csv = new StringBuilder();
            foreach (var r in report)
            {
                var newLine = string.Format("{0},{1},{2},{3},{4},{5}", r.idReport.ToString(), r.Customer.ToString(), r.addOp.ToString(), r.updateOp.ToString(), r.viewOp.ToString(), r.date.ToString());
                csv.AppendLine(newLine);

            }

            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(csv);
            }
        }
    }
}
