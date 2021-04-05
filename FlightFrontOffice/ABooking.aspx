<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ABooking.aspx.cs" Inherits="ABooking" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblBookingName" runat="server" style="z-index: 1; left: 38px; top: 77px; position: absolute" Text="Booking Name"></asp:Label>
        <asp:Label ID="lblBookingDate" runat="server" style="z-index: 1; left: 37px; top: 128px; position: absolute; width: 111px" Text="Booking Date"></asp:Label>
        <asp:Label ID="lblBookingValidity" runat="server" style="z-index: 1; left: 37px; top: 178px; position: absolute; width: 139px" Text="Booking Validity"></asp:Label>
        <asp:TextBox ID="txtBookingName" runat="server" style="z-index: 1; left: 184px; top: 77px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtBookingDate" runat="server" style="z-index: 1; left: 178px; top: 128px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtBookingValidity" runat="server" style="z-index: 1; left: 192px; top: 176px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 36px; top: 246px; position: absolute" Text="lblError"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 40px; top: 305px; position: absolute; height: 38px; width: 99px" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 177px; top: 304px; position: absolute; height: 39px; width: 117px" Text="Cancel" OnClick="btnCancel_Click" />
    </form>
</body>
</html>
