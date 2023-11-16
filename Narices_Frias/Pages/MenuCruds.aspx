<%@ Page Title="" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="MenuCruds.aspx.cs" Inherits="Narices_Frias.Pages.MenuCruds" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <link rel="stylesheet" href="/Stylesheets/MenuStyle.css">


    <div class="container-fluid menuSection">
    <div class="row">
        <h4>El Refugio Mas Grande De Cochabamba</h4>



    </div>
    <div class="row">
        <div class="col-xl-4 optionCard">
            <a href="/Pages/CrudUsers/UserView.aspx">
                <div class="cardContainer">
                    <p>Usuarios</p>
                </div>

            </a>
        </div>
        <div class="col-xl-4 optionCard">
            <a href="CrudProducts.aspx">
                <div class="cardContainer">
                    <p>Productos</p>
                </div>
                
            </a>
        </div>
        <div class="col-xl-4 optionCard">
            <a href="/Pages/CrudAnimals/AnimalView.aspx">
                <div class="cardContainer">
                    <p>Animales</p>
                </div>
                
            </a>
        </div>
        <div class="col-xl-4 optionCard">
            <a href="AdminDateControl.aspx">
                <div class="cardContainer">
                    <p>Administracion de citas</p>
                </div>
                
            </a>
        </div>
        <div class="col-xl-4 optionCard">
            <a href="BillView.aspx">
                <div class="cardContainer">
                    <p>Facturas</p>
                </div>
                
            </a>
        </div>
        <div class="col-xl-4 optionCard">
            <a href="CrudCharitableActivities.aspx">
                <div class="cardContainer">
                    <p>Actividades Beneficas</p>
                </div>
                
            </a>
        </div>
    </div>



</div>




</asp:Content>
