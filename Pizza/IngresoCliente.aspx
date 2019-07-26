<%@ Page Title="" Language="C#" MasterPageFile="~/WebPizza.Master" AutoEventWireup="true" CodeBehind="IngresoCliente.aspx.cs" Inherits="Pizza.IngresoCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h4><asp:Label ID="LabelIngresoCliente" runat="server" Text="Ingreso clientes"></asp:Label></h4> <br /><br />



     <h5><asp:Label ID="Label2" runat="server" Text="Rut :"></asp:Label><br />
     <asp:TextBox ID="TextBoxRutCliente" runat="server" CssClass="col-md-3"></asp:TextBox></h5>  <br />
     <h5><asp:Label ID="Label3" runat="server" Text="Nombre :" ></asp:Label><br />
     <asp:TextBox ID="TextBoxNombreCliente" runat="server" CssClass="col-md-3"></asp:TextBox></h5>  <br />
             <h5><asp:Label ID="Label1" runat="server" Text="Teléfono :"></asp:Label><br />
    <asp:TextBox ID="TextBoxTelefonoCliente" runat="server" CssClass="col-md-3"></asp:TextBox></h5>  <br />
     <h5><asp:Label ID="Label4" runat="server" Text="Dirección :"></asp:Label><br />
    <asp:TextBox ID="TextBoxDireccionCliente" runat="server" CssClass="col-md-3"></asp:TextBox></h5>  <br />

    <h5><asp:Button ID="Button1" runat="server" Text="Ingresar cliente" OnClick="Button1_Click" /></h5><br /><br />
    <h4><asp:Panel ID="Panel1" runat="server" Visible="False">Error</asp:Panel></h4>
    <p></p>

</asp:Content>
