<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Pessoal.AspNet.WebForms.Tarefas.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>
        Tarefas</h1>
    <hr />
    <asp:LinkButton ID="novaTarefaLinkButton" runat="server" PostBackUrl="Create">Nova</asp:LinkButton>
    <asp:GridView ID="tarefasGridView" runat="server" DataSourceID="tarefasObjectDataSource" AutoGenerateColumns="False" Width="100%">
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" />
            <asp:BoundField DataField="Nome" HeaderText="Nome" SortExpression="Nome" />
            <asp:BoundField DataField="Prioridade" HeaderText="Prioridade" SortExpression="Prioridade" />
            <asp:CheckBoxField DataField="Concluida" HeaderText="Concluida" SortExpression="Concluida" />
            <asp:BoundField DataField="Observacoes" HeaderText="Observacoes" SortExpression="Observacoes" />
        </Columns>
    </asp:GridView>
    <asp:ObjectDataSource ID="tarefasObjectDataSource" runat="server" SelectMethod="Selecionar" TypeName="Impacta.AspNet.Repositorios.SqlServer.TarefaRepositorio"></asp:ObjectDataSource>
</asp:Content>
