<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="KitapEkle.aspx.cs" Inherits="WebQuiz_Kütüphane.KitapEkle" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Kitap Ekle</title>
    <link href="Content/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table border="1" class="table">
                <tr>
                    <td>
                        <asp:Label ID="label1" CssClass="form-kontrol" runat="server" Text="Kitap Adı:"></asp:Label>


                    </td>


                    <td>
                        <asp:TextBox ID="TextBoxKitapad" CssClass="form-control" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="label2" runat="server" Text="Konusu">
                    
                        </asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBoxKonu" CssClass="form-control" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="label3" runat="server" Text="Sayfa Sayısı"> </asp:Label>


                    </td>
                    <td>
                        <asp:TextBox ID="TextBoxsayfa" CssClass="form-control" runat="server"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td colspan="2">
                        <asp:Button ID="BtnKaydet" class="btn btn-primary btn-block" runat="server" Text="Kaydet" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
