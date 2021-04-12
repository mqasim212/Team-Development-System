<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FlightDelete.aspx.cs" Inherits="FlightDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblDeleteDateOfBirth" runat="server" Font-Bold="True" Font-Size="Larger" style="z-index: 1; left: 71px; top: 80px; position: absolute" Text="Are you sure you want to delete this Date Of Birth?"></asp:Label>
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 135px; top: 177px; position: absolute; height: 53px; width: 177px; right: 536px" Text="Yes" />
        <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" style="z-index: 1; left: 336px; top: 177px; position: absolute; height: 54px; width: 197px" Text="No" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 43px; top: 280px; position: absolute" Text="lblError"></asp:Label>
    </form>
</body>
</html>
