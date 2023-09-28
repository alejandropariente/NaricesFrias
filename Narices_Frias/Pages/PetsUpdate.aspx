<%@ Page Title="" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="PetsUpdate.aspx.cs" Inherits="Narices_Frias.Pages.PetsUpdate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <link rel="stylesheet" href="/Stylesheets/StylesCrud.css">
    <div class="container-fluid CrudSection">
        <div class="row">
            <div class="crudSearcher">
                <h1>Gestion de Mascotas</h1>
            </div>
        </div>
         <div class="container-fluid" style="padding:0;">
       <div class="alert alert-success alert-dismissible" id="Div1" runat="server">

<asp:Button Text="x" ID="Button1" runat="server" type="button" class="close" data-dismiss="alert" aria-hidden="true" Onclick ="Button1_Click"/>
<h5><i class="icon fas fa-check"></i> Alerta!</h5>
                    Registro Eliminado con exito!!..
</div>
<div class="alert alert-success alert-dismissible" id="midiv" runat="server">
<asp:Button Text="x" ID="btnClose" runat="server" type="button" class="close" data-dismiss="alert" aria-hidden="true" OnClick="btnClose_Click"/>
<h5><i class="icon fas fa-check"></i> Alerta!</h5>
                    Registro modificado con exito!!..

            <div class="crudSearcher">
                <h1>Gestion de Usuarios</h1>
            </div>
        </div>
        <div class="row">
            <div class="col-xl-12">
                
                <form>
                            <div class="form-group">
                                <label for="">Nombre:</label>
                                <asp:TextBox ID="txtName" CssClass="form-control form-control-lg"
                                    placeholder="Ingresar Nombre" runat="server"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label for="">Edad:</label>
                                <asp:TextBox ID="txtEdad" CssClass="form-control form-control-lg"
                                    placeholder="Ingresar Edad" runat="server"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label for="">Raza:</label>
                                <asp:TextBox ID="txtRaza" CssClass="form-control form-control-lg"
                                    placeholder="Ingresar Raza" runat="server"></asp:TextBox>
                            </div>
                           
                            <div class="form-group">
                                <label for="">Categoria:</label>
                                <asp:DropDownList ID="cbxCategory" runat="server" CssClass="form-control form-control-lg" AutoPostBack="True">

                                    <asp:ListItem Selected="True" Value="1"> Perro </asp:ListItem>
                                    <asp:ListItem Value="2"> Gato </asp:ListItem>


                                </asp:DropDownList>
                                <asp:CheckBox  ID="ckVeterinario" runat="server" Text="Veterinario" />                               
                            </div>
                            <div class="form-group row">
                                <div class="btnRegister offset-sm-2 col-xl-12">
                                    <asp:GridView ID="dgvSalida" runat="server" AutoGenerateColumns="false" CssClass="table table-bordered table-striped dataTable dtr-inline">
                                    <Columns>
                                    <asp:BoundField DataField="id" HeaderText="ID" />
                                    <asp:BoundField DataField="name" HeaderText="Nombres" />
                                         <asp:BoundField DataField="animalBreed" HeaderText="Raza" />
                                    <asp:BoundField DataField="age" HeaderText="Edad" />
                                   
                                    <asp:BoundField DataField="animalCategoryId" HeaderText="Categoria" />
                                    <asp:TemplateField HeaderText="Acciones">
                                    <ItemTemplate>
                                   

                                    </ItemTemplate>
                                    </asp:TemplateField>
                                    </Columns>
                                    </asp:GridView>





                                    

                                </div>
                            </div>
                        </form>
            </div>
        </div>
               <div class="row">
            <div class="col-xl-12">
                <div>
                   <a href='UserCrud.aspx'>Volver</a>
<asp:Button ID="btnActualizar" runat="server" Text="Actualizar" OnClick ="btnActualizar_Click"/>
<asp:Button ID="btnDelete" runat ="server" Text="Eliminar" OnClientClick="return confirm('¿Estás seguro de que deseas eliminar este registro?');" OnClick="btnDelete_Click" />
                </div>
            </div>
        </div>
</asp:Content>
