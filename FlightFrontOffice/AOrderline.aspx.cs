using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FlightClasses;

public partial class AOrderline : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 OrderlineID;

    //event handler for the page load event
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the customer to be processed
        OrderlineID = Convert.ToInt32(Session["OrderlineID"]);
        if (IsPostBack == false)
        {
            //populate the list of Orderlines
            DisplayOrderline();
            //if this is not a new record
            if (OrderlineID != -1)
            {
                //display the current data for the record
                DisplayOrderline();
            }
        }
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        if (OrderlineID == -1)
        {
            //add the new record
            Add();
        }
        else
        {
            //update the record
            Update();
        }

        //all done so redirect back to the main page
        Response.Redirect("OrderlineList.aspx");
    }

    //function for adding new records
    void Add()
    {
        //create an instance of the Orderline Book
        clsOrderlineCollection OrderlineBook = new clsOrderlineCollection();
        //validate the data on the web form
        string Error = OrderlineBook.ThisOrderline.Valid(txtBookingNo.Text, txtQuantity.Text);
        //if the data is ok then add it to the object
        if (Error == "")
        {
            //get the data entered by the user
            OrderlineBook.ThisOrderline.BookingNo = txtBookingNo.Text;
            OrderlineBook.ThisOrderline.Quantity = Convert.ToInt32(txtQuantity.Text);
            //add the record
            OrderlineBook.Add();
            //all done so redirect back to the main page
            Response.Redirect("OrderlineList.aspx");
        }
        else
        {
            //report an error
            lblError.Text = "There are problems with the data entered " + Error;
        }


    }

    //function for updating new records
    void Update()
    {
        //create an instance of the Orderline Book
        clsOrderlineCollection OrderlineBook = new clsOrderlineCollection();
        //validate the data on the web form
        string Error = OrderlineBook.ThisOrderline.Valid(txtBookingNo.Text, txtQuantity.Text);
        //if the data is ok then add it to the object
        if (Error == "")
        {
            //find the record to update
            OrderlineBook.ThisOrderline.Find(OrderlineID);
            //get the data entered by the user
            OrderlineBook.ThisOrderline.BookingNo = txtBookingNo.Text;
            OrderlineBook.ThisOrderline.Quantity = Convert.ToInt32(txtQuantity.Text);
            //update the record
            OrderlineBook.Update();
            //all done so redirect back to the main page
            Response.Redirect("OrderlineList.aspx");
        }
        else
        {
            //report an error
            lblError.Text = "There are problems with the data entered " + Error;
        }
    }

    void DisplayOrderline()
    {
        //create an instance of the Orderline Book
        clsOrderlineCollection OrderlineBook = new clsOrderlineCollection();
        //find the record to update
        OrderlineBook.ThisOrderline.Find(OrderlineID);
        //disply the data for this record
        txtBookingNo.Text = OrderlineBook.ThisOrderline.BookingNo;
        txtQuantity.Text = OrderlineBook.ThisOrderline.Quantity.ToString();
    }
}