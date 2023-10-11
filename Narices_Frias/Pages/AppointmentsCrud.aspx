<%@ Page Title="" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="AppointmentsCrud.aspx.cs" Inherits="Narices_Frias.Pages.AppointmentsCrud" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" href="/Stylesheets/StylesCrud.css">
    <div class="container-fluid CrudSection">
        <div class="row">
            <div class="crudSearcher">
                <h1>Gestion de Citas</h1>
            </div>
        </div>
        <div class="row">
            <div class="col-xl-12">
                
                <form>
                            <div class="form-group">
                                <label for="">Tipo:</label>
                                <asp:DropDownList ID="cbxTipo" runat="server" CssClass="form-control form-control-lg" AutoPostBack="True">

                                    <asp:ListItem Selected="True" Value="Adopcion"> Cita Adopcion </asp:ListItem>
                                    <asp:ListItem Value="Veterinaria"> Cita Veterinaria </asp:ListItem>


                                </asp:DropDownList>
                            </div>
                            <div class="form-group">
                                <label for="">Descripcion:</label>
                                <asp:TextBox ID="txtDescripcion" CssClass="form-control form-control-lg"
                                    placeholder="Ingresar Descripcion" runat="server"></asp:TextBox>
                            </div>
                           
                            
                            <div class="form-group">
                                <label for="">Fecha:</label>
                                <asp:TextBox ID="txtFecha" runat="server" CssClass="form-control" TextMode="Date"></asp:TextBox>
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
