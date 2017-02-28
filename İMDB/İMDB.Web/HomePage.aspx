<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="İMDB.Web.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Ana Sayfa</title>
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <script src="Scripts/jquery-1.9.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div class="container">
            <h1>İMDB Film Listesi</h1>
            <%--<a href="BookList.aspx" class="btn btn-primary">Ana Sayfa</a><br />--%>

            <%--İşlemler--%>
            <div class="btn-group">
                <button type="button" class="btn btn-primary">İşlemler</button>
                <button type="button" class="btn btn-primary dropdown-toggle" data-toggle="dropdown">
                    <span class="caret"></span>
                </button>
                <ul class="dropdown-menu" role="menu">
                    <li><a href="MovieAdd.aspx">Film Ekle</a></li>
                    <li><a href="DirectorAdd.aspx">Yönetmen Ekle</a></li>
                    <li><a href="MovieList.aspx">Filmleri Listele</a></li>
                    <li><a href="WriterAdd.aspx">Yönetmenleri Listele</a></li>
                
                </ul>
            </div>
    </form>
</body>
</html>
