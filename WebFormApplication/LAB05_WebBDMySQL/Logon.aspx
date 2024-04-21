<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Logon.aspx.cs" Inherits="LAB05_WebBDMySQL.Logon" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="CSS/StyleSheet1.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .auto-style1 {
            margin-left: 40px;
        }
        .auto-style2 {
            width: 140px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1"><h1>Logon Page</h1>
            <br />
            <br />
            <table style="width:100%;">
                <tr>
                    <td class="auto-style2">Email:</td>
                    <td>
                        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Password:</td>
                    <td>
                        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                        <asp:CheckBox ID="CheckBox1" runat="server" AutoPostBack="true" OnCheckedChanged="CheckBox1_CheckedChanged1"/>
                    </td>
                </tr>
            </table>
             <br />
             <br />
            <asp:Button ID="btnLogon" runat="server" Text="Logon" Width="110px" OnClick="btnLogon_Click" CssClass="button" />
             <br />
             <br />
            <asp:Label ID="lblMensagem" runat="server" ForeColor="Red"></asp:Label>
        </div>
    </form>
</body>
</html>
