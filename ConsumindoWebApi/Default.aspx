<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ConsumindoWebApi._Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1>Consumindo Wep Api<%: Title %></h1>
            </hgroup>
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h3>Usuario:</h3>
    <br />

    <asp:GridView ID="GridView1" runat="server" DataKeyNames="Id" OnRowCommand="GridView1_RowCommand" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="Id" />
            <asp:BoundField DataField="Nome" HeaderText="Nome" />
            <asp:ButtonField ButtonType="Link" CommandName="Excluir" Text="Excluir" HeaderText="Excluir" />
            <asp:ButtonField ButtonType="Link" CommandName="Atualizar" Text="Atualizar" HeaderText="Atualizar" />
        </Columns>
    </asp:GridView>
</asp:Content>
