<%@ Page Title="" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="MedicCrud.aspx.cs" Inherits="Narices_Frias.Pages.MedicCrud" %>
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
                <h1>Gestión de Médicos</h1>
            </div>
        </div>
        <div class="row">
            <div class="col-xl-12">
                <form onsubmit="return validateForm()">
                    <div class="form-group">
                        <label for="txtName">Nombre:</label>
                        <asp:TextBox ID="txtName" CssClass="form-control form-control-lg" placeholder="Ingresar Nombre" runat="server" onblur="validateName()"></asp:TextBox>
                    </div>
                    <div class="form-group">
                                <label for=""></label>
                                <asp:TextBox ID="txtfirstName" CssClass="form-control form-control-lg"
                                    placeholder="Ingresar Primer Apellido" runat="server" onblur=validateName()></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label for=""></label>
                                <asp:TextBox ID="txtMiddleName" CssClass="form-control form-control-lg"
                                    placeholder="Ingresar Segundo Apellido" runat="server" onblur=validateName()></asp:TextBox>
                            </div>
                    <div class="form-group">
                        <label for="txtBornDate">Fecha de Nacimiento:</label>
                        <asp:TextBox ID="txtBornDate" runat="server" CssClass="form-control" TextMode="Date"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="txtCi">Ci:</label>
                        <asp:TextBox ID="txtCi" CssClass="form-control form-control-lg" placeholder="Ingresar CI" runat="server" onblur="validateCI()"></asp:TextBox>
                    </div>
                    
                    <div class="form-group">
                        <label for="txtEmail">Correo Electrónico:</label>
                        <asp:TextBox ID="txtEmail" CssClass="form-control form-control-lg" placeholder="Ingresar Correo" runat="server" onblur="validateEmail()"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="ddlRol">Rol:</label>
                        <asp:DropDownList ID="ddlRol" runat="server" CssClass="form-control form-control-lg">
                            <asp:ListItem Value="1">Medico</asp:ListItem>
                            <asp:ListItem Value="2">Voluntario</asp:ListItem>
                            <asp:ListItem Value="3">Usuario</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="form-group">
                        <label for="txtPhone">Celular:</label>
                        <asp:TextBox ID="txtPhone" CssClass="form-control form-control-lg" placeholder="Ingresar Celular" runat="server" onblur="validatePhone()"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="txtDireccion">Dirección:</label>
                        <asp:TextBox ID="txtDireccion" CssClass="form-control form-control-lg" placeholder="Ingresar Dirección" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="txtUniversidad">Número de Universidad:</label>
                        <asp:TextBox ID="txtUniversidad" CssClass="form-control form-control-lg" placeholder="Ingresar Número de Universidad" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="txtPassword">Contraseña:</label>
                        <asp:TextBox ID="txtPassword" CssClass="form-control form-control-lg" placeholder="Ingresar Contraseña" runat="server" onblur="validatePassword()"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="txtPasswordRepeat">Repetir Contraseña:</label>
                        <asp:TextBox ID="txtPasswordRepeat" CssClass="form-control form-control-lg" placeholder="Repetir Contraseña" runat="server" onblur="validatePasswordRepeat()"></asp:TextBox>
                    </div>
                    <div class="form-group row">
                        <div class="offset-sm-2 col-xl-12">
                            <asp:Button ID="btnRegistrar" runat="server" Text="Registrar" OnClick="btnRegistrar_Click"/>

                        </div>
                    </div>
                    
                </form>
            </div>
        </div>
        <div class="col-md-5">
                        <div class="box-body">
                            <asp:GridView ID="dgvSalida" runat="server" AutoGenerateColumns="false" CssClass="table table-bordered table-striped dataTable dtr-inline">
                                <Columns>
                                    <asp:BoundField DataField="id" HeaderText="ID" />
                                    <asp:BoundField DataField="name" HeaderText="Nombres" />
                                    <asp:BoundField DataField="lastName" HeaderText="Primer Apellido" />
                                    <asp:BoundField DataField="secondLastName" HeaderText="Segundo Apellido" />
                                    <asp:BoundField DataField="ci" HeaderText="Carnet de Identidad" />
                                    <asp:BoundField DataField="phone" HeaderText="Celular" />
                                    <asp:BoundField DataField="collegeNumber" HeaderText="Numero Colegiatura" />
                                    <asp:BoundField DataField="address" HeaderText="Direccion" />
                                    <asp:BoundField DataField="userName" HeaderText="Nombre de usuario" />
                                    <asp:BoundField DataField="email" HeaderText="Correo Electronico" />
                                    <asp:BoundField DataField="role" HeaderText="Rol" />
                                    <asp:BoundField DataField="birthdate" HeaderText="Fecha de Nacimiento" />
                                    <asp:TemplateField HeaderText="Acciones">
                                        <ItemTemplate>
                                            <a href='MedicCrudUpdate.aspx?id=<%# Eval("ID") %>'>Modificar</a>
                                            <a href='MedicCrud.aspx'>Volver</a>
                                            
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                            </asp:GridView>
                        </div>
                    </div>
        <div class="row">
            <div class="col-xl-12">
            <div>
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
        function validateCI() {
            var ciTextBox = document.getElementById('<%= txtCi.ClientID %>');
            var ciValue = ciTextBox.value;
            var regex = /^[0-9-]+$/; // Acepta números y guiones
            if (!regex.test(ciValue)) {
                alert("El CI debe contener solo números y un guión (-) opcional.");
                ciTextBox.value = "";
                ciTextBox.focus();
            }
        }
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

        function validatePhone() {
            var phoneTextBox = document.getElementById('<%= txtPhone.ClientID %>');
            var phoneValue = phoneTextBox.value;

            if (phoneValue.trim() === "") {
                return; // Campo vacío, no se realiza validación
            }

            var regex = /^\d{1,8}$/;
            if (!regex.test(phoneValue)) {
                alert("El número de celular debe tener hasta 8 dígitos numéricos.");
                phoneTextBox.value = "";
                phoneTextBox.focus();
            }
        }

        function validatePassword() {
            var passwordTextBox = document.getElementById('<%= txtPassword.ClientID %>');
            var passwordValue = passwordTextBox.value;

            if (passwordValue.trim() === "") {
                return; // Campo vacío, no se realiza validación
            }

            // Verificar si la contraseña cumple con los requisitos
            var regex = /^(?=.*[A-Z])(?=.*[a-z])(?=.*\d).{9,}$/;
            if (!regex.test(passwordValue)) {
                alert("La contraseña debe tener al menos 9 caracteres, incluyendo al menos una letra mayúscula, una letra minúscula y un número.");
                passwordTextBox.value = "";
                passwordTextBox.focus();
            }
        }

        function validatePasswordRepeat() {
            var passwordTextBox = document.getElementById('<%= txtPassword.ClientID %>');
            var passwordRepeatTextBox = document.getElementById('<%= txtPasswordRepeat.ClientID %>');
            var passwordValue = passwordTextBox.value;
            var passwordRepeatValue = passwordRepeatTextBox.value;

            if (passwordRepeatValue.trim() === "") {
                return; // Campo vacío, no se realiza validación
            }

            if (passwordValue !== passwordRepeatValue) {
                alert("Las contraseñas no coinciden. Por favor, inténtalo de nuevo.");
                passwordTextBox.value = "";
                passwordRepeatTextBox.value = "";
                passwordTextBox.focus();
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
