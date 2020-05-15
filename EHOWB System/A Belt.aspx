<%@ Page Language="C#" AutoEventWireup="true" CodeFile="A Belt.aspx.cs" Inherits="A_Belt" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblBeltName" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute" Text="BeltName"></asp:Label>
        <asp:ListBox ID="ddlBeltName" runat="server" style="z-index: 1; left: 84px; top: 31px; position: absolute; height: 26px; bottom: 498px; width: 162px"></asp:ListBox>
        <asp:Label ID="lblBrandNo" runat="server" style="z-index: 1; left: 10px; top: 72px; position: absolute" Text="BrandNo"></asp:Label>
        <asp:TextBox ID="txtBrandNo" runat="server" style="z-index: 1; left: 84px; top: 72px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblManufacturerNo" runat="server" style="z-index: 1; left: 10px; top: 109px; position: absolute" Text="ManufacturerNo"></asp:Label>
        <asp:TextBox ID="txtManufacturerNo" runat="server" style="z-index: 1; left: 127px; top: 107px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblBeltDescription" runat="server" style="z-index: 1; left: 10px; top: 158px; position: absolute" Text="BeltDescription"></asp:Label>
        <asp:TextBox ID="txtBeltDescription" runat="server" style="z-index: 1; left: 123px; top: 143px; position: absolute; height: 43px; width: 241px"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" ForeColor="Red" style="z-index: 1; left: 10px; top: 222px; position: absolute"></asp:Label>
        <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" style="z-index: 1; left: 10px; top: 279px; position: absolute" Text="Submit" />
    </form>
</body>
</html>
