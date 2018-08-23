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
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Button2.Visible = true;
                Button1.Visible = false;
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
            Button3.Visible = false;
            Button4.Visible = false;
        }
        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ArrayList product = web.getOrderProductDetails(Convert.ToInt32(Session["Order"]), Convert.ToString(web.GetProductsCode2(ListBox1.SelectedItem.Text)));
            TextBox1.Text = Convert.ToString(product[0]);
            TextBox2.Text = Convert.ToString(product[2]);
            TextBox3.Text = Convert.ToString(product[3]);
            TextBox4.Text = Convert.ToString(product[1]);
            if(!Button4.Visible)
                Button1.Visible = true;
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
            Button1.Visible = true;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {


           
            int i;
            if (!int.TryParse(TextBox3.Text, out i))
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "The Quantity must be an integer" + "');", true);


            }
            else
            {
                decimal d;
                if (!decimal.TryParse(TextBox2.Text, out d))
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "The Price must be decimal" + "');", true);
                }
                else
                {
                    Button2.Visible = false;
                    initButtons();
                    Button1.Visible = true;
                    Button5.Text = "Finish";
                    if ( web.updateOrderDetail(Convert.ToInt32(Session["Order"]), Convert.ToString(web.GetProductsCode2(TextBox1.Text)), Convert.ToInt32(TextBox3.Text), Convert.ToDouble(TextBox2.Text)))
                        ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Product changed" + "');", true);
                   else
                        ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Error" + "');", true);
                }
            }
        }
        protected void Button5_Click(object sender, EventArgs e)
        {
            
            if(Button5.Text == "Finish")
            {
               if(web.EmpToCustOffer(Convert.ToString(Session["Order"])))
               {
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + " Renegociere trimisa clientului" + "');", true);
                    Response.Redirect("EmpPendingOrders.aspx");
               }
               else
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + " Eroare" + "');", true);
            }
            else
                Response.Redirect("EmpPendingOrders.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            foreach(ListItem product in ListBox1.Items)
            {
               ArrayList arrayList = web.getOrderProductDetails(Convert.ToInt32(Session["Order"]), Convert.ToString(web.GetProductsCode2(product.Text)));
               if( web.acceptOrderDetails(web.GetProductsCode2(product.Text), Convert.ToInt32(arrayList[1]) - Convert.ToInt32(arrayList[3])) && web.acceptOrder(Convert.ToString(Session["Order"])))
               {
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + " Oferta acceptata" + "');", true);
                    Response.Redirect("EmpPendingOrders.aspx");
               }
               else
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + " Eroare" + "');", true);
            }
        }
    }
}