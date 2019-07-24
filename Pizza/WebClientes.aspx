<%@ Page Title="" Language="C#" MasterPageFile="~/WebPizza.Master" AutoEventWireup="true" CodeBehind="WebClientes.aspx.cs" Inherits="Pizza.WebClientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server"><br />
    <h4><asp:Label ID="LabelClientes" runat="server" Text="Clientes"></asp:Label></h4> <br />
    <asp:GridView ID="GridView1" runat="server" CssClass="table table-bordered col-md-5" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="RutCliente" HeaderText="Rut Cliente" />
            <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
            <asp:BoundField DataField="Telefono" HeaderText="Teléfono" />
            <asp:BoundField DataField="Direccion" HeaderText="Dirección" />
        </Columns>
    </asp:GridView><br />
    <asp:Button ID="Button1" runat="server" Text="Ingresar cliente" OnClick="Button1_Click" />
</asp:Content>
