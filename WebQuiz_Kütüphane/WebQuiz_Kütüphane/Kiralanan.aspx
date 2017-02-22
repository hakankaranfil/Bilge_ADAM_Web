<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Kiralanan.aspx.cs" Inherits="WebQuiz_Kütüphane.Kiralanan" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>KitapKirala</title>
    <link href="Content/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table border="1" class="table">
                <tr>
                    <td>
                        <asp:Label ID="label1" CssClass="form-kontrol" runat="server" Text="Kullanıcı adı:"></asp:Label>


                    </td>


                    <td>
                        <asp:TextBox ID="TextBoxKullanıcıAd" CssClass="form-control" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="label2" runat="server" Text="Kitap adı:">
                    
                        </asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBoxKitapadi" CssClass="form-control" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="label5" runat="server" Text="Kitap Konu:">
                    
                        </asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBoxKitapKonu" CssClass="form-control" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="label6" runat="server" Text="Kitap sayfa:">
                    
                        </asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBoxKitapSayfa" CssClass="form-control" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="label3" runat="server" Text="Alış Tarihi:"> </asp:Label>


                    </td>
                    <td>
                        <asp:TextBox ID="TextBoxAlisTarih" CssClass="form-control" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="label4" runat="server" Text="İade Tarihi:"> </asp:Label>


                    </td>
                    <td>
                        <asp:TextBox ID="TextBoxİadeTarih" CssClass="form-control" runat="server"></asp:TextBox>
                    </td>
                </tr>
                 <tr>
                    <td>
                        <asp:Label ID="label7" runat="server" Text="kullanıcıno:">
                    
                        </asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBoxkullanicino" CssClass="form-control" runat="server"></asp:TextBox>
                    </td>
                </tr>
                 <tr>
                    <td>
                        <asp:Label ID="label8" runat="server" Text="KitapNo:">
                    
                        </asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBoxKitapNO" CssClass="form-control" runat="server"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td colspan="2">
                      <asp:Button ID="BtnKirala" class="btn btn-primary btn-block" runat="server" Text="Kirala" OnClick="BtnKirala_Click"/>
                    </td>
                </tr>
            </table>

        </div>
    </form>
</body>
</html>
