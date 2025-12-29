<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataForm_withDS.aspx.cs" Inherits="DataProject.DataForm_withDS" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource2">
            <Columns>
                <asp:BoundField DataField="custid" HeaderText="custid" SortExpression="custid" />
                <asp:BoundField DataField="custname" HeaderText="custname" SortExpression="custname" />
                <asp:BoundField DataField="age" HeaderText="age" SortExpression="age" />
                <asp:BoundField DataField="custAddress" HeaderText="custAddress" SortExpression="custAddress" />
                <asp:BoundField DataField="custPhone" HeaderText="custPhone" SortExpression="custPhone" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:infinitedbConnectionString %>" ProviderName="<%$ ConnectionStrings:infinitedbConnectionString.ProviderName %>" SelectCommand="SELECT * FROM [customers]"></asp:SqlDataSource>
    </form>
</body>
</html>
