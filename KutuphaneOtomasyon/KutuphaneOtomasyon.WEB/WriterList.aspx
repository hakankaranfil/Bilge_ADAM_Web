<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WriterList.aspx.cs" Inherits="KutuphaneOtomasyon.WEB.WriterList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link href="Content/bootstrap.css" rel="stylesheet" />
    <script src="Scripts/jquery-1.9.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
   <div>
    <table border="1">
                <tr>
                    
                    <th>Kullanıcı Adı</th>
                    
                 
                    
                   
                </tr>
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                    
                            
                            <td><%# Eval("WriterName")%></td>
                            
                           
                         
                            
                            
                            
                            <td>
                                <div class="table-responsive">
                                    <table class="table table-bordered">
                            </td>
                        
                            <td>
                                
                          
                                <a href="WriterList.aspx?ID=<%#Eval("WriterID")%>" class="btn btn-warning btn-btn-block">Sil</a>"
                            </td>
                        <td>
                                
                          
                                <a href="WriterAdd.aspx?ID=<%#Eval("WriterID")%>" class="btn btn-warning btn-btn-block">düzenle</a>"
                            </td>
                        </tr>
                        </div>
                         </table>
                 
                    </td>
           </tr>
                    </ItemTemplate>
                </asp:Repeater>
           

            </table>
    </div>
    </form>
</body>
</html>
