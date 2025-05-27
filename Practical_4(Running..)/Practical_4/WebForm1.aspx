<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Practical_4.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 450px">
    <form id="form1" runat="server">
        <div style="height: 420px">
            <asp:TextBox ID="Lastname" runat="server" style="z-index: 1; left: 167px; top: 127px; position: absolute; right: 1072px; margin-top: 0px"></asp:TextBox>
            <asp:TextBox ID="firstname" runat="server" style="z-index: 1; left: 165px; top: 87px; position: absolute"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 141px; top: 177px; position: absolute" Text="Button" />
            <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 37px; top: 134px; position: absolute" Text="Last Name"></asp:Label>
            <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 35px; top: 87px; position: absolute" Text="First Name"></asp:Label>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False"
    OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
    style="z-index: 1; left: 35px; top: 243px; position: absolute; height: 152px; width: 232px">
    <Columns>
        <asp:BoundField DataField="Firstname" HeaderText="Firstname" SortExpression="Firstname" />
        <asp:BoundField DataField="Lastname" HeaderText="Lastname" SortExpression="Lastname" />
    </Columns>
</asp:GridView>
        </div>
    </form>
</body>
</html>
