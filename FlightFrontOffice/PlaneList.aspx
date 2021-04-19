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
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 96px; top: 372px; position: absolute" Text="[lblError]"></asp:Label>
        <p>
            <asp:Label ID="lblEnterPlaneName" runat="server" Font-Bold="True" Font-Size="Large" style="z-index: 1; left: 107px; top: 419px; position: absolute" Text="Please enter the Plane Name:"></asp:Label>
            <asp:ListBox ID="lstPlane" runat="server" style="z-index: 1; left: 92px; top: 63px; position: absolute; height: 298px; width: 426px"></asp:ListBox>
        </p>
        <asp:TextBox ID="txtPlaneName" runat="server" style="z-index: 1; left: 104px; top: 453px; position: absolute; height: 38px; width: 392px"></asp:TextBox>
        <asp:Button ID="btnApply" runat="server" style="z-index: 1; left: 104px; top: 517px; position: absolute; height: 45px; width: 96px" Text="Apply" OnClick="btnApply_Click" />
        <asp:Button ID="btnDisplayAll" runat="server" style="z-index: 1; left: 227px; top: 516px; position: absolute; height: 45px; width: 133px" Text="Display All" OnClick="btnDisplayAll_Click" />
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 102px; top: 596px; position: absolute; height: 44px; width: 98px; right: 622px" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 216px; top: 595px; position: absolute; width: 101px; height: 46px" Text="Edit" />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 341px; top: 594px; position: absolute; height: 47px; width: 143px" Text="Delete" />
    </form>
</body>
</html>
