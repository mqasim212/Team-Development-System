using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FlightClasses;

public partial class ABooking : System.Web.UI.Page
{   
    //variable to store the primary key with page level scope
    Int32 BookingID;

    //event handler for the page load event
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the booking to be processed
        BookingID = Convert.ToInt32(Session["BookingID"]);
        if (IsPostBack == false)
        {
            //populate the list of customers
            DisplayBooking();
            //if this is not a new record
            if (BookingID != -1)
            {
                //display the current data fir the record
                DisplayBooking();
            }
        }
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        if (BookingID == -1)
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
        Response.Redirect("BookingList.aspx");
    }

    //function for adding new records
    void Add()
    {
        //create an instance of the booking Book
        clsBookingCollection BookingBook = new clsBookingCollection();
        //validate the data on the web form
        string Error = BookingBook.ThisBooking.Valid(txtBookingName.Text, txtBookingDate.Text, txtBookingValidity.Text);
        //if the data is ok then add it to the object
        if (Error == "")
        {
            //get the data entered by the user
            BookingBook.ThisBooking.BookingName = txtBookingName.Text;
            BookingBook.ThisBooking.BookingDate = Convert.ToDateTime(txtBookingDate.Text);
            BookingBook.ThisBooking.BookingValidity = Convert.ToInt32(txtBookingValidity.Text);
            //add the record
            BookingBook.Add();
            //all done so redirect back to the main page
            Response.Redirect("BookingList.aspx");
        }
        else
        {
            //report an error
            lblError.Text = "There are problems with the data entered " + Error;
        }
    }

    //function for updating new records
    void Update()
    {
        //create an instance of the booking Book
        clsBookingCollection BookingBook = new clsBookingCollection();
        //validate the data on the web form
        string Error = BookingBook.ThisBooking.Valid(txtBookingName.Text, txtBookingDate.Text, txtBookingValidity.Text);
        //if the data is ok then add it to the object
        if (Error == "")
        {
            //find the record to update
            BookingBook.ThisBooking.Find(BookingID);
            //get the data entered by the user
            BookingBook.ThisBooking.BookingName = txtBookingName.Text;
            BookingBook.ThisBooking.BookingDate = Convert.ToDateTime(txtBookingDate.Text);
            BookingBook.ThisBooking.BookingValidity = Convert.ToInt32(txtBookingValidity.Text);
            //update the record
            BookingBook.Update();
            //all done so redirect back to the main page
            Response.Redirect("BookingList.aspx");
        }
        else
        {
            //report an error
            lblError.Text = "There are problems with the data entered " + Error;
        }
    }

    void DisplayBooking()
    {
        //create an instance of the booking Book
        clsBookingCollection BookingBook = new clsBookingCollection();
        //find the record to update
        BookingBook.ThisBooking.Find(BookingID);
        //display the data for this record
        txtBookingName.Text = BookingBook.ThisBooking.BookingName;
        txtBookingDate.Text = BookingBook.ThisBooking.BookingDate.ToString();
        txtBookingValidity.Text = BookingBook.ThisBooking.BookingValidity.ToString();
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //all done so redirect back to the main page
        Response.Redirect("BookingList.aspx");
    }
}