<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebMenu.aspx.cs" Inherits="LAB01_WebSalarios.WebMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 80px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <h2>Calcular Salário Líquido</h2>
            <br />
            <asp:Label ID="Label1" runat="server" Text="Informe o seu salário bruto:"></asp:Label>&nbsp; <asp:TextBox ID="txtSalarioBruto" runat="server"></asp:TextBox>
            <br />
             <br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnCalcular" runat="server" Text="Calcular" OnClick="btnCalcular_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="btnLimpar" runat="server" Text="Limpar" OnClick="btnLimpar_Click" Width="107px" />
            &nbsp;<br />
            Salário Líquido: <asp:TextBox ID="txtLiquido" runat="server"></asp:TextBox>
            <br />
        </div>
    </form>
</body>
</html>
