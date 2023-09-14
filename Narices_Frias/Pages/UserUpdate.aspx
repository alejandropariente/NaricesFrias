<%@ Page Title="" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="UserUpdate.aspx.cs" Inherits="Narices_Frias.Pages.UserUpdate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">
<div class="row">
<div class="alert alert-success alert-dismissible" id="Div1" runat="server">

<asp:Button Text="x" ID="Button1" runat="server" type="button" class="close" data-dismiss="alert" aria-hidden="true" Onclick ="Button1_Click"/>
<h5><i class="icon fas fa-check"></i> Alerta!</h5>
                    Registro Eliminado con exito!!..
</div>
<div class="alert alert-success alert-dismissible" id="midiv" runat="server">
<asp:Button Text="x" ID="btnClose" runat="server" type="button" class="close" data-dismiss="alert" aria-hidden="true" OnClick="btnClose_Click"/>
<h5><i class="icon fas fa-check"></i> Alerta!</h5>
                    Registro modificado con exito!!..
</div>
  <div class="container-fluid">
        <div class="row">
            <div class="crudSearcher">
                <h1>Gestion de Usuarios</h1>
            </div>
        </div>
        <div class="row">
            <div class="col-xl-12">
                
             <form>
<div class="form-group">
<label for=""></label>
<asp:TextBox ID="txtName" CssClass="form-control form-control-lg"
                                    placeholder="Ingresar Nombre" runat="server" onblur="validateName()" ></asp:TextBox>
</div>
<div class="form-group">
<label for=""></label>
<asp:TextBox ID="txtfirstName" CssClass="form-control form-control-lg"
                                    placeholder="Ingresar Primer Apellido" runat="server" onblur="validateName()" ></asp:TextBox>
</div>
<div class="form-group">
<label for=""></label>
<asp:TextBox ID="txtMiddleName" CssClass="form-control form-control-lg"
                                    placeholder="Ingresar Segundo Apellido" runat="server" onblur="validateName()" ></asp:TextBox>
</div>
<div class="form-group">
<label for=""></label>
<asp:TextBox ID="txtBornDate" runat="server" CssClass="form-control" TextMode="Date" onblur="validateDateOfBirth()"></asp:TextBox>

 

                            </div>
<div class="form-group">
<label for=""></label>
<asp:TextBox ID="txtEmail" CssClass="form-control form-control-lg"
                                    placeholder="Ingresar Correo" runat="server" onblur="validateEmail()"></asp:TextBox>
</div>
                 <div class="form-group">
<label for="ddlRol">Rol:</label>
<asp:DropDownList ID="ddlRol" runat="server" CssClass="form-control form-control-lg">
<asp:ListItem Value="1">Medico</asp:ListItem>
<asp:ListItem Value="2">Ayudante</asp:ListItem>
</asp:DropDownList>
</div>



                 <div class="box-body">

</div>
               

        <div class="row">
            <div class="col-xl-12">
                <div>
                   <a href='UserCrud.aspx'>Volver</a>
<asp:Button ID="btnActualizar" runat="server" Text="Actualizar" OnClick="btnActualizar_Click"/>
<asp:Button ID="btnDelete" runat="server" Text="Eliminar" OnClientClick="return confirm('¿Estás seguro de que deseas eliminar este registro?');" OnClick="btnDelete_Click"/>
                </div>
            </div>
        </div>
    </div>

       <script>
          
           function validateName() {
               var nameTextBox = document.getElementById('<%= txtName.ClientID %>');
               var nameValue = nameTextBox.value;



               if (nameValue.trim() === "") {
                   return; // Campo vacío, no se realiza validación
               }



               var regex = /^[a-zA-Z\s]+$/;
               if (!regex.test(nameValue)) {
                   alert("El nombre no debe contener números ni caracteres especiales.");
                   nameTextBox.value = "";
                   nameTextBox.focus();
               }
           }



           function validateEmail() {
               var emailTextBox = document.getElementById('<%= txtEmail.ClientID %>');
               var emailValue = emailTextBox.value;



               if (emailValue.trim() === "") {
                   return; // Campo vacío, no se realiza validación
               }



               var regex = /^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$/;
               if (!regex.test(emailValue)) {
                   alert("Ingrese una dirección de correo electrónico válida.");
                   emailTextBox.value = "";
                   emailTextBox.focus();
               }
           }



           

       

 

      
        function validateDateOfBirth() {
            var dateOfBirthTextBox = document.getElementById('<%= txtBornDate.ClientID %>');
               var dateOfBirthValue = dateOfBirthTextBox.value;



               if (dateOfBirthValue.trim() === "") {
                   return; // Campo vacío, no se realiza validación
               }



               var birthDate = new Date(dateOfBirthValue);
               var currentDate = new Date();
               var age = currentDate.getFullYear() - birthDate.getFullYear();



               // Comprobar si ya ha pasado el cumpleaños de este año
               if (currentDate.getMonth() < birthDate.getMonth() || (currentDate.getMonth() === birthDate.getMonth() && currentDate.getDate() < birthDate.getDate())) {
                   age--;
               }



               if (age < 18) {
                   alert("Debes ser mayor de 18 años para registrarte.");
                   dateOfBirthTextBox.value = "";
                   dateOfBirthTextBox.focus();
               }
           }



           function validateForm() {
               var isFormValid = true;



               // Validar Nombre
               if (!validateName()) {
                   isFormValid = false;
               }



               // Validar Correo Electrónico
               if (!validateEmail()) {
                   isFormValid = false;
               }



               // Validar Celular
               if (!validatePhone()) {
                   isFormValid = false;
               }



               // Validar Contraseña
               if (!validatePassword()) {
                   isFormValid = false;
               }



               // Validar Repetir Contraseña
               if (!validatePasswordRepeat()) {
                   isFormValid = false;
               }



               // Validar Fecha de Nacimiento
               if (!validateDateOfBirth()) {
                   isFormValid = false;
               }
               if (!validateCI()) {
                   isFormValid = false;
               }



               return isFormValid;
           }
       </script>
 



</asp:Content>

