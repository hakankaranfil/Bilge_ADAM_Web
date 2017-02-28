<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MovieAdd.aspx.cs" Inherits="İMDB.Web.MovieAdd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Film Ekle</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <link href="Content/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <div class="container">
            <h1>Film Ekle</h1>
            <a href="HomePage.aspx" class="btn btn-primary">Ana Sayfa</a><br /><br />
            <table class="table table-bordered">
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Film Adı:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtMovieName" CssClass="form-control" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Film Konusu:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtSubject" CssClass="form-control" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="Çıkış Tarihi:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtRealiseDate" CssClass="form-control" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text="Puanı:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtMovieRating" CssClass="form-control" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label5" runat="server" Text="Film Türü:"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="DropMovieType" CssClass="form-control" runat="server"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label6" runat="server" Text="Yönetmeni:"></asp:Label>
                    </td>
                    <td>
                       <asp:DropDownList ID="DropDirector" CssClass="form-control" runat="server"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnKaydet" CssClass="btn btn-primary btn-block" runat="server" Text="Kaydet" OnClick="btnKaydet_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </div>
    </form>
</body>
</html>
