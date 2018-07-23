<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Principal.aspx.cs" Inherits="WebPage.Principal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Cedula:<asp:Label ID="lblcedula" runat="server" Text="Label"></asp:Label>
            <br />
            Nombre:<asp:Label ID="lblnombre" runat="server" Text="Label"></asp:Label>
            <br />
            Apellido:<asp:Label ID="lblapellido" runat="server" Text="Label"></asp:Label>
            <br />
            Edad:<asp:Label ID="lbledad" runat="server" Text="Label"></asp:Label>
            <br />
        </div>
    </form>
</body>
</html>
