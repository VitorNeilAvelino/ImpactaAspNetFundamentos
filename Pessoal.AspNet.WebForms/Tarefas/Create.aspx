<%@ Page Title="Nova tarefa" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Create.aspx.cs" Inherits="Pessoal.AspNet.WebForms.Tarefas.Create" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Nova tarefa</h1>
    <hr />
    <asp:ValidationSummary ID="tarefaValidationSummary" runat="server" CssClass="text-danger" />
    <table >
        <tr>
            <td style="width: 126px">Nome</td>
            <td>
                <asp:TextBox ID="nomeTextBox" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="nomeRequiredFieldValidator" runat="server" ControlToValidate="nomeTextBox" CssClass="text-danger" Display="Dynamic" ErrorMessage="Nome é obrigatório">(!)</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 126px">Prioridade</td>
            <td>
                <asp:DropDownList ID="prioridadeDropDownList" runat="server" DataSourceID="prioridadeObjectDataSource" AppendDataBoundItems="True">
                    <asp:ListItem Value="0">Selecione</asp:ListItem>
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="prioridadeRequiredFieldValidator" runat="server" ControlToValidate="prioridadeDropDownList" CssClass="text-danger" Display="Dynamic" ErrorMessage="Prioridade é obrigatória" InitialValue="0">(!)</asp:RequiredFieldValidator>
                <asp:ObjectDataSource ID="prioridadeObjectDataSource" runat="server" SelectMethod="ObterPrioridades" TypeName="Pessoal.AspNet.WebForms.Tarefas.Create"></asp:ObjectDataSource>
            </td>
        </tr>
        <tr>
            <td style="width: 126px">Concluída</td>
            <td>
                <asp:CheckBox ID="concluidaCheckBox" runat="server" />
            </td>
        </tr>
        <tr>
            <td style="width: 126px">Observações</td>
            <td>
                <asp:TextBox ID="observacoesTextBox" runat="server" Rows="5" TextMode="MultiLine"></asp:TextBox>
            </td>
        </tr>
    </table>
    <asp:Button ID="gravarButton" runat="server" Text="Gravar" OnClick="gravarButton_Click" />
</asp:Content>