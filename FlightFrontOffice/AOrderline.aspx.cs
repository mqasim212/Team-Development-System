using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FlightClasses;

public partial class AOrderline : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsOrderline
        clsOrderline AOrderline = new clsOrderline();
        //capture the booking Number
        AOrderline.BookingNo = txtBookingNo.Text;
        //capture the quantity
        AOrderline.Quantity = Convert.ToInt32(txtQuantity.Text);
        Session["AOrderline"] = AOrderline;
        //redirect to the viewer page
        Response.Redirect("OrderlineViewer.aspx");
    }
}