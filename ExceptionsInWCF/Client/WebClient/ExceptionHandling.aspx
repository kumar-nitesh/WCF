<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ExceptionHandling.aspx.cs" Inherits="WebClient.ExceptionHandling" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="lblNum" runat="server" Text="Numerator"></asp:Label>
&nbsp;<asp:TextBox ID="txtNum" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblDenom" runat="server" Text="Denominator"></asp:Label>
        <asp:TextBox ID="txtDenom" runat="server"></asp:TextBox>
        <br />
        .<br />
        <asp:Button ID="btnDivide" runat="server" OnClick="btnDivide_Click" Text="Divide" />
        <br />
        <br />
        <asp:Label ID="lblResult" runat="server" Text="Result"></asp:Label>
    
    </div>
    </form>
</body>
</html>
