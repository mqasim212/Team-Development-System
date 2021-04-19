<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LocationList.aspx.cs" Inherits="LocationList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstLocation" runat="server" style="z-index: 1; left: 107px; top: 77px; position: absolute; height: 278px; width: 428px"></asp:ListBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 110px; top: 364px; position: absolute" Text="[lblError]"></asp:Label>
        <asp:Label ID="lblEnterCountryDeparture" runat="server" Font-Bold="True" Font-Size="Large" style="z-index: 1; left: 110px; top: 403px; position: absolute; height: 26px" Text="Please enter the Country of Departure:"></asp:Label>
        <asp:TextBox ID="txtCountryDeparture" runat="server" style="z-index: 1; left: 109px; top: 436px; position: absolute; height: 25px; width: 387px"></asp:TextBox>
        <asp:Button ID="btnApply" runat="server" style="z-index: 1; left: 108px; top: 491px; position: absolute; height: 44px; width: 113px" Text="Apply" OnClick="btnApply_Click" />
        <asp:Button ID="btnDisplayAll" runat="server" style="z-index: 1; left: 235px; top: 491px; position: absolute; height: 44px; width: 167px" Text="Display All" OnClick="btnDisplayAll_Click" />
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 107px; top: 569px; position: absolute; height: 48px; width: 98px" Text="Add" OnClick="btnAdd_Click" />
        <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 225px; top: 569px; position: absolute; height: 47px; width: 101px" Text="Edit" OnClick="btnEdit_Click" />
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 339px; top: 569px; position: absolute; height: 45px; width: 132px" Text="Delete" OnClick="btnDelete_Click" />
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Overline="False" Font-Size="Large" style="z-index: 1; left: 88px; top: 45px; position: absolute" Text="Country of Departure / Airport of Destination"></asp:Label>
    </form>
</body>
</html>
