<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RetrieveData.aspx.cs" Inherits="HowtoPassDatabtwPages.RetrieveData" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
      <form id="form1" runat="server">
        <div>
            Cookies:&nbsp;<asp:Label ID="lbl1" runat="server" ForeColor="Red" Font-Bold="true"></asp:Label><br /><br />
            QueryString:&nbsp;<asp:Label ID="lbl2" runat="server" ForeColor="Red" Font-Bold="true"></asp:Label><br /><br />
            Sessions:&nbsp;<asp:Label ID="lbl3" runat="server" ForeColor="Red" Font-Bold="true"></asp:Label><br /><br />
            CrossPagePosting:&nbsp;<asp:Label ID="lbl4" runat="server" ForeColor="Red" Font-Bold="true"></asp:Label><br /><br />
            Server.Transfer:&nbsp;<asp:Label ID="lbl5" runat="server" ForeColor="Red" Font-Bold="true"></asp:Label><br /><br />
        </div>
    </form>
</body>
</html>
