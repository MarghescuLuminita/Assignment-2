using FurnitureManufacturer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace FurnitureManufacturer.Exporter
{
    public class XMLFormat : IFactoryMethod
    {
        public void saveFile(IList<Report> report)
        {
            string path = @"E:\An III\Sem II\PS\Assign 2 - Final\FurnitureManufacturer\xml.txt";
            XmlTextWriter writer = new XmlTextWriter(path, null);
            writer.WriteStartDocument();
            writer.WriteStartElement("reports");
            foreach (Report item in report)
            {
                writer.WriteStartElement("idReport");
                writer.WriteString(item.idReport.ToString());
                writer.WriteEndElement();

                writer.WriteStartElement("Customer");
                writer.WriteString(item.Customer.ToString());
                writer.WriteEndElement();

                writer.WriteStartElement("addOp");
                writer.WriteString(item.addOp.ToString());
                writer.WriteEndElement();


                writer.WriteStartElement("updateOp");
                writer.WriteString(item.updateOp.ToString());
                writer.WriteEndElement();

                writer.WriteStartElement("IDComanda");
                writer.WriteString(item.viewOp.ToString());
                writer.WriteEndElement();

                writer.WriteStartElement("date");
                writer.WriteString(item.date.ToString());
                writer.WriteEndElement();

            }

            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();
        }
    }
}
