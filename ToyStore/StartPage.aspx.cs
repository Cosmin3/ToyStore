﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ToyStore
{
    public partial class StartPage : System.Web.UI.Page
    {
        WebService1 web = new WebService1();

        protected void Page_Load(object sender, EventArgs e)
        {

           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (DropDownList1.Text == "Customer")
            {
                if (web.checkLogInCust(TextBox1.Text, TextBox2.Text))
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + " Esti logat" + "');", true);
                    Session["CustomerNr"] = TextBox2.Text;
                    Session["loggedUser"] = "customer";

                    Response.Redirect("Customer.aspx");
                }
                else
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + " Eroare" + "');", true);
            }
            else if (DropDownList1.Text == "Employee")
            {
                if (web.checkLogInEmp(TextBox1.Text, TextBox2.Text))
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + " ESTI logat" + "');", true);
                    Session["LoggedUser"] = TextBox2.Text;
                    Session["UserName"] = TextBox1.Text;
                    Session["EmployeeLevel"] = web.getEmployeeLevel(Convert.ToInt32(TextBox2.Text));
                    Response.Redirect("productsEmployee.aspx");
                }
                    
                else
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + " Eroare" + "');", true);
            }
            else if (DropDownList1.Text == "Admin")
            {
                if (web.checkLogInAdmin(TextBox1.Text, TextBox2.Text))
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + " ESTI logat" + "');", true);
                    Session["LoggedUser"] = "admin";
                    Response.Redirect("padmin.aspx");
                }
                else
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + " Eroare" + "');", true);
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
           if(CheckBox1.Checked == true)
            {
                CheckBox1.Checked = false;
            }
            else
            {
                CheckBox1.Checked = false;
            }
           
            if (DropDownList1.Text == "Customer")
            {
                Label1.Text = "Telephone:";
            }
            else if (DropDownList1.Text == "Employee")
            {
                Label1.Text = "E-mail:";
            }
            else 
                Label1.Text = "Username:";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("pcustomer.aspx");
        }
    }
}