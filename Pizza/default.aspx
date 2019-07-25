<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Pizza._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <meta name="description" content="">
    <meta name="author" content="Mark Otto, Jacob Thornton, and Bootstrap contributors">
    <meta name="generator" content="Jekyll v3.8.5">
    <title>Login</title>

    <link rel="canonical" href="https://getbootstrap.com/docs/4.3/examples/sign-in/">

    <!-- Bootstrap core CSS -->
<link href="https://getbootstrap.com/docs/4.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
    

    <style>
      .bd-placeholder-img {
        font-size: 1.125rem;
        text-anchor: middle;
        -webkit-user-select: none;
        -moz-user-select: none;
        -ms-user-select: none;
        user-select: none;
      }

      @media (min-width: 768px) {
        .bd-placeholder-img-lg {
          font-size: 3.5rem;
        }
      }
   </style>
    <!-- Custom styles for this template -->
    <link href="https://getbootstrap.com/docs/4.3/examples/sign-in/signin.css" rel="stylesheet">
</head>
<body class="text-center">
    <form id="form1" runat="server" class="form-signin">
          <img class="mb-4" src="Images/mr-pizza.svg" alt="" width="200" height="200">
            <h1 class="h3 mb-3 font-weight-normal">Ingresar Usuario</h1>
            <label for="inputEmail" class="sr-only">Email address</label>

             <asp:TextBox ID="TxtUsuario" CssClass="form-control" placeholder="Usuario"  runat="server"></asp:TextBox>
            <label for="inputPassword" class="sr-only">Password</label>

            <asp:TextBox ID="TxtClave" runat="server" CssClass="form-control" placeholder="Clave"   MaxLength="50" TextMode="Password"></asp:TextBox>


      <asp:Button ID="ButtonLogin" runat="server" CssClass="btn btn-lg btn-primary btn-block" Text="Ingresar" OnClick="ButtonLogin_Click" />
          
            <p class="mt-5 mb-3 text-muted">&copy; 2019</p>


            <asp:Panel ID="PanelError" runat="server" BackColor="Red" Visible="False">
                <div class="alert alert-danger" role="alert">
                Usuario o Clave Incorrecta!
                </div>   
            </asp:Panel>

    
    </form>
</body>
</html>

