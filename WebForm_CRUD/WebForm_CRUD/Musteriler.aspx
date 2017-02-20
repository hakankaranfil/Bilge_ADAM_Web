<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Musteriler.aspx.cs" Inherits="WebForm_CRUD.Musteriler" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 122px;
        }
        .auto-style2 {
            width: 100px;
        }
        .auto-style3 {
            width: 99px;
        }
        .auto-style4 {
            width: 98px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Musteriler</h1>
        <a href="#">Yeni Ekle</a>
        <table border="1">
            <tr>
            <th>ID</th>
            <th>name</th>
            <th>surname</th>
            <th>phonenumber</th>
            <th>adresss</th>
            <th>Edit</th>
                </tr>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                       <td><%# Eval("CustomerID")%></td>
                        <td><%# Eval("CustomerName")%></td>
                        <td><%# Eval("CustomerSurname")%></td>
                        <td><%# Eval("PhoneNumber")%></td>
                        <td><%# Eval("Adress")%></td>
                        <td><%# Eval("CustomerID")%></td>
                        <td>
                            <a href="#">update</a>
                             <a href="#">delete</a>

                        </td>

                    </tr>

                </ItemTemplate>



            </asp:Repeater>
        </table>
    
    </div>
    </form>
</body>
</html>
