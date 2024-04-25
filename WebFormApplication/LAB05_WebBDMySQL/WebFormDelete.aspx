<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormDelete.aspx.cs" Inherits="LAB05_WebBDMySQL.WebFormDelete" %>

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
            width: 71%;
        }
        .auto-style3 {
            width: 149px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <br /><h1>Apagar Formando</h1>
            <br />
            <br />
            <table class="auto-style2">
                <tr>
                    <td class="auto-style3">ID</td>
                    <td>
                        <asp:DropDownList ID="ddlFormandos" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlFormandos_SelectedIndexChanged">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Nome:</td>
                    <td>
                        <asp:Label ID="lblNome" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Idade:</td>
                    <td>
                        <asp:Label ID="lblIdade" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Género:</td>
                    <td>
                        <asp:Label ID="lblGenero" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" Width="110px" OnClick="btnCancelar_Click" CssClass="button" />
                    </td>
                    <td>
                        <asp:Button ID="btnApagar" runat="server" Text="Apagar" Width="110px" OnClick="btnApagar_Click" CssClass="button" />
                    </td>
                </tr>
            </table>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
