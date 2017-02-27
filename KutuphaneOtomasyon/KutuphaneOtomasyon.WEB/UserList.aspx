<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserList.aspx.cs" Inherits="KutuphaneOtomasyon.WEB.UserList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Kullanıcılar</title>
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <script src="Scripts/jquery-1.9.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>

    

    
   
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <h1>Kullanıcı Listesi</h1>
         <table border="1">
                <tr>
                    
                    <th>Kullanıcı Adı</th>
                    <th>Adres</th>
                 
                    
                   
                </tr>
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                    
                            
                            <td><%# Eval("UserName")%></td>
                            <td><%# Eval("Address")%></td>
                           
                         
                            
                            
                            
                            <td>
                                <div class="table-responsive">
                                    <table class="table table-bordered">
                            </td>

                            <td>
                                
                          
                                <a href="MusteriDuzenle.aspx?ID=<%#Eval("BookID")%>" class="btn btn-warning btn-btn-block">Hareketler</a>"
                            </td>
                        </tr>
                        </div>
                         </table>
                 
                    </td>
          <%-- </tr>--%>
                    </ItemTemplate>
                </asp:Repeater>
           

            </table>
    </div>

    </form>
</body>
</html>
