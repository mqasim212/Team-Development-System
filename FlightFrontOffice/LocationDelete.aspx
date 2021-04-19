<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LocationDelete.aspx.cs" Inherits="LocationDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblDeleteCountryDeparture" runat="server" Font-Bold="True" Font-Size="Larger" style="z-index: 1; left: 70px; top: 68px; position: absolute" Text="Are you sure you want to delete this Country of Departure?"></asp:Label>
        <asp:Button ID="btnYes" runat="server" style="z-index: 1; left: 164px; top: 170px; position: absolute; height: 62px; width: 169px" Text="Yes" OnClick="btnYes_Click" />
        <asp:Button ID="btnNo" runat="server" style="z-index: 1; left: 369px; top: 168px; position: absolute; height: 63px; width: 176px" Text="No" OnClick="btnNo_Click" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 72px; top: 346px; position: absolute" Text="[lblError]"></asp:Label>
    </form>
</body>
</html>
