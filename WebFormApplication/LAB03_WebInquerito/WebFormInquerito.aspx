<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormInquerito.aspx.cs" Inherits="LAB03_WebInquerito.WebFormInquerito" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 40px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2 class="auto-style1">Inquérito de Teste</h2>
            <p class="auto-style1">Nome: 
                <asp:TextBox ID="TextBox1" runat="server" Width="448px"></asp:TextBox>
            </p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <p class="auto-style1">Distrito:
                <br />
                <asp:ListBox ID="ListBox1" runat="server" Width="111px">
                    <asp:ListItem>Lisboa</asp:ListItem>
                    <asp:ListItem>Porto</asp:ListItem>
                    <asp:ListItem>Faro</asp:ListItem>
                </asp:ListBox>
            </p>
            <br />
            <p class="auto-style1">Pratos Favoritos: 
                <br />
                <asp:CheckBox ID="CheckBox1" runat="server" Text="Pizza" />
                &nbsp;&nbsp;
                <asp:CheckBox ID="CheckBox2" runat="server" Text="Bife" />
                &nbsp;&nbsp;
                <asp:CheckBox ID="CheckBox3" runat="server" Text="Refogado" />
            </p>
            <br />
            <p class="auto-style1">Clube:
                <br />
                <asp:RadioButton ID="RadioButton1" runat="server" Text="FCP" GroupName="Clube" />
                &nbsp;&nbsp;
                <asp:RadioButton ID="RadioButton2" runat="server" Text="SLB" GroupName="Clube" />
                &nbsp;&nbsp;
                <asp:RadioButton ID="RadioButton3" runat="server" Text="SCP" GroupName="Clube" />
            </p>
            <br />
            <p class="auto-style1">
                <asp:Button ID="Button1" runat="server" Text="Submeter" Width="115px" OnClick="Button1_Click" />
                <br />
                <br />
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            </p>
            <br />
        </div>
    </form>
</body>
</html>
