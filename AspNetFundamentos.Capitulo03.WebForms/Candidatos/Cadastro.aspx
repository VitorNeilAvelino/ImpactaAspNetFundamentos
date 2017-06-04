<%@ Page Title="Cadastro de candidatos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="AspNetFundamentos.Capitulo03.WebForms.Candidatos.Cadastro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:MultiView ID="cadastroMultiView" ActiveViewIndex="0" runat="server">
        <asp:View ID="cadastroView" runat="server">
            <h1>Cadastro de candidato</h1>
            <hr />
            <div class="form-group">
                <asp:Label ID="Label1" runat="server" Text="Nome" AssociatedControlID="nomeTextBox"></asp:Label>
                <asp:TextBox ID="nomeTextBox" runat="server" CssClass="form-control" placeholder="Nome"></asp:TextBox>
                <asp:RequiredFieldValidator ID="nomeRequiredFieldValidator" runat="server" ErrorMessage="O campo Nome é obrigatório."
                    ControlToValidate="nomeTextBox" Display="Dynamic" CssClass="validator"></asp:RequiredFieldValidator>
            </div>
            <div class="form-group">
                <asp:Label ID="Label5" runat="server" Text="Nascimento" AssociatedControlID="nascimentoTextBox"></asp:Label>
                <asp:TextBox ID="nascimentoTextBox" runat="server" class="form-control" placeholder="Nascimento"></asp:TextBox>
                <asp:RequiredFieldValidator ID="nascimentoRequiredFieldValidator" runat="server" ErrorMessage="O campo Nascimento é obrigatório."
                    ControlToValidate="nascimentoTextBox" Display="Dynamic" CssClass="validator"></asp:RequiredFieldValidator>
                <asp:CompareValidator ID="nascimentoCompareValidator" runat="server" ErrorMessage="O campo Nascimento aceita apenas datas válidas."
                    Type="Date" Operator="DataTypeCheck" ControlToValidate="nascimentoTextBox" Display="Dynamic" CssClass="validator"></asp:CompareValidator>
            </div>
            <div class="form-group">
                <asp:Label ID="Label2" runat="server" Text="Email" AssociatedControlID="emailTextBox"></asp:Label>
                <asp:TextBox ID="emailTextBox" runat="server" class="form-control" placeholder="Email"></asp:TextBox>
                <asp:RequiredFieldValidator ID="emailRequiredFieldValidator" runat="server" ErrorMessage="O campo Email é obrigatório."
                    ControlToValidate="emailTextBox" Display="Dynamic" CssClass="validator"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="emailRegularExpressionValidator" runat="server" ErrorMessage="Email com formato inválido." CssClass="validator" ControlToValidate="emailTextBox" Display="Dynamic" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            </div>
            <div class="form-group">
                <asp:Label ID="Label4" runat="server" Text="Estado" AssociatedControlID="estadoDropDownList"></asp:Label>
                <asp:DropDownList ID="estadoDropDownList" CssClass="form-control" runat="server" Width="300px">
                    <asp:ListItem Value="">Estados</asp:ListItem>
                    <asp:ListItem>SP</asp:ListItem>
                    <asp:ListItem>RJ</asp:ListItem>
                    <asp:ListItem>SC</asp:ListItem>
                    <asp:ListItem>RN</asp:ListItem>
                </asp:DropDownList>
                <%--        <asp:RequiredFieldValidator ID="estadoRequiredFieldValidator" runat="server" ErrorMessage="O campo Estado é obrigatório."
            ControlToValidate="estadoDropDownList" Display="Dynamic" ForeColor="#CC3300"></asp:RequiredFieldValidator>--%>
            </div>
            <div class="form-group">
                <asp:Label ID="Label7" runat="server" Text="Pretensão" AssociatedControlID="pretensaoTextBox"></asp:Label>
                <asp:TextBox ID="pretensaoTextBox" runat="server" class="form-control" placeholder="Pretensão"></asp:TextBox>
            </div>
            <hr />
            <asp:Button ID="gravarButton" runat="server" Text="Gravar" CssClass="btn btn-default" OnClick="gravarButton_Click" />

        </asp:View>
        <asp:View ID="mensagemView" runat="server">
            <h2>
                <asp:Label ID="mensagemLabel" runat="server" Text=""></asp:Label></h2>
            <hr />
            <asp:Button ID="novoCadastroButton" runat="server" Text="Novo cadastro" OnClick="novoCadastroButton_Click" />
        </asp:View>
    </asp:MultiView>

</asp:Content>
