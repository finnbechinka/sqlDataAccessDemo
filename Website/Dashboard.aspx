<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Dashboard.aspx.cs" Inherits="Dashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/User.aspx">User Panel</asp:HyperLink>
&nbsp;<asp:Label ID="Label8" runat="server" Text="--&gt;"></asp:Label>
&nbsp;Dashboard</div>
        <table class="auto-style1">
            <tr>
                <td>
                    <br />
                    <asp:Button ID="buttonMieter" runat="server" Height="42px" OnClick="buttonMieter_Click" Text="Mieter" Width="82px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="buttonWohnunegn" runat="server" Height="42px" OnClick="buttonWohnunegn_Click" Text="Wohnungen" Width="96px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="buttonHäuser" runat="server" Height="42px" OnClick="buttonHäuser_Click" Text="Häuser" Width="82px" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
