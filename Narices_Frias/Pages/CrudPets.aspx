<%@ Page Title="" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="CrudPets.aspx.cs" Inherits="Narices_Frias.Pages.CrudPets" %>
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

                                    <asp:ListItem Selected="True" Value="Perro"> Perro </asp:ListItem>
                                    <asp:ListItem Value="Gato"> Gato </asp:ListItem>


                                </asp:DropDownList>
                                <asp:CheckBox  ID="ckVeterinario" runat="server" Text="Veterinario" />                               
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
                                    <asp:TemplateField HeaderText="Acciones">
                                    <ItemTemplate>
                                   

                                    </ItemTemplate>
                                    </asp:TemplateField>
                                    </Columns>
                                    </asp:GridView>





                                    <asp:Button runat="server" ID="btnRegistrar" ForeColor="White"  Text="Registrar" CssClass="btnCrudRegister" />  

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
    </div>



</asp:Content>
