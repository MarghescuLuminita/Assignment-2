using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FurnitureManufacturer.Presenter;

namespace FurnitureManufacturer.View
{
    public partial class ProductToOrder : Form
    {
        public ProductToOrder()
        {
            InitializeComponent();
        }

        private void gridProductToOrder_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            OrderDetailsOperations orderDetailsOperations = new OrderDetailsOperations();
            gridProductToOrder.DataSource = orderDetailsOperations.RetrieveOrderDetails();
        }
    }
}
