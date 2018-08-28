using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ToyStore
{
    public partial class Customer : System.Web.UI.Page
    {
        int a;
        bool cat;
        WebService1 web = new WebService1();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request["__EVENTARGUMENT"] != null && Request["__EVENTARGUMENT"] == "event 1")
            {
                Response.Redirect("productDetails.aspx");
            }
            ListBox1.Attributes.Add("ondblclick", ClientScript.GetPostBackEventReference(ListBox1, "event 1"));

            if (!Page.IsPostBack)
            {
                ArrayList array = new ArrayList();
                array=web.getCustomerDetails(Convert.ToInt32(Session["CustomerNr"]));
                this.Label4.Text = "Welcome: " + array[1];
                this.refresh();
            }
        }
        private void refresh()
        {
            ListBox1.Items.Clear();

            bool arg = true;
            if (DropDownList2.SelectedItem.Text == "Descendent")
                arg = false;
            else
                arg = true;
            List<ArrayList> ts = new List<ArrayList>();
            ts = web.filter("", arg, "buyPrice", "-");
            foreach (ArrayList prod in ts)
            {
                ListBox1.Items.Add(prod[0] + "..." + prod[6]);
            }
            DropDownList3.Items.Add("-");
            foreach (String a in web.GetProductLine())
                DropDownList3.Items.Add(a);
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Session["LoggedUser"] = "";
            Response.Redirect("StartPage.aspx");
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String a = Convert.ToString(ListBox1.SelectedItem.Text);
            bool ok = true;
            String b = "", c = "";
            for (int i = 0; i < a.Length && ok; i++)
            {
                if (a[i + 1] == '.' && a[i + 2] == '.' && a[i + 3] == '.')
                    ok = false;
                b = b + a[i];
            }
            ok = true;
            for (int i = a.Length - 1; i > 0 && ok; i--)
            {
                if (a[i - 1] == '.' && a[i - 2] == '.')
                    ok = false;
                c = a[i] + c;
            }
            Session["selectedproduct"] = b;
            Session["price"] = Convert.ToDouble(c);

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            ListBox1.Items.Clear();
            bool arg = true;
            if (DropDownList2.SelectedItem.Text == "Descendent")
                arg = false;
            else
                arg = true;
            List<ArrayList> ts = new List<ArrayList>();
            ts = web.filter(TextBox1.Text, arg, DropDownList1.SelectedValue, DropDownList3.SelectedItem.Text);
            foreach (ArrayList prod in ts)
            {
                ListBox1.Items.Add(prod[0] + "........." + prod[6]);
            }
            DropDownList3.Items.Clear();
            DropDownList3.Items.Add("-");
            foreach (String a in web.GetProductLine())
                DropDownList3.Items.Add(a);
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("order.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Session["CustomerNr"] ==Session["sameorder"])
            {
                cat = false;
            }
            else
            {
                cat = true;
            }
            ArrayList ts = new ArrayList();
            ts.Add(Session["selectedproduct"]);
            int i;
            if (!int.TryParse(TextBox2.Text, out i))
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "The Quantity must be an integer" + "');", true);
            }
            else
            {
                double d;
                if(!double.TryParse(TextBox3.Text,out d))
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "The Price must be decimal" + "');", true);
                else
                {
                    if (!web.productquantity(web.GetProductsCode2(Convert.ToString(Session["selectedproduct"])), Convert.ToInt32(TextBox2.Text)))
                        ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Not enough products in stock" + "');", true);
                    else
                    {
                        ts.Add(Convert.ToInt32(TextBox2.Text));
                        ts.Add(Convert.ToDouble(TextBox3.Text));
                        Session["ordernr"] = web.addOrder(ts, cat);
                        a++;
                        Session["nrcart"] = a;
                       // HtmlGenericControl spanNote = (HtmlGenericControl)UpdateProgress1.FindControl("spanNote");
                        //spanNote.InnerHTML = Session["nrcart"];

                    }
                }
            }
           
            if (Convert.ToInt32(Session["ordernr"])!= 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + " Product added to cart" + "');", true);
                Session["sameorder"] = Session["CustomerNr"];


                
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + " Error while adding to cart" + "');", true);
            }
            TextBox2.Text = "";
            TextBox3.Text = "";
        }
    }
}