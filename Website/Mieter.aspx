<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Mieter.aspx.cs" Inherits="Mieter" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 41px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/User.aspx">User Panel</asp:HyperLink>
&nbsp;<asp:Label ID="Label8" runat="server" Text="--&gt;"></asp:Label>
&nbsp;<asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Dashboard.aspx">Dashboard</asp:HyperLink>
&nbsp;<asp:Label ID="Label7" runat="server" Text="--&gt;"></asp:Label>
&nbsp;<asp:Label ID="Label9" runat="server" Font-Bold="True" Text="Mieter"></asp:Label>
        </p>
        <p>
            <asp:Label ID="label1" runat="server" Font-Names="Microsoft Sans Serif" Font-Size="12pt" Text="Nachname"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="NachnameText" runat="server" Height="20px" Width="260px"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="MieterSearch" runat="server" Height="40px" OnClick="MieterSearch_Click" Text="Search" Width="107px" />
        </p>
        <p>
            <asp:ListBox ID="MieterFoundListBox" runat="server" Height="384px" Width="375px"></asp:ListBox>
        </p>
        <p>
            <asp:Label ID="asda" runat="server" Font-Names="Microsoft Sans Serif" Font-Size="12pt" Text="Nachname"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="NachnameInsText" runat="server" Height="20px" Width="260px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="NachnameInsText" ErrorMessage="RequiredFieldValidator" ForeColor="Red" ValidationGroup="MieterValid">Bitte geben Sie einen Nachnamen ein!</asp:RequiredFieldValidator>
        </p>
        <p>
            <asp:Label ID="label3" runat="server" Font-Names="Microsoft Sans Serif" Font-Size="12pt" Text="Vorname"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="VornameInsText" runat="server" Height="20px" Width="260px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="VornameInsText" ErrorMessage="RequiredFieldValidator" ForeColor="Red" ValidationGroup="MieterValid">Bitte geben Sie einen Vornamen ein!</asp:RequiredFieldValidator>
        </p>
        <p>
            <asp:Label ID="l" runat="server" Font-Names="Microsoft Sans Serif" Font-Size="12pt" Text="Tel"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TelInsText" runat="server" Height="20px" Width="260px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TelInsText" ErrorMessage="RequiredFieldValidator" ForeColor="Red" ValidationGroup="MieterValid">Bitte geben Sie eine Tell-Nummer ein!</asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TelInsText" ErrorMessage="RegularExpressionValidator" ForeColor="Red" ValidationExpression="^\d+$" ValidationGroup="MieterValid">Bitte geben Sie nur Zahlen ein!</asp:RegularExpressionValidator>
        </p>
        <p>
            <asp:Label ID="label5" runat="server" Font-Names="Microsoft Sans Serif" Font-Size="12pt" Text="WohnungsID"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="WohnungsIDInsText" runat="server" Height="20px" Width="260px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="WohnungsIDInsText" ErrorMessage="RequiredFieldValidator" ForeColor="Red" ValidationGroup="MieterValid">Bitte geben Sie eine WohnungsID ein!</asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="WohnungsIDInsText" ErrorMessage="RegularExpressionValidator" ForeColor="Red" ValidationExpression="^\d+$" ValidationGroup="MieterValid">Bitte geben Sie nur Zahlen ein!</asp:RegularExpressionValidator>
        </p>
        <p class="auto-style1">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="label6" runat="server" Font-Names="Microsoft Sans Serif" Font-Size="9pt" Text="MieterID (Update&amp;Delete)"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="MieterIDText" runat="server" Height="16px" Width="77px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="MieterIDText" ErrorMessage="RequiredFieldValidator" ForeColor="Red" ValidationGroup="MieterValidDel">Bitte geben Sie eine MieterID ein!</asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="MieterIDText" ErrorMessage="RegularExpressionValidator" ForeColor="Red" ValidationExpression="^\d+$" ValidationGroup="MieterValidDel">Bitte geben Sie nur Zahlen ein!</asp:RegularExpressionValidator>
        </p>
        <p>
            <asp:Button ID="MieterInsertRecordButton" runat="server" BackColor="YellowGreen" Height="40px" OnClick="MieterInsertRecordButton_Click" Text="Insert" Width="107px" ValidationGroup="MieterValid" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="MieterUpdateButton" runat="server" BackColor="Orange" Height="40px" OnClick="MieterUpdateButton_Click" Text="Update" Width="107px" ValidationGroup="MieterValid" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="MieterDeleteButton" runat="server" BackColor="Coral" Height="40px" OnClick="MieterDeleteButton_Click" Text="Delete" Width="107px" ValidationGroup="MieterValidDel" />
        </p>
    </form>
</body>
</html>
