<%@ Page Language="C#" AutoEventWireup="true" CodeFile="APlane.aspx.cs" Inherits="APlane" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblPlaneName" runat="server" style="z-index: 1; left: 63px; top: 62px; position: absolute" Text="Plane Name"></asp:Label>
        <asp:Label ID="lblHoursFly" runat="server" style="z-index: 1; left: 64px; top: 128px; position: absolute" Text="Hours Fly"></asp:Label>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 62px; top: 201px; position: absolute" Text="[lblError]"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 62px; top: 270px; position: absolute; height: 47px; width: 119px" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 207px; top: 269px; position: absolute; height: 48px; width: 124px" Text="Cancel" OnClick="btnCancel_Click" />
        <asp:TextBox ID="txtPlaneName" runat="server" style="z-index: 1; left: 183px; top: 58px; position: absolute; height: 26px; width: 172px"></asp:TextBox>
        <asp:TextBox ID="txtHoursFly" runat="server" style="z-index: 1; left: 178px; top: 121px; position: absolute; height: 25px; width: 169px"></asp:TextBox>
    </form>
</body>
</html>
