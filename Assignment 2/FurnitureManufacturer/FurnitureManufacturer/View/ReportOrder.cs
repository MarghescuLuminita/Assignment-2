using FurnitureManufacturer.Exporter;
using FurnitureManufacturer.Model;
using FurnitureManufacturer.Presenter;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FurnitureManufacturer.View
{
    public partial class ReportOrder : Form
    {
        public ReportOrder()
        {
            InitializeComponent();
        }

        DataSet ds = new DataSet();
        private string connString;
        MySqlDataAdapter adapt;

        public ReportOrder reportOrder;
   
        private void gridReportOrder_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            ReportOperations reportOperations = new ReportOperations();
            gridReportOrder.DataSource = reportOperations.RetrieveReports();
        }

        private void btnSaveCSV_Click(object sender, EventArgs e)
        {
            ReportOperations reportOperations = new ReportOperations();
            IList<Report> report = reportOperations.RetrieveReports();
            IFactoryMethod interf = FactoryMethod.getFormat("CSV");
            interf.saveFile(report);
        }

        private void btnSaveXML_Click(object sender, EventArgs e)
        {
            ReportOperations reportOperations = new ReportOperations();
            IList<Report> report = reportOperations.RetrieveReports();
            IFactoryMethod interf= FactoryMethod.getFormat("XML");
            interf.saveFile(report);
        }
    }
}
