<%@ Page Title="" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="CrudCharitableActivitiesUpdate.aspx.cs" Inherits="Narices_Frias.Pages.WebForm1" %>
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
        <div class="alert alert-success alert-dismissible" id="Div1" runat="server">
                   <asp:Button Text="x" ID="Button1" runat="server" type="button" class="close" data-dismiss="alert" aria-hidden="true" OnClick="Button1_Click"/>
                    <h5><i class="icon fas fa-check"></i> Alerta!</h5>
                    Registro Eliminado con exito!!..
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
                        <div class="offset-sm-2 col-xl-12">
                            <asp:Button ID="btnActualizar" runat="server" Text="Actualizar" OnClick="btnActualizar_Click1" OnClientClick="return validateForm();"/>
                            <asp:Button ID="btnDelete" runat="server" Text="Eliminar" OnClick="btnDelete_Click"/>
                            <a href='CrudCharitableactivities.aspx'>Volver</a>
                        </div>
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
    <script>
    function validateForm() {
        var isFormValid = true;

        
        var nameTextBox = document.getElementById('<%= txtName.ClientID %>');
        var nameValue = nameTextBox.value.trim();
        if (nameValue === "") {
            alert("El campo Nombre es obligatorio.");
            isFormValid = false;
            nameTextBox.focus();
        } else if (!/^[a-zA-Z\s]+$/.test(nameValue)) {
            alert("El campo Nombre no debe contener caracteres especiales ni números.");
            isFormValid = false;
            nameTextBox.value = ""; 
            nameTextBox.focus();
        }

        
        var descripcionTextBox = document.getElementById('<%= txtDescripcion.ClientID %>');
        var descripcionValue = descripcionTextBox.value.trim();
        if (descripcionValue === "") {
            alert("El campo Descripción es obligatorio.");
            isFormValid = false;
            descripcionTextBox.focus();
        } else if (!/^[a-zA-Z\s]+$/.test(descripcionValue)) {
            alert("El campo Descripción no debe contener caracteres especiales ni números.");
            isFormValid = false;
            descripcionTextBox.value = ""; 
            descripcionTextBox.focus();
        }

        
        var fechaTextBox = document.getElementById('<%= txtFecha.ClientID %>');
        var fechaValue = fechaTextBox.value.trim();
        if (fechaValue === "") {
            alert("El campo Fecha es obligatorio.");
            isFormValid = false;
            fechaTextBox.focus();
        }

        
        var totalRecaudadoTextBox = document.getElementById('<%= txtTotalRecaudado.ClientID %>');
        var totalRecaudadoValue = totalRecaudadoTextBox.value.trim();
        if (totalRecaudadoValue === "") {
            alert("El campo Total Recaudado es obligatorio.");
            isFormValid = false;
            totalRecaudadoTextBox.focus();
        } else if (!/^\d+(\.\d{1,2})?|\d+(,\d{1,2})?$/.test(totalRecaudadoValue)) {
            alert("El campo Total Recaudado debe contener solo números y puede tener hasta dos decimales (usando coma o punto como separador decimal).");
            isFormValid = false;
            totalRecaudadoTextBox.value = ""; 
            totalRecaudadoTextBox.focus();
        }


        return isFormValid;
    }
    </script>
</asp:Content>
