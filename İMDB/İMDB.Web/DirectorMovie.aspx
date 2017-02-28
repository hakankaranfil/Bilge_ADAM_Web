<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DirectorMovie.aspx.cs" Inherits="İMDB.Web.DirectorMovie" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <style type="text/css">
        body {
         background-color:brown;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <div class="container">
            <h1>Yönetmen Film Listesi</h1>
            <a href="HomePage.aspx" class="btn btn-primary">Ana Sayfa</a><br /><br />
            <div class="table-responsive">
                <table class="table table-bordered">
                    <tr>
                         <th>Yönetmen adı</th>
                         <th>Filmleri</th>
                       
                      
                    </tr>
                    <asp:Repeater ID="Repeater1" runat="server">
                        <ItemTemplate>
                            <tr>
                                <td><%#Eval("DirectorName") %></td>
                                <td><%#Eval("MovieName") %></td>
                                
                         
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                   
                        
                   
              
                    
                </table>
            </div>
    </div>
    </form>
</body>
</html>
