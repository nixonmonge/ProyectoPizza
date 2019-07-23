<%@ Page Title="" Language="C#" MasterPageFile="~/WebPizza.Master" AutoEventWireup="true" CodeBehind="IngresoCliente.aspx.cs" Inherits="Pizza.IngresoCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h4><asp:Label ID="LabelIngresoCliente" runat="server" Text="Ingreso clientes"></asp:Label></h4> <br /><br />



     <h5><asp:Label ID="Label2" runat="server" Text="Rut :"></asp:Label>
     <asp:TextBox ID="TextBoxRutCliente" runat="server"></asp:TextBox></h5>  <br />
     <h5><asp:Label ID="Label3" runat="server" Text="Nombre :"></asp:Label>
     <asp:TextBox ID="TextBoxNombreCliente" runat="server"></asp:TextBox></h5>  <br />
     <h5><asp:Label ID="Label4" runat="server" Text="Dirección :"></asp:Label>
    <asp:TextBox ID="TextBoxDireccionCliente" runat="server"></asp:TextBox></h5>  <br />
         <h5><asp:Label ID="Label1" runat="server" Text="Teléfono :"></asp:Label>
    <asp:TextBox ID="TextBoxTelefonoCliente" runat="server"></asp:TextBox></h5>  <br />
    <h5><asp:Button ID="Button1" runat="server" Text="Ingresar cliente" /></h5><br />
    <h4><asp:Panel ID="Panel1" runat="server">Error</asp:Panel></h4>
    <p></p>

</asp:Content>
