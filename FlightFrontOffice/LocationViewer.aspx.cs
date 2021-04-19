using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FlightClasses;

public partial class LocationViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create an instance of clsLocation
        clsLocation ALocation = new clsLocation();
        //get the data from the session object
        ALocation = (clsLocation)Session["ALocation"];
        //display the country departure for this entry
        Response.Write(ALocation.CountryDeparture);
        //display the country destination for this entry
        Response.Write(ALocation.AirportDestination);
        //display the airport departure for this entry
        Response.Write(ALocation.AirportDeparture);
        //display the airport destination for this entry
        Response.Write(ALocation.AirportDestination);
    }
}