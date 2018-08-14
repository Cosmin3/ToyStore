using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ToyStore
{
    public partial class EmployeeOrderNegociate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                initButtons();
            }
        }
        void initButtons()
        {
            TextBox1.Enabled = false;
            TextBox2.Enabled = false;
            TextBox3.Enabled = false;
            TextBox4.Enabled = false;
            Button1.Visible = true;
            Button2.Visible = true;
            Button3.Visible = false;
            Button4.Visible = false;
        }
        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Button2.Visible = false;
            TextBox2.Enabled = true;
            TextBox3.Enabled = true;
            Button3.Visible = true;
            Button4.Visible = true;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            initButtons();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            initButtons();
        }
    }
}