using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MyStaffAccount : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnManageStaffAccounts_Click(object sender, EventArgs e)
    {
        //Redirect to the staff page
        Response.Redirect("StaffList.aspx");
    }

    protected void btnManageCustomerAccounts_Click(object sender, EventArgs e)
    {
        //Redirect to the customer page
        Response.Redirect("CustomerList.aspx");
    }

    protected void btnManageBookings_Click(object sender, EventArgs e)
    {
        //Redirect to the bookings page
        Response.Redirect("BookingList.aspx");
    }

    protected void btnManageOrderlines_Click(object sender, EventArgs e)
    {
        //Redirect to the Orderlines page
        Response.Redirect("OrderlineList.aspx");
    }

    protected void btnManageTickets_Click(object sender, EventArgs e)
    {
        //Redirect to the Tickets page
        Response.Redirect("TicketList.aspx");
    }

    protected void btnManagePlanes_Click(object sender, EventArgs e)
    {
        //Redirect to the planes page
        Response.Redirect("PlaneList.aspx");
    }

    protected void btnManageFlights_Click(object sender, EventArgs e)
    {
        //Redirect to the flights page
        Response.Redirect("FlightList.aspx");
    }

    protected void btnManageLocations_Click(object sender, EventArgs e)
    {
        //Redirect to the locations page
        Response.Redirect("LocationList.aspx");
    }

    protected void btnChangePassword_Click(object sender, EventArgs e)
    {
        //Redirect to the change password page
        Response.Redirect("ChangePassword.aspx");
    }

    protected void btnLogOut_Click(object sender, EventArgs e)
    {
        //Redirect to the homepage page
        Response.Redirect("HomePage.aspx");
    }
}