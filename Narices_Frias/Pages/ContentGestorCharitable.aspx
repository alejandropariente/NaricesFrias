﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="ContentGestorCharitable.aspx.cs" Inherits="Narices_Frias.Pages.ContentGestorCharitable" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="/Stylesheets/CrudCharitableActivities.css">
    <style>
        .image-preview {
    width: 200px;
    height: 150px;
    margin: 10px;
}
    </style>
    <script>
        function previewImages() {
            var fileInput = document.getElementById('<%= fileUploadControl.ClientID %>');
            var imagePreview = document.getElementById('imagePreview');
            imagePreview.innerHTML = ''; // Limpia cualquier imagen previamente mostrada

            if (fileInput.files.length > 0) {
                for (var i = 0; i < fileInput.files.length; i++) {
                    var file = fileInput.files[i];
                    if (file.type.startsWith('image/')) {
                        var img = document.createElement('img');
                        img.src = URL.createObjectURL(file);
                        img.className = 'image-preview'; // Ajusta el tamaño de la imagen si es necesario
                        imagePreview.appendChild(img);
                    }
                }
            }
        }


    </script>
    <script>
        function mostrarVentanaEmergente() {
            var ventanaEmergente = document.getElementById('ventanaEmergente');
            ventanaEmergente.style.display = 'block';
        }

        function cerrarVentanaEmergente() {
            var ventanaEmergente = document.getElementById('ventanaEmergente');
            ventanaEmergente.style.display = 'none';
        }
    </script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" href="/Stylesheets/CrudCharitableActivities.css">
    <div class="formSectionCharitable">
        <asp:Label runat="server" ID="lblName">Nombre :</asp:Label>
        <asp:TextBox runat="server" ID="txtName" ></asp:TextBox>
        <asp:Label runat="server" ID="lblDescription">Descripcion :</asp:Label>
        <textarea runat="server" ID="txtDescription"></textarea>
        <asp:Label runat="server" ID="lblDate">Fecha :</asp:Label>
            <asp:UpdatePanel runat="server">
        <ContentTemplate>
            <asp:Calendar runat="server" ID="txtDate" ></asp:Calendar>
        </ContentTemplate>
    </asp:UpdatePanel>
        <asp:FileUpload ID="fileUploadControl" runat="server" AllowMultiple="true" />
        <div class="buttonSection">
            <asp:Button ID="btnUpload" runat="server" Text="Subir Imágenes" OnClick="btnUpload_Click" onchange="previewImages() />

            <div id="imagePreview"></div>
            <asp:Button ID="SavePost" runat="server" Text="Subir Imágenes" OnClick="SavePost_Click" />
        </div>
        <div id="ventanaEmergente" style="display: none; position: fixed; top: 0; left: 0; width: 100%; height: 100%; background-color: rgba(0, 0, 0, 0.7); text-align: center; padding-top: 100px;">
    <div style="background-color: white; width: 300px; margin: 0 auto; padding: 20px; border-radius: 5px;">
        <h2>Error</h2>
        <p>Se ha producido un error. Por favor, inténtalo de nuevo.</p>
        <button onclick="cerrarVentanaEmergente()">Cerrar</button>
    </div>
    </div>
</asp:Content>                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      
