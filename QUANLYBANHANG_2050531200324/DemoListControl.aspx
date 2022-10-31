<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DemoListControl.aspx.cs" Inherits="QUANLYBANHANG_2050531200324.DemoListControl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 253px;
        }
        .auto-style2 {
            height: 138px;
            vertical-align:top;
            color:aqua;
        }
        .auto-style3 {
            height: 159px;
        }

        .auto-style4 {
            height: 138px;
            align-items: start;
            width: 337px;
        }
        .auto-style5 {
            height: 159px;
            width: 337px;
        }
        .auto-style6 {
            width: 337px;
        }
        #table1 {
            background-color:coral;
            border:2px solid thin;
            border-inline:2px solid yellow;
        }
        
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table id="table1" body="2px" class="auto-style1">
                <tr>
                    <td class="auto-style2">
                        ListBox</td>
                    <td class="auto-style4">
                        <asp:ListBox ID="ListBox1" runat="server">
                        </asp:ListBox>
                    </td>
                    <td class="auto-style2"></td>
                </tr>
                <tr>
                    <td class="auto-style3">Dropdownlist</td>
                    <td class="auto-style5">
                        <asp:DropDownList ID="DropDownList1" runat="server">
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style3"></td>
                </tr>
                <tr>
                    <td>CheckListBox</td>
                    <td class="auto-style6">
                        <asp:CheckBoxList ID="CheckBoxList1" runat="server">
                        </asp:CheckBoxList>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                  <tr>
                    <td>RadioButtonList</td>
                    <td class="auto-style6">
                        <h3>Ai dep trai nhat</h3>
                      <asp:RadioButtonList ID="RadioButtonList1" runat="server" Width="277px">
                        </asp:RadioButtonList>
                      </td>
                    <td>&nbsp;</td>
                </tr>
                    <tr>
                    <td>
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Selected item" />
                        </td>
                    <td class="auto-style6">
                        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Delete item" />
                        </td>
                    <td>
                        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Clear" />
                        </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
