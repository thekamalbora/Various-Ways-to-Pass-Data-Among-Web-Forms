<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sessions.aspx.cs" Inherits="HowtoPassDatabtwPages.Sessions" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
     <form id="form1" runat="server">
        <div>
            <b>Name:</b>&nbsp;<asp:TextBox ID="txtName" runat="server" Width="266px"></asp:TextBox><br /><br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnPage2" Text="Call Page2" runat="server" width="132px" 
                onclick="btnPage2_Click" />
        </div>
    </form>
</body>
</html>
