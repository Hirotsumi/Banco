<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Alunos.aspx.cs" Inherits="Banco.Alunos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <br />
    <br />
    <asp:GridView runat="server" ID="gridAluno" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="ID do aluno" />
            <asp:BoundField DataField="Nome" HeaderText="Nome do aluno" />
        </Columns>
    </asp:GridView>
</asp:Content>
