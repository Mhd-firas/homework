<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="page 1.aspx.cs" Inherits="homework.page_1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txt_one" runat="server"></asp:TextBox><asp:TextBox ID="txt_two" runat="server"></asp:TextBox>
            <br /><asp:Button ID="btn_send" runat="server"  Text="change" OnClick="btn_send_Click" />
        </div>
        <asp:Button ID="btn_response" runat="server" OnClick="btn_response_Click" Text="response" />
    </form>
</body>
</html>
