<%@ Page Title="" EnableEventValidation="false" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="AnimalView.aspx.cs" Inherits="Narices_Frias.Pages.CrudAnimals.AnimalView" %>
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

    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
<link href="https://fonts.googleapis.com/css2?family=Inter&family=Play:wght@400;700&display=swap" rel="stylesheet">
<link rel="stylesheet" href="/Stylesheets/AnimalView.css">
    <div class="AnimalViewSection">
        <div id="scrollableDiv" style="overflow: auto; height: auto;">
        <asp:GridView runat="server" CssClass="table" ID="dgvAnimals" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField DataField="id" HeaderText="ID" />
                <asp:BoundField DataField="name" HeaderText="Nombre" />
                <asp:TemplateField HeaderText="Categoria">
                    <ItemTemplate>
                        <asp:Label runat="server"><%# int.Parse(Eval("animalCategoryId").ToString()) == 1 ? "Perro":"Gato" %></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="animalBreed" HeaderText="Raza" />
                <asp:TemplateField HeaderText="Estado">
                    <ItemTemplate>
                        <asp:Label runat="server"><%# int.Parse(Eval("isAdoptedOrSponsored").ToString()) == 0 ? "Sin adoptar":
                                                          int.Parse(Eval("isAdoptedOrSponsored").ToString()) == 1 ? "Adoptado":"Apadrinado"%></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Padrino">
                    <ItemTemplate>
                        <asp:Label runat="server"><%# int.Parse(Eval("systemUserId").ToString()) == 0 ? "------" : ReturnSponsor(int.Parse(Eval("systemUserId").ToString())) %></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Acciones">
                    <ItemTemplate>
                        <a class="btn btn-primary" href='AnimalUpdate.aspx?id=<%# Eval("ID") %>'>Modificar</a>

                        <asp:Button runat="server" CssClass="btn btn-danger" Text="Eliminar" OnClick="Delete_Click"  CommandArgument='<%# Eval("ID") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        </div>
        <a class="btn btn-dark" href="AnimalForm.aspx">Registrar animal</a>
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
