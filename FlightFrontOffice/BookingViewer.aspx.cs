using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FlightClasses;

public partial class BookingViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsBooking
        clsBooking ABooking = new clsBooking();
        //get the data from the session object
        ABooking = (clsBooking)Session["ABooking"];
        //display the booking name for this entry
        Response.Write(ABooking.BookingName);
        //display the booking date for this entry
        Response.Write(ABooking.BookingDate);
        //display the booking Validity for this entry
        Response.Write(ABooking.BookingValidity);
    }
}