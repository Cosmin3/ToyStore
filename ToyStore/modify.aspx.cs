using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ToyStore
{
    public partial class modify : System.Web.UI.Page
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
                DropDownList1.Items.Add(Convert.ToString(arrayList[1]));
                foreach (String c in web.GetProductLine())
                {
                    if(c!=Convert.ToString(arrayList[1]))
                    DropDownList1.Items.Add(c);
                }
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
            bool update;
            List<ArrayList> products = web.getProducts();
            int nameAp = 0;
            foreach(ArrayList product in products)
            {
                if (Convert.ToString(product[1])== TextBox2.Text)
                {
                    nameAp++;
                }

            }
            if(nameAp>1)
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Name already in the database " + "');", true);
            else
            {
                int i;
                if(!int.TryParse(TextBox7.Text, out i))
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

                        update = web.UpdateToy(TextBox1.Text, TextBox2.Text, DropDownList1.SelectedItem.Text, TextBox4.Text, TextBox5.Text,TextBox6.Text, Convert.ToInt32(TextBox7.Text), Convert.ToDouble(TextBox8.Text), Convert.ToDouble(TextBox9.Text));
                        if (update)
                        {
                            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Produs modificat " + "');", true);
                            if((string)Session["LoggedUser"]=="admin")
                                Response.Redirect("padmin.aspx");
                            else
                                Response.Redirect("productsEmployee.aspx");

                        }
                        else
                            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "eroare in timpul modificarii " + "');", true);

                    }

                }

            }

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

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