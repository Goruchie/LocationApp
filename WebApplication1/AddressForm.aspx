<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddressForm.aspx.cs" Inherits="WebApplication1.AddressForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="col-6">
            <div class="mb-3">
                <label for="txtId" class="form-label">Id</label>
                <asp:TextBox runat="server" ID="txtId" CssClass="form-control" />
            </div>
            <div class="mb-3">
                <label for="txtStreet" class="form-label">Street</label>
                <asp:TextBox runat="server" TextMode="SingleLine" ID="txtStreet" CssClass="form-control" />
            </div>
            <div class="mb-3">
                <label for="txtNumber" class="form-label">Number</label>
                <asp:TextBox runat="server" TextMode="Number" ID="txtNumber" CssClass="form-control" />
            </div>
            <div class="mb-3">
                <asp:Button Text="Accept" ID="btnAccept" OnClick="btnAccept_Click" CssClass="btn btn-dark" runat="server" />
                <a href="/Default.aspx">Cancel</a>
            </div>
        </div>
    </div>

</asp:Content>
