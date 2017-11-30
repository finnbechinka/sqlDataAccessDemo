<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Wohnungen.aspx.cs" Inherits="Wohnungen" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/User.aspx">User Panel</asp:HyperLink>
&nbsp;<asp:Label ID="Label8" runat="server" Text="--&gt;"></asp:Label>
&nbsp;<asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Dashboard.aspx">Dasboard</asp:HyperLink>
&nbsp;
        <asp:Label ID="Label1" runat="server" Text="--&gt;"></asp:Label>
&nbsp;<asp:Label ID="Label2" runat="server" Text="Wohnungen" Font-Bold="True"></asp:Label>
        <br />
        <asp:Label ID="Label3" runat="server" Font-Names="Microsoft Sans Serif" Text="HausID"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="WohnHausIDText" runat="server" Height="20px" Width="260px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="WohnSearchButton" runat="server" Height="40px" OnClick="WohnSearchButton_Click" Text="Search" Width="107px" />
        <br />
    
    </div>
        <asp:ListBox ID="WohnungenFoundListBox" runat="server" Height="384px" Width="375px"></asp:ListBox>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Font-Names="Microsoft Sans Serif" Text="HausID"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="WohnHausIDInsText" runat="server" Height="20px" Width="260px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="WohnHausIDInsText" ErrorMessage="Bitte geben Sie eine HausID ein!" ForeColor="Red" ValidationGroup="ValidateWohn"></asp:RequiredFieldValidator>
&nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="WohnHausIDInsText" ErrorMessage="Bitte gebn Sie nur Zahlen ein!" ForeColor="Red" ValidationExpression="^\d+$" ValidationGroup="ValidateWohn"></asp:RegularExpressionValidator>
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Font-Names="Microsoft Sans Serif" Text="Stockwerk"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="StockwerkInsText" runat="server" Height="20px" Width="260px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="StockwerkInsText" ErrorMessage="Bitte geben Sie ein Stockwerk ein!" ForeColor="Red" ValidationGroup="ValidateWohn"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="StockwerkInsText" ErrorMessage="Bitte gebn Sie nur Zahlen ein!" ForeColor="Red" ValidationExpression="^\d+$" ValidationGroup="ValidateWohn"></asp:RegularExpressionValidator>
        <br />
        <br />
        <asp:Label ID="Label6" runat="server" Font-Names="Microsoft Sans Serif" Text="Größe"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="GrößeInsText" runat="server" Height="20px" Width="260px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="GrößeInsText" ErrorMessage="Bitte gebn Sie eine Größe ein!" ForeColor="Red" ValidationGroup="ValidateWohn"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="GrößeInsText" ErrorMessage="Bitte gebn Sie nur Zahlen ein!" ForeColor="Red" ValidationExpression="^\d+$" ValidationGroup="ValidateWohn"></asp:RegularExpressionValidator>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label7" runat="server" Font-Names="Microsoft Sans Serif" Font-Size="9pt" Text="WohnungsID (Update&amp;Delete)"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="WohnWohnungsIDText" runat="server" Height="16px" Width="77px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="GrößeInsText" ErrorMessage="Bitte gebn Sie eine WohnungsID ein!" ForeColor="Red" ValidationGroup="ValidateWohnDel"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="GrößeInsText" ErrorMessage="Bitte gebn Sie nur Zahlen ein!" ForeColor="Red" ValidationExpression="^\d+$" ValidationGroup="ValidateWohnDel"></asp:RegularExpressionValidator>
        <br />
        <asp:Button ID="WohnInsertButton" runat="server" BackColor="YellowGreen" Height="40px" OnClick="WohnInsertButton_Click" Text="Insert" Width="107px" ValidationGroup="ValidateWohn" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="WohnUpdateButton" runat="server" BackColor="Orange" Height="40px" OnClick="WohnUpdateButton_Click" Text="Update" Width="107px" ValidationGroup="ValidateWohn" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="WohnDeleteButton" runat="server" BackColor="Coral" Height="40px" OnClick="WohnDeleteButton_Click" Text="Delete" Width="107px" ValidationGroup="ValidateWohnDel" />
    </form>
</body>
</html>
