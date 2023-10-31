<%@ Page Title="" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="Landing.aspx.cs" Inherits="Narices_Frias.Pages.Landing" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
    <link href="https://fonts.googleapis.com/css2?family=Inter&family=Play:wght@400;700&display=swap" rel="stylesheet">
    <link rel="stylesheet" href="/Stylesheets/Landing.css">



    <div class="container-fluid">
        <div class="row main">
            <div class="col-xl-8">
                <div class="landingLeft">
                    <p>
                        La forma más rápida de ayudar a los animales a encontrar un hogar.
                    </p>
                    <a name="" id="" class="btnContact btn btn-primary" href="#" role="button">Contactanos</a>
                    <h6>Organización sin fines de lucro</h6>

                </div>
                
            </div>
            <div class="col-xl-4">
                <div class="cardDog">
                    <img src="/Images/imgLandingCard.png" alt="">
                    <h4>
                        SAMMY
                    </h4>
                    <h6>
                        Raza: Pug Ingles 
                    </h6>
                    <a name="" id="" class="btn btn-primary" href="#" role="button">Ver</a>
                </div>
                
            </div>
        </div>
    </div>

    <div class="container-fluid">
        <div class="row naricesFriasCenter">
            <div class="col-xl-7">
                <div class="naricesFriasDescription">
                    <h2>¿Qué es Narices Frias?</h2>
                    <h1>NOS DEDICAMOS A AYUDAR A QUE LAS PERSONAS ENCUENTREN UNA MASCOTA</h1>
                    <h4>Ofrecemos la opcion de adoptar o apadrinar 
                        a uno de los amigos mas fieles del hombre, 
                        con solo un boton.</h4>
                    <div>
                        <a name="" id="" class="btn btn-primary" href="#" role="button">View Pets</a>
                    </div>
                </div>
            </div>
            <div class="col-xl-5 imgPerritos">
                <img src="/Images/Mosquera-perros 1.png" alt="">

            </div>
            <div class="Contcircle">
                <div>

                </div>
            </div>
        </div>
    </div>

    <div class="container-fluid">
        <div class="row servicesSection">
            <div class="col-xl-2 halfCircleLeft">
                <img src="/Images/halfCircle1.png" alt="">
            </div>
            <div class="col-xl-4">
                <img src="/Images/AdoptIcon.png" alt="">
                <h3>ADOPTAR</h3>
                <p>Dale la oportunidad a un animalito a tener una familia </p>
            </div>
            <div class="col-xl-4">
                <img src="/Images/ApadrinarIcon.png" alt="">
                <h3>APADRINAR</h3>
                <p>Apoya a un animalito
                    dandolo lo necesario para su bien estar
                    como si fuera tuyo</p>
            </div>
            
            <div class="col-xl-2 halfCircleRight">
                <img src="/Images/halfCircle2.png" alt="">
            </div>
        </div>
    </div>
</asp:Content>
