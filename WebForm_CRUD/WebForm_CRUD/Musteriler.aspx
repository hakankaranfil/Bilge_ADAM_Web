<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Musteriler.aspx.cs" Inherits="WebForm_CRUD.Musteriler" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Müsteriler</title>
    <link href="Content/bootstrap.css" rel="stylesheet" />
    
    <style type="text/css">
        body {
            font-family: 'Segoe UI',Tahoma,Verdana;
        }
    </style>


</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>ErdalBakkal Musterileri</h1>
            <a href="MusteriEkle.aspx" class="btn btn-grimary" >YeniEkle </a>
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
                            <td style="visibility:hidden"><%# Eval("CustomerID")%></td>
                            <td><%# Eval("CustomerName")%></td>
                            <td><%# Eval("CustomerSurname")%></td>
                            <td><%# Eval("Phone")%></td>
                            <td><%# Eval("Adress")%></td>
                            <td>
                                <div class="table-responsive">
                                <table class="table table-bordered">
                               

                            </td>

                            <td>
                                <a class="btn btn-warning" href="MusteriGuncelle.aspx?ID=<%#Eval("CustomerID")%>">update</a>
                                <a class="btn btn-danger" href="Musteriler.aspx?ID=<%#Eval("CustomerID")%>">delete</a>

                            </td>

                        </tr>
                   </div>
                         </table>
                   

                    </ItemTemplate>


                   
                </asp:Repeater>
            </table>
            

        </div>
    </form>
</body>
</html>
