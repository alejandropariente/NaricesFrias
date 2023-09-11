<%@ Page Title="" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="MedicCrud.aspx.cs" Inherits="Narices_Frias.Pages.MedicCrud" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">
        <div class="row">
            <div class="crudSearcher">
                <h1>Gestion de Medicos</h1>
            </div>
        </div>
        <div class="row">
            <div class="col-xl-12">
                
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
                                <asp:TextBox ID="txtCi" CssClass="form-control form-control-lg"
                                    placeholder="Ingresar CI" runat="server"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label for=""></label>
                                <asp:TextBox ID="txtPhone" CssClass="form-control form-control-lg"
                                    placeholder="Ingresar Celular" runat="server"></asp:TextBox>
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
                                <div class="offset-sm-2 col-xl-12">
                                    <button type="submit" class="btn btn-primary">Registrar</button>
                                </div>
                            </div>
                        </form>
            </div>
        </div>
        <div class="row">
            <div class="col-xl-12">
                <div>
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
