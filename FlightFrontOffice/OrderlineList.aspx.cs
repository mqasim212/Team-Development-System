using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FlightClasses;

public partial class OrderlineList : System.Web.UI.Page
{
    //this function handles the load object for the page
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayOrderline();
        }
    }

    void DisplayOrderline()
    {
        //create an instance of orderline collection
        clsOrderlineCollection Orderline = new clsOrderlineCollection();
        //set the data source to the list of orderlines in the collection
        lstOrderline.DataSource = Orderline.OrderlineList;
        //set the name of the primary key
        lstOrderline.DataValueField = "OrderlineID";
        //set the data field to display
        lstOrderline.DataTextField = "BookingNo";
        //bind the data to the list
        lstOrderline.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["OrderlineID"] = -1;
        //redirect to the data entry page
        Response.Redirect("AOrderline.aspx");
    }

    protected void Delete_Click(object sender, EventArgs e)
    {
        //var to store the pariamry key value of the record to be deleted
        Int32 OrderlineID;
        //if a record has been selected from the list
        if (lstOrderline.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            OrderlineID = Convert.ToInt32(lstOrderline.SelectedValue);
            //store the data in the session object
            Session["OrderlineID"] = OrderlineID;
            //redirect to the delete page
            Response.Redirect("OrderlineDelete.aspx");
        }
        //if no record has been selected
        else
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void Edit_Click(object sender, EventArgs e)
    {
        //var to store the pariamry key value of the record to be edited
        Int32 OrderlineID;
        //if a record has been selected from the list
        if (lstOrderline.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            OrderlineID = Convert.ToInt32(lstOrderline.SelectedValue);
            //store the data in the session object
            Session["OrderlineID"] = OrderlineID;
            //redirect to the edit page
            Response.Redirect("AOrderline.aspx");
        }
        //if no record has been selected
        else
        {
            //display an error
            lblError.Text = "Please select a record to update from the list";
        }
    }
}


