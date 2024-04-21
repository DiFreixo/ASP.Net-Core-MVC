<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormInsert.aspx.cs" Inherits="LAB05_WebBDMySQL.WebFormInsert" %>

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
            width: 169px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <br />
            Registar Formando
            <br />
            <br />
            <table style="width: 100%;">
                <tr>
                    <td class="auto-style2">Nome</td>
                    <td>
                        <asp:TextBox ID="txtNome" runat="server" Width="348px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Género</td>
                    <td>
                        <asp:RadioButton ID="rbMasculino" runat="server" Text="Masculino" />
                        &nbsp;&nbsp;
                        <asp:RadioButton ID="rbFeminino" runat="server" Text="Feminino" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Idade</td>
                    <td>
                        <asp:DropDownList ID="ddlIdade" runat="server">
                        </asp:DropDownList>
                    </td>
                </tr>
                 <tr>
                     <td class="auto-style2">
                         <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" Width="110px" OnClick="btnCancelar_Click" CssClass="button" />
                     </td>
                     <td>
                         <asp:Button ID="btnGravar" runat="server" Text="Gravar" Width="110px" OnClick="btnGravar_Click" CssClass="button" />
                     </td>
                 </tr>
                 <tr>
                     <td colspan="2">
                         <br />
                         <br />
                         <br />
                         <asp:Label ID="lblMensagem" runat="server"></asp:Label>
                     </td>
                 </tr>
            </table>

        </div>
    </form>
</body>
</html>
