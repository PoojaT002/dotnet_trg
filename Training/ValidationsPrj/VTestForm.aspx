<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VTestForm.aspx.cs" Inherits="ValidationsPrj.VTestForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Validation Test Form</title>
</head>
<body>
<form id="form1" runat="server">
       Age :
<asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
<asp:CustomValidator
           ID="cvAge"
           runat="server"
           ControlToValidate="txtAge"
           ErrorMessage="Age must be 18 or above"
           OnServerValidate="cvAge_ServerValidate"
           ForeColor="Red">
</asp:CustomValidator>
<br /><br />
<asp:Button
           ID="btnSubmit"
           runat="server"
           Text="Submit"
           OnClick="btnSubmit_Click" />
<br /><br />
<asp:Label ID="lblMsg" runat="server"></asp:Label>
</form>
</body>
</html>
