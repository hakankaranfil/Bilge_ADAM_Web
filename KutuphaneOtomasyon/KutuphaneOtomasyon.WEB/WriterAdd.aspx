<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WriterAdd.aspx.cs" Inherits="KutuphaneOtomasyon.WEB.WriterAdd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <div>
    <table border="1" class="table">
                <tr>
                    <td>
                        <asp:Label ID="label1" CssClass="form-kontrol" runat="server" Text="Yazar AdıSoyadı:"></asp:Label>


                    </td>


                    <td>
                        <asp:TextBox ID="TextBoxWriterName" CssClass="form-control" runat="server"></asp:TextBox>
                    </td>
                </tr>

             
            
          <tr>
                    <td colspan="2">
                        <asp:Button ID="BtnKaydet" class="btn btn-primary btn-block" runat="server" Text="Kaydet" OnClick="BtnKaydet_Click"/>
                    </td>
                </tr>
        </table>
    </div>
    </form>
</body>
</html>
