<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Parameterized_procedure.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 400px">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" Text="ENTER YOUR ID:"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 183px; top: 36px; position: absolute"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 144px; top: 87px; position: absolute" Text="Button" />
        <asp:GridView ID="GridView1" runat="server" style="z-index: 1; left: 462px; top: 178px; position: absolute; height: 152px; width: 232px" AutoGenerateColumns="true">
        </asp:GridView>
    </form>
</body>
</html>
