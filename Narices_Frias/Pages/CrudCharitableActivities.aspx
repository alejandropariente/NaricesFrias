<%@ Page Title="" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="CrudCharitableActivities.aspx.cs" Inherits="Narices_Frias.Pages.CrudCharitableActivities" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <link rel="stylesheet" href="/Stylesheets/StylesCrud.css">
    <div class="container-fluid CrudSection">
        
        <div class="row">
            <div class="alert alert-success alert-dismissible" id="midiv" runat="server">
                   <asp:Button Text="x" ID="btnClose" runat="server" type="button" class="close" data-dismiss="alert" aria-hidden="true" OnClick="btnClose_Click"/>
                    <h5><i class="icon fas fa-check"></i> Alerta!</h5>
                    Registro insertado con exito!!..
                </div>
            <div class="crudSearcher">
                <h1>Gestion de Actividades Beneficas</h1>
            </div>
        </div>
        <div class="row">
            <div class="col-xl-12">
                
                
                            
                            <div class="form-group row">
                                <div class="btnRegister offset-sm-2 col-xl-12">
                                    <div id="scrollableDiv" style="overflow: auto; height: 600px;">
                                    <asp:GridView ID="dgvSalida" runat="server" AutoGenerateColumns="false" CssClass="table table-bordered table-striped dataTable dtr-inline">
                                    <Columns>
                                    <asp:BoundField DataField="id" HeaderText="ID" />
                                    <asp:BoundField DataField="name" HeaderText="Nombres" />
                                    <asp:BoundField DataField="description" HeaderText="Descripcion" />
                                    <asp:TemplateField HeaderText="Fecha">
                                        <ItemTemplate>
                                            <asp:Label ID="lblDate" runat="server" Text='<%# Eval("date", "{0:yyyy-MM-dd}") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:BoundField DataField="moneyRaising" HeaderText="Total Recaudado" />
                                    <asp:TemplateField HeaderText="Acciones">
                                    <ItemTemplate>
                                            <a href='CrudCharitableActivitiesUpdate.aspx?id=<%# Eval("ID") %>'>Modificar</a>
                                            
                                            
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    </Columns>
                                    </asp:GridView>
                                    </div>



                                    <a class="btnCrudRegister" href="ContentGestorCharitable.aspx">
                                        Registrar
                                    </a>
                                      

                                </div>
                            </div>
                        
            </div>
        </div>
        
    



</asp:Content>
