<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebCirculo.aspx.cs" Inherits="WebArea.WebCirculo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
     <form id="form1" runat="server">
     <div style="margin-left: 240px">
         <h2>Área do Círculo</h2>
         Raio: <asp:TextBox ID="txtRaio" runat="server"></asp:TextBox>
         
         <br />
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         
         <asp:Label ID="lblResultado" runat="server" Text="Resultado"></asp:Label>
         <br />
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="btnCalcular" runat="server" Text="Calcular" OnClick="btnCalcular_Click" />

         <br />
         <asp:LinkButton ID="menu" runat="server" OnClick="menu_Click">< Voltar</asp:LinkButton>
         <br />

     </div>
 </form>
</body>
</html>
