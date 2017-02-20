<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="listbox_2.aspx.cs" Inherits="Web_Form_Listbox2.listbox_2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .form-control {
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="row" style="margin-top: 50px;">
                <div class="panel panel-default">
                    <div class="panel-body">
                        <div class="col-lg-12">
                            <asp:DropDownList ID="Droplist" runat="server" OnSelectedIndexChanged="Droplist_SelectedIndexChanged" Width="697px">
                            </asp:DropDownList>
                            <br />
                            <asp:ListBox CssClass="form-control" ID="ListUrun" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ListUrun_SelectedIndexChanged" Width="700px"></asp:ListBox>
                        </div>

                    </div>
                </div>
            </div>
        </div>

    </form>
</body>
</html>
