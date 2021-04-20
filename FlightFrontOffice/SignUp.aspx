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
        <asp:Label ID="lblEmail" runat="server" Font-Size="Large" style="z-index: 1; left: 364px; top: 201px; position: absolute" Text="Email"></asp:Label>
        <asp:Label ID="lblPaymentID" runat="server" Font-Size="Large" style="z-index: 1; left: 348px; top: 382px; position: absolute; height: 27px;" Text="PaymentID"></asp:Label>
        <p>
            <asp:Label ID="lblPaymentType" runat="server" Font-Size="Large" style="z-index: 1; left: 320px; top: 429px; position: absolute" Text="Payment Type"></asp:Label>
            <asp:TextBox ID="txtName" runat="server" style="z-index: 1; left: 509px; top: 110px; position: absolute; width: 315px"></asp:TextBox>
            <asp:Label ID="lblPhone" runat="server" Font-Size="Large" style="z-index: 1; left: 377px; top: 157px; position: absolute" Text="Phone"></asp:Label>
        </p>
        <p>
        <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 510px; top: 203px; position: absolute; width: 319px; height:20px; bottom: 547px;"></asp:TextBox>
        <asp:TextBox ID="txtPaymentType" runat="server" style="z-index: 1; left: 497px; top: 431px; position: absolute; width: 329px"></asp:TextBox>
        <asp:TextBox ID="txtPaymentID" runat="server" style="z-index: 1; left: 497px; top: 383px; position: absolute; width: 320px"></asp:TextBox>
        </p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 313px; top: 599px; position: absolute" Text="[lblError]"></asp:Label>
        <asp:Label ID="lblName" runat="server" Font-Size="Large" style="z-index: 1; left: 379px; top: 110px; position: absolute" Text="Name"></asp:Label>
        <asp:Button ID="btnSignUp" runat="server" OnClick="btnSignUp_Click" style="z-index: 1; left: 568px; top: 586px; position: absolute; height: 50px; width: 116px; margin-bottom: 18px" Text="Sign Up" />
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 503px; top: 297px; position: absolute; width: 319px"></asp:TextBox>
        <asp:Label ID="lblSecretmsg" runat="server" Font-Size="Large" style="z-index: 1; left: 320px; top: 479px; position: absolute; height: 26px;" Text="Security Msg"></asp:Label>
        <asp:TextBox ID="txtSecurityMsg" runat="server" style="z-index: 1; left: 497px; top: 483px; position: absolute; width: 324px"></asp:TextBox>
        <asp:TextBox ID="txtUsername" runat="server" style="z-index: 1; left: 505px; top: 248px; position: absolute; width: 323px"></asp:TextBox>
        <asp:Label ID="lblPassword" runat="server" Font-Size="Large" style="z-index: 1; left: 380px; top: 299px; position: absolute" Text="Password"></asp:Label>
        <asp:Label ID="lblUsername" runat="server" Font-Size="Large" style="z-index: 1; left: 341px; top: 250px; position: absolute" Text="Username"></asp:Label>
        <asp:TextBox ID="txtPhone" runat="server" style="z-index: 1; left: 504px; top: 157px; position: absolute; width: 319px"></asp:TextBox>
        <p>
            <asp:Label ID="lblConfirm" runat="server" style="z-index: 1; left: 329px; top: 340px; position: absolute" Text="Confirm Password"></asp:Label>
        </p>
        <asp:TextBox ID="txtConfirm" runat="server" style="z-index: 1; left: 502px; top: 335px; position: absolute; width: 336px"></asp:TextBox>
    </form>
</body>
</html>
