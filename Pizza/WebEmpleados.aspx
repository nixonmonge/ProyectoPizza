<%@ Page Title="" Language="C#" MasterPageFile="~/WebPizza.Master" AutoEventWireup="true" CodeBehind="WebEmpleados.aspx.cs" Inherits="Pizza.WebEmpleados" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server"><br />
    <h4><asp:Label ID="LabelEmpleados" runat="server" Text="Empleados"></asp:Label></h4> <br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CssClass="table table-bordered col-md-3">
        <Columns>
            <asp:BoundField DataField="IdUsuario" HeaderText="ID"  />
            <asp:BoundField DataField="Usuario" HeaderText="Usuario" />
            <asp:BoundField DataField="NombreCompleto" HeaderText="Nombre Completo" />
        </Columns>
</asp:GridView>
</asp:Content>
