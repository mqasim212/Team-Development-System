<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDelete.aspx.cs" Inherits="StaffDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblDeleteStaff" runat="server" Font-Bold="True" Font-Size="Large" style="z-index: 1; left: 124px; top: 100px; position: absolute; margin-top: 0px" Text="Are you sure you want to delete this staff?"></asp:Label>
        <p>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 33px; top: 317px; position: absolute" Text="lblError"></asp:Label>
        </p>
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 159px; top: 156px; position: absolute; height: 44px; width: 121px" Text="Yes" />
        <asp:Button ID="btnNo" runat="server" style="z-index: 1; left: 328px; top: 156px; position: absolute; height: 45px; width: 126px" Text="No" OnClick="btnNo_Click" />
    </form>
</body>
</html>
