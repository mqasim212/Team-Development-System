<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ACustomer.aspx.cs" Inherits="ACustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 530px">
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtName" runat="server" style="z-index: 1; left: 118px; top: 45px; position: absolute; right: 1329px"></asp:TextBox>
            <asp:Label ID="lblName" runat="server" style="z-index: 1; left: 23px; top: 43px; position: absolute" Text="Name"></asp:Label>
        </div>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 33px; top: 370px; position: absolute; height: 25px" Text="lblError"></asp:Label>
        <asp:Label ID="lblPhone" runat="server" style="z-index: 1; left: 23px; top: 86px; position: absolute" Text="Phone"></asp:Label>
        <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 22px; top: 131px; position: absolute" Text="Email"></asp:Label>
        <asp:TextBox ID="txtPhone" runat="server" style="z-index: 1; left: 116px; top: 87px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 118px; top: 131px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblUserName" runat="server" style="z-index: 1; left: 15px; top: 178px; position: absolute" Text="UserName"></asp:Label>
        <asp:TextBox ID="txtUserName" runat="server" style="z-index: 1; left: 121px; top: 173px; position: absolute; height: 24px;"></asp:TextBox>
        <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 18px; top: 221px; position: absolute" Text="Password"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 125px; top: 219px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblPaymentID" runat="server" style="z-index: 1; left: 17px; top: 270px; position: absolute" Text="PaymentID"></asp:Label>
        <asp:Label ID="lblPaymentType" runat="server" style="z-index: 1; left: 20px; top: 312px; position: absolute; height: 25px; width: 126px; right: 1367px;" Text="Payment Type"></asp:Label>
        <asp:TextBox ID="txtPaymentID" runat="server" style="z-index: 1; left: 132px; top: 267px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPaymentType" runat="server" style="z-index: 1; left: 146px; top: 313px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnOK" runat="server" style="z-index: 1; left: 21px; top: 422px; position: absolute; width: 55px; height: 36px; right: 1437px" Text="OK" OnClick="btnOK_Click" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 105px; top: 423px; position: absolute; width: 88px; height: 36px" Text="Cancel" />
    </form>
</body>
</html>
