<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="page 2.aspx.cs" Inherits="homework.page_2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:CheckBox ID="chb_one" runat="server" Text="one" TextAlign="Left" /><asp:Button ID="btn_check" runat="server" Text="check" OnClick="btn_check_Click" />
        </div>
    </form>
</body>
</html>
