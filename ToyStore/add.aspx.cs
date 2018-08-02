using System;
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

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            bool add;
            add=web.AddToy(TextBox1.Text,TextBox2.Text,TextBox3.Text,TextBox4.Text,TextBox5.Text,TextBox6.Text, Convert.ToInt32(TextBox7.Text),Convert.ToDouble(TextBox8.Text), Convert.ToDouble(TextBox9.Text));
            if(add)
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Produs adaugat " + "');", true);
            else
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Eroare in timpul adaugarii" + "');", true);
        }
    }
}