<%@ Page Title="" Language="C#" MasterPageFile="~/MASTER_PAGE_USER.Master" AutoEventWireup="true" CodeBehind="pageCHITIET.aspx.cs" Inherits="QUANLYBANHANG_2050531200324.pageCHITIET" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
    <asp:Repeater ID="Repeater2" runat="server">
        <itemtemplate>
        <div style="padding: 16px">
            <img alt="" src='IMAGES/<%# Eval("HINHANH") %>' width="150px" height="150px" />
            <h1>Tên sản phẩm: <%# Eval("TENSANPHAM") %></h1>
            <%# Eval("MOTA") %>
            <br />
        </div>
    </itemtemplate>
    </asp:Repeater>

    <asp:DropDownList ID="drlSOLUONG" runat="server">
    </asp:DropDownList>
    <asp:Button ID="btn_GIOHANG" runat="server" Text="Theme vao gio" />

</asp:Content>
