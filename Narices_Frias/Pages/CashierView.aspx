<%@ Page Title="" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="CashierView.aspx.cs" Inherits="Narices_Frias.Pages.CashierView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .productCard{
            margin:5px;
            padding:10px;
            border:black 10px solid;
        }
        .productCard > img{
            width :100px;
            height:100px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-md-8" style="background-color:red;">
            <h1>Productos</h1>
            <asp:Panel runat="server" ID="productPanel">

            </asp:Panel>
        </div>
        <div class="col-md-4" style="background-color:blue;">
            <h1>Facturas</h1>
            <asp:Panel runat="server" ID="billPreview">

            </asp:Panel>
            <asp:Button runat="server" ID="btnGenerateBill" Text="Generar factura" OnClick="btnGenerateBill_Click" />
        </div>
    </div>
    <div class="row">

    </div>
</asp:Content>
