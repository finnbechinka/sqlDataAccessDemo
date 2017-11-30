<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

<!DOCTYPE html>
<script runat="server">

    
</script>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 321px;
        }
        .auto-style3 {
            width: 321px;
            text-align: right;
        }
        .auto-style4 {
            width: 127px;
        }
        .auto-style5 {
            width: 321px;
            text-align: right;
            height: 26px;
        }
        .auto-style6 {
            width: 127px;
            height: 26px;
        }
        .auto-style7 {
            height: 26px;
            color: #FF0000;
        }
        .auto-style8 {
            color: #FF0000;
        }
        .auto-style9 {
            width: 56px;
        }
    </style>
</head>
    <body>
    <form id="form1" runat="server">
    <div>
    
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/User.aspx">User Panel</asp:HyperLink>
&nbsp;<asp:Label ID="Label8" runat="server" Text="--&gt;"></asp:Label>
&nbsp;<asp:Label ID="Label9" runat="server" Font-Bold="True" Text="Register"></asp:Label>
    
    </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style5">User Name:</td>
                <td class="auto-style6">
                    <asp:TextBox ID="UserNameText" runat="server" Width="180px"></asp:TextBox>
                </td>
                <td class="auto-style7">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorUserName" runat="server" ControlToValidate="UserNameText" ErrorMessage="Please enter a User Name"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">E-Mail:</td>
                <td class="auto-style4">
                    <asp:TextBox ID="EMailText" runat="server" Width="180px"></asp:TextBox>
                </td>
                <td class="auto-style8">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorEMail" runat="server" ControlToValidate="EMailText" ErrorMessage="Please enter a E-Mail adress"></asp:RequiredFieldValidator>
                    <br />
                    <asp:RegularExpressionValidator ID="RegularExpressionValidatorValidEMail" runat="server" ControlToValidate="EMailText" ErrorMessage="Please enter a valid E-Mail adress" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Country:</td>
                <td class="auto-style4">
                    <asp:DropDownList ID="CountryDropDown" runat="server" Width="180px">
                        <asp:ListItem>Select Country</asp:ListItem>
                        <asp:ListItem>Germany</asp:ListItem>
                        <asp:ListItem>Sweden</asp:ListItem>
                        <asp:ListItem>UK</asp:ListItem>
                        <asp:ListItem>Other</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style8">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorCountry" runat="server" ControlToValidate="CountryDropDown" ErrorMessage="Please choose a Country" InitialValue="Select Country"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Password:</td>
                <td class="auto-style4">
                    <asp:TextBox ID="PasswordText" runat="server" TextMode="Password" Width="180px"></asp:TextBox>
                </td>
                <td class="auto-style8">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorPassword" runat="server" ControlToValidate="PasswordText" ErrorMessage="Please enter a Password"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Confrim Password:</td>
                <td class="auto-style4">
                    <asp:TextBox ID="ConfirmPasswordText" runat="server" TextMode="Password" Width="180px"></asp:TextBox>
                </td>
                <td class="auto-style8">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorConfirmPassword" runat="server" ControlToValidate="ConfirmPasswordText" ErrorMessage="Please confirm your Password"></asp:RequiredFieldValidator>
                    <br />
                    <asp:CompareValidator ID="CompareValidatorPasswordMatch" runat="server" ControlToCompare="PasswordText" ControlToValidate="ConfirmPasswordText" ErrorMessage="The Passwords do not match"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style4">
                    <asp:Button ID="SubmitButton" runat="server" Text="Submit" OnClick="SubmitButton_Click"/>
                    <input id="Reset1" type="reset" value="reset" class="auto-style9" />&nbsp;&nbsp; </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>

