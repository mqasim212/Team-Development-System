<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PlaneList.aspx.cs" Inherits="PlaneList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 423px; top: 370px; position: absolute" Text="[lblError]"></asp:Label>
        <p>
            <asp:Label ID="lblEnterPlaneName" runat="server" Font-Bold="True" Font-Size="Large" style="z-index: 1; left: 423px; top: 410px; position: absolute" Text="Please enter the Plane Name:"></asp:Label>
            <asp:ListBox ID="lstPlane" runat="server" style="z-index: 1; left: 423px; top: 58px; position: absolute; height: 298px; width: 426px"></asp:ListBox>
        </p>
        <asp:TextBox ID="txtPlaneName" runat="server" style="z-index: 1; left: 421px; top: 445px; position: absolute; height: 38px; width: 392px; right: 665px;"></asp:TextBox>
        <asp:Button ID="btnApply" runat="server" style="z-index: 1; left: 423px; top: 506px; position: absolute; height: 45px; width: 101px" Text="Apply" OnClick="btnApply_Click" />
        <asp:Button ID="btnDisplayAll" runat="server" style="z-index: 1; left: 572px; top: 504px; position: absolute; height: 47px; width: 137px" Text="Display All" OnClick="btnDisplayAll_Click" />
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 400px; top: 580px; position: absolute; height: 45px; width: 98px; " Text="Add" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 517px; top: 579px; position: absolute; width: 101px; height: 47px" Text="Edit" />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 636px; top: 578px; position: absolute; height: 47px; width: 143px" Text="Delete" />
        <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="XX-Large" Font-Underline="True" style="z-index: 1; left: 48px; top: 69px; position: absolute; height: 48px; width: 269px; margin-right: 60px;" Text="Plane Page"></asp:Label>
        <asp:Button ID="btnBackCustomer" runat="server" OnClick="btnBackCustomer_Click" style="z-index: 1; left: 48px; top: 438px; position: absolute; height: 48px; width: 146px" Text="Back (Customer)" />
        <asp:Button ID="btnBackStaff" runat="server" style="z-index: 1; left: 46px; top: 510px; position: absolute; height: 45px; width: 146px" Text="Back (Staff)" OnClick="btnBackStaff_Click" />
    </form>
</body>
</html>
