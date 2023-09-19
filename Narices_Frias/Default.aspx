<%@ Page Title="" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Narices_Frias.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
    

</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!DOCTYPE html>
    <html lang="en">
    <head>
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <title>Document</title>
        <link rel="stylesheet" href="/Stylesheets/LogIn.css">

    </head>
    <body>
        <div class="container-fluid LogIn">
        <div class="row" style="margin:0;">
            <div class="col-xl-12">
                <h1>NARICES FRIAS</h1>
            </div>
            <div class="col-xl-12 formSection">
                <div>
                    <div class="formContainer">
                        <form>
                            <div class="form-group inputContainer">
                                <img src="/Images/UserIconBlack.png" class="UserIcon Icons" alt="">
                                <asp:TextBox ID="txtUsername" CssClass="logInInputs form-control form-control-lg "
                                    placeholder="Ingresar usuario" runat="server"></asp:TextBox>
                            </div>
                            <div class="form-group inputContainer">
                                <img src="/Images/iconPasswordBlack.png" class="PasswordIcon Icons" alt="">
                                <asp:TextBox ID="txtPassword" CssClass="logInInputs form-control form-control-lg "
                                    placeholder="Ingresar Contrasena" runat="server"></asp:TextBox>
                            </div>
                            
                            <div class="form-group row">
                                <div class="offset-sm-2 col-xl-12">
                                      <asp:Button Text="Ingresar" ID="btnIngresar" runat="server" CssClass="boton" OnClick="btnIngresar_Click" />
                                </div>
                                <div id="myAlert" runat="server" class="alert alert-danger alert-dismissible" style="display: none;">
                                        Los campos de usuario y contraseña son obligatorios.
                                </div>
                            </div>
                        </form>
                        <h4><a href=""> Olvidaste tu cotrasena? </a></h4>
                    </div
                    
                </div>
            </div>
        </div>
        <div class="imgLogin">
            <img src="" alt="">

        </div>
    </div>
    </body>
    </html> 
</asp:Content>

