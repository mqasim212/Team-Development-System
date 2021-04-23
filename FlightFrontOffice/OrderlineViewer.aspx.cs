using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FlightClasses;

public partial class OrderlineViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create an instance of clsOrderline
        clsOrderline AOrderline = new clsOrderline();
        //get the data from the session object
        AOrderline = (clsOrderline)Session["AOrderline"];
        //display the booking number for this entry
        Response.Write(AOrderline.BookingNo);
        //display the quantity for this entry
        Response.Write(AOrderline.Quantity);
    }
}