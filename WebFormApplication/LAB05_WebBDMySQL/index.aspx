﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="LAB05_WebBDMySQL.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="CSS/StyleSheet1.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .auto-style1 {
            width: 27%;
        }
        .auto-style2 {
            height: 31px;
        }
    </style>
</head>
<body style="margin-left: 40px">
    <form id="form1" runat="server">
        <div>
            <br />
            <table class="auto-style1">
                <tr>
                    <td colspan="2">
                        <h1>Gestão de Formandos</h1>
                    </td>
                    <td class="auto-style2">
                        <asp:Button ID="btnLogout" runat="server" Text="Logout" Width="110px" OnClick="btnLogout_Click" CssClass="button" />
                    </td>
                </tr>
                <tr>
                    <td colspan="3">
                        <asp:Label ID="lblUser" runat="server"></asp:Label>
                        <br />
                        <br />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnInserir" runat="server" Text="Inserir" Width="110px" OnClick="btnInserir_Click" CssClass="button" />
                    </td>
                    <td>
                        <asp:Button ID="btnAtualizar" runat="server" Text="Atualizar" Width="110px" OnClick="btnAtualizar_Click" CssClass="button" />
                    </td>
                    <td>
                        <asp:Button ID="btnApagar" runat="server" Text="Apagar" Width="110px" OnClick="btnApagar_Click" CssClass="button" />
                    </td>
                </tr>
                <tr>
                    <td colspan="3">
                        <asp:Label ID="lblMensagem" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">Nº de Formandos:</td>
                    <td>
                        <asp:Label ID="lblNFormandos" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">Idade Média:</td>
                    <td>
                        <asp:Label ID="lblMedia" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td colspan="3">
                    </td>
                </tr>
                <tr>
                    <td colspan="3">
                        Lista dos Formandos</td>
                </tr>
                <tr>
                    <td colspan="3">
                        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" OnPageIndexChanging="GridView1_PageIndexChanging">
                            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                            <Columns>
                                <asp:BoundField DataField="id_formando" HeaderText="ID" />
                                <asp:BoundField DataField="nome" HeaderText="Nome" />
                                <asp:BoundField DataField="genero" HeaderText="Género" />
                                <asp:BoundField DataField="idade" HeaderText="Idade" />
                            </Columns>
                            <EditRowStyle BackColor="#999999" />
                            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                            <SortedAscendingCellStyle BackColor="#E9E7E2" />
                            <SortedAscendingHeaderStyle BackColor="#506C8C" />
                            <SortedDescendingCellStyle BackColor="#FFFDF8" />
                            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                        </asp:GridView>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
