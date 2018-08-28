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
                ClientScript.RegisterStartupScript(this.GetType(), "myalert1", "alert('" + "You don't have enough credit to purchase the items! Please redo the order" + "');", true);
            }
            else
            {
                if (web.finalizeOrder(Convert.ToDateTime(Session["requiredate"]), Convert.ToInt32(Session["CustomerNr"])))
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert2", "alert('" + " Order sent to employee" + "');", true);
                    Response.Redirect("Customer.aspx");
                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert3", "alert('" + "Error" + "');", true);
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Customer.aspx");
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}