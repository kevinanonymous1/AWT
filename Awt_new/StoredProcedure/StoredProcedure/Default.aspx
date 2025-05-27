<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="StoredProcedure.Default" %>

<!DOCTYPE html>
<html>
<head>
    <title>Stored Procedure Demo</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Search Employees by Department</h2>
            Department:
            <asp:TextBox ID="txtDepartment" runat="server" />
            <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />
            <br /><br />

            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="true" />
        </div>
    </form>
</body>
</html>