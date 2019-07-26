<%@ Page Title="" Language="C#" MasterPageFile="~/WebPizza.Master" AutoEventWireup="true" CodeBehind="WebOrdenesIngresadas.aspx.cs" Inherits="Pizza.WebOrdenesIngresadas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <h4><asp:Label ID="LabelOrdenesIngresadas" runat="server" Text="Ordenes Ingresadas"></asp:Label></h4> <br />
    <asp:gridview ID="GridViewOrdenes" runat="server" CssClass="table table-bordered col-md-9" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="Cantidad" HeaderText="Cantidad" />
            <asp:BoundField DataField="Pizzas.Titulo" HeaderText="Pizzas" />
            <asp:BoundField DataField="Fecha" HeaderText="Fecha" />
            <asp:BoundField DataField="Clientes.Nombre" HeaderText="Clientes" />
            <asp:BoundField DataField="Clientes.Telefono" HeaderText="Teléfono" />
            <asp:BoundField DataField="Clientes.Direccion" HeaderText="Dirección" />
            <asp:BoundField DataField="Empleados.NombreCompleto" HeaderText="Vendedor" />
        </Columns>
    </asp:gridview>
</asp:Content>
