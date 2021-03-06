﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MovieList.aspx.cs" Inherits="İMDB.Web.MovieList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Film Listesi</title>
    <a href="HomePage.aspx" class="btn btn-primary">Ana Sayfa</a><br />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/jquery-1.9.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <style type="text/css">
        body {
            background-color: gray;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">

        <div class="container">
            <h1>İMDB FİLM LİSTESİ</h1>
            <br />



            <br />
            <br />


            <td><a href="MovieList.aspx?sort=rating_desc" class="btn btn-info btn-btn-block">Puana Göre Sırala</a>
                <table class="table table-bordered">
                    <tr>
                        <td>
                            <span class="label label-primary">Türe Göre Listele</span>
                        </td>
                        <td>
                            <asp:DropDownList ID="DropMovieType" CssClass="form-control" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropMovieType_SelectedIndexChanged"></asp:DropDownList>
                        </td>
                    </tr>
            </td>

            </tr>
                <div class="table-responsive">
                    <table class="table table-bordered">

                        <tr>
                            <th>Film Adı</th>
                            <th>Film Konusu</th>
                            <th>Çıkış Tarihi</th>
                            <th>Puanı</th>
                            <th>Türü</th>
                            <th>Yönetmeni</th>

                        </tr>


                        <asp:Repeater ID="Repeater1" runat="server">
                            <ItemTemplate>

                                <td><%#Eval("MovieName") %></td>
                                <td><%#Eval("MovieSubject") %></td>
                                <td><%#Eval("RealiseDate") %></td>
                                <td><%#Eval("MovieRating") %></td>
                                <td><%#Eval("MovieTypeName") %></td>
                                <td><%#Eval("DirectorName") %></td>
                                <td>
                                    <div class="table-responsive">
                                        <table class="table table-bordered">
                                </td>

                                <td>
                                    <a href="MovieList.aspx?ID=<%#Eval("MovieID")%>" class="btn btn-danger btn-btn-block">Sil</a>
                                </td>
                                <td>
                                    <a href="MovieAdd.aspx?ID=<%#Eval("MovieID")%>" class="btn btn-success btn-btn-block">düzenle</a>
                                </td>
                                <td>
                                    <a href="MovieRating.aspx?ID=<%#Eval("MovieID")%>" class="btn btn-info btn-btn-block">Puan Ver</a>
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
        </div>
    </form>
</body>
</html>
