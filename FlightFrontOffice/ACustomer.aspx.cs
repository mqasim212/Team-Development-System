using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FlightClasses;


public partial class ACustomer : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 CustomerID;

    //event handler for the page load event
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the customer to be processed
        CustomerID = Convert.ToInt32(Session["CustomerID"]);
        if (IsPostBack == false)
        {
            //populate the list of customers
            DisplayCustomers();
            //if this not a new record
            if (CustomerID != -1)
            {
                //display the current data for the record
                DisplayCustomers();
            }
        }
    }

    //event handler for the ok button
    protected void btnOK_Click(object sender, EventArgs e)
    {
        if (CustomerID == -1)
        {
            //add the new record
            Add();
        }
        else
        {
            //update the record
            Update();
        }

        //all done so redirect back to the main page
        Response.Redirect("CustomerList.aspx");
    }

    //function for adding new records
    void Add()
    {
        //create an instance of the Customer Book
        clsCustomerCollection CustomerBook = new clsCustomerCollection();
        //validate the data on the web form
        String Error = CustomerBook.ThisCustomer.Valid(txtName.Text, txtPhone.Text, txtEmail.Text, txtUsername.Text, txtPassword.Text, txtPaymentType.Text);
        //if the data is ok then add it to the object
        if (Error == "")
        {
            //get the data entered by the user
            CustomerBook.ThisCustomer.Name = txtName.Text;
            CustomerBook.ThisCustomer.Phone = txtPhone.Text;
            CustomerBook.ThisCustomer.Email = txtEmail.Text;
            CustomerBook.ThisCustomer.Username = txtUsername.Text;
            CustomerBook.ThisCustomer.Password = txtPassword.Text;
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

    //function for updating records
    void Update()
    {
        //create an instance of the Customer Book
        clsCustomerCollection CustomerBook = new clsCustomerCollection();
        //validate the data on the web form
        String Error = CustomerBook.ThisCustomer.Valid(txtName.Text, txtPhone.Text, txtEmail.Text, txtUsername.Text, txtPassword.Text, txtPaymentType.Text);
        //if the data is ok then add it to the object
        if (Error == "")
        {
            //find the record to update
            CustomerBook.ThisCustomer.Find(CustomerID);
            //get the data entered by the user
            CustomerBook.ThisCustomer.Name = txtName.Text;
            CustomerBook.ThisCustomer.Phone = txtPhone.Text;
            CustomerBook.ThisCustomer.Email = txtEmail.Text;
            CustomerBook.ThisCustomer.Username = txtUsername.Text;
            CustomerBook.ThisCustomer.Password = txtPassword.Text;
            CustomerBook.ThisCustomer.PaymentType = txtPaymentType.Text;
            //update the record
            CustomerBook.Update();
            //all done so redirect back to the main page
            Response.Redirect("CustomerList.aspx");
        }
        else
        {
            //report an error
            lblError.Text = "There were problems with the data entered " + Error;
        }
    }

    void DisplayCustomers()
    {
        //create an instance of the Customer Book
        clsCustomerCollection CustomerBook = new clsCustomerCollection();
        //find the record to update
        CustomerBook.ThisCustomer.Find(CustomerID);
        //display the data for this record
        txtName.Text = CustomerBook.ThisCustomer.Name;
        txtPhone.Text = CustomerBook.ThisCustomer.Phone;
        txtEmail.Text = CustomerBook.ThisCustomer.Email;
        txtUsername.Text = CustomerBook.ThisCustomer.Username;
        txtPassword.Text = CustomerBook.ThisCustomer.Password;
        txtPaymentType.Text = CustomerBook.ThisCustomer.PaymentType;
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //all done so redirect back to the main page
        Response.Redirect("CustomerList.aspx");
    }
}
