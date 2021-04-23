using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FlightClasses;

public partial class CustomerList : System.Web.UI.Page
{
    //this function handles the load event for the page
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayCustomers();
        }
    }
    void DisplayCustomers()
    {
        //create an instance of the customer collection
        clsCustomerCollection Customers = new clsCustomerCollection();
        //set the data source to the list of customers in the collection
        lstCustomers.DataSource = Customers.CustomerList;
        //set the name of the primary key
        lstCustomers.DataValueField = "CustomerID";
        //set the data field to display
        lstCustomers.DataTextField = "Name";
        //bind the data to the list
        lstCustomers.DataBind();
    }

    //event handler for the add button
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["CustomerID"] = -1;
        //redirect to the data entry page
        Response.Redirect("ACustomer.aspx");
    }

    //event handler for the delete
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the pariamry key value of the record to be deleted
        Int32 CustomerID;
        //if a record has been selected from the list
        if (lstCustomers.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            CustomerID = Convert.ToInt32(lstCustomers.SelectedValue);
            //store the data in the session object
            Session["CustomerID"] = CustomerID;
            //redirect to the delete page
            Response.Redirect("CustomerDelete.aspx");
        }
        //if no record has been selected
        else
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the pariamry key value of the record to be edited
        Int32 CustomerID;
        //if a record has been selected from the list
        if (lstCustomers.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            CustomerID = Convert.ToInt32(lstCustomers.SelectedValue);
            //store the data in the session object
            Session["CustomerID"] = CustomerID;
            //redirect to the edit page
            Response.Redirect("ACustomer.aspx");
        }
        //if no record has been selected
        else
        {
            //display an error
            lblError.Text = "Please select a record to update from the list";
        }      
    }

    protected void btnDisplayAll_Click(object sender, EventArgs e)
    {
        //display all names
        DisplayCustomers("");
    }

    Int32 DisplayCustomers(string NameFilter)
    {
        //var to store the username
        string Username;
        //var to store the name
        string Name;
        //create an instance of customer collection class
        clsCustomerCollection Customers = new clsCustomerCollection();
        Customers.ReportByName(NameFilter);
        //var to store the count of records
        Int32 RecordCount;
        //var to store the index for the loop
        Int32 Index = 0;
        //get the count of records
        RecordCount = Customers.Count;
        //clear the list box
        lstCustomers.Items.Clear();
        //while there are records 
        while (Index < RecordCount)
        {
            //get the username
            Username = Customers.CustomerList[Index].Username;
            //get the custome name
            Name = Customers.CustomerList[Index].Name;
            //create a new entry for th list box
            ListItem NewEntry = new ListItem(Name  + " " +  Username.ToString());
            //add the customer to the list
            lstCustomers.Items.Add(NewEntry);
            //move the index to the next record
            Index++;
        }
        //return to the count of records found
        return RecordCount;
    }


    protected void btnApply_Click(object sender, EventArgs e)
    {
        Int32 RecordCount;
        RecordCount = DisplayCustomers(txtName.Text);
        lblError.Text = RecordCount + " Record Found";
    }

    protected void btnBackCustomer_Click(object sender, EventArgs e)
    {
        //Redirect to the customer page
        Response.Redirect("MyCustomerAccount.aspx");
    }

    protected void btnBackStaff_Click(object sender, EventArgs e)
    {
        //Redirect to the staff page
        Response.Redirect("MyStaffAccount.aspx");
    }
}
