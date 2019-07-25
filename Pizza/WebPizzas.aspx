<%@ Page Title="" Language="C#" MasterPageFile="~/WebPizza.Master" AutoEventWireup="true" CodeBehind="WebPizzas.aspx.cs" Inherits="Pizza.WebPizzas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server"><br />
    <h4><asp:Label ID="Label4" runat="server" Text="Lista de Pizzas"></asp:Label></h4><br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CssClass="table table-bordered col-md-5">
        <Columns>
            <asp:BoundField DataField="Titulo" HeaderText="Título" />
            <asp:BoundField DataField="Precio" HeaderText="Précio" />
            <asp:TemplateField HeaderText="Imagen" ControlStyle-Width="35px" ControlStyle-Height="35px" >
                <ItemTemplate>
                    <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("Imagen") %>' />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <br />
    <asp:Button ID="Button1" runat="server" Text="Adregar Pizza" OnClick="Button1_Click" />

</asp:Content>
