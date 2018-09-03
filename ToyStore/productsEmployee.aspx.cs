using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ToyStore
{
    public partial class productsEmployee : System.Web.UI.Page
    {
        WebService1 web = new WebService1();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request["__EVENTARGUMENT"] != null && Request["__EVENTARGUMENT"] == "event 1")
            {

                Response.Redirect("modify.aspx");
            }
            ListBox1.Attributes.Add("ondblclick", ClientScript.GetPostBackEventReference(ListBox1, "event 1"));

            if (!Page.IsPostBack)
            {
                if (Convert.ToInt32(Session["EmployeeLevel"]) != 3)
                    Button6.Visible = false;
                this.Label4.Text = "Welcome: " + Session["UserName"];
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

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("add.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
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

            web.deleteToy(b);
            this.refresh();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Session["LoggedUser"] = "";
            Session["UserName"] = "";
            Response.Redirect("StartPage.aspx");

        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("EmployeeCust.aspx");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("EmpPendingOrders.aspx");
        }
    }
}