<%@ Page Title="" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="UserForm.aspx.cs" Inherits="Narices_Frias.Pages.CrudUsers.UserForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script>


        

        
        function optioChange() {
            var cb = document.getElementById('<%= cbOptions.ClientID %>');
            var divForm = document.getElementById('shelterStaffDiv');
            if (cb.value <= 2) {
                divForm.style.display = 'block';
            }
            else {
                divForm.style.display = 'none';
            }
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:Label runat="server">Rol :</asp:Label>
        <asp:DropDownList ID="cbOptions" onchange="optioChange()" runat="server">
            <asp:ListItem Value="3" >Usuario</asp:ListItem>
            <asp:ListItem Value="1" Selected="True">Medico</asp:ListItem>
            <asp:ListItem Value="2" >Cajero</asp:ListItem>
        </asp:DropDownList>
    </div>
    <div>
        <div>
            <asp:Label runat="server">Nombre : </asp:Label>
            <asp:TextBox runat="server" ID="txtName"></asp:TextBox>
        </div>
        <div>
            <asp:Label runat="server">Primer apellido : </asp:Label>
            <asp:TextBox runat="server" ID="txtLastName"></asp:TextBox>
        </div>
        <div>
            <asp:Label runat="server">Segundo apellido : </asp:Label>
            <asp:TextBox runat="server" ID="txtSecondLastName"></asp:TextBox>
        </div>
        <div>
            <asp:Label runat="server">Nombre de usuario : </asp:Label>
            <asp:TextBox runat="server" ID="txtUsername"></asp:TextBox>
        </div>
        <div>
            <asp:Label runat="server">email : </asp:Label>
            <asp:TextBox runat="server" TextMode="Email" ID="txtEmail"></asp:TextBox>
        </div>
        <div>
            <asp:Label runat="server">Cumpleaños : </asp:Label>
            <asp:TextBox runat="server" ID="txtBirthdate" TextMode="Date"></asp:TextBox>
        </div>
        <div  id="shelterStaffDiv">
            <div>
                <asp:Label runat="server">Ci : </asp:Label>
                <asp:TextBox runat="server" ID="txtCi"></asp:TextBox>
            </div>
            <div>
                <asp:Label runat="server">Telefono : </asp:Label>
                <asp:TextBox runat="server" ID="txtPhone" TextMode="Phone"></asp:TextBox>
            </div>
            <div>
                <asp:Label runat="server">Direccion : </asp:Label>
                <textarea runat="server" id="txtAddress"></textarea>
            </div>
        </div>
    </div>
    <asp:Button runat="server" ID="btnInsert" OnClick="btnInsert_Click" />
</asp:Content>
