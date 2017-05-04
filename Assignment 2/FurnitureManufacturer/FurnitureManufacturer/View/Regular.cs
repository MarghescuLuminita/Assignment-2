using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FurnitureManufacturer.Model;
using FurnitureManufacturer.Presenter;
using FurnitureManufacturer.View;

namespace FurnitureManufacturer
{
    public partial class Regular : Form
    {
        public Regular()
        {
            InitializeComponent();
        }

        private Product RetrieveProductInformation()
        {
            Product product = new Product();
            product.Title = txtProductTitle.Text;
            product.Description = txtProductDescription.Text;
            product.Color = txtProductColor.Text;
            product.Size = Convert.ToInt32(txtProductSize.Text);
            product.Price = Convert.ToInt32(txtProductPrice.Text);
            product.Stock = Convert.ToInt32(txtProductStock.Text) - Convert.ToInt32(txtQuantity.Text);
            return product;
        }

        private Order RetrieveOrderInformation()
        {
            Order order = new Order();
            order.Customer = txtCustomer.Text;
            order.ShippingAddress = txtShippingAddress.Text;
            order.IdentificationNumber = Convert.ToInt32(txtIdentificationNumber.Text);
            order.DeliveryDate = dateDelivery.Value;
            order.Status = txtStatus.Text;
            return order;
        }

        private OrderDetails RetrieveOrderDetailsInformation()
        {
            Product product = new Product();
            Order order = new Order();
            OrderDetails orderDetails = new OrderDetails();

            orderDetails.idProduct = Convert.ToInt32(txtIdProduct.Text);
            orderDetails.idOrder = Convert.ToInt32(txtIdOrder.Text);
            orderDetails.Quantity = Convert.ToInt32(txtQuantity.Text);
            orderDetails.PriceUnit = Convert.ToInt32(txtProductPrice.Text);
            orderDetails.Price = Convert.ToInt32(txtQuantity.Text) * Convert.ToInt32(txtProductPrice.Text);
            return orderDetails;
        }

        /**
        public Report RetrieveReportsInformation()
        {
            Report report = new Report();
            report.Customer = txtCustomer.Text;
            if (btnAddOrderClicked == true)
                report.addOp = 1;
            if (btnUpdateOrderClicked == true)
                report.updateOp = 1;
            if (btnRetrieveOrderClicked == true)
                report.viewOp = 1;
            report.date = DateTime.Now;
            return report;
        }
    */
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                Product product = RetrieveProductInformation();
                ProductOperations productOperations = new ProductOperations();
                productOperations.AddProduct(product);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            try
            {
                Product product = RetrieveProductInformation();
                ProductOperations productOperations = new ProductOperations();
                productOperations.UpdateProduct(product);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            try
            {
                Product product = RetrieveProductInformation();
                ProductOperations productOperations = new ProductOperations();
                productOperations.DeleteProduct(product);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRetrieveProduct_Click(object sender, EventArgs e)
        {
            try
            {
                ProductOperations productOperations = new ProductOperations();
                gridProducts.DataSource = productOperations.RetrieveProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public bool btnAddOrderClicked = false;
        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            try
            {
                Order order = RetrieveOrderInformation();
                OrderOperations orderOperations = new OrderOperations();
                orderOperations.AddOrder(order);

                Report report = new Report();
                ReportOperations reportOperations = new ReportOperations();
                report.Customer = txtCustomer.Text;
                report.addOp = 1;
                report.updateOp = 0;
                report.viewOp = 0;
                report.date = DateTime.Now;
                reportOperations.AddReport(report);
                btnAddOrderClicked = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public bool btnUpdateOrderClicked = false;
        private void btnUpdateOrder_Click(object sender, EventArgs e)
        {
            try
            {
                Order order = RetrieveOrderInformation();
                OrderOperations orderOperations = new OrderOperations();
                orderOperations.UpdateOrder(order);

                Report report = new Report();
                ReportOperations reportOperations = new ReportOperations();
                report.Customer = txtCustomer.Text;
                report.addOp = 0;
                report.updateOp = 1;
                report.viewOp = 0;
                report.date = DateTime.Now;
                reportOperations.AddReport(report);
                btnUpdateOrderClicked = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public bool btnRetrieveOrderClicked = false;
        private void btnRetrieveOrder_Click(object sender, EventArgs e)
        {
            try
            {
                OrderOperations orderOperations = new OrderOperations();
                gridOrders.DataSource = orderOperations.RetrieveOrders();

                Report report = new Report();
                ReportOperations reportOperations = new ReportOperations();
                report.Customer = txtCustomer.Text;
                report.addOp = 0;
                report.updateOp = 0;
                report.viewOp = 1;
                report.date = DateTime.Now;
                reportOperations.AddReport(report);
                btnRetrieveOrderClicked = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        int indexRow;
        private void dataGridProducts(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = gridProducts.Rows[indexRow];
            txtIdProduct.Text = row.Cells[0].Value.ToString();
            txtProductTitle.Text = row.Cells[1].Value.ToString();
            txtProductDescription.Text = row.Cells[2].Value.ToString();
            txtProductColor.Text = row.Cells[3].Value.ToString();
            txtProductSize.Text = row.Cells[4].Value.ToString();
            txtProductPrice.Text = row.Cells[5].Value.ToString();
            txtProductStock.Text = row.Cells[6].Value.ToString();
        }

        private void dataGridOrders(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = gridOrders.Rows[indexRow];
            txtIdOrder.Text= row.Cells[0].Value.ToString();      
            txtCustomer.Text= row.Cells[1].Value.ToString();
            txtShippingAddress.Text = row.Cells[2].Value.ToString();
            txtIdentificationNumber.Text = row.Cells[3].Value.ToString();
            dateDelivery.Text = row.Cells[4].Value.ToString();
            txtStatus.Text = row.Cells[5].Value.ToString();
        }

        private void btnAddProdToOrder_Click(object sender, EventArgs e)
        {
            try
            {
                OrderDetails orderDetails = RetrieveOrderDetailsInformation();
                OrderDetailsOperations orderDetailsOperations = new OrderDetailsOperations();
                orderDetailsOperations.AddProductToOrder(orderDetails);

                ProductToOrder productToOrderFrom = new ProductToOrder();
                productToOrderFrom.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    }
}