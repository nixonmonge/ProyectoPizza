<%@ Page Title="" Language="C#" MasterPageFile="~/WebPizza.Master" AutoEventWireup="true" CodeBehind="IngresoPizza.aspx.cs" Inherits="Pizza.IngresoPizza" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <h4><asp:Label ID="LabelIngresoPizza" runat="server" Text="Ingreso pizza"></asp:Label></h4> <br />
    <h5><asp:Label ID="Label2" runat="server" Text="Titulo :"></asp:Label><br />
    <asp:TextBox ID="TextBoxTitulo" runat="server" CssClass="col-md-3"></asp:TextBox></h5>  <br />
    <h5><asp:Label ID="Label3" runat="server" Text="Precio :" ></asp:Label><br />
    <asp:TextBox ID="TextBoxPrecio" runat="server" CssClass="col-md-3"></asp:TextBox></h5>  <br />
    <h5><asp:Label ID="Label1" runat="server" Text="Imagen :"></asp:Label><br />
    <asp:TextBox ID="TextBoxImagen" runat="server" CssClass="col-md-3"></asp:TextBox></h5>  <br />
    <h5><asp:Button ID="Button1" runat="server" Text="Ingresar Pizza" OnClick="Button1_Click"/></h5><br /><br />
    <h4><asp:Panel ID="Panel1" runat="server">Error</asp:Panel></h4>
    <p></p>
    <br />
</asp:Content>
