using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FlightClasses;

public partial class AStaff : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 StaffID;

    //event handler for the page load event
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the customer to be processed
        StaffID = Convert.ToInt32(Session["StaffID"]);
        if (IsPostBack == false)
        {
            //populate the list of staff
            DisplayStaff();
            //if this is not a new record
            if (StaffID != -1)
            {
                //display the current data for the record
                DisplayStaff();
            }
        }
    }


    protected void btnOK_Click(object sender, EventArgs e)
    {
        if (StaffID == -1)
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
        Response.Redirect("StaffList.aspx");
    }

    //function for adding new records
    void Add()
    {
        //create an instance of the staff Book
        clsStaffCollection StaffBook = new clsStaffCollection();
        //validate the data on the web form
        string Error = StaffBook.ThisStaff.Valid(txtStaffEmail.Text, txtStaffName.Text, txtStaffPassword.Text);
        //if the data is ok then add it to the object
        if (Error == "")
        {
            //get the data entered by the user
            StaffBook.ThisStaff.Email = txtStaffEmail.Text;
            StaffBook.ThisStaff.Name = txtStaffName.Text;
            StaffBook.ThisStaff.Password = txtStaffPassword.Text;
            //add the record
            StaffBook.Add();
            //all done so redirect back to the main page
            Response.Redirect("StaffList.aspx");
        }
        else
        {
            //report the error
            lblError.Text = "There were problems with the data entered " + Error;
        }
    }

    //function for updating new records
    void Update()
    {
        //create an instance of the staff Book
        clsStaffCollection StaffBook = new clsStaffCollection();
        //validate the data on the web form
        string Error = StaffBook.ThisStaff.Valid(txtStaffEmail.Text, txtStaffName.Text, txtStaffPassword.Text);
        //if the data is ok then add it to the object
        if (Error == "")
        {
            //find the record to update
            StaffBook.ThisStaff.Find(StaffID);
            //get the data entered by the user
            StaffBook.ThisStaff.Email = txtStaffEmail.Text;
            StaffBook.ThisStaff.Name = txtStaffName.Text;
            StaffBook.ThisStaff.Password = txtStaffPassword.Text;
            //update the record
            StaffBook.Update();
            //all done so redirect back to the main page
            Response.Redirect("StaffList.aspx");
        }
        else
        {
            //report the error
            lblError.Text = "There were problems with the data entered " + Error;
        }
    }

    void DisplayStaff()
    {
        //create an instance of the staff Book
        clsStaffCollection StaffBook = new clsStaffCollection();
        //find the record to update
        StaffBook.ThisStaff.Find(StaffID);
        //display the data for this record
        txtStaffEmail.Text = StaffBook.ThisStaff.Email;
        txtStaffName.Text = StaffBook.ThisStaff.Name;
        txtStaffPassword.Text = StaffBook.ThisStaff.Password;
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //all done so redirect back to the main page
        Response.Redirect("StaffList.aspx");
    }
}
