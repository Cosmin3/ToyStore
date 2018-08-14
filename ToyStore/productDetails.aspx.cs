using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ToyStore
{
    public partial class productDetails : System.Web.UI.Page
    {

        WebService1 web = new WebService1();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string a = (string)(Session["selectedproduct"]);
                double b = (double)(Session["price"]);
                ArrayList arrayList = new ArrayList();
                arrayList = web.GetProductDetails(web.GetProductsCode(a, b));
                TextBox1.Text = web.GetProductsCode(a, b);
                TextBox2.Text = (string)arrayList[0];
                TextBox3.Text = (string)arrayList[1];
                TextBox4.Text = (string)arrayList[2];
                TextBox5.Text = (string)arrayList[3];
                TextBox6.Text = (string)arrayList[4];
                TextBox7.Text = Convert.ToString(arrayList[5]);
                TextBox8.Text = Convert.ToString(arrayList[6]);
                TextBox9.Text = Convert.ToString(arrayList[7]);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToString(Session["loggedUser"]) == "customer")
                Response.Redirect("Customer.aspx");
            else
                Response.Redirect("pcustomer.aspx");
        }
    }
}