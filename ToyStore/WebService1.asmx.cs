using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ToyStore
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        SqlConnection connection = new SqlConnection(@"Data Source=.; Initial Catalog=classicmodels;Integrated Security=True");
        SqlCommand command;
        SqlCommandBuilder commandBuilder;
        SqlDataReader reader;
        SqlDataAdapter adapter;
        SqlCommandBuilder builder;
        
        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public string GetProductsCode(string productName, double buyPrice)
        {
            ArrayList products = new ArrayList();
            string productCode;
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "Select productCode as Code From Products where productName='" + productName + "' and buyPrice =" + buyPrice;
            reader = command.ExecuteReader();
            reader.Read();
            productCode = (Convert.ToString(reader["Code"]));


            reader.Close();
            connection.Close();
            return productCode;

        }
        [WebMethod]
        public string GetProductsCode2(string productName)
        {
            ArrayList products = new ArrayList();
            string productCode;
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "Select productCode as Code From Products where productName='" + productName + "'";
            reader = command.ExecuteReader();
            reader.Read();
            productCode = (Convert.ToString(reader["Code"]));


            reader.Close();
            connection.Close();
            return productCode;

        }
        [WebMethod]
        public ArrayList GetProductsName()
        {
            ArrayList products = new ArrayList();
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "Select productName as Name From Products";
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                products.Add(Convert.ToString(reader["Name"]));
            }

            reader.Close();
            connection.Close();
            return products;

        }

        [WebMethod]
        public List<ArrayList> GetProductsNamePrice()
        {
            List<ArrayList> products = new List<ArrayList>();
            ArrayList element = new ArrayList();

            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "Select productName as Name, buyPrice as Price From Products";
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                element.Add(Convert.ToString(reader["Name"]));
                element.Add(Convert.ToDouble(reader["Price"]));
                products.Add((ArrayList)element.Clone());
                element.Clear();
            }

            reader.Close();
            connection.Close();

            return products;

        }

        [WebMethod]
        public ArrayList GetProductDetails(string productCode)
        {
            ArrayList product = new ArrayList();


            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "Select * From Products where productCode='" + productCode + "'";
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                product.Add(Convert.ToString(reader["productName"]));
                product.Add(Convert.ToString(reader["productLine"]));
                product.Add(Convert.ToString(reader["productScale"]));
                product.Add(Convert.ToString(reader["productVendor"]));
                product.Add(Convert.ToString(reader["productDescription"]));
                product.Add(Convert.ToInt32(reader["quantityInStock"]));
                product.Add(Convert.ToDouble(reader["buyPrice"]));
                product.Add(Convert.ToDouble(reader["MSRP"]));


                reader.Close();
                connection.Close();

                return product;
            }

            reader.Close();
            connection.Close();

            return null;

        }

        [WebMethod]
        public List<ArrayList> orderProducts(bool asc, string key) //order by key
        {
            List<ArrayList> products = new List<ArrayList>();
            ArrayList element = new ArrayList();

            connection.Open();
            command = connection.CreateCommand();
            if (!asc)
            {
                command.CommandText = "Select * From Products Order by " + key + " DESC";
            }
            else
            {
                command.CommandText = "Select * From Products Order by " + key + " ASC";
            }

            reader = command.ExecuteReader();
            while (reader.Read())
            {
                element.Add(Convert.ToString(reader["productName"]));
                element.Add(Convert.ToString(reader["productLine"]));
                element.Add(Convert.ToString(reader["productScale"]));
                element.Add(Convert.ToString(reader["productVendor"]));
                element.Add(Convert.ToString(reader["productDescription"]));
                element.Add(Convert.ToInt32(reader["quantityInStock"]));
                element.Add(Convert.ToDouble(reader["buyPrice"]));
                element.Add(Convert.ToDouble(reader["MSRP"]));
                products.Add((ArrayList)element.Clone());
                element.Clear();
            }

            reader.Close();
            connection.Close();

            return products;

        }

        [WebMethod]
        public List<ArrayList> getProducts()
        {
            List<ArrayList> products = new List<ArrayList>();
            ArrayList element = new ArrayList();

            connection.Open();
            command = connection.CreateCommand();

            command.CommandText = "Select * From Products";


            reader = command.ExecuteReader();
            while (reader.Read())
            {
                element.Add(Convert.ToString(reader["productCode"]));
                element.Add(Convert.ToString(reader["productName"]));
                element.Add(Convert.ToString(reader["productLine"]));
                element.Add(Convert.ToString(reader["productScale"]));
                element.Add(Convert.ToString(reader["productVendor"]));
                element.Add(Convert.ToString(reader["productDescription"]));
                element.Add(Convert.ToInt32(reader["quantityInStock"]));
                element.Add(Convert.ToDouble(reader["buyPrice"]));
                element.Add(Convert.ToDouble(reader["MSRP"]));
                products.Add((ArrayList)element.Clone());
                element.Clear();
            }

            reader.Close();
            connection.Close();

            return products;

        }

        [WebMethod]
        public List<ArrayList> SearchProductByName(string productName)
        {
            List<ArrayList> products = new List<ArrayList>();
            ArrayList element = new ArrayList();


            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "Select * From Products where productCode in (select productCode from Products where productName Like'%" + productName + "%')";
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                element.Add(Convert.ToString(reader["productName"]));
                element.Add(Convert.ToString(reader["productLine"]));
                element.Add(Convert.ToString(reader["productScale"]));
                element.Add(Convert.ToString(reader["productVendor"]));
                element.Add(Convert.ToString(reader["productDescription"]));
                element.Add(Convert.ToInt32(reader["quantityInStock"]));
                element.Add(Convert.ToDouble(reader["buyPrice"]));
                element.Add(Convert.ToDouble(reader["MSRP"]));
                products.Add((ArrayList)element.Clone());
                element.Clear();
            }

            reader.Close();
            connection.Close();

            return products;

        }

        [WebMethod]
        public List<ArrayList> filter(string productName, bool asc, string key, string productln)
        {
            List<ArrayList> products = new List<ArrayList>();
            ArrayList element = new ArrayList();


            connection.Open();
            command = connection.CreateCommand();

            if (productName == null)
            {
                if (productln == "-")
                {
                    if (!asc)
                    {
                        command.CommandText = "Select * From Products Order by " + key + " DESC";
                    }
                    else
                    {
                        command.CommandText = "Select * From Products Order by " + key + " ASC";
                    }
                }
                else
                {
                    if (!asc)
                    {
                        command.CommandText = "Select * From Products where  productLine ='" + productln + "'  Order by " + key + " DESC";
                    }
                    else
                    {
                        command.CommandText = "Select * From Products where productLine ='" + productln + "'  Order by " + key + " ASC";
                    }
                }
            }

            else
            {
                if (productln == "-")
                {
                    if (!asc)
                    {
                        command.CommandText = "Select * From Products where productCode in (select productCode from Products where productName Like'%" + productName + "%')  Order by " + key + " DESC";
                    }
                    else
                    {
                        command.CommandText = "Select * From Products where productCode in (select productCode from Products where productName Like'%" + productName + "%')  Order by " + key + " ASC";
                    }
                }
                else
                {
                    if (!asc)
                    {
                        command.CommandText = "Select * From Products where (productCode in (select productCode from Products where productName Like'%" + productName + "%') and productLine ='" + productln + "')  Order by " + key + " DESC";
                    }
                    else
                    {
                        command.CommandText = "Select * From Products where (productCode in (select productCode from Products where productName Like'%" + productName + "%')and productLine ='" + productln + "')  Order by " + key + " ASC";
                    }
                }
            }






            reader = command.ExecuteReader();
            while (reader.Read())
            {
                element.Add(Convert.ToString(reader["productName"]));
                element.Add(Convert.ToString(reader["productLine"]));
                element.Add(Convert.ToString(reader["productScale"]));
                element.Add(Convert.ToString(reader["productVendor"]));
                element.Add(Convert.ToString(reader["productDescription"]));
                element.Add(Convert.ToInt32(reader["quantityInStock"]));
                element.Add(Convert.ToDouble(reader["buyPrice"]));
                element.Add(Convert.ToDouble(reader["MSRP"]));
                products.Add((ArrayList)element.Clone());
                element.Clear();
            }

            reader.Close();
            connection.Close();

            return products;
        }

        [WebMethod]
        public bool AddToy(string productCode, string productName, string productLine, string productScale, string productVendor, string productDescription, int quantityInStock, double buyPrice, double MSRP)
        {
            bool valid = true;
            ArrayList Codes = new ArrayList();
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "Select productCode as Code From Products";
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                Codes.Add(Convert.ToString(reader["Code"]));
            }

            reader.Close();
            connection.Close();

            foreach (string code in Codes)
            {
                if (code == productCode)
                {
                    valid = false;
                }
            }
            if (valid)
            {
                adapter = new SqlDataAdapter("SELECT * FROM Products", connection);
                commandBuilder = new SqlCommandBuilder(adapter);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet, "Products");
                DataRow dataRow = dataSet.Tables["Products"].NewRow();
                dataRow["productCode"] = productCode;
                dataRow["productName"] = productName;
                dataRow["productLine"] = productLine;
                dataRow["productScale"] = productScale;
                dataRow["productVendor"] = productVendor;
                dataRow["productDescription"] = productDescription;
                dataRow["quantityInStock"] = quantityInStock;
                dataRow["buyPrice"] = buyPrice;
                dataRow["MSRP"] = MSRP;
                dataSet.Tables["Products"].Rows.Add(dataRow);
                try
                {
                    adapter.Update(dataSet, "Products");
                    return true;

                }
                catch (SqlException ex)
                {
                    Console.WriteLine(" Nu am putut actualiza baza de date: " + ex.Message);
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Codul deja exista");
                return false;
            }




        }


        [WebMethod]
        public ArrayList GetProductLine()
        {
            ArrayList lines = new ArrayList();
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "Select Distinct productLine as Line From Products Order by Line ASC";
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                lines.Add(Convert.ToString(reader["Line"]));
            }

            reader.Close();
            connection.Close();
            return lines;
        }


        [WebMethod]
        public bool checkLogInEmp(string user, string pass)
        {
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "Select email as 'user', employeeNumber as 'pass' from Employees";
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                if ((Convert.ToString(reader["user"]) == user) && (Convert.ToString(reader["pass"]) == pass))
                {
                    return true;
                }
            }

            reader.Close();
            connection.Close();
            return false;
        }

        [WebMethod]
        public bool checkLogInCust(string user, string pass)
        {
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "Select phone as 'user', customerNumber as 'pass' from Customers";
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                if ((Convert.ToString(reader["user"]) == user) && (Convert.ToString(reader["pass"]) == pass))
                {
                    return true;
                }
            }

            reader.Close();
            connection.Close();
            return false;
        }

        [WebMethod]
        public bool checkLogInAdmin(string user, string pass)
        {

            if ((user == "admin") && (pass == "admin"))
            {
                return true;
            }

            return false;
        }


        [WebMethod]
        public bool deleteToy(string productName)
        {
            connection.Open();
            adapter = new SqlDataAdapter("SELECT * FROM Products ORDER BY productName", connection);

            builder = new SqlCommandBuilder(adapter);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, "Products");

            DataColumn[] pk = new DataColumn[1];
            pk[0] = dataSet.Tables["Products"].Columns["productName"];
            dataSet.Tables["Products"].PrimaryKey = pk;
            DataRow caut = null;
            while (caut == null)
            {

                caut = dataSet.Tables["Products"].Rows.Find(productName);
            }

            try
            {

                caut.Delete();
                adapter.Update(dataSet, "Products");
                connection.Close();
                Console.WriteLine("OK");
                return true;
            }
            catch (SqlException ex)
            {
                connection.Close();
                Console.WriteLine("Error: 0" + ex);
                return false;
            }
        }

        [WebMethod]
        public bool UpdateToy(string productCode, string productName, string productLine, string productScale, string productVendor, string productDescription, int quantityInStock, double buyPrice, double MSRP)
        {

            ArrayList productList = new ArrayList();
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "Select productCode as Code From Products order by productCode";
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                productList.Add(Convert.ToString(reader["Code"]));
            }

            reader.Close();
            connection.Close();

            int row = 0;
            int ok = 0;
            foreach (string slist in productList)
            {
                if (productCode == slist)
                    ok = 1;
                if (productCode != slist && ok == 0)
                    row++;

            }

            adapter = new SqlDataAdapter("Select * from Products order by productCode", connection);


            builder = new SqlCommandBuilder(adapter);
            DataSet dataset = new DataSet();

            adapter.Fill(dataset, "Products");

            dataset.Tables["Products"].Rows[row]["productName"] = productName;
            dataset.Tables["Products"].Rows[row]["productLine"] = productLine;
            dataset.Tables["Products"].Rows[row]["productScale"] = productScale;
            dataset.Tables["Products"].Rows[row]["productVendor"] = productVendor;
            dataset.Tables["Products"].Rows[row]["productDescription"] = productDescription;
            dataset.Tables["Products"].Rows[row]["quantityInStock"] = quantityInStock;
            dataset.Tables["Products"].Rows[row]["buyPrice"] = buyPrice;
            dataset.Tables["Products"].Rows[row]["MSRP"] = MSRP;

            try
            {

                adapter.Update(dataset, "Products");


                connection.Close();
                Console.WriteLine("OK");
                return true;
            }
            catch (SqlException ex)
            {
                connection.Close();
                Console.WriteLine("Error: 0" + ex);
                return false;
            }
        }


        [WebMethod]
        public bool addCustomer(int employeeNumber, string customerName, string contactLastName, string contactFirstName, string phone, string addressLine1, string addressLine2, string city, string state, string postalCode, string country, double creditLimit)
        {


            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "Select top (1) customerNumber from Customers order by customerNumber desc";
            reader = command.ExecuteReader();
            reader.Read();
            int lastCode = Convert.ToInt32(reader["customerNumber"]);

            reader.Close();
            connection.Close();


            adapter = new SqlDataAdapter("SELECT * FROM Customers", connection);
            commandBuilder = new SqlCommandBuilder(adapter);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, "Customers");
            DataRow dataRow = dataSet.Tables["Customers"].NewRow();
            dataRow["customerNumber"] = lastCode + 1;
            dataRow["customerName"] = customerName;
            dataRow["contactLastName"] = contactLastName;
            dataRow["contactFirstName"] = contactFirstName;
            dataRow["phone"] = phone;
            dataRow["addressLine1"] = addressLine1;
            dataRow["addressLine2"] = addressLine2;
            dataRow["city"] = city;
            dataRow["state"] = state;
            dataRow["postalCode"] = postalCode;
            dataRow["country"] = country;
            dataRow["salesRepEmployeeNumber"] = employeeNumber;
            dataRow["creditLimit"] = creditLimit;

            dataSet.Tables["Customers"].Rows.Add(dataRow);
            try
            {
                adapter.Update(dataSet, "Customers");
                return true;

            }
            catch (SqlException ex)
            {
                Console.WriteLine(" Nu am putut actualiza baza de date: " + ex.Message);
                return false;
            }

        }

        [WebMethod]
        public ArrayList getEmployeeDetails(int employeeNumber)
        {
            ArrayList employee = new ArrayList();


            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "Select * From Employees where employeeNumber='" + employeeNumber + "'";
            reader = command.ExecuteReader();
            if (reader.Read())
            {


                employee.Add(Convert.ToInt32(reader["employeeNumber"]));
                employee.Add(Convert.ToString(reader["lastName"]));
                employee.Add(Convert.ToString(reader["firstName"]));
                employee.Add(Convert.ToString(reader["extension"]));
                employee.Add(Convert.ToString(reader["email"]));
                employee.Add(Convert.ToString(reader["officeCode"]));
                employee.Add(Convert.ToInt32(reader["reportsTo"]));
                employee.Add(Convert.ToString(reader["jobTitle"]));


                reader.Close();
                connection.Close();

                return employee;
            }

            reader.Close();
            connection.Close();

            return null;
        }

        [WebMethod]
        public ArrayList getCustomersForEmployee(int employeeNumber)
        {
            ArrayList customers = new ArrayList();
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "Select customerName as Name From Customers where salesRepEmployeeNumber='" + employeeNumber + "'";
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                customers.Add(Convert.ToString(reader["Name"]));
            }

            reader.Close();
            connection.Close();
            return customers;
        }


        [WebMethod]
        public List<ArrayList> getOrdersForCustomer(int customerNumber)
        {
            List<ArrayList> orders = new List<ArrayList>();
            ArrayList order = new ArrayList();
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "Select orderNumber, status From Orders where customerNumber='" + customerNumber + "'";
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                order.Add(Convert.ToString(reader["orderNumber"]));
                order.Add(Convert.ToString(reader["status"]));
                orders.Add((ArrayList)order.Clone());
                order.Clear();
            }

            reader.Close();
            connection.Close();
            return orders;
        }

        [WebMethod]
        public int getCustomerNumber(string customerName)
        {
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "Select customerNumber as number From Customers where CustomerName='" + customerName + "'";
            reader = command.ExecuteReader();
            reader.Read();
            int number = Convert.ToInt32(reader["number"]);
            reader.Close();
            connection.Close();
            return number;

        }

        [WebMethod]
        public ArrayList getCustomerDetails(int customerNumber)
        {
            ArrayList customer = new ArrayList();


            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "Select * From Customers where customerNumber='" + customerNumber + "'";
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                customer.Add(Convert.ToInt32(reader["customerNumber"]));
                customer.Add(Convert.ToString(reader["customerName"]));
                customer.Add(Convert.ToString(reader["contactLastName"]));
                customer.Add(Convert.ToString(reader["contactFirstName"]));
                customer.Add(Convert.ToString(reader["phone"]));
                customer.Add(Convert.ToString(reader["addressLine1"]));
                customer.Add(Convert.ToString(reader["addressLine2"]));
                customer.Add(Convert.ToString(reader["city"]));
                customer.Add(Convert.ToString(reader["state"]));
                customer.Add(Convert.ToString(reader["postalCode"]));
                customer.Add(Convert.ToString(reader["country"]));
                customer.Add(Convert.ToInt32(reader["salesRepEmployeeNumber"]));
                customer.Add(Convert.ToDouble(reader["creditLimit"]));


                reader.Close();
                connection.Close();

                return customer;
            }

            reader.Close();
            connection.Close();

            return null;
        }


        [WebMethod]
        public ArrayList empPendingOrders(int empNumber)
        {
            ArrayList orders = new ArrayList();


            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "Select orderNumber from Orders where (customerNumber in (Select customerNumber from customers where salesRepEmployeeNumber = '" + empNumber + "') and status = 'Pending')";
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                orders.Add(Convert.ToInt32(reader["orderNumber"]));
            }

            reader.Close();
            connection.Close();

            return orders;

        }
        [WebMethod]
        public int addOrder(ArrayList arrayList, bool arg)
        {
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "Select top (1) orderNumber from OrderDetails order by orderNumber desc";
            reader = command.ExecuteReader();
            reader.Read();
            int lastCode = Convert.ToInt32(reader["orderNumber"]);
            reader.Close();
            connection.Close();
            adapter = new SqlDataAdapter("SELECT * FROM OrderDetails", connection);
            commandBuilder = new SqlCommandBuilder(adapter);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, "OrderDetails");
            DataRow dataRow = dataSet.Tables["OrderDetails"].NewRow();
            dataRow["orderNumber"] = lastCode + Convert.ToInt32(arg);
            dataRow["productCode"] = this.GetProductsCode(Convert.ToString(arrayList[0]), Convert.ToDouble(Session["price"]));
            dataRow["quantityOrdered"] = arrayList[1];
            dataRow["priceEach"] = arrayList[2];
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "Select top (1) orderLineNumber from OrderDetails where orderNumber=" + lastCode + " order by orderLineNumber desc";
            reader = command.ExecuteReader();
            reader.Read();
            int lineCode = Convert.ToInt32(reader["orderLineNumber"]);
            reader.Close();
            connection.Close();
            dataRow["orderLineNumber"] = lineCode + 1;
            dataSet.Tables["OrderDetails"].Rows.Add(dataRow);
            try
            {
                adapter.Update(dataSet, "OrderDetails");
                return Convert.ToInt32(dataRow["orderNumber"]);

            }
            catch (SqlException ex)
            {
                Console.WriteLine(" Nu am putut actualiza baza de date: " + ex.Message);
                return 0;
            }
        }
        [WebMethod]
        public ArrayList getOrderDetails(int orderNumber)
        {


            ArrayList products = new ArrayList();


            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "SELECT productName as name from products where productCode in (select productCode from OrderDetails where orderNumber =" + orderNumber + ")";
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                products.Add(Convert.ToString(reader["name"]));

            }

            reader.Close();
            connection.Close();

            return products;



        }
        [WebMethod]
        public ArrayList getOrderproductCode(int orderNumber)
        {
            ArrayList array = new ArrayList();
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "SELECT productCode from OrderDetails where orderNumber="+orderNumber;
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                array.Add(Convert.ToString(reader["productCode"]));
            }
            reader.Close();
            connection.Close();
            return array;
        }
        [WebMethod]
        public ArrayList getOrderProductDetails(int orderNumber, string productCode)
        {


            ArrayList product = new ArrayList();


            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "SELECT p.productName as name, p.quantityInStock as instock, o.priceEach as price, o.quantityOrdered as ordered from OrderDetails o join Products p on o.productCode = p.productCode where o.orderNumber =" + orderNumber + "and p.productCode='" + productCode + "'";
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                product.Add(Convert.ToString(reader["name"]));
                product.Add(Convert.ToInt32(reader["instock"]));
                product.Add(Convert.ToDouble(reader["price"]));
                product.Add(Convert.ToInt32(reader["ordered"]));

                reader.Close();
                connection.Close();

                return product;
            }

            reader.Close();
            connection.Close();

            return null;



        }
        [WebMethod]
        public bool productquantity(string productCode,int quantity)
        {
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText="select quantityInStock from Products where productCode = '"+productCode+"'";
            reader = command.ExecuteReader();
            reader.Read();
            if (Convert.ToInt32(reader["quantityInStock"]) < quantity)
            {
                reader.Close();
                connection.Close();
                return false;
            }
            else
            {
                reader.Close();
                connection.Close();
                return true;
            }
        }
        [WebMethod]
        public bool finalizeOrder(DateTime reqdate,int cust)
        {
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "Select top (1) orderNumber from OrderDetails order by orderNumber desc";
            reader = command.ExecuteReader();
            reader.Read();
            int lastCode = Convert.ToInt32(reader["orderNumber"]);
            reader.Close();
            connection.Close();
            adapter = new SqlDataAdapter("SELECT * FROM Orders", connection);
            commandBuilder = new SqlCommandBuilder(adapter);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, "Orders");
            DataRow dataRow = dataSet.Tables["Orders"].NewRow();
            dataRow["orderNumber"] = lastCode;
            dataRow["orderDate"] = DateTime.Now;
            dataRow["requiredDate"] = reqdate;
            dataRow["shippedDate"] = null;
            dataRow["status"] = "Pending";
            dataRow["comments"] = null;
            dataRow["customerNumber"] = Session["CustomerNr"];
            dataSet.Tables["Orders"].Rows.Add(dataRow);
           /* try
            {*/
                adapter.Update(dataSet, "Orders");
                return true;


        }
        [WebMethod]
        public bool checkCustomercredit(int customerNumber,int ordercost)
        {
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "select creditLimit from Customers where customerNumber =" + customerNumber;
            reader = command.ExecuteReader();
            reader.Read();
            if (Convert.ToInt32(reader["creditLimit"]) < ordercost)
            {
                reader.Close();
                connection.Close();
                return false;
            }
            else
            {
                reader.Close();
                connection.Close();
                return true;
            }
        }
        [WebMethod]
         public bool acceptOrderDetails(string productCode, int newQuant)
        {
            ArrayList productList = new ArrayList();
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "Select productCode as Code From Products order by productCode";
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                productList.Add(Convert.ToString(reader["Code"]));
            }

            reader.Close();
            connection.Close();

            int row = 0;
            int ok = 0;
            foreach (string slist in productList)
            {
                if (productCode == slist)
                    ok = 1;
                if (productCode != slist && ok == 0)
                    row++;

            }

            adapter = new SqlDataAdapter("Select * from Products order by productCode", connection);


            builder = new SqlCommandBuilder(adapter);
            DataSet dataset = new DataSet();

            adapter.Fill(dataset, "Products");


            dataset.Tables["Products"].Rows[row]["quantityInStock"] = newQuant;
            

            try
            {

                adapter.Update(dataset, "Products");


                connection.Close();
                Console.WriteLine("OK");
                return true;
            }
            catch (SqlException ex)
            {
                connection.Close();
                Console.WriteLine("Error: 0" + ex);
                return false;
            }
        }

        [WebMethod]
        public bool acceptOrder(string orderNumber)
        {
            ArrayList productList = new ArrayList();
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "Select orderNumber as Number From Orders order by orderNumber";
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                productList.Add(Convert.ToString(reader["Number"]));
            }

            reader.Close();
            connection.Close();

            int row = 0;
            int ok = 0;
            foreach (string slist in productList)
            {
                if (orderNumber == slist)
                    ok = 1;
                if (orderNumber != slist && ok == 0)
                    row++;

            }

            adapter = new SqlDataAdapter("Select * from Orders order by orderNumber", connection);


            builder = new SqlCommandBuilder(adapter);
            DataSet dataset = new DataSet();

            adapter.Fill(dataset, "Orders");


            dataset.Tables["Orders"].Rows[row]["status"] = "Shipped";


            try
            {

                adapter.Update(dataset, "Orders");


                connection.Close();
                Console.WriteLine("OK");
                return true;
            }
            catch (SqlException ex)
            {
                connection.Close();
                Console.WriteLine("Error: 0" + ex);
                return false;
            }
        }
        [WebMethod]
        public bool EmpToCustOffer(string orderNumber)
        {
            ArrayList orderList = new ArrayList();
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "Select orderNumber From Orders order by orderNumber";
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                orderList.Add(Convert.ToString(reader["orderNumber"]));
            }

            reader.Close();
            connection.Close();

            int row = 0;
            int ok = 0;
            foreach (string slist in orderList)
            {
                if (orderNumber == slist)
                    ok = 1;
                if (orderNumber != slist && ok == 0)
                    row++;

            }

            adapter = new SqlDataAdapter("Select * from Orders order by orderNumber", connection);


            builder = new SqlCommandBuilder(adapter);
            DataSet dataset = new DataSet();

            adapter.Fill(dataset, "Orders");


            dataset.Tables["Orders"].Rows[row]["status"] = "Renegociate";


            try
            {

                adapter.Update(dataset, "Orders");


                connection.Close();
                Console.WriteLine("OK");
                return true;
            }
            catch (SqlException ex)
            {
                connection.Close();
                Console.WriteLine("Error: 0" + ex);
                return false;
            }
        }

        [WebMethod]
        public bool updateOrderDetail(int orderNumber, string productCode, int quantityOrdered, double priceEach)
        {

            try 
            {

                using (SqlCommand command = connection.CreateCommand())
                {
                   // command = connection.CreateCommand();
                    command.CommandText = "Update OrderDetails Set quantityOrdered = @quant, priceEach = @price where (orderNumber= @number and productCode = @cod)";

                    command.Parameters.AddWithValue("@quant", quantityOrdered);
                    command.Parameters.AddWithValue("@price", priceEach);
                    command.Parameters.AddWithValue("@number", orderNumber);
                    command.Parameters.AddWithValue("@cod", productCode);
                    
                    
                    

                    // command.ExecuteNonQuery();
                    connection.Open();
                    command.ExecuteNonQuery();


                    connection.Close();
                    return true;
                }

            }
            catch (SqlException ex)
            {
                return false;
            }
        }
    }
}
