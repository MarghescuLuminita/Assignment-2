using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.IO;
using System.Xml;
using System.Data;
using FurnitureManufacturer.View;

namespace FurnitureManufacturer.Model
{
    public class DataAccess
    {
        DataSet ds = new DataSet();
        private string connString;
        MySqlDataAdapter adapt;

        public ReportOrder reportOrder;

        public DataAccess()
        {
            connString = "datasource=127.0.0.1;port=3306;username=root;password=;database=furniture;";
        }

        public IList<User> RetrieveUsers()
        {
            IList<User> userList = new List<User>();

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string statement = "SELECT * FROM user";

                MySqlCommand cmd = new MySqlCommand(statement, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        User user = new User();
                        user.UserName = reader.GetString("Username");
                        user.Password = reader.GetString("Password");
                        user.IsAdmin = reader.GetBoolean("Admin");
                        user.firstName = reader.GetString("Firstname");
                        user.lastName = reader.GetString("Lastname");
                        userList.Add(user);
                    }
                }
            }
            return userList;
        }

        public User GetUser(string userName)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string statement = "SELECT * FROM user where username LIKE \"%" + userName + "%\";";

                MySqlCommand cmd = new MySqlCommand(statement, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    {
                        User user = new User();
                        user.UserName = reader.GetString("Username");
                        user.Password = reader.GetString("Password");
                        user.firstName = reader.GetString("Firstname");
                        user.lastName = reader.GetString("Lastname");
                        string admin = reader.GetString("Admin");
                        if (Int32.Parse(admin) == 1)
                        {
                            user.IsAdmin = true;
                        }
                        else
                        {
                            user.IsAdmin = false;
                        }

                        return user;
                    }
                }
            }
            return null;
        }

        public void AddUser(User user)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO user(Username, Password, Firstname, Lastname, Admin) VALUES(@username, @password, @firstname, @lastname, @admin)";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@username", user.UserName);
                cmd.Parameters.AddWithValue("@password", user.Password);
                cmd.Parameters.AddWithValue("@firstname", user.firstName);
                cmd.Parameters.AddWithValue("@lastname", user.lastName);
                int admin;
                if (user.IsAdmin == true)
                {
                    admin = 1;
                }
                else
                {
                    admin = 0;
                }
                cmd.Parameters.AddWithValue("@admin", admin);

                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateUser(User user)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "UPDATE user SET Username=@username, Firstname=@firstname, Lastname=@lastname WHERE Admin=0";
                cmd.Prepare();

                cmd.Parameters.Add(new MySqlParameter("@username", user.UserName));
                cmd.Parameters.Add(new MySqlParameter("@firstname", user.firstName));
                cmd.Parameters.Add(new MySqlParameter("@lastname", user.lastName));

                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteUser(User user)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "DELETE from user where Username=@username;";
                cmd.Parameters.AddWithValue("@username", user.UserName);
                cmd.Prepare();

                cmd.ExecuteNonQuery();
            }
        }

        public IList<Product> RetrieveProducts()
        {
            IList<Product> productList = new List<Product>();

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string statement = "SELECT * FROM product";

                MySqlCommand cmd = new MySqlCommand(statement, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Product product = new Product();
                        product.idProduct = reader.GetInt32("idProduct");
                        product.Title = reader.GetString("Title");
                        product.Description = reader.GetString("Description");
                        product.Color = reader.GetString("Color");
                        product.Size = reader.GetInt32("Size");
                        product.Price = reader.GetInt32("Price");
                        product.Stock = reader.GetInt32("Stock");
                        productList.Add(product);
                    }
                }
            }
            return productList;
        }

        public void AddProduct(Product product)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO product(idProduct, Title, Description, Color, Size, Price, Stock) VALUES(@idProduct, @title, @description, @color, @size, @price, @stock)";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@idProduct", product.idProduct);
                cmd.Parameters.AddWithValue("@title", product.Title);
                cmd.Parameters.AddWithValue("@description", product.Description);
                cmd.Parameters.AddWithValue("@color", product.Color);
                cmd.Parameters.AddWithValue("@size", product.Size);
                cmd.Parameters.AddWithValue("@price", product.Price);
                cmd.Parameters.AddWithValue("@stock", product.Stock);

                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateProduct(Product product)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "UPDATE product SET Description=@description, Color=@color, Size=@size, Price=@price, Stock=@stock WHERE Title=@title";
                cmd.Prepare();

                cmd.Parameters.Add(new MySqlParameter("@title", product.Title));
                cmd.Parameters.Add(new MySqlParameter("@description", product.Description));
                cmd.Parameters.Add(new MySqlParameter("@color", product.Color));
                cmd.Parameters.Add(new MySqlParameter("@size", product.Size));
                cmd.Parameters.Add(new MySqlParameter("@price", product.Price));
                cmd.Parameters.Add(new MySqlParameter("@stock", product.Stock));

                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteProduct(Product product)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "DELETE from product where Title=@title;";
                cmd.Parameters.AddWithValue("@title", product.Title);
                cmd.Prepare();

                cmd.ExecuteNonQuery();
            }
        }

        public IList<Order> RetrieveOrders()
        {
            IList<Order> orderList = new List<Order>();

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string statement = "SELECT * FROM orders";

                MySqlCommand cmd = new MySqlCommand(statement, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Order order = new Order();
                        order.idOrder = reader.GetInt32("idOrder");
                        order.Customer = reader.GetString("Customer");
                        order.ShippingAddress = reader.GetString("ShippingAddress");
                        order.IdentificationNumber = reader.GetInt32("IdentificationNumber");
                        order.DeliveryDate = reader.GetDateTime("DeliveryDate");
                        order.Status = reader.GetString("Status");
                        orderList.Add(order);
                    }
                }
            }
            return orderList;
        }

        public void AddOrder(Order order)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO orders (idOrder, Customer, ShippingAddress, IdentificationNumber, DeliveryDate, Status) VALUES (@idOrder, @customer, @shippingAddress, @identificationNumber, @deliveryDate, @status)";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@idOrder", order.idOrder);
                cmd.Parameters.AddWithValue("@customer", order.Customer);
                cmd.Parameters.AddWithValue("@shippingAddress", order.ShippingAddress);
                cmd.Parameters.AddWithValue("@identificationNumber", order.IdentificationNumber);
                cmd.Parameters.AddWithValue("@deliveryDate", order.DeliveryDate);
                cmd.Parameters.AddWithValue("@status", order.Status);

                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateOrder(Order order)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "UPDATE orders SET ShippingAddress=@shippingAddress, IdentificationNumber=@identificationNumber, DeliveryDate=@deliveryDate, Status=@status WHERE Customer=@customer";
                cmd.Prepare();

                cmd.Parameters.Add(new MySqlParameter("@customer", order.Customer));
                cmd.Parameters.Add(new MySqlParameter("@shippingAddress", order.ShippingAddress));
                cmd.Parameters.Add(new MySqlParameter("@identificationNumber", order.IdentificationNumber));
                cmd.Parameters.Add(new MySqlParameter("@deliveryDate", order.DeliveryDate));
                cmd.Parameters.Add(new MySqlParameter("@status", order.Status));

                cmd.ExecuteNonQuery();
            }
        }

        public void AddProductToOrder(OrderDetails orderDetails)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO orderdetails(idOrder, idProduct, PriceUnit, Quantity, Price) VALUES (@idOrder, @idProduct, @priceUnit, @quantity, @price)";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@idOrder", orderDetails.idOrder);
                cmd.Parameters.AddWithValue("@idProduct", orderDetails.idProduct);
                cmd.Parameters.AddWithValue("@priceUnit", orderDetails.PriceUnit);
                cmd.Parameters.AddWithValue("@quantity", orderDetails.Quantity);
                cmd.Parameters.AddWithValue("@price", orderDetails.Price);

                cmd.ExecuteNonQuery();
            }
        }

        public IList<OrderDetails> RetrieveOrderDetails()
        {
            IList<OrderDetails> orderDetailsList = new List<OrderDetails>();

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string statement = "SELECT * FROM orderdetails";

                MySqlCommand cmd = new MySqlCommand(statement, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        OrderDetails orderDetails = new OrderDetails();
                        orderDetails.idOrder = reader.GetInt32("idOrder");
                        orderDetails.idProduct = reader.GetInt32("idProduct");
                        orderDetails.PriceUnit = reader.GetInt32("PriceUnit");
                        orderDetails.Quantity = reader.GetInt32("Quantity");
                        orderDetails.Price = reader.GetInt32("Price");

                        orderDetailsList.Add(orderDetails);
                    }
                }
            }
            return orderDetailsList;
        }

        public IList<Report> RetrieveReports()
        {
            IList<Report> reportList = new List<Report>();

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string statement = "SELECT * FROM reports";

                MySqlCommand cmd = new MySqlCommand(statement, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Report report = new Model.Report();
                        report.idReport = reader.GetInt32("idReport");
                        report.Customer = reader.GetString("Customer");
                        report.addOp = reader.GetInt32("addOp");
                        report.updateOp = reader.GetInt32("updateOp");
                        report.viewOp = reader.GetInt32("viewOp");
                        report.date = reader.GetDateTime("date");
                        reportList.Add(report);
                    }
                }
            }
            return reportList;
        }

        public void AddReport(Report report)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO reports(idReport, Customer, addOp, updateOp, viewOp, date) VALUES (@idReport, @Customer, @addOp, @updateOp, @viewOp, @date)";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@idReport", report.idReport);
                cmd.Parameters.AddWithValue("@Customer", report.Customer);
                cmd.Parameters.AddWithValue("@addOp", report.addOp);
                cmd.Parameters.AddWithValue("@updateOp", report.updateOp);
                cmd.Parameters.AddWithValue("@viewOp", report.viewOp);
                cmd.Parameters.AddWithValue("@date", report.date);

                cmd.ExecuteNonQuery();
            }
        }

        /**
        public void updateReport()
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                adapt = new MySqlDataAdapter("SELECT `idReport`, `Customer`, `addOp`, `updateOp`, `viewOp`, `date` FROM `reports`", conn);
                ds = new System.Data.DataSet();
                adapt.Fill(ds, "Reports_Details");
                reportOrder.gridReportOrder.DataSource = ds.Tables[0];
            }
        }
    */

    }
}