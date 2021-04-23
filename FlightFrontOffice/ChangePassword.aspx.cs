using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FlightClasses;

public partial class ChangePassword : System.Web.UI.Page
{
    //private security class instance
    private clsSecurity mSec;

    //public security class
    public clsSecurity Sec
    {
        get
        {
            return mSec;
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        mSec = new clsSecurity();
    }

    protected void btnConfirm_Click(object sender, EventArgs e)
    {
        //var to store the data entered
        string Username = txtUsername.Text;
        string Password1 = txtPassword.Text;
        string Password2 = txtConfirmPassword.Text;
        string SecurityMsg = txtSecurityMsg.Text;

        //change the password and confirm outcome
        lblError.Text = Sec.UserChangePassword(Username, Password1, Password2, SecurityMsg);
        //if there is an error
        if(lblError.Text== "")
        {
            //redirect to account page
            Response.Redirect("SignIn.aspx");
        }
        //if there is an error
        else
        {
            lblError.Text = lblError.Text;
        }
        Session["Sec"] = Sec;
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //redirect to account page
        Response.Redirect("SignIn.aspx");
    }

}