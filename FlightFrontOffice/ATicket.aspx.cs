using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FlightClasses;

public partial class ATicket : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsTicket
        clsTicket ATicket = new clsTicket();
        //capture the ticket purchase date
        ATicket.TicketPurchaseDate = Convert.ToDateTime(txtTicketPurchaseDate.Text);
        //capture the ticket no
        ATicket.TicketNo = txtTicketNo.Text;
        //capture the flight no
        ATicket.FlightNo = Convert.ToInt32(txtFlightNo.Text);
        //capture the seat no
        ATicket.SeatNo = txtSeatNo.Text;
        Session["ATicket"] = ATicket;
        //redirect to the viewer page
        Response.Redirect("TicketViewer.aspx");
    }
}