<%@ Page Title="" Language="C#" MasterPageFile="~/WebPizza.Master" AutoEventWireup="true" CodeBehind="Clientes.aspx.cs" Inherits="Pizza.Clientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h4><asp:Label ID="LabelClientes" runat="server" Text="Clientes"></asp:Label></h4> <br /><br />
    <asp:GridView ID="GridView1" runat="server"></asp:GridView><br />
    <asp:Button ID="Button1" runat="server" Text="Ingresar cliente" OnClick="Button1_Click" />
</asp:Content>
