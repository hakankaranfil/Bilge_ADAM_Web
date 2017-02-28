<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DirectorAdd.aspx.cs" Inherits="İMDB.Web.DirectorAdd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Yönetmen Ekle</title>
    <link href="Content/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
         <div class="container">
            <h1>Yönetmen Ekle</h1>
            <a href="MovieList.aspx" class="btn btn-primary">Ana Sayfa</a><br /><br />
     <table class="table table-bordered">
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Yönetmen Adı:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtDirectorName" CssClass="form-control" runat="server"></asp:TextBox>
                    </td>

                </tr>
           <tr>
                    <td colspan="2">
                        <asp:Button ID="btnKaydet" CssClass="btn btn-primary btn-block" runat="server" Text="Kaydet" OnClick="btnKaydet_Click" />
                    </td>
                </tr>
               
                    </table>
    </div>
    </form>
</body>
</html>
