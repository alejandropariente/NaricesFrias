<%@ Page Title="" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="AnimalView.aspx.cs" Inherits="Narices_Frias.Pages.CrudAnimals.AnimalView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script>
        
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView runat="server" ID="dgvAnimals">
        <Columns>
            <asp:BoundField DataField="id" HeaderText="ID" />
            <asp:BoundField DataField="name" HeaderText="Nombre" />
            <asp:BoundField DataField="animalCategoryId" HeaderText="Categoria" />
            <asp:BoundField DataField="animalBreed" HeaderText="Raza" />
            <asp:TemplateField HeaderText="Acciones">
                <ItemTemplate>
                    <a class="btn btn-primary" href='AnimalForm.aspx?id=<%# Eval("ID") %>'>Modificar</a>
                    <a class="btn btn-danger" onclick="confirmEliminate">Eliminar</a>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <a class="btn btn-dark" href="AnimalForm.aspx">Registrar animal</a>
</asp:Content>
