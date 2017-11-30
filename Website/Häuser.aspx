<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Häuser.aspx.cs" Inherits="Häuser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style3 {
            text-align: left;
        }
        .auto-style4 {
            text-align: left;
            height: 43px;
        }
        .auto-style5 {
            text-align: left;
            height: 53px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/User.aspx">User Panel</asp:HyperLink>
&nbsp;<asp:Label ID="Label8" runat="server" Text="--&gt;"></asp:Label>
&nbsp;<asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Dashboard.aspx">Dashboard</asp:HyperLink>
&nbsp;<asp:Label ID="Label6" runat="server" Text="--&gt;"></asp:Label>
        &nbsp;<asp:Label ID="Label9" runat="server" Font-Bold="True" Text="Häuser"></asp:Label>
        </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label1" runat="server" Font-Names="Microsoft Sans Serif" Font-Size="12pt" Text="Bezeichnung"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="BezeichnungText" runat="server" Height="20px" Width="260px"></asp:TextBox>
                    <br />
                </td>
            </tr>
        </table>
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">&nbsp;<asp:Button ID="HäuserSearchButton" runat="server" Height="40px" OnClick="HäuserSearchButton_Click" Text="Search" Width="107px" />
                    <br />
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:ListBox ID="HäuserFoundListBox" runat="server" Height="384px" Width="375px"></asp:ListBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <br />
                    <asp:Label ID="Label2" runat="server" Font-Names="Microsoft Sans Serif" Font-Size="12pt" Text="Bezeichnung"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="bezeichnungInsText" runat="server" Height="20px" Width="260px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="Red" ValidationGroup="HäuserValid" ControlToValidate="bezeichnungInsText">Bitte geben Sie eine Bezeichnung ein!</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <br />
                    <asp:Label ID="Label3" runat="server" Font-Names="Microsoft Sans Serif" Font-Size="12pt" Text="Adresse"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="adresseInsText" runat="server" Height="20px" Width="260px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="Red" ValidationGroup="HäuserValid" ControlToValidate="adresseInsText">Bitte geben Sie eine Adresse ein!</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <br />
                    <asp:Label ID="HausmeisterTelOnstText" runat="server" Font-Names="Microsoft Sans Serif" Font-Size="12pt" Text="HausmeisterTel"></asp:Label>
&nbsp;&nbsp;
                    <asp:TextBox ID="hausmeisterTelInsText" runat="server" Height="20px" Width="260px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="Red" ValidationGroup="HäuserValid" ControlToValidate="hausmeisterTelInsText">Bitte geben Sie eine HausmeisterTel-Nummer ein!</asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="hausmeisterTelInsText" ErrorMessage="RegularExpressionValidator" ForeColor="Red" ValidationExpression="^\d+$" ValidationGroup="HäuserValid">Bitte geben Sie nur Zahlen ein!</asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label5" runat="server" Font-Names="Microsoft Sans Serif" Font-Size="9pt" Text="HausID (Update&amp;&amp;Delete)"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="hausIDText" runat="server" Height="16px" Width="77px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="RequiredFieldValidator" ForeColor="Red" ValidationGroup="HäuserValidDel" ControlToValidate="hausIDText">Bitte geben Sie eine HausID ein!</asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="hausmeisterTelInsText" ErrorMessage="RegularExpressionValidator" ForeColor="Red" ValidationExpression="^\d+$" ValidationGroup="HäuserValidDel">Bitte geben Sie nur Zahlen ein!</asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <br />
                    <asp:Button ID="InsertRecordButton0" runat="server" BackColor="YellowGreen" Height="40px" OnClick="InsertRecordButton0_Click1" Text="Insert" Width="107px" ValidationGroup="HäuserValid" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                    <asp:Button ID="UpdateButton0" runat="server" BackColor="Orange" Height="40px" OnClick="UpdateButton0_Click1" Text="Update" Width="107px" ValidationGroup="HäuserValid" />
&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="DeleteButton0" runat="server" BackColor="Coral" Height="40px" OnClick="DeleteButton0_Click" Text="Delete" Width="107px" ValidationGroup="HäuserValidDel" />
                    </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <br />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
