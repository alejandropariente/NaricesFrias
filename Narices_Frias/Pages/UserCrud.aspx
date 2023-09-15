<%@ Page Title="" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="UserCrud.aspx.cs" Inherits="Narices_Frias.Pages.UserCrud" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<link rel="stylesheet" href="/Stylesheets/StylesCrud.css">

    <div class="container-fluid CrudSection">
        <div class="row" style="margin:0;">
            <div class="crudSearcher">
                <h1>Gestion de Usuarios</h1>
            </div>
        </div>
        <div class="row" style="margin:0;">
            <div class="col-xl-12">
                
                <form>
                            <div class="form-group">
                                <label for=""></label>
                                <asp:TextBox ID="txtName" CssClass="crudInputs form-control form-control-lg "
                                    placeholder="Ingresar Nombre" runat="server"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label for=""></label>
                                <asp:TextBox ID="txtfirstName" CssClass="crudInputs form-control form-control-lg"
                                    placeholder="Ingresar Primer Apellido" runat="server"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label for=""></label>
                                <asp:TextBox ID="txtMiddleName" CssClass="crudInputs form-control form-control-lg"
                                    placeholder="Ingresar Segundo Apellido" runat="server"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label for=""></label>
                                <asp:TextBox ID="txtBornDate" runat="server" CssClass="crudInputs form-control" TextMode="Date" ></asp:TextBox>

                            </div>
                            <div class="form-group">
                                <label for=""></label>
                                <asp:TextBox ID="txtEmail" CssClass="crudInputs form-control form-control-lg"
                                    placeholder="Ingresar Correo" runat="server"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label for=""></label>
                                <asp:TextBox ID="txtPassword" CssClass="crudInputs form-control form-control-lg"
                                    placeholder="Ingresar Contrasena" runat="server"></asp:TextBox>
                            </div>
                            
                            <div class="form-group row">
                                <div class="btnRegister offset-sm-2 col-xl-12">
                                    <button type="submit" class="btn btn-primary">Registrar</button>
                                </div>
                            </div>
                        </form>
            </div>
        </div>
        <div class="row" style="margin:0;">
            <div class="col-xl-12">
                <div class="crudMenu">
                    <nav>
                        <ul>
                            <li><a href="#">
                                <asp:Image runat="server" src="../Images/iconInsert.png"
                                 alt="Sample image"/>
                            </a></li>
                            <li><a href="#">
                                <asp:Image runat="server" src="../Images/iconUpdate.png"
                                 alt="Sample image"/>
                            </a></li>
                            <li><a href="#">
                                <asp:Image runat="server" src="../Images/iconDelete.png"
                                 alt="Sample image"/>
                            </a></li>
                        </ul>
                    </nav>
                </div>
            </div>
        </div>
    </div>



</asp:Content>
