<%@ Page Title="" Language="C#" MasterPageFile="~/MASTER_PAGE_USER.Master" AutoEventWireup="true" CodeBehind="pageDANHSACHSANPHAM.aspx.cs" Inherits="QUANLYBANHANG_2050531200324.pageDANHSACHSANPHAM" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DataList ID="DataList1" runat="server">
        <ItemTemplate>4
            <div style=" padding:16px">
                <a href="pageCHITIET.aspx?MSP=<%# Eval("MASANPHAM") %>">
                    <img alt="" src ="IMAGES/<%# Eval("HINHANH")%>" width="200px" height="200px"" />
                   <br />
                    Tên sản phầm : <%# Eval("TENSANPHAM") %>
                    <br />
                    Đơn giá : <%# Eval("DONGIA") %>
                </a>
                
            </div>
        </ItemTemplate>
    </asp:DataList>
</asp:Content>
