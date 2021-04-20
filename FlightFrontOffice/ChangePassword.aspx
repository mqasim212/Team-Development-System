<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ChangePassword.aspx.cs" Inherits="ChangePassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="XX-Large" Font-Underline="True" style="z-index: 1; left: 275px; top: 44px; position: absolute; height: 48px; width: 417px; margin-right: 60px;" Text="Change Password Page"></asp:Label>
        <asp:Label ID="lblUsername" runat="server" Font-Size="Large" style="z-index: 1; left: 320px; top: 134px; position: absolute" Text="Username"></asp:Label>
        <asp:TextBox ID="txtUsername" runat="server" style="z-index: 1; left: 437px; top: 135px; position: absolute; width: 330px"></asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 439px; top: 187px; position: absolute; width: 327px"></asp:TextBox>
        <asp:TextBox ID="txtConfirmPassword" runat="server" style="z-index: 1; left: 441px; top: 248px; position: absolute; width: 326px"></asp:TextBox>
        <asp:Label ID="lblPassword2" runat="server" Font-Size="Large" style="z-index: 1; left: 247px; top: 251px; position: absolute" Text="Confirm Password"></asp:Label>
        <asp:TextBox ID="txtSecurityMsg" runat="server" style="z-index: 1; left: 439px; top: 304px; position: absolute; width: 325px"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 295px; top: 380px; position: absolute" Text="[lblError]"></asp:Label>
        <asp:Button ID="btnConfirm" runat="server" OnClick="btnConfirm_Click" style="z-index: 1; left: 663px; top: 433px; position: absolute; height: 51px; width: 118px" Text="Confirm" />
        <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" style="z-index: 1; left: 371px; top: 433px; position: absolute; height: 53px; width: 115px" Text="Cancel" />
        <asp:Button ID="Return" runat="server" OnClick="Return_Click" style="z-index: 1; left: 514px; top: 432px; position: absolute; height: 54px; width: 118px" Text="Return" />
        <p>
            <asp:Label ID="lblPassword1" runat="server" Font-Size="Large" style="z-index: 1; left: 283px; top: 189px; position: absolute" Text="New Password"></asp:Label>
        </p>
        <asp:Label ID="lblSecurityMsg" runat="server" Font-Size="Large" style="z-index: 1; left: 271px; top: 308px; position: absolute" Text="Secret Password"></asp:Label>
    </form>
</body>
</html>
