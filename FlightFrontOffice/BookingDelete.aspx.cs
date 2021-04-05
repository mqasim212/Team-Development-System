using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FlightClasses;

public partial class BookingDelete : System.Web.UI.Page
{
    //var to store the primary key value of the record to be deleted
    Int32 BookingID;

    //event handler for the load object
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the customer to be deleted from the session object
        BookingID = Convert.ToInt32(Session["BookingID"]);
    }

    void DeleteBooking()
    {
        //function to delete the selected record

        //create a new instance of the Booking book
        clsBookingCollection BookingBook = new clsBookingCollection();
        //find the record to delete
        BookingBook.ThisBooking.Find(BookingID);
        //delete the record
        BookingBook.Delete();
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //delete the record
        DeleteBooking();
        //redirect back to the main page
        Response.Redirect("BookingList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect back to the main page
        Response.Redirect("BookingList.aspx");
    }
}