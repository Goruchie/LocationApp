<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        .hidden {
            display: none;
        }
    </style>
    <div class="col">
        <asp:GridView runat="server" ID="dgvAddresses" DataKeyNames="Id" OnRowDeleting="dgvAddresses_RowDeleting" OnSelectedIndexChanged="dgvAddresses_SelectedIndexChanged" CssClass="table table-dark table-bordered" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField HeaderText="Id" DataField="Id" HeaderStyle-CssClass="hidden" ItemStyle-CssClass="hidden" />
                <asp:BoundField HeaderText="Street" DataField="Street" />
                <asp:BoundField HeaderText="Number" DataField="Number" />
                <asp:CommandField ShowSelectButton="true" SelectText="Select" HeaderText="Edit" />
                <asp:CommandField ShowDeleteButton="true" ButtonType="Button" DeleteText="Delete" HeaderText="Delete Item" />
            </Columns>
        </asp:GridView>
        <a href="AddressForm">Add</a>
    </div>

</asp:Content>
