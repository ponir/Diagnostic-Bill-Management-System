<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentInfoSave.aspx.cs" Inherits="StudentInfoManagementApp.UI.StudentInfoSave" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 178px;
        }
        .auto-style2 {
            width: 178px;
            height: 23px;
        }
        .auto-style3 {
            height: 23px;
        }
    </style>
</head>
<body>
<h1>Save Student Information</h1>
    <form id="form1" runat="server">
    <div>
    
        <table style="width:100%;">
            <tr>
                <td class="auto-style1">First Name :</td>
                <td>&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="firstNameTextBox" runat="server" Height="19px" Width="153px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Last Name:</td>
                <td class="auto-style3">&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="lastNameTextBox" runat="server" Height="19px" Width="153px"></asp:TextBox>
                </td>
                <td class="auto-style3"></td>
            </tr>
            <tr>
                <td class="auto-style1">Email :</td>
                <td>&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="emailTextBox" runat="server" Height="19px" Width="153px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">RegNo:</td>
                <td>&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="regNoTextBox" runat="server" Height="19px" Width="153px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">Address:</td>
                <td>&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="addressTextBox" runat="server" Height="19px" Width="153px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">Phone</td>
                <td>&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="phoneTextBox" runat="server" Height="19px" Width="153px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
        <asp:Button ID="saveButton" runat="server" OnClick="saveButton_Click1" Text="Save" Width="101px" />
        <asp:Label ID="messageLable" runat="server"></asp:Label>
    </form>
</body>
</html>
