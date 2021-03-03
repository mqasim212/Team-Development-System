using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FlightClasses;

public partial class CustomerViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create an instance of clsCustomer
        clsCustomer ACustomer = new clsCustomer();
        //get the data from the session object
        ACustomer = (clsCustomer)Session["ACustomer"];
        //display the Name for this entry
        Response.Write(ACustomer.Name);
        //display the phone for this entry
        Response.Write(ACustomer.Phone);
        //display the email for this entry
        Response.Write(ACustomer.Email);
        //display the UserName for this entry
        Response.Write(ACustomer.UserName);
        //display the Password for this entry
        Response.Write(ACustomer.Password);
        //display the Paymentid for this entry
        Response.Write(ACustomer.PaymentID);
        //display the payment type for this entry
        Response.Write(ACustomer.PaymentType);
    }
}