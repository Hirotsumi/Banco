<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EstadoCidade.aspx.cs" Inherits="Banco.EstadoCidade" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br /> <br />
    <h2><asp:Label ID="lblEstado" Text="Estado" runat="server" /></h2>

    <asp:DropDownList ID="drpEstado" OnSelectedIndexChanged="drpEstado_SelectedIndexChanged" runat="server" AutoPostBack="true">
    </asp:DropDownList>
    <br />
    <h2><asp:Label ID="lblCidade" Text="Cidade" runat="server" Visible="false" /></h2>
    <asp:DropDownList ID="drpCidade" runat="server" Visible="false">
    </asp:DropDownList>
</asp:Content>
