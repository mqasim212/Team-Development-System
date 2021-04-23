<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderlineList.aspx.cs" Inherits="OrderlineList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstOrderline" runat="server" style="z-index: 1; left: 431px; top: 57px; position: absolute; height: 280px; width: 398px"></asp:ListBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 433px; top: 348px; position: absolute" Text="lblError"></asp:Label>
        <asp:Label ID="lblEnterBookingNumber" runat="server" Font-Bold="True" Font-Size="Large" style="z-index: 1; left: 434px; top: 386px; position: absolute" Text="Please enter the Booking Number:"></asp:Label>
        <asp:Button ID="btnApply" runat="server" style="z-index: 1; left: 436px; top: 476px; position: absolute; height: 47px; width: 118px" Text="Apply" OnClick="btnApply_Click" />
        <asp:TextBox ID="txtBookingNo" runat="server" style="z-index: 1; left: 434px; top: 421px; position: absolute; height: 37px; width: 372px"></asp:TextBox>
        <p>
            <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 425px; top: 557px; position: absolute; height: 47px; width: 108px" Text="Add" OnClick="btnAdd_Click" />
        </p>
        <asp:Button ID="Edit" runat="server" style="z-index: 1; left: 549px; top: 556px; position: absolute; height: 47px; width: 109px" Text="Edit" OnClick="Edit_Click" />
        <asp:Button ID="Delete" runat="server" style="z-index: 1; left: 675px; top: 555px; position: absolute; height: 48px; width: 139px" Text="Delete" OnClick="Delete_Click" />
        <p>
            &nbsp;</p>
            <asp:Button ID="btnDisplayAll" runat="server" OnClick="btnDisplayAll_Click" style="z-index: 1; left: 594px; top: 476px; position: absolute; height: 47px; width: 160px" Text="Display All" />
        <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="XX-Large" Font-Underline="True" style="z-index: 1; left: 56px; top: 63px; position: absolute; height: 48px; width: 269px; margin-right: 60px;" Text="Orderline Page"></asp:Label>
        <asp:Button ID="btnBackCustomer" runat="server" OnClick="btnBackCustomer_Click" style="z-index: 1; left: 44px; top: 499px; position: absolute; height: 48px; width: 146px" Text="Back (Customer)" />
        <asp:Button ID="btnBackStaff" runat="server" style="z-index: 1; left: 44px; top: 569px; position: absolute; height: 45px; width: 146px" Text="Back (Staff)" OnClick="btnBackStaff_Click" />
    </form>
</body>
</html>
