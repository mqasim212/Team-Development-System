using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FlightClasses;

public partial class OrderlineDelete : System.Web.UI.Page
{
    //var to store the primary key value of the record to be deleted
    Int32 OrderlineID;

    //event handler for the load event
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the orderlines to be deleted from the session object
        OrderlineID = Convert.ToInt32(Session["OrderlineID"]);
    }

    void DeleteOrderline()
    {
        //function to delete the selected record

        //create a new instance of the orderline book
        clsOrderlineCollection OrderlineBook = new clsOrderlineCollection();
        //find the record to delete
        OrderlineBook.ThisOrderline.Find(OrderlineID);
        //delete the record
        OrderlineBook.Delete();
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //delete the record
        DeleteOrderline();
        //redirect to the main page
        Response.Redirect("OrderlineList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect to the main page
        Response.Redirect("OrderlineList.aspx");
    }
}