<%@ Page Title="" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="CharitableActivitiesView.aspx.cs" Inherits="Narices_Frias.Pages.CharitableActivitiesView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="../StylesSheets/CharitableActivities.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="scrollView">
        <asp:GridView CssClass="table table-bordered table-striped dataTable dtr-inline" runat="server" ID="dgvCharitables" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField DataField="name" HeaderText="Nombre" />
                <asp:BoundField DataField="description" HeaderText="Descripcion" />
                <asp:BoundField DataField="date" HeaderText="Fecha" />
                <asp:BoundField DataField="moneyRaising" HeaderText="Total Recaudado" />
                
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
