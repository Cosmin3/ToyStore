﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ToyStore
{
    public partial class EmpPendingOrders : System.Web.UI.Page
    {
        WebService1 web = new WebService1();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request["__EVENTARGUMENT"] != null && Request["__EVENTARGUMENT"] == "event 1")
            {
                
                Response.Redirect("EmployeeOrderNegociate.aspx");
            }
            ListBox1.Attributes.Add("ondblclick", ClientScript.GetPostBackEventReference(ListBox1, "event 1"));

            if (!Page.IsPostBack)
            {
                this.Label4.Text = "Welcome: " + Session["UserName"];
                ListBox1.Items.Clear();
                foreach (int order in web.empPendingOrders(Convert.ToInt32(Session["LoggedUser"])))
                    ListBox1.Items.Add(Convert.ToString(order));
            }
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["Order"] = ListBox1.SelectedItem.Text;
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("productsEmployee.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Session["LoggedUser"] = "";
            Session["UserName"] = "";
            Response.Redirect("StartPage.aspx");
        }
    }
}