using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MyAccount : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnEditAccount_Click(object sender, EventArgs e)
    {
        //Redirect to the customer page
        Response.Redirect("CustomerList.aspx");
    }

    protected void btnManageBooking_Click(object sender, EventArgs e)
    {
        //Redirect to the booking page
        Response.Redirect("BookingList.aspx");
    }

    protected void btnManageTicket_Click(object sender, EventArgs e)
    {
        //Redirect to the Ticket page
        Response.Redirect("TicketList.aspx");
    }

    protected void ManageFlight_Click(object sender, EventArgs e)
    {
        //Redirect to the flight page
        Response.Redirect("FlightList.aspx");
    }

    protected void btnManagePlane_Click(object sender, EventArgs e)
    {
        //Redirect to the Plane page
        Response.Redirect("PlaneList.aspx");
    }

    protected void btnManageLocation_Click(object sender, EventArgs e)
    {
        //Redirect to the Location page
        Response.Redirect("LocationList.aspx");
    }

    protected void btnSignOut_Click(object sender, EventArgs e)
    {
        //Redirect to the homepage page
        Response.Redirect("HomePage.aspx");
    }

    protected void btnChangePassword_Click(object sender, EventArgs e)
    {
        //Redirect to the change password page
        Response.Redirect("ChangePassword.aspx");
    }
}