<%@ Page Title="" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="AdoptedDogs.aspx.cs" Inherits="Narices_Frias.Pages.AdoptedDogs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" href="/Stylesheets/AdotedDogs.css">
    <div class="CrudSection">

    
    <h1>Tus animales :</h1>
    <div id="warningDiv" visible="false" runat="server" role="alert" class="alert-sucess">No tienes ningun perrito adoptado , Adopta uno!</div>
        <asp:GridView runat="server" CssClass="table" ID="dgvAnimals" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField Visible="false" DataField="id" HeaderText="ID" />
                <asp:BoundField DataField="name" HeaderText="Nombre" />
                <asp:TemplateField HeaderText="Categoria">
                    <ItemTemplate>
                        <asp:Label runat="server"><%# int.Parse(Eval("animalCategoryId").ToString()) == 1 ? "Perro":"Gato" %></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="animalBreed" HeaderText="Raza" />
                <asp:TemplateField HeaderText="Estado">
                    <ItemTemplate>
                        <asp:Label runat="server"><%# int.Parse(Eval("isAdoptedOrSponsored").ToString()) == 0 ? "Sin adoptar":
                                                          int.Parse(Eval("isAdoptedOrSponsored").ToString()) == 1 ? "Adoptado":"Apadrinado"%></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>         
            </Columns>
        </asp:GridView>
        </div>
</asp:Content>
<%--sdad--%>

