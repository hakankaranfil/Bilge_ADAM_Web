<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RentBook.aspx.cs" Inherits="KutuphaneOtomasyon.WEB.RentBook" %>

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
                        <asp:Label ID="label1" CssClass="form-kontrol" runat="server" Text="Kitap Adı:"></asp:Label>


                    </td>


                    <td>
                        <asp:TextBox ID="TextBoxKitapName" CssClass="form-control" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="label2" runat="server" Text="Konusu">
                    
                        </asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBoxSubject" CssClass="form-control" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="label3" runat="server" Text="Sayfa Sayısı"> </asp:Label>


                    </td>
                    <td>
                        <asp:TextBox ID="TextBoxPageCount" CssClass="form-control" runat="server"></asp:TextBox>
                    </td>
                </tr>
         <tr>
                    <td>
                        <asp:Label ID="label4" runat="server" Text="raf no:"> </asp:Label>


                    </td>
                    <td>
                        <asp:TextBox ID="TextBoxShelfNumberf" CssClass="form-control" runat="server"></asp:TextBox>
                    </td>
                </tr>
         <tr>
                    <td>
                        <asp:Label ID="label5" runat="server" Text="KUlacınıcı adı:"> </asp:Label>


                    </td>
                    <td>
                        <asp:DropDownList ID="DropUser" runat="server"></asp:DropDownList>
                    </td>
                </tr>

                <tr>
                    <td colspan="2">
                        <asp:Button ID="BtnKaydet" class="btn btn-primary btn-block" runat="server" Text="Kirala" OnClick="BtnKaydet_Click"  />
                    </td>
                </tr>
            </table>
    </div>
    </form>
</body>
</html>
