using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FlightClasses;

public partial class TicketViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create an instance of clsticket
        clsTicket ATicket = new clsTicket();
        //get the data from the session object
        ATicket = (clsTicket)Session["ATicket"];
        //display the ticket purchase date
        Response.Write(ATicket.TicketPurchaseDate);
        //display the ticket no
        Response.Write(ATicket.TicketNo);
        //display the flight no
        Response.Write(ATicket.FlightNo);
        //display the seat no
        Response.Write(ATicket.SeatNo);
    }
}