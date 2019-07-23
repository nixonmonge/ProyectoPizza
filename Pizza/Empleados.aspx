<%@ Page Title="" Language="C#" MasterPageFile="~/WebPizza.Master" AutoEventWireup="true" CodeBehind="Empleados.aspx.cs" Inherits="Pizza.Empleados" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h4><asp:Label ID="LabelEmpleados" runat="server" Text="Empleados"></asp:Label></h4> <br /><br />
    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
</asp:Content>
