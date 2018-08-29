using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ToyStore
{
    public partial class order : System.Web.UI.Page
    {
        public int cost;
        WebService1 web = new WebService1();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ArrayList array = new ArrayList();
                ArrayList prod = new ArrayList();
                array = web.getOrderproductCode(Convert.ToInt32(Session["ordernr"]));
                foreach (string a in array)
                {
                    prod = web.getOrderProductDetails(Convert.ToInt32(Session["ordernr"]), a);
                    ListBox1.Items.Add(prod[0] + "..." + prod[2] + "..." + prod[3]);
                    cost+= Convert.ToInt32(prod[2]) * Convert.ToInt32(prod[3]);
                }
                Session["cost"] = cost;
            }
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            Session["requiredate"] = Calendar1.SelectedDate.ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (!web.checkCustomercredit(Convert.ToInt32(Session["CustomerNr"]), Convert.ToInt32(Session["cost"])))
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + " You don't have enought credit" + "');", true);
            }
            else
            {
                if (web.finalizeOrder(Convert.ToDateTime(Session["requiredate"]), Convert.ToInt32(Session["CustomerNr"])))
                {

                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + " Order sent to employee" + "');", true);
                    Response.Redirect("Customer.aspx");
                    ListBox1.Items.Clear();
                    Session["ordernr"] = 0;
                    
                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + " Eroare" + "');", true);

                }
            }
        }
        private void refresh()
        {
            ListBox1.Items.Clear();

            ArrayList array = new ArrayList();
            ArrayList prod = new ArrayList();
            array = web.getOrderproductCode(Convert.ToInt32(Session["ordernr"]));
            foreach (string a in array)
            {
                prod = web.getOrderProductDetails(Convert.ToInt32(Session["ordernr"]), a);
                ListBox1.Items.Add(prod[0] + "..." + prod[2] + "..." + prod[3]);

            }
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Customer.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            String a = Convert.ToString(ListBox1.SelectedItem.Text);
            bool ok = true;
            String b = "";
            for (int i = 0; i < a.Length && ok; i++)
            {
                if (a[i + 1] == '.' && a[i + 2] == '.' && a[i + 3] == '.')
                    ok = false;
                b = b + a[i];
            }

            web.removeCart(web.GetProductsCode2(b),Convert.ToInt32(Session["ordernr"]));
            this.refresh();


        }
        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}