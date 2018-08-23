using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ToyStore
{
    public partial class EmployeeOrderNegociate : System.Web.UI.Page
    {
        WebService1 web = new WebService1();
        bool modified;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                modified = false;
                initButtons();

                ListBox1.Items.Clear();
                foreach (String product in web.getOrderDetails(Convert.ToInt32(Session["Order"])))
                    ListBox1.Items.Add(product);
            }
        }
        void initButtons()
        {
            TextBox1.Enabled = false;
            TextBox2.Enabled = false;
            TextBox3.Enabled = false;
            TextBox4.Enabled = false;
            Button1.Visible = true;
            if(!modified)
                Button2.Visible = true;
            Button3.Visible = false;
            Button4.Visible = false;
        }
        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ArrayList product = web.getOrderProductDetails(Convert.ToInt32(Session["Order"]), Convert.ToString(web.GetProductsCode2(ListBox1.SelectedItem.Text)));
            TextBox1.Text = Convert.ToString(product[0]);
            TextBox2.Text = Convert.ToString(product[2]);
            TextBox3.Text = Convert.ToString(product[4]);
            TextBox4.Text = Convert.ToString(product[1]);

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Button2.Visible = false;
            TextBox2.Enabled = true;
            TextBox3.Enabled = true;
            Button3.Visible = true;
            Button4.Visible = true;
            Button1.Visible = false;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            initButtons();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            modified = true;
            initButtons();
            Button5.Text = "Finish";
            
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("EmpPendingOrders.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            foreach(ListItem product in ListBox1.Items)
            {
                ArrayList arrayList = web.getOrderProductDetails(Convert.ToInt32(Session["Order"]), Convert.ToString(web.GetProductsCode2(product.Text)));
                web.acceptOrder(web.GetProductsCode2(product.Text), Convert.ToInt32(arrayList[1]) - Convert.ToInt32(arrayList[4]));
            }
        }
    }
}