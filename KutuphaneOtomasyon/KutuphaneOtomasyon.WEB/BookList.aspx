<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BookList.aspx.cs" Inherits="KutuphaneOtomasyon.WEB.BookList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Kitaplar Listesi</title>
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            height: 58px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    
    <div>
            <h1>Kitaplar</h1>

            <table border="1">
                <tr>
                    
                    <th>Kitap Adı</th>
                    <th>Konusu</th>
                     <th>YazarAdı</th>
                    <th>Sayfa Sayısı</th>
                    <th>Durum</th>
                     <th>İşlem</th>
                    
                   
                </tr>
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <tr>
                            
                            <td><%# Eval("BookName")%></td>
                            <td><%# Eval("BookSubject")%></td>
                            <td><%# Eval("WriterName")%></td>
                            <td><%# Eval("PageCount")%></td>
                            <td><%# Eval("ISRented")%></td>
                            
                            
                            
                            <td>
                                <div class="table-responsive">
                                    <table class="table table-bordered">
                            </td>

                            <td>
                                
                                <a class="btn btn-success" href="#">Sil</a>"
                                <a class="btn btn-info" href="#">Düzenle</a>
                                <a class="btn btn-danger" href="#">Kirala</a>"
                            </td>
                        </tr>
                        </div>
                         </table>
                 
                    </td>
           
                    </ItemTemplate>
                </asp:Repeater>
                <tr>
                    <td>
                        <a class="btn btn-success" href="AddBook.aspx">Kitap Ekle</a>
                        <a class="btn btn-primary" href="UsersAdd.aspx">Kullanıcı Ekle</a>
                    </td>
                </tr>

            </table>
        </div>
    
    </form>
</body>
</html>
