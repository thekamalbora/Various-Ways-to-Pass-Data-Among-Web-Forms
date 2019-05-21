<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cookies.aspx.cs" Inherits="HowtoPassDatabtwPages.Cookies" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="frmCookies" runat="server">
        <div>
            <asp:Label ID="lblMsg" runat="server"></asp:Label><br /><br />
            <b>Name:</b>&nbsp;<asp:TextBox ID="txtName" runat="server" Width="266px"></asp:TextBox><br /><br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnCreate" Text="Create Cookies" runat="server" onclick="btnCreate_Click" width="132px" />
        </div>
    </form>
</body>
</html>
