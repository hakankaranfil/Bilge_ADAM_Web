<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Web_Kitap.aspx.cs" Inherits="WebQuiz_Kütüphane.Web_Kitap" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Kütüphane</title>
    <link href="Content/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Kitaplar</h1>
            
            <table border="1">
                <tr>
                    <th>Kitap ID</th>
                    <th>Kitap Adı</th>
                    <th>Konusu</th>
                    <th>Sayfa Sayısı</th>
                    <th>Durum</th>
                    <th>Düzenle</th>
                </tr>
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td style="visibility: hidden"><%# Eval("KitapID")%></td>
                            <td><%# Eval("KitapAdi")%></td>
                            <td><%# Eval("KitapKonu")%></td>
                            <td><%# Eval("KitapSayfa")%></td>
                            <td><%# Eval("Durum")%></td>
                            <td>
                                <div class="table-responsive">
                                    <table class="table table-bordered">
                            </td>

                            <td>
                                <%--<a class="btn btn-warning" href="MusteriGuncelle.aspx?ID=<%#Eval("CustomerID")%>">update</a>
                                <a class="btn btn-danger" href="Musteriler.aspx?ID=<%#Eval("CustomerID")%>">delete</a>--%>
                                <a class="btn btn-success" href="#">Kirala</a>
                                <a class="btn btn-info" href="#">Düzenle</a>
                                <a class="btn btn-danger" href="#">Sil</a>

                            </td>
                              
                
                        </tr>
                        </div>
                         </table>
                 
                    </td>
           
                    </ItemTemplate>
                </asp:Repeater>
                <tr>
                     <td colspan="6">
                 <a class="btn btn-success" href="KitapEkle.aspx">Kitap Ekle</a>
                    </td>
                </tr>
                 
            </table>
          
           
        
           
        </div>
    </form>
</body>
</html>
