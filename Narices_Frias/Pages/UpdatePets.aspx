<%@ Page Title="" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="UpdatePets.aspx.cs" Inherits="Narices_Frias.Pages.UpdatePets" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server"> <link rel="stylesheet" href="/Stylesheets/StylesCrud.css">
    <div class="container-fluid CrudSection">
          <div class="alert alert-success alert-dismissible" id="midiv" runat="server">
                   <asp:Button Text="x" ID="btnClose" runat="server" type="button" class="close" data-dismiss="alert" aria-hidden="true" OnClick="btnClose_Click"/>
                    <h5><i class="icon fas fa-check"></i> Alerta!</h5>
                    Registro insertado con exito!!..
                </div>
        <div class="alert alert-success alert-dismissible" id="Div1" runat="server">
                   <asp:Button Text="x" ID="Button1" runat="server" type="button" class="close" data-dismiss="alert" aria-hidden="true" OnClick="Button1_Click"/>
                    <h5><i class="icon fas fa-check"></i> Alerta!</h5>
                    Registro Eliminado con exito!!..
                </div>
            <div class="crudProduct">
                <h1>Gestion de Animales</h1>
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
                                   


                                </asp:DropDownList>
                                <asp:CheckBox  ID="ckVeterinario" runat="server" Text="Veterinario" />                               
                            </div>
                    <div class="form-group">
                                <label for=""></label>
                                <asp:FileUpload ID="fileUploadControl" runat="server" AllowMultiple="true" placeholder="Seleccione una imagen" />
                                <asp:Image ID="imgImage" runat="server" />


                               




                            </div>
                            <div class="form-group row">
                                <div class="btnRegister offset-sm-2 col-xl-12">
                                    <asp:GridView ID="dgvSalida" runat="server" AutoGenerateColumns="false" CssClass="table table-bordered table-striped dataTable dtr-inline">
                                    <Columns>
                                    <asp:BoundField DataField="id" HeaderText="ID" />
                                    <asp:BoundField DataField="name" HeaderText="Nombres" />
                                    <asp:BoundField DataField="edad" HeaderText="Edad" />
                                    <asp:BoundField DataField="raza" HeaderText="Raza" />
                                    <asp:BoundField DataField="category" HeaderText="Categoria" />
                                          <asp:BoundField DataField="photo" HeaderText="Foto" />
                                                                      <asp:TemplateField HeaderText="Acciones">
                                    <ItemTemplate>
                                            <a href='CrudPets.aspx?id=<%# Eval("ID") %>'>Modificar</a>
                                            
                                            
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    </Columns>
                                    </asp:GridView>





                                  <asp:Button ID="btnDelete" runat="server" Text="Eliminar" OnClick="btnDelete_Click"/>
                                    <a href='CrudPets.aspx'>Volver</a>
                                    <asp:Button runat="server" ID="btnRegistrar" ForeColor="White"  Text="Actualizar" CssClass="btnCrudRegister" OnClientClick ="return validateForm();" OnClick="btnRegistrar_Click" />  
                                </div>
                            </div>
                        </form>
            </div>
        </div>
        <div class="row">
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
    



</asp:Content>
