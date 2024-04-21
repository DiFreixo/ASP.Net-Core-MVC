<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormUpdate.aspx.cs" Inherits="LAB05_WebBDMySQL.WebFormUpdate" %>

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
            margin-left: 0px;
        }
        .auto-style3 {
            width: 155px;
            margin-left: 0px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
    <br />
    Atualizar Formando
    <br />
    <br />
    <table style="width: 100%;">
        <tr>
            <td class="auto-style3">Formando</td>
            <td>
                <asp:DropDownList ID="ddlFormando" runat="server" Width="357px" CssClass="auto-style2" OnSelectedIndexChanged="ddlFormando_SelectedIndexChanged" AutoPostBack="True">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">ID</td>
            <td>
                <asp:TextBox ID="txtID" runat="server" Width="146px"></asp:TextBox>
                 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                 <asp:Button ID="btnProcurar" runat="server" Text="Procurar" Width="110px" OnClick="btnProcurar_Click" CssClass="button"/>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Nome</td>
            <td>
                <asp:TextBox ID="txtNome" runat="server" Width="348px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Género</td>
            <td>
                <asp:RadioButton ID="rbMasculino" runat="server" Text="Masculino" AutoPostBack="True" GroupName="Genero" />
                &nbsp;&nbsp;
                <asp:RadioButton ID="rbFeminino" runat="server" Text="Feminino" AutoPostBack="True" GroupName="Genero" />
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Idade</td>
            <td>
                <asp:DropDownList ID="ddlIdade" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
         <tr>
             <td class="auto-style3">
                 <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" Width="110px" OnClick="btnCancelar_Click" CssClass="button" />
             </td>
             <td>
                 <asp:Button ID="btnAtualizar" runat="server" Text="Atualizar" Width="110px" OnClick="btnAtualizar_Click" CssClass="button" />
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
