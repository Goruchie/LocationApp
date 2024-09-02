<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView runat="server" ID="dgvAddresses" CssClass="table table-dark table-bordered" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField HeaderText="Street" DataField="Street" />
            <asp:BoundField HeaderText="Number" DataField="Number" />
        </Columns>
    </asp:GridView>

</asp:Content>
