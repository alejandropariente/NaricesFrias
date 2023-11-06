<%@ Page Title="" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="AnimalForm.aspx.cs" Inherits="Narices_Frias.Pages.CrudAnimals.AnimalForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script>
        function previewImages() {
            var fileInput = document.getElementById('<%= fuPhoto.ClientID %>');
            var imagePreview = document.getElementById('imagePreview');
            imagePreview.innerHTML = ''; // Limpia cualquier imagen previamente mostrada

            if (fileInput.files.length > 0) {
                for (var i = 0; i < fileInput.files.length; i++) {
                    var file = fileInput.files[i];
                    if (file.type.startsWith('image/')) {
                        var exits = fileInput.parentNode.querySelector('.errorSpan');
                        if (exits) {
                            fileInput.parentNode.removeChild(exits);
                        }
                        var img = document.createElement('img');
                        img.src = URL.createObjectURL(file);
                        img.className = 'image-preview'; // Ajusta el tamaño de la imagen si es necesario
                        imagePreview.appendChild(img);
                    }
                    else {
                        var exits = fileInput.parentNode.querySelector('.errorSpan');
                        if (exits) {
                            fileInput.parentNode.removeChild(exits);
                        }
                        SetError(fileInput.parentNode,"Solo se admiten imagenes");
                        fileInput.value = '';
                        return
                    }
                }
            }
        
        }
        function SetError(container, message) {
            
            var spanError = document.createElement('span');
            spanError.className = 'errorSpan';
            spanError.textContent = message;
            container.appendChild(spanError);
        }

        function ValideForm() {
            let errors = document.querySelectorAll('span.errorSpan');
            errors.forEach(function (span) {
                span.parentNode.removeChild(span);
            });
            var state = true;
            var constrols = [];
            var nombre = document.getElementById('<%= txtname.ClientID %>');
            var raza = document.getElementById('<%= txtAnimalBreed.ClientID %>');
            var edad = document.getElementById('<%= txtAge.ClientID %>');
            var photo = document.getElementById('<%= fuPhoto.ClientID %>');
            constrols.push(nombre,raza,edad);
            constrols.forEach(function (control) {
                
                var parent = control.parentNode;
                if (control.value == "") {
                    
                    SetError(parent, "Campo vacio");
                    state = false;

                }
            
            });
            if (photo.files.length === 0) {


                SetError(photo.parentNode, "Debe seleccionar una imagen");
                state = false;
            }
            
            
            let regex = /^[a-zA-Z0-9\s]+$/;
            if (nombre.value.length > 50) {
                state = false;
                SetError(nombre.parentNode, "No se admiten mas de 50 caracteres");
            }
            else if (!regex.test(nombre.value) && nombre.value != '') {
                state = false;
                SetError(nombre.parentNode, "No se admiten caracteres especiales");
            }


            if (raza.value.length > 50) {
                state = false;
                SetError(raza.parentNode, "No se admiten mas de 50 caracteres");
            }
            else if (!regex.test(raza.value) && raza.value != '') {
                state = false;
                SetError(raza.parentNode, "No se admiten caracteres especiales");
            }

            return state;
        }

    </script>
    <style>
            .image-preview{
                width: 200px;
                height: 150px;
                margin: 10px;
            }
            .errorSpan{
                color:red;
                font-weight: bold;
            }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:Label runat="server">Nombre:</asp:Label>
        <asp:TextBox runat="server" ID="txtname" ></asp:TextBox>
    </div>
    <div>
        <asp:Label runat="server">Categoria:</asp:Label>
        <asp:DropDownList ID="cbAnimalCategory" runat="server">
            <asp:ListItem Selected="True" Text="Perro" Value="1" />
            <asp:ListItem Text="Gato" Value="2" />
        </asp:DropDownList>
    </div>
    <div>
        <asp:Label runat="server">Raza:</asp:Label>
        <asp:TextBox runat="server" ID="txtAnimalBreed" ></asp:TextBox>
        <%--Div de error--%> 
    </div>
    <div>
        <asp:Label runat="server">Edad:</asp:Label>
        <asp:TextBox TextMode="Number" runat="server" ID="txtAge" ></asp:TextBox>
    </div>
    <div>
        <asp:FileUpload onchange="previewImages()" runat="server" ID="fuPhoto" />
    </div>
    
    <div style="display:flex;" id="imagePreview"></div>

    <asp:Button Text="Registar Animal" runat="server" ID="btnRegister" OnClientClick="return ValideForm()" OnClick="btnRegister_Click" />
</asp:Content>
