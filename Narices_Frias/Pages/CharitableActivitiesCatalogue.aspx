<%@ Page Title="" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="CharitableActivitiesCatalogue.aspx.cs" Inherits="Narices_Frias.Pages.CharitableActivitiesCatalogue" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .postContainer{
            margin:5px;
            padding:10px;
            border:black 10px solid;
        }
        .post{
            margin:5px;
            padding:10px;
            border:black 10px solid;
        }
        .post > div > img{
            width :100px;
            height:100px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel runat="server" ID="cataloguePanel" CssClass="postContainer">

    </asp:Panel>
</asp:Content>
