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
        <asp:ListBox ID="lstBooking" runat="server" style="z-index: 1; left: 99px; top: 71px; position: absolute; height: 292px; width: 383px"></asp:ListBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 101px; top: 373px; position: absolute" Text="lblError"></asp:Label>
        <asp:Label ID="lblEnterBookingName" runat="server" Font-Bold="True" Font-Size="Large" style="z-index: 1; left: 102px; top: 413px; position: absolute" Text="Please enter the Booking Name:"></asp:Label>
        <asp:TextBox ID="txtBookingName" runat="server" style="z-index: 1; left: 100px; top: 451px; position: absolute; height: 35px; width: 384px"></asp:TextBox>
        <asp:Button ID="btnApply" runat="server" style="z-index: 1; left: 100px; top: 513px; position: absolute; height: 44px; width: 114px" Text="Apply" OnClick="btnApply_Click" />
        <asp:Button ID="btnDisplayAll" runat="server" style="z-index: 1; left: 249px; top: 512px; position: absolute; height: 47px; width: 157px" Text="Display All" OnClick="btnDisplayAll_Click" />
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 97px; top: 585px; position: absolute; height: 46px; width: 94px" Text="Add" OnClick="btnAdd_Click" />
        <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 229px; top: 585px; position: absolute; height: 46px; width: 99px" Text="Edit" OnClick="btnEdit_Click" />
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 356px; top: 585px; position: absolute; height: 47px; width: 115px; right: 368px" Text="Delete" OnClick="btnDelete_Click" />
    </form>
</body>
</html>
