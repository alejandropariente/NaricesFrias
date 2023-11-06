<%@ Page Title="" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="UserFormDate.aspx.cs" Inherits="Narices_Frias.Pages.UserFormDate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label runat="server">Tipo de cita</asp:Label>
    <asp:DropDownList ID="cbType" runat="server">
        <asp:ListItem Selected="True" Text="Apadrinar/Adoptar" Value="1"></asp:ListItem>
        <asp:ListItem Text="Veterinario" Value="2"></asp:ListItem>
    </asp:DropDownList>
    <div>
        <asp:Label runat="server">Descripcion :</asp:Label>
    <textarea runat="server" id="txtDescriptionDate"></textarea>
    </div>
    <div>
        <asp:Label runat="server">Fecha :</asp:Label>
        <asp:TextBox runat="server" ID="txtDate" TextMode="DateTimeLocal"></asp:TextBox>
    </div>
    <asp:Button Text="Agendar Cita" runat="server" ID="SendDate" OnClick="SendDate_Click" />
    
</asp:Content>
