using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FlightClasses;

public partial class SignIn : System.Web.UI.Page
{
    //create a copy of the security object with page level scope
    clsSecurity Sec;

    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void Page_UnLoad(object sender, EventArgs e)
    {
       
    }



    protected void btnLogin_Click(object sender, EventArgs e)
    {
        //create an instance of the class
        clsSecurity Sec = new clsSecurity();
        //var to store the data entered
        string Username = txtUsername.Text;
        string Password = txtPassword.Text;
        //var to store the error and function
        lblError.Text = Sec.SignIn(txtUsername.Text, txtPassword.Text);
        //if there is no error
        if (lblError.Text == "")
        {
            //go to my customer account page
            Response.Redirect("MyCustomerAccount.aspx");
        }
        else
        {
            //show the error
            lblError.Text = lblError.Text;
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //go to my homepage
        Response.Redirect("HomePage.aspx");
    }

    protected void btnForgotPassword_Click(object sender, EventArgs e)
    {
        //redirect to change password page
        Response.Redirect("ChangePassword.aspx");
    }

    protected void btnloginStaff_Click(object sender, EventArgs e)
    {
        //create an instance of the class
        clsSecurity Sec = new clsSecurity();
        //var to store the data entered
        string Username = txtUsername.Text;
        string Password = txtPassword.Text;
        //var to store the error and function
        lblError.Text = Sec.SignIn(txtUsername.Text, txtPassword.Text);
        //if there is no error
        if (lblError.Text == "")
        {
            //go to my customer account page
            Response.Redirect("MyStaffAccount.aspx");
        }
        else
        {
            //show the error
            lblError.Text = lblError.Text;
        }
    }
}

