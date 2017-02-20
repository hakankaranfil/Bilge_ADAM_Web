<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Web_AutoPost._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
   <style type="text/css">
       body{
           font-family:Verdana;
           font-size:12pt;
       }

   </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="İl seçin"></asp:Label>
    
    </div>
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
        </asp:DropDownList>
        <p>
            <asp:Label ID="Label2" runat="server" Text="İlçe seçin"></asp:Label>
        </p>
        <asp:DropDownList ID="DropDownList2" runat="server">
        </asp:DropDownList>
    </form>
</body>
</html>
