using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FlightClasses;

public partial class SignUp : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSignUp_Click(object sender, EventArgs e)
    {
        //create a new instance of the security class
        clsSecurity Sec = new clsSecurity();
        //var to store the data
        string Name = txtName.Text;
        string Phone = txtPhone.Text;
        string Email = txtEmail.Text;
        string Username = txtUsername.Text;
        string Password = txtPassword.Text;
        string PasswordConfirm = txtConfirm.Text;
        string PasswordType = txtPaymentType.Text;
        string SecurityMsg = txtSecurityMsg.Text;
        //validate the data
        lblError.Text = Sec.SignUp(Name, Phone, Email, Username, Password, PasswordConfirm, PasswordType, SecurityMsg);
        //if the username isnt taken

            //if there is no error
            if (lblError.Text == "")
            {
                //go to sign up success page
                Response.Redirect("HomePage.aspx");
            }
            else
            {
                //show error
                lblError.Text = lblError.Text;
            }
        
        Session["Sec"] = Sec;
    }

    protected void btnDone_Click(object sender, EventArgs e)
    {
        //if done redirect to main page
        Response.Redirect("MyCustomerAccount.aspx");
    }

    protected void btnView_Click(object sender, EventArgs e)
    {
        //view the email
        Response.Redirect("EMailViewer.aspx");
    }

    protected void btnReSend_Click(object sender, EventArgs e)
    {

        //display re-set password form
        Response.Redirect("ReSet.aspx");
    }
}