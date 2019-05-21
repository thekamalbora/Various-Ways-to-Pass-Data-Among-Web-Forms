<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CrossPagePosting.aspx.cs" Inherits="HowtoPassDatabtwPages.CrossPagePosting" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
 <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="ddl1" runat="server"></asp:DropDownList>
            <asp:Button ID="btnPage2" Text="Call Page2" runat="server" width="132px" PostBackUrl="~/RetrieveData.aspx" />
        </div>
    </form>
</body>
</html>
