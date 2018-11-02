<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowAllInformation.aspx.cs" Inherits="StudentInfoManagementApp.UI.ShowAllInformation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
<h1 style="text-align: center">Show All Student Information</h1>
    <form id="form1" runat="server">
        <asp:GridView ID="GridView" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
