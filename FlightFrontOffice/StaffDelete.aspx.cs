using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FlightClasses;

public partial class StaffDelete : System.Web.UI.Page
{
    //var to store the primary key value of the record to be deleted
    Int32 StaffID;

    //event handler for the load object
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the customer to be deleted from the session object
        StaffID = Convert.ToInt32(Session["StaffID"]);
    }

    void DeleteStaff()
    {
        //function to delete the selected record

        //create a new instance of the staff book
        clsStaffCollection StaffBook = new clsStaffCollection();
        //find the record to delete
        StaffBook.ThisStaff.Find(StaffID);
        //delete the record
        StaffBook.Delete();
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //delete the record
        DeleteStaff();
        //redirect to the main page
        Response.Redirect("StaffList.aspx"); 
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect to the main page
        Response.Redirect("StaffList.aspx");
    }
}