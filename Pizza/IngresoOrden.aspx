<%@ Page Title="" Language="C#" MasterPageFile="~/WebPizza.Master" AutoEventWireup="true" CodeBehind="IngresoOrden.aspx.cs" Inherits="Pizza.IngresoOrden" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
     <h4><asp:Label ID="Label1" runat="server" Text="Ingreso de Orden"></asp:Label></h4><br />
     <h5><asp:Label ID="Label2" runat="server" Text="Pizza :"></asp:Label><br />
     <asp:DropDownList ID="DropDownList1" runat="server" CssClass="btn btn-secondary btn-sm dropdown-toggle col-md-3"></asp:DropDownList></h5><br />
     <h5><asp:Label ID="Label3" runat="server" Text="Cliente :"></asp:Label><br />
     <asp:DropDownList ID="DropDownList2" runat="server" CssClass="btn btn-secondary btn-sm dropdown-toggle col-md-3"></asp:DropDownList></h5><br />
     <h5><asp:Label ID="Label4" runat="server" Text="Cantidad :"></asp:Label><br />
    <asp:TextBox ID="TextBoxCantidad" runat="server" CssClass="col-md-3"></asp:TextBox></h5>  <br />
    <h5><asp:Button ID="Button1" runat="server" Text="Ingresar orden" /></h5><br />
    <h4><asp:Panel ID="Panel1" runat="server">Error</asp:Panel></h4>


</asp:Content>
