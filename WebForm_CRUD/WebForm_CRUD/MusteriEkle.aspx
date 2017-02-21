<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MusteriEkle.aspx.cs" Inherits="WebForm_CRUD.MusteriEkle" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table border="1" class="table">
                <tr>
                    <td>
                        <asp:Label ID="label1" CssClass="form-kontrol" runat="server" Text="Ad"></asp:Label>


                    </td>


                    <td>
                        <asp:TextBox ID="TextBox1ad" CssClass="form-control" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="label2" runat="server" Text="Soyad">
                    
                        </asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBoxsoyad" CssClass="form-control" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="label3" runat="server" Text="telefon"> </asp:Label>


                    </td>
                    <td>
                        <asp:TextBox ID="TextBoxtel" CssClass="form-control" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="label4" runat="server" Text="Adres"> </asp:Label>


                    </td>
                    <td>
                        <asp:TextBox ID="Textadres" CssClass="form-control" runat="server"></asp:TextBox>
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
