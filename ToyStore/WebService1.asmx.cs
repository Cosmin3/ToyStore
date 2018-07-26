using System;
using System.Collections;
using System.Collections.Generic;
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
    // [System.Web.Script.Services.ScriptService]
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

       // [WebMethod]
    }
}
