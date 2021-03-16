using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FlightClasses;

public partial class StaffViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create an instance of clsStaff
        clsStaff AStaff = new clsStaff();
        //get the data from the session object
        AStaff = (clsStaff)Session["AStaff"];
        //display the Email for this entry
        Response.Write(AStaff.Email);
        //display the name for this entry
        Response.Write(AStaff.Name);
        //display the Password for this entry
        Response.Write(AStaff.Password);
    }
}