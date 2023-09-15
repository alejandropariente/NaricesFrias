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
    </head>
    <body>
        <div class="container-fluid">
        <div class="row">
            <div class="col-xl-12">
                <h1>NARICES FRIAS</h1>
            </div>
            <div class="col-xl-12">
                <div>
                    <div class="container">
                        <form>
                            <div class="form-group">
                                <img src="" class="UserIcon" alt="">
                                <label for=""></label>
                                <asp:TextBox ID="txtUsername" CssClass="form-control form-control-lg"
                                    placeholder="Ingresar usuario" runat="server"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <img src="" class="PasswordIcon" alt="">
                                <label for=""></label>
                                <asp:TextBox ID="txtPassword" CssClass="form-control form-control-lg"
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

