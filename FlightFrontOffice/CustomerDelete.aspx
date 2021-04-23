<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDelete.aspx.cs" Inherits="CustomerDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblAreyousureyouwanttodeletethisname" runat="server" Font-Bold="True" Font-Size="Large" style="z-index: 1; left: 81px; top: 70px; position: absolute" Text="Are you sure you want to delete this Name?"></asp:Label>
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 124px; top: 132px; position: absolute; height: 49px; width: 88px; right: 418px" Text="Yes" />
        <asp:Button ID="btnNo" runat="server" style="z-index: 1; left: 251px; top: 131px; position: absolute; height: 50px; width: 96px" Text="No" OnClick="btnNo_Click" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 50px; top: 295px; position: absolute" Text="lblError"></asp:Label>
    </form>
</body>
</html>
