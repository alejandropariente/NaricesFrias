<%@ Page Title="" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="ChangePassword.aspx.cs" Inherits="Narices_Frias.Pages.ChangePassword" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script>
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
            var controls = [];
            var newPassword = document.getElementById('<%= txtNewPassword.ClientID %>');
            var confirmPassword = document.getElementById('<%= txtConfirmPassword.ClientID %>');
            controls.push(newPassword, confirmPassword);

            controls.forEach(function (control) {
                var parent = control.parentNode;
                if (control.value == "") {
                    SetError(parent, "Campo vacío");
                    state = false;
                }
            });

            var regex = /^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$/;
            if (!regex.test(newPassword.value) && newPassword.value != '') {
                state = false;
                SetError(newPassword.parentNode, "La contraseña debe contener minimo 8 digitos, una letra minúscula, una letra mayúscula y un número .");
            }
            
            if (newPassword.value !== confirmPassword.value) {
                state = false;
                SetError(newPassword.parentNode, "Las contraseñas no coinciden");
            }

            return state;
        }

    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label runat="server">Recomendacion la contraseña debe contener al menos una letra minuscula una letra mayuscula y un numero para mayor seguridad</asp:Label>
    <div>
    <asp:Label runat="server">Contraseña Nueva:</asp:Label>
    <asp:TextBox runat="server" ID="txtNewPassword" TextMode="Password"></asp:TextBox>
</div>

<div>
    <asp:Label runat="server">Repetir Contraseña:</asp:Label>
    <asp:TextBox runat="server" ID="txtConfirmPassword" TextMode="Password"></asp:TextBox>
</div>
    <asp:Button Text="Cambiar Contraseña" runat="server" ID="btnChange" OnClientClick="return ValideForm()" OnClick="btnChange_Click"/>
</asp:Content>
