<%@ Page Title="" Language="C#" MasterPageFile="~/WebPizza.Master" AutoEventWireup="true" CodeBehind="WebPizzas.aspx.cs" Inherits="Pizza.WebPizzas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h4><asp:Label ID="LabelIngresoPizza" runat="server" Text="Ingreso pizza"></asp:Label></h4> <br /><br />
    <h5><asp:Label ID="Label2" runat="server" Text="Titulo :"></asp:Label><br />
    <asp:TextBox ID="TextBoxTitulo" runat="server" CssClass="col-md-3"></asp:TextBox></h5>  <br />
    <h5><asp:Label ID="Label3" runat="server" Text="Precio :" ></asp:Label><br />
    <asp:TextBox ID="TextBoxPrecio" runat="server" CssClass="col-md-3"></asp:TextBox></h5>  <br />
    <h5><asp:Label ID="Label1" runat="server" Text="Imagen :"></asp:Label><br />
    <asp:TextBox ID="TextBoxImagen" runat="server" CssClass="col-md-3"></asp:TextBox></h5>  <br />
    <h5><asp:Button ID="Button1" runat="server" Text="Ingresar Pizza"/></h5><br /><br />
    <h4><asp:Panel ID="Panel1" runat="server">Error</asp:Panel></h4>
    <p></p>
    <br /><br />
    <h4><asp:Label ID="Label4" runat="server" Text="Lista de Pizzas"></asp:Label></h4><br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CssClass="table table-bordered col-md-5">
        <Columns>
            <asp:BoundField DataField="Titulo" HeaderText="Título" />
            <asp:BoundField DataField="Precio" HeaderText="Précio" />
        </Columns>
    </asp:GridView>

</asp:Content>
