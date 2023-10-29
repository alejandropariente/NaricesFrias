<%@ Page Title="" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="SignIn.aspx.cs" Inherits="Narices_Frias.Pages.SignIn" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" href="/Stylesheets/StylesCrud.css">

    <div class="container-fluid CrudSection">
        <div class="row">
            <div class="col-xl-12">
                <h1>Registrarse</h1>
            </div>
            <div class="col-xl-12">
                <div>
                    <div class="container">
                        <form>
                            <div class="form-group">
                                <label for=""></label>
                                <asp:TextBox ID="txtName" CssClass="form-control form-control-lg"
                                    placeholder="Ingresar Nombre" runat="server"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label for=""></label>
                                <asp:TextBox ID="txtfirstName" CssClass="form-control form-control-lg"
                                    placeholder="Ingresar Primer Apellido" runat="server"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label for=""></label>
                                <asp:TextBox ID="txtMiddleName" CssClass="form-control form-control-lg"
                                    placeholder="Ingresar Segundo Apellido" runat="server"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label for=""></label>
                                <asp:TextBox ID="txtUsername" CssClass="form-control form-control-lg"
                                    placeholder="Ingresar Nombre de Usuario" runat="server"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label for=""></label>
                                <asp:TextBox ID="txtBornDate" runat="server" CssClass="form-control" TextMode="Date" ></asp:TextBox>

                            </div>
                            <div class="form-group">
                                <label for=""></label>
                                <asp:TextBox ID="txtEmail" CssClass="form-control form-control-lg"
                                    placeholder="Ingresar Correo" runat="server"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label for=""></label>
                                <asp:TextBox ID="txtPassword" CssClass="form-control form-control-lg"
                                    placeholder="Ingresar Contrasena" runat="server"></asp:TextBox>
                            </div>
                            
                            <div class="form-group row">

                               <div  class="btnRegister offset-sm-2 col-xl-12">>
                                      <asp:Button Text="Registrar" ID="btnRegistrar" runat="server" CssClass="boton" OnClick="btnRegistrar_Click" />

                                </div>
                            </div>
                        </form>
                    </div>


                    
                </div>
            </div>  
        </div>
        <div class="imgLogin">
            <img src="" alt="">

        </div>
    </div>
</asp:Content>
