<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ALocation.aspx.cs" Inherits="ALocation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblCountryDeparture" runat="server" style="z-index: 1; left: 54px; top: 52px; position: absolute" Text="Country Departure"></asp:Label>
        <asp:Label ID="lblCountryDestination" runat="server" style="z-index: 1; left: 55px; top: 104px; position: absolute" Text="Country Destination"></asp:Label>
        <asp:Label ID="lblAirportDeparture" runat="server" style="z-index: 1; left: 58px; top: 158px; position: absolute" Text="Airport Departure"></asp:Label>
        <asp:Label ID="lblAirportDestination" runat="server" style="z-index: 1; left: 60px; top: 212px; position: absolute" Text="Airport Destination"></asp:Label>
        <asp:TextBox ID="txtCountryDeparture" runat="server" style="z-index: 1; left: 228px; top: 52px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtCountryDestination" runat="server" style="z-index: 1; left: 232px; top: 103px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtAirportDeparture" runat="server" style="z-index: 1; left: 226px; top: 161px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtAirportDestination" runat="server" style="z-index: 1; left: 234px; top: 212px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 59px; top: 282px; position: absolute" Text="[lblError]"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 64px; top: 337px; position: absolute; height: 44px; width: 122px" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 207px; top: 336px; position: absolute; height: 45px; width: 131px" Text="Cancel" OnClick="btnCancel_Click" />
    </form>
</body>
</html>
