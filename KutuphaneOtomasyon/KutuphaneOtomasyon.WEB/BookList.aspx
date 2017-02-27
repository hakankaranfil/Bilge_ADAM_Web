<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BookList.aspx.cs" Inherits="KutuphaneOtomasyon.WEB.BookList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Kitaplar Listesi</title>
      <link href="Content/bootstrap.css" rel="stylesheet" />
    <script src="Scripts/jquery-1.9.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
  
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
        <div class="btn-group">
  <button type="button" class="btn btn-primary">Sony</button>
  <button type="button" class="btn btn-primary dropdown-toggle" data-toggle="dropdown">
    <span class="caret"></span>
  </button>
  <ul class="dropdown-menu" role="menu">
    <li><a href="AddBook.aspx">Kitap Ekle</a></li>
    <li><a href="WriterAdd.aspx">Yazar Ekle</a></li>
    <li><a href="UsersAdd.aspx">Kullanıcı Ekle</a></li>
     <li><a href="#">Kayıtlar</a></li>
      <li><a href="#">Tüm Hareketler</a></li>
  </ul>
</div>

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
                       <%-- <tr class="<%# Eval("IsRented").ToString()=="True" ? "danger":"success"%>">--%>
                            
                            <td><%# Eval("BookName")%></td>
                            <td><%# Eval("BookSubject")%></td>
                            <td><%# Eval("WriterName")%></td>
                            <td><%# Eval("PageCount")%></td>
                           <%-- <td><%# Eval("IsRented").ToString()=="True"?"Alınabilir":"Alınamaz"%></td>--%>
                            
                            
                            
                            <td>
                                <div class="table-responsive">
                                    <table class="table table-bordered">
                            </td>

                            <td>
                                
                              <%--  <a class="btn btn-success" href="#">Sil</a>"
                                <a class="btn btn-info" href="#">Düzenle</a>--%>
                                <a href="#?ID=<%#Eval("BookID")%>" class="btn btn-info btn-btn-block">Kirala</a>"
                            </td>
                        </tr>
                        </div>
                         </table>
                 
                    </td>
          <%-- </tr>--%>
                    </ItemTemplate>
                </asp:Repeater>
                <tr>
                    <td>
                      <%--  <a class="btn btn-success" href="AddBook.aspx">Kitap Ekle</a>
                        <a class="btn btn-primary" href="UsersAdd.aspx">Kullanıcı Ekle</a>--%>
                    </td>
                </tr>

            </table>
        </div>
    
    </form>
</body>
</html>
