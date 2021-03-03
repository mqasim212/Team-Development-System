using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FlightClasses;


public partial class ACustomer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    //event handler for the ok button
    protected void btnOK_Click(object sender, EventArgs e)
    {
        //add the new record
        Add();
        //all done so redirect to the main page
        Response.Redirect("CustomerList.aspx");
    }
    //function for adding new records
    void Add()
    {
        //create an instance of the Customer Book
        clsCustomerCollection CustomerBook = new clsCustomerCollection();
        //validate the data on the web form
        String Error = CustomerBook.ThisCustomer.Valid(txtName.Text, txtPhone.Text, txtEmail.Text, txtUserName.Text, txtPassword.Text, txtPaymentID.Text, txtPaymentType.Text);
        //if the data is ok then add it to the object
        if (Error == "")
        {
            //get the data entered by the user
            CustomerBook.ThisCustomer.Name = txtName.Text;
            CustomerBook.ThisCustomer.Phone = txtPhone.Text;
            CustomerBook.ThisCustomer.Email = txtEmail.Text;
            CustomerBook.ThisCustomer.UserName = txtUserName.Text;
            CustomerBook.ThisCustomer.Password = txtPassword.Text;
            CustomerBook.ThisCustomer.PaymentID = txtPaymentID.Text;
            CustomerBook.ThisCustomer.PaymentType = txtPaymentType.Text;
            //add the record
            CustomerBook.Add();
            //all done so redirect back to the main page
            Response.Redirect("CustomerList.aspx");
        }
        else
        {
            //report the error
            lblError.Text = "There were problems with the data entered " + Error;
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //redirect to the main page
        Response.Redirect("CustomerList.aspx");
    }
}
