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

    protected void btnDisplayAll_Click(object sender, EventArgs e)
    {
        //display all orderlines
        DisplayOrderline("");
    }

    Int32 DisplayOrderline(string BookingNoFilter)
    {
        //var to store the BookingNo
        string BookingNo;
        //create an instance of the Orderline collection class
        clsOrderlineCollection Orderline = new clsOrderlineCollection();
        Orderline.ReportByBookingNo(BookingNoFilter);
        //var to store the count of records
        Int32 RecordCount;
        //var to store the index for the loop
        Int32 Index = 0;
        //get the count of records
        RecordCount = Orderline.Count;
        //clear the list box
        lstOrderline.Items.Clear();
        //while there are records 
        while (Index < RecordCount)
        {
            //get the BookingNo
            BookingNo = Orderline.OrderlineList[Index].BookingNo;
            //create a new entry for the list box
            ListItem NewEntry = new ListItem(BookingNo + " " .ToString());
            //add the staff to the list
            lstOrderline.Items.Add(NewEntry);
            //move the index to the next record
            Index++;
        }
        //return to the count of records found
        return RecordCount;
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        Int32 RecordCount;
        RecordCount = DisplayOrderline(txtBookingNo.Text);
        lblError.Text = RecordCount + " Record Found";
    }

    protected void btnBackCustomer_Click(object sender, EventArgs e)
    {
        //Redirect to the customer page
        Response.Redirect("MyCustomerAccount.aspx");
    }

    protected void btnBackStaff_Click(object sender, EventArgs e)
    {
        //Redirect to the staff page
        Response.Redirect("MyStaffAccount.aspx");
    }
}



