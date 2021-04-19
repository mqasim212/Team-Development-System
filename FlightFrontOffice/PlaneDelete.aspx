<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PlaneDelete.aspx.cs" Inherits="PlaneDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblDeletePlaneName" runat="server" Font-Bold="True" Font-Size="Larger" style="z-index: 1; left: 73px; top: 72px; position: absolute" Text="Are you sure you want to delete this Plane Name?"></asp:Label>
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 137px; top: 172px; position: absolute; height: 67px; width: 147px" Text="Yes" />
        <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" style="z-index: 1; left: 324px; top: 172px; position: absolute; height: 66px; width: 161px" Text="No" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 41px; top: 305px; position: absolute" Text="[lblError]"></asp:Label>
    </form>
</body>
</html>
