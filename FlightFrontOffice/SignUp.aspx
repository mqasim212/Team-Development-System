<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SignUp.aspx.cs" Inherits="SignUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="XX-Large" Font-Underline="True" style="z-index: 1; left: 40px; top: 31px; position: absolute; height: 48px; width: 378px; margin-right: 60px;" Text="Account Sign Up Page"></asp:Label>
        <asp:Label ID="lblEmail" runat="server" Font-Size="Large" style="z-index: 1; left: 403px; top: 204px; position: absolute" Text="Email"></asp:Label>
        <p>
            <asp:Label ID="lblPaymentType" runat="server" Font-Size="Large" style="z-index: 1; left: 340px; top: 433px; position: absolute" Text="Payment Type"></asp:Label>
            <asp:TextBox ID="txtName" runat="server" style="z-index: 1; left: 508px; top: 110px; position: absolute; width: 342px"></asp:TextBox>
            <asp:Label ID="lblPhone" runat="server" Font-Size="Large" style="z-index: 1; left: 407px; top: 156px; position: absolute" Text="Phone"></asp:Label>
        </p>
        <p>
        <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 505px; top: 203px; position: absolute; width: 342px; height:20px; bottom: 547px;"></asp:TextBox>
        <asp:TextBox ID="txtPaymentType" runat="server" style="z-index: 1; left: 499px; top: 431px; position: absolute; width: 338px"></asp:TextBox>
        </p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 874px; top: 337px; position: absolute" Text="[lblError]" Font-Bold="True" Font-Size="Larger"></asp:Label>
        <asp:Label ID="lblName" runat="server" Font-Size="Large" style="z-index: 1; left: 412px; top: 110px; position: absolute" Text="Name"></asp:Label>
        <asp:Button ID="btnSignUp" runat="server" OnClick="btnSignUp_Click" style="z-index: 1; left: 673px; top: 573px; position: absolute; height: 50px; width: 116px; margin-bottom: 18px" Text="Sign Up" />
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 502px; top: 308px; position: absolute; width: 341px"></asp:TextBox>
        <asp:Label ID="lblSecretmsg" runat="server" Font-Size="Large" style="z-index: 1; left: 346px; top: 488px; position: absolute; height: 26px;" Text="Security Msg"></asp:Label>
        <asp:TextBox ID="txtSecurityMsg" runat="server" style="z-index: 1; left: 497px; top: 486px; position: absolute; width: 347px"></asp:TextBox>
        <asp:TextBox ID="txtUsername" runat="server" style="z-index: 1; left: 501px; top: 254px; position: absolute; width: 341px"></asp:TextBox>
        <asp:Label ID="lblPassword" runat="server" Font-Size="Large" style="z-index: 1; left: 381px; top: 309px; position: absolute" Text="Password"></asp:Label>
        <asp:Label ID="lblUsername" runat="server" Font-Size="Large" style="z-index: 1; left: 378px; top: 253px; position: absolute" Text="Username"></asp:Label>
        <asp:TextBox ID="txtPhone" runat="server" style="z-index: 1; left: 508px; top: 157px; position: absolute; width: 341px"></asp:TextBox>
        <p>
            <asp:Label ID="lblConfirm" runat="server" Font-Size="Large" style="z-index: 1; left: 306px; top: 370px; position: absolute" Text="Confirm Password"></asp:Label>
        </p>
        <asp:TextBox ID="txtConfirm" runat="server" style="z-index: 1; left: 502px; top: 369px; position: absolute; width: 336px"></asp:TextBox>
        <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" style="z-index: 1; left: 518px; top: 574px; position: absolute; height: 49px; width: 116px; right: 631px" Text="Cancel" />
    </form>
</body>
</html>
