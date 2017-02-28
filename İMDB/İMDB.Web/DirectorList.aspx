<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DirectorList.aspx.cs" Inherits="İMDB.Web.DirectorList" %>

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
                <h1>Yönetmen Listesi</h1>
                <a href="HomePage.aspx" class="btn btn-primary">Ana Sayfa</a><br />
                <br />
                <div class="table-responsive">
                    <table class="table table-bordered">
                        <tr>
                            <th>Yönetmen Adı</th>
                            <th style="width: 30%;">İşlemler</th>
                        </tr>
                        <asp:Repeater ID="Repeater1" runat="server">
                            <ItemTemplate>
                                <tr>
                                    <td><%#Eval("DirectorName") %></td>
                                    <td>
                                        <a href="DirectorAdd.aspx?ID=<%#Eval("DirectorID") %>" class="btn btn-warning">Düzenle</a>
                                        <a href="DirectorList.aspx?ID=<%#Eval("DirectorID") %>" class="btn btn-danger">Sil</a>
                                        <a href="DirectorMovie.aspx?ID=<%#Eval("DirectorID") %>" class="btn btn-primary">Filmleri</a>
                                    </td>
                                </tr>
                            </ItemTemplate>
                        </asp:Repeater>
                    </table>
                </div>
            </div>
    </form>
</body>
</html>
