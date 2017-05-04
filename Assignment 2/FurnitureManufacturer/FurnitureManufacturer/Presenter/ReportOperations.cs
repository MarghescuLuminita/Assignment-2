using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FurnitureManufacturer.Model;

namespace FurnitureManufacturer.Presenter
{
    public class ReportOperations
    {
        public IList<Report> RetrieveReports()
        {
            IList<Report> listReport = new List<Report>();
            DataAccess dal = new DataAccess();
            listReport = dal.RetrieveReports();

            return listReport;
        }

        public void AddReport(Report report)
        {
            DataAccess dal = new DataAccess();
            dal.AddReport(report);
        }

        /**
        public void updateReport()
        {
            DataAccess dal = new DataAccess();
            dal.updateReport();
        }
    */
    }
}