<%@ Page Title="" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="UserUpdate.aspx.cs" Inherits="Narices_Frias.Pages.CrudUsers.UserUpdate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<link rel="stylesheet" href="/Stylesheets/UserForm.css">
    <div class="CrudSection">
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
        <div runat="server" id="shelterStaffDiv">
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
        <asp:Button runat="server" Text="Insertar" ID="btnInsert" OnClick="btnInsert_Click" />
    </div>

</asp:Content>
