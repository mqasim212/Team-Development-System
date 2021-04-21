<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MyStaffAccount.aspx.cs" Inherits="MyStaffAccount" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="XX-Large" style="z-index: 1; left: 254px; top: 29px; position: absolute" Text="Welcome to Qasim's Flight Booking Website"></asp:Label>
        <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="XX-Large" style="z-index: 1; left: 430px; top: 118px; position: absolute" Text="My Account (Staff)"></asp:Label>
        <asp:Button ID="btnManageStaffAccounts" runat="server" OnClick="btnManageStaffAccounts_Click" style="z-index: 1; left: 20px; top: 251px; position: absolute; height: 58px; width: 182px" Text="Manage Staff Accounts" />
        <p>
            &nbsp;</p>
        <asp:Button ID="btnManageCustomerAccounts" runat="server" OnClick="btnManageCustomerAccounts_Click" style="z-index: 1; left: 229px; top: 250px; position: absolute; height: 59px; width: 222px" Text="Manage Customer Accounts" />
        <asp:Button ID="btnManageBookings" runat="server" OnClick="btnManageBookings_Click" style="z-index: 1; left: 19px; top: 356px; position: absolute; height: 56px; width: 179px" Text="Manage Bookings" />
        <p>
            <asp:Button ID="btnManageOrderlines" runat="server" OnClick="btnManageOrderlines_Click" style="z-index: 1; left: 235px; top: 356px; position: absolute; height: 56px; width: 207px; margin-top: 0px" Text="Manage Orderlines" />
        </p>
        <asp:Button ID="btnManagePlanes" runat="server" OnClick="btnManagePlanes_Click" style="z-index: 1; left: 234px; top: 451px; position: absolute; height: 59px; width: 200px; margin-right: 16px" Text="Manage Planes" />
        <asp:Button ID="btnManageTickets" runat="server" OnClick="btnManageTickets_Click" style="z-index: 1; left: 28px; top: 454px; position: absolute; height: 58px; width: 164px" Text="Manage Tickets" />
        <asp:Button ID="btnManageFlights" runat="server" OnClick="btnManageFlights_Click" style="z-index: 1; left: 27px; top: 567px; position: absolute; height: 58px; width: 165px" Text="Manage Flights" />
        <asp:Button ID="btnManageLocations" runat="server" OnClick="btnManageLocations_Click" style="z-index: 1; left: 233px; top: 564px; position: absolute; height: 60px; width: 198px" Text="Manage Locations" />
        <p>
            &nbsp;</p>
        <asp:Button ID="btnChangePassword" runat="server" style="z-index: 1; left: 903px; top: 333px; position: absolute; height: 66px; width: 205px; margin-bottom: 13px;" Text="Change Password" OnClick="btnChangePassword_Click" />
        <asp:Button ID="btnLogOut" runat="server" OnClick="btnLogOut_Click" style="z-index: 1; left: 905px; top: 229px; position: absolute; height: 62px; width: 196px" Text="Sign Out" />
    </form>
</body>
</html>
