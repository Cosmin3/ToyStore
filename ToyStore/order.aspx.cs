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
        WebService1 web = new WebService1();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ArrayList array = new ArrayList();
                array = web.getOrderDetails(Convert.ToInt32(Session["ordernr"]));
                foreach (string a in array)
                {
                    ListBox1.Items.Add(Convert.ToString(a));
                }
            }
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            Session["requiredate"] = Calendar1.SelectedDate.ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (web.finalizeOrder(Convert.ToDateTime( Session["requiredate"]), Convert.ToInt32(Session["CustomerNr"])))
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + " Order sent to employee" + "');", true);
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Error" + "');", true);
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Customer.aspx");
        }
    }
}