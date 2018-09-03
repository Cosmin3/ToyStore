using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ToyStore
{
    public partial class EmpCustDet : System.Web.UI.Page
    {
        WebService1 web = new WebService1();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request["__EVENTARGUMENT"] != null && Request["__EVENTARGUMENT"] == "event 1")
            {
                if (Convert.ToInt32(Session["EmployeeLevel"]) == 3)
                {
                    if (Convert.ToString(Session["State"]) == "Pending")
                        Response.Redirect("EmployeeOrderNegociate.aspx");
                }
            }
            ListBox1.Attributes.Add("ondblclick", ClientScript.GetPostBackEventReference(ListBox1, "event 1"));
            if (!Page.IsPostBack)
            {
                
                ArrayList details = web.getCustomerDetails((int)Session["Customer"]);
                Label2.Text = Convert.ToString(details[0]);
                Label4.Text = Convert.ToString(details[1]);
                Label6.Text = Convert.ToString(details[2]);
                Label8.Text = Convert.ToString(details[3]);
                Label10.Text = Convert.ToString(details[4]);
                Label12.Text = Convert.ToString(details[5]);
                Label14.Text = Convert.ToString(details[6]);
                Label16.Text = Convert.ToString(details[7]);
                Label18.Text = Convert.ToString(details[8]);
                Label20.Text = Convert.ToString(details[9]);
                Label22.Text = Convert.ToString(details[10]);
                Label24.Text = Convert.ToString(details[12]);
                ListBox1.Items.Clear();
                foreach (ArrayList order in web.getOrdersForCustomer((int)Session["Customer"]))
                    ListBox1.Items.Add(order[0]+": "+order[1]);
            }

            
        }
        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (Convert.ToInt32(Session["EmployeeLevel"]) == 3)
            {
                string a = Convert.ToString(ListBox1.SelectedItem.Text);
                bool ok = true;
                string b = "", c = "";
                for (int i = 0; i < a.Length && ok; i++)
                {
                    if (a[i + 1] == ':')
                        ok = false;
                    b = b + a[i];
                }
                ok = true;
                for (int i = a.Length - 1; i > 0 && ok; i--)
                {
                    if (a[i - 1] == ' ' && a[i - 2] == ':')
                        ok = false;
                    c = a[i] + c;
                }

                Session["State"] = c;
                Session["Order"] = b;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Session["LoggedUser"] = "";
            Session["UserName"] = "";
            Response.Redirect("StartPage.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["Customer"] = "";
            Response.Redirect("EmployeeCust.aspx");

        }
    }
}