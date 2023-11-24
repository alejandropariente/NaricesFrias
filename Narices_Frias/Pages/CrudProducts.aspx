<%@ Page Title="" Language="C#" EnableEventValidation="false" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="CrudProducts.aspx.cs" Inherits="Narices_Frias.Pages.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script>
        function Show() {
            var ventanaEmergente = document.getElementById('modalDeleteRecord');
            ventanaEmergente.style.display = 'block';
            document.getElementById('btnConfirmDelete').addEventListener('click', function () {
                ventanaEmergente.style.display = 'none';
                return true;  // Resuelve la promesa con un valor "true" cuando se confirma
            });

            // Configura un manejador para el botón "Cancelar" en la ventana modal
            document.getElementById('btnCancelDelete').addEventListener('click', function () {
                ventanaEmergente.style.display = 'none';
                return false; 
            }

    </script>
    <style>
        /* Styles for the popup window */
        .modal {
            display: none; /* Initially hidden */
            position: fixed;
            top: 0;
            left: 0;
            width: 100%;
            height: 100%;
            background-color: rgba(0, 0, 0, 0.5); /* Semi-transparent background */
        }

        .modal-content {
            position: absolute;
            top: 50%;
            left: 50%;
            transform: translate(-50%, -50%);
            background-color: #fff;
            padding: 20px;
            border: 1px solid #ccc;
            border-radius: 5px;
            text-align: center;
        }

        /* Styles for the buttons */
        .modal-button {
            margin: 0 10px;
            padding: 10px 20px;
            cursor: pointer;
        }

        .modal-button.confirm {
            background-color: #4CAF50;
            color: white;
        }

        .modal-button.cancel {
            background-color: #f44336;
            color: white;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" href="/Stylesheets/CrudProducts.css">
    <div class="CrudSection">

        
        <div id="scrollableDiv" style="overflow: auto; height: auto;">
        <asp:GridView runat="server" ID="dgvProdcuts" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField DataField="id" HeaderText="ID" />
                <asp:BoundField DataField="name" HeaderText="Nombre" />
                <asp:BoundField DataField="description" HeaderText="Descripcion" />
                <asp:BoundField DataField="unitPrice" HeaderText="Precio" />
                <asp:BoundField DataField="stock" HeaderText="Cantidad" />
                <asp:TemplateField HeaderText="Acciones">
                    <ItemTemplate>
                        <a class="btn btn-primary" href='CrudProductsUpdate.aspx?id=<%# Eval("ID") %>'>Modificar</a>

                        <asp:Button runat="server" CssClass="btn btn-danger" Text="Eliminar" OnClick="Unnamed_Click" CommandArgument='<%# Eval("ID") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        </div>
        <a class="btnRegistrar btn btn-dark" href="CrudProdcutsInsert.aspx">Registrar Producto</a>
        <div id="modalDeleteRecord" class="modal">
            <div class="modal-content">
                <h3>Seguro de eliminar el Registro?</h3>
                <p>Are you sure you want to delete this record?</p>
                <button  id="btnConfirmDelete" class="modal-button confirm">Yes</button>
                <button  id="btnCancelDelete" class="modal-button cancel">No</button>
            </div>
        </div>
    </div>
</asp:Content>
