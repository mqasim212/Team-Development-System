using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FlightClasses;

public partial class PlaneViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsPlane
        clsPlane APlane = new clsPlane();
        //get the data from the session object
        APlane = (clsPlane)Session["APlane"];
        //display the plane name for this entry
        Response.Write(APlane.PlaneName);
        //display the hours fly for this entry
        Response.Write(APlane.HoursFly);
    }
}