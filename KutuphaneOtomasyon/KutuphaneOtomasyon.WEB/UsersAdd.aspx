<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UsersAdd.aspx.cs" Inherits="KutuphaneOtomasyon.WEB.UsersAdd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Kişi Ekle</title>
    <link href="Content/bootstrap-theme.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table border="1" class="table">
                <tr>
                    <td>
                        <asp:Label ID="label1" CssClass="form-kontrol" runat="server" Text="Kişi AdıSoyadı:"></asp:Label>


                    </td>


                    <td>
                        <asp:TextBox ID="TextBoxUserName" CssClass="form-control" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="label2" runat="server" Text="Adres:">
                    
                        </asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBoxAddress" CssClass="form-control" runat="server"></asp:TextBox>
                    </td>
                </tr>
            
          <tr>
                    <td colspan="2">
                        <asp:Button ID="BtnKaydet" class="btn btn-primary btn-block" runat="server" Text="Kaydet" OnClick="BtnKaydet_Click"/>
                    </td>
                </tr>
        </table>
    </div>
    </form>
</body>
</html>
