<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormCalendario.aspx.cs" Inherits="LAB02_WebCalendario.WebFormCalendario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 40px;
        }
        .auto-style2 {
            width: 100%;
        }
        .auto-style4 {
            width: 484px;
        }
        .auto-style5 {
            width: 72px;
        }
        .auto-style6 {
            width: 71px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <p>Selecione a sua data de nascimento: <asp:Label ID="lblDataNascimento" runat="server" Text=""></asp:Label>
            </p>
            <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" Width="350px" OnSelectionChanged="Calendar1_SelectionChanged">
                <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
                <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
                <OtherMonthDayStyle ForeColor="#999999" />
                <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
                <TodayDayStyle BackColor="#DC6B19" />
            </asp:Calendar>
            <br />
            <br />
            <asp:TextBox ID="txtDataNascimento" runat="server"></asp:TextBox>&nbsp;&nbsp;&nbsp; <asp:Button ID="Button2" runat="server" Text="Carregar Data" OnClick="Button2_Click" />
            <br />
            <br />
            <table class="auto-style2">
                <tr>
                    <td class="auto-style5">Dia</td>
                    <td class="auto-style5">Mês</td>
                    <td class="auto-style6">Ano</td>
                    <td class="auto-style4">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">
                        <asp:DropDownList ID="DropDownListDia" runat="server">
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style5">
                        <asp:DropDownList ID="DropDownListMes" runat="server">
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style6">
                        <asp:DropDownList ID="DropDownListAno" runat="server">
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style4">
                        <asp:Button ID="Button3" runat="server" Text="Carregar Data" OnClick="Button3_Click" />
                    </td>
                </tr>

            </table>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Calcular Idade" OnClick="Button1_Click" />
            &nbsp;
            <asp:Label ID="lblIdade" runat="server" Text=""></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblInfo" runat="server" Text=""></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblDiasVividos" runat="server" Text=""></asp:Label>
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Image ID="imagem" runat="server" Height="192px" Width="192px" />
            <br />
            <br />
            <asp:Label ID="lblSigno" runat="server" Text=""></asp:Label>
            <br />
            <br />
            <br />
            <br />
        </div>
        
    </form>
</body>
</html>

