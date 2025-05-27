<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Linq_project.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 514px">
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true" OnSelectedIndexChanged="linq_func">
                <asp:ListItem>yash</asp:ListItem>
                <asp:ListItem>prasad</asp:ListItem>
            </asp:DropDownList>
        </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="true">
        </asp:GridView>
    </form>
</body>
</html>
