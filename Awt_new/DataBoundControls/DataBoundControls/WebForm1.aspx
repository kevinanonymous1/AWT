<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="DataBoundControls.WebForm1" %>

<!DOCTYPE html>
<html>
<head>
    <title>ASP.NET Data Bound Controls</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Student List</h2>

            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="true"></asp:GridView>
            <br />

            <h3>Select Student:</h3>
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true" 
                              OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            </asp:DropDownList>
            <br /><br />

            <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="true" Height="50px" Width="300px">
            </asp:DetailsView>
        </div>
    </form>
</body>
</html>
