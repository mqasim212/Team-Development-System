<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BookingList.aspx.cs" Inherits="BookingList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstBooking" runat="server" style="z-index: 1; left: 550px; top: 54px; position: absolute; height: 292px; width: 383px"></asp:ListBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 552px; top: 361px; position: absolute; bottom: 193px;" Text="lblError"></asp:Label>
        <asp:Label ID="lblEnterBookingName" runat="server" Font-Bold="True" Font-Size="Large" style="z-index: 1; left: 547px; top: 397px; position: absolute" Text="Please enter the Booking Name:"></asp:Label>
        <asp:TextBox ID="txtBookingName" runat="server" style="z-index: 1; left: 545px; top: 436px; position: absolute; height: 35px; width: 384px"></asp:TextBox>
        <asp:Button ID="btnApply" runat="server" style="z-index: 1; left: 543px; top: 500px; position: absolute; height: 44px; width: 114px" Text="Apply" OnClick="btnApply_Click" />
        <asp:Button ID="btnDisplayAll" runat="server" style="z-index: 1; left: 712px; top: 498px; position: absolute; height: 47px; width: 157px" Text="Display All" OnClick="btnDisplayAll_Click" />
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 541px; top: 577px; position: absolute; height: 46px; width: 94px" Text="Add" OnClick="btnAdd_Click" />
        <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 662px; top: 578px; position: absolute; height: 46px; width: 99px" Text="Edit" OnClick="btnEdit_Click" />
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 784px; top: 577px; position: absolute; height: 47px; width: 141px; right: 561px" Text="Delete" OnClick="btnDelete_Click" />
        <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="XX-Large" Font-Underline="True" style="z-index: 1; left: 64px; top: 55px; position: absolute; height: 48px; width: 269px; margin-right: 60px;" Text="Booking Page"></asp:Label>
        <asp:Button ID="btnBackCustomer" runat="server" OnClick="btnBackCustomer_Click" style="z-index: 1; left: 48px; top: 439px; position: absolute; height: 48px; width: 146px" Text="Back (Customer)" />
        <asp:Button ID="btnBackStaff" runat="server" style="z-index: 1; left: 46px; top: 510px; position: absolute; height: 45px; width: 146px" Text="Back (Staff)" OnClick="btnBackStaff_Click" />
    </form>
</body>
</html>
