<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebMenu.aspx.cs" Inherits="WebArea.WebMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 100px;
        }
        .auto-style3 {
            width: 900px;
        }
        .auto-style4 {
            width: 100px;
            height: 39px;
        }
        .auto-style5 {
            width: 350px;
            height: 39px;
        }
        .auto-style6 {
            margin-top: 0px;
        }
    </style>
</head>
<body style="margin-left: 54px">
    <form id="form1" runat="server">
        <div>
            <h1>Calcular áreas</h1>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style4">
                        <br />
                        <asp:Button ID="btnRetangulo" runat="server" Text="Retângulo" Width="192px" CssClass="auto-style6" Height="48px" OnClick="btnRetangulo_Click" />
                        <br />
                        <br />
                    </td>
                    <td class="auto-style5">
                        <asp:Button ID="btnTriangulo" runat="server" Text="Triângulo" Width="192px" Height="48px" OnClick="btnTriangulo_Click" />
                        <br />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Button ID="btnQuadrado" runat="server" Text="Quadrado" Width="192px" Height="48px" OnClick="btnQuadrado_Click" />
                    </td>
                    <td class="auto-style3">
                        <asp:Button ID="btnCirculo" runat="server" Text="Círculo" Width="192px" Height="48px" OnClick="btnCirculo_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
