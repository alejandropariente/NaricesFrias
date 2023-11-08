<%@ Page Title="" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="RecoverAcount.aspx.cs" Inherits="Narices_Frias.Pages.RecoverAcount" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <link rel="stylesheet" href="/Stylesheets/RecoverAccount.css">

    <div class="RecoverAcount">

        <div runat="server" id="waringDiv"> </div>
        <div class="form-group inputContainer">
            <asp:TextBox ID="txtEmailRecover" CssClass="logInInputs form-control form-control-lg " placeholder="Ingresar Correo" runat="server"></asp:TextBox>
            <asp:Button Text="Recover" ID="btnRecover" runat="server" CssClass="boton" OnClick="btnRecover_Click" />
        </div>
    </div>
</asp:Content>
