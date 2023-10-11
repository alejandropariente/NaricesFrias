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
            <a href="/Pages/UserCrud">
                <div class="cardContainer">
                    <p>Usuarios</p>
                </div>

            </a>
        </div>
        <div class="col-xl-4 optionCard">
            <a href="/Pages/MedicCrud">
                <div class="cardContainer">
                    <p>Medicos</p>
                </div>
                
            </a>
        </div>
        <div class="col-xl-4 optionCard">
            <a href="/Pages/CrudPets">
                <div class="cardContainer">
                    <p>Mascotas</p>
                </div>
                
            </a>
        </div>
        <div class="col-xl-4 optionCard">
            <a href="/Pages/AppointmentsCrud">
                <div class="cardContainer">
                    <p>Citas</p>
                </div>
                
            </a>
        </div>
        <div class="col-xl-4 optionCard">
            <a href="">
                <div class="cardContainer">
                    <p>Mascotas</p>
                </div>
                
            </a>
        </div>
        <div class="col-xl-4 optionCard">
            <a href="/Pages/CrudCharitableActivities">
                <div class="cardContainer">
                    <p>Actividades Beneficas</p>
                </div>
                
            </a>
        </div>
    </div>



</div>




</asp:Content>
