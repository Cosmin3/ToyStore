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
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-K2DSFB8\SQLEXPRESS; Initial Catalog=classicmodels;Integrated Security=True");
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
            List<ArrayList> products=new List<ArrayList>();
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
            command.CommandText = "Select * From Products where productCode='"+productCode+"'";
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
        public List<ArrayList> orderProducts(string ord, string key)//ord=desc || asc , order by key
        {
            List<ArrayList> products = new List<ArrayList>();
            ArrayList element = new ArrayList();

            connection.Open();
            command = connection.CreateCommand();
            if(ord=="desc")
            {
                command.CommandText = "Select * From Products Order by "+key+" DESC";
            }
            else
            {
                command.CommandText = "Select * From Products Order by " + key + " ASC" ;
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
        public List<ArrayList> SearchProductByName(string productName)
        {
            List<ArrayList> products = new List<ArrayList>();
            ArrayList element = new ArrayList();


            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "Select * From Products where productCode in (select productCode from Products where productName Like'%"+productName+"%')";
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
        public bool AddToy(string productCode, string productName, string productLine, string productScale,string productVendor,string productDescription, int quantityInStock,double buyPrice, double MSRP)
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
                if(code==productCode)
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

        
    }
}
