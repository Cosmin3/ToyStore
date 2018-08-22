using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ToyStore
{
    
    public partial class add : System.Web.UI.Page
    {
        WebService1 web = new WebService1();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                foreach (String c in web.GetProductLine())
                {
                    DropDownList1.Items.Add(c);
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            bool add;
            List<ArrayList> products = web.getProducts();
            int nameAp = 0;
            int codAp = 0;
            foreach (ArrayList product in products)
            {
                if (Convert.ToString(product[1]) == TextBox2.Text)
                    nameAp++;
                if (Convert.ToString(product[0]) == TextBox1.Text)
                    codAp++;
            }
            if(codAp>0)
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Code already in the database " + "');", true);
            else
            {
                if (nameAp > 0)
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Name already in the database " + "');", true);
                else
                {
                    int i;
                    if (!int.TryParse(TextBox7.Text, out i))
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "The Quantity must be an integer" + "');", true);

                    }
                    else
                    {
                        decimal d;
                        if (!decimal.TryParse(TextBox8.Text, out d) || !decimal.TryParse(TextBox9.Text, out d))
                        {
                            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "The Prices must be decimal" + "');", true);
                        }
                        else
                        {

                            add = web.AddToy(TextBox1.Text, TextBox2.Text, DropDownList1.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text, Convert.ToInt32(TextBox7.Text), Convert.ToDouble(TextBox8.Text), Convert.ToDouble(TextBox9.Text));
                            if (add)
                            {
                                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Produs adaugat " + "');", true);
                                if ((string)Session["LoggedUser"] == "admin")
                                    Response.Redirect("padmin.aspx");
                                else
                                    Response.Redirect("productsEmployee.aspx");
                            }
                            else
                                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Eroare in timpul adaugarii" + "');", true);

                        }

                    }

                }
            }
           
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if ((string)Session["LoggedUser"] == "admin")
                Response.Redirect("padmin.aspx");
            else
                Response.Redirect("productsEmployee.aspx");
        }
    }
}