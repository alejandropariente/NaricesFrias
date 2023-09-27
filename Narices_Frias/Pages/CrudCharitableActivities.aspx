﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="CrudCharitableActivities.aspx.cs" Inherits="Narices_Frias.Pages.CrudCharitableActivities" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <link rel="stylesheet" href="/Stylesheets/StylesCrud.css">
    <div class="container-fluid CrudSection">
        <div class="alert alert-success alert-dismissible" id="midiv" runat="server">
                   <asp:Button Text="x" ID="btnClose" runat="server" type="button" class="close" data-dismiss="alert" aria-hidden="true" OnClick="btnClose_Click"/>
                    <h5><i class="icon fas fa-check"></i> Alerta!</h5>
                    Registro insertado con exito!!..
                </div>
        <div class="row">
            <div class="crudSearcher">
                <h1>Gestion de Actividades Beneficas</h1>
            </div>
        </div>
        <div class="row">
            <div class="col-xl-12">
                
                <form>
                            <div class="form-group">
                                <label for="">Nombre:</label>
                                <asp:TextBox ID="txtName" CssClass="form-control form-control-lg"
                                    placeholder="Ingresar Nombre" runat="server"></asp:TextBox>
                                <asp:Label runat="server" ID="lblName" CssClass="error">
                                    
                                </asp:Label>
                            </div>
                            <div class="form-group">
                                <label for="">Descripcion:</label>
                                <asp:TextBox ID="txtDescripcion" CssClass="form-control form-control-lg"
                                    placeholder="Ingresar Descripcion" runat="server"></asp:TextBox>
                                <asp:Label runat="server" ID="lblDescrip" CssClass="error">
                                    
                                </asp:Label>
                            </div>
                            <div class="form-group">
                                <label for="">Fecha:</label>
                                <asp:TextBox ID="txtFecha" runat="server" CssClass="form-control" TextMode="Date"></asp:TextBox>
                                <asp:Label runat="server" ID="lblfecha" CssClass="error">
                                    
                                </asp:Label>
                            </div>
                           
                            <div class="form-group">
                                <label for="">Total Recaudado:</label>
                                 <asp:TextBox ID="txtTotalRecaudado" CssClass="form-control form-control-lg"
                                    placeholder="Ingresar TotalRecaudado" runat="server"></asp:TextBox>
                                <asp:Label runat="server" ID="lblRecaudacion" CssClass="error">
                                    
                                </asp:Label>
                                                             
                            </div>
                            <div class="form-group row">
                                <div class="btnRegister offset-sm-2 col-xl-12">
                                    <asp:GridView ID="dgvSalida" runat="server" AutoGenerateColumns="false" CssClass="table table-bordered table-striped dataTable dtr-inline">
                                    <Columns>
                                    <asp:BoundField DataField="id" HeaderText="ID" />
                                    <asp:BoundField DataField="name" HeaderText="Nombres" />
                                    <asp:BoundField DataField="descripcion" HeaderText="Descripcion" />
                                    <asp:BoundField DataField="Fecha" HeaderText="Fecha" />
                                    <asp:BoundField DataField="recaudado" HeaderText="Total Recaudado" />
                                    <asp:TemplateField HeaderText="Acciones">
                                    <ItemTemplate>
                                            <a href='CrudCharitableActivitiesUpdate.aspx?id=<%# Eval("ID") %>'>Modificar</a>
                                            
                                            
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    </Columns>
                                    </asp:GridView>





                                    <asp:Button runat="server" ID="btnRegistrar" ForeColor="White"  Text="Registrar" CssClass="btnCrudRegister" OnClick="btnRegistrar_Click" />  

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
