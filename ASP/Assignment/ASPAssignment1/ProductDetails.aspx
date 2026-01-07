<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductDetails.aspx.cs" Inherits="AssignmentDec25.ProductDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="ddlProducts" runat="server" AutoPostBack="true"
    OnSelectedIndexChanged="ddlProducts_SelectedIndexChanged">
    <asp:ListItem Text="Select" Value="0"></asp:ListItem>
    <asp:ListItem Text="bag" Value="2000"></asp:ListItem>
    <asp:ListItem Text="headphs" Value="5000"></asp:ListItem>
    <asp:ListItem Text="bottle" Value="2500"></asp:ListItem>
</asp:DropDownList>
<br /><br />
<asp:Image ID="imgProduct" runat="server" Width="300px" Height="250px" />
<br /><br />
<asp:Button ID="btnPrice" runat="server" Text="Show Price" OnClick="btnPrice_Click" />
<br /><br />
<asp:Label ID="lblPrice" runat="server" ForeColor="Green"></asp:Label>
        </div>
    </form>
</body>
</html>
