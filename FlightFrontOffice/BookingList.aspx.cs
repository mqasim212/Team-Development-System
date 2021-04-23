using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FlightClasses;

public partial class BookingList : System.Web.UI.Page
{
    //this function handles the load object for the page
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayBooking();
        }
    }

    void DisplayBooking()
    {
        //create an instance of the booking collection
        clsBookingCollection Booking = new clsBookingCollection();
        //set the data source to the list of bookings in the collection
        lstBooking.DataSource = Booking.BookingList;
        //set the name of the primary key
        lstBooking.DataValueField = "BookingID";
        //set the data field to display
        lstBooking.DataTextField = "BookingName";
        //bind the data source to the list
        lstBooking.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["BookingID"] = -1;
        //redirect to the data entry page
        Response.Redirect("ABooking.aspx");
    }

    //event handler for the delete button
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the pariamry key value of the record to be deleted
        Int32 BookingID;
        //if a record has been selected from the list
        if (lstBooking.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            BookingID = Convert.ToInt32(lstBooking.SelectedValue);
            //store the data in the session object
            Session["BookingID"] = BookingID;
            //redirect to the delete page
            Response.Redirect("BookingDelete.aspx");
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
        Int32 BookingID;
        //if a record has been selected from the list
        if (lstBooking.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            BookingID = Convert.ToInt32(lstBooking.SelectedValue);
            //store the data in the session object
            Session["BookingID"] = BookingID;
            //redirect to the edit page
            Response.Redirect("ABooking.aspx");
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
        //display all orderlines
        DisplayBooking("");
    }

    Int32 DisplayBooking(string BookingNameFilter)
    {
        //var to store the BookingName
        string BookingName;
        //create an instance of the Orderline collection class
        clsBookingCollection Booking = new clsBookingCollection();
        Booking.ReportByBookingName(BookingNameFilter);
        //var to store the count of records
        Int32 RecordCount;
        //var to store the index for the loop
        Int32 Index = 0;
        //get the count of records
        RecordCount = Booking.Count;
        //clear the list box
        lstBooking.Items.Clear();
        //while there are records 
        while (Index < RecordCount)
        {
            //get the BookingName
            BookingName = Booking.BookingList[Index].BookingName;
            //create a new entry for the list box
            ListItem NewEntry = new ListItem(BookingName + " ".ToString());
            //add the staff to the list
            lstBooking.Items.Add(NewEntry);
            //move the index to the next record
            Index++;
        }
        //return to the count of records found
        return RecordCount;
    }


    protected void btnApply_Click(object sender, EventArgs e)
    {
        Int32 RecordCount;
        RecordCount = DisplayBooking(txtBookingName.Text);
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


