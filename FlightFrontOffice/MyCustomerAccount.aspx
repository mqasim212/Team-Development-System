<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MyCustomerAccount.aspx.cs" Inherits="MyAccount" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="XX-Large" style="z-index: 1; left: 254px; top: 29px; position: absolute" Text="Welcome to Qasim's Flight Booking Website"></asp:Label>
        </div>
        <asp:Button ID="btnSignOut" runat="server" OnClick="btnSignOut_Click" style="z-index: 1; left: 909px; top: 204px; position: absolute; height: 61px; width: 197px" Text="Sign Out" />
        <asp:Button ID="btnChangePassword" runat="server" style="z-index: 1; left: 906px; top: 339px; position: absolute; height: 67px; width: 202px" Text="Change Password" OnClick="btnChangePassword_Click" />
        <asp:Button ID="btnEditAccount" runat="server" OnClick="btnEditAccount_Click" style="z-index: 1; left: 65px; top: 176px; position: absolute; height: 53px; width: 159px" Text="Edit Account" />
        <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="XX-Large" style="z-index: 1; left: 407px; top: 118px; position: absolute" Text="My Account (Customer)" Font-Underline="True"></asp:Label>
        <asp:Button ID="btnManageBooking" runat="server" OnClick="btnManageBooking_Click" style="z-index: 1; left: 65px; top: 261px; position: absolute; height: 56px; width: 156px" Text="Manage Booking" />
        <asp:Button ID="btnManageTicket" runat="server" OnClick="btnManageTicket_Click" style="z-index: 1; left: 65px; top: 354px; position: absolute; height: 55px; width: 153px" Text="Manage Ticket" />
        <asp:Button ID="ManageFlight" runat="server" OnClick="ManageFlight_Click" style="z-index: 1; left: 63px; top: 445px; position: absolute; height: 54px; width: 154px" Text="Manage Flight" />
        <asp:Button ID="btnManagePlane" runat="server" OnClick="btnManagePlane_Click" style="z-index: 1; left: 268px; top: 229px; position: absolute; height: 62px; width: 149px; margin-right: 11px" Text="Manage Plane" />
        <asp:Button ID="btnManageLocation" runat="server" OnClick="btnManageLocation_Click" style="z-index: 1; left: 267px; top: 383px; position: absolute; height: 60px; width: 152px" Text="Manage Locations" />
    </form>
</body>
</html>
