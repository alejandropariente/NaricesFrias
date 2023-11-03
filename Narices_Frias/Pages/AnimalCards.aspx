<%@ Page Title="" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="AnimalCards.aspx.cs" Inherits="Narices_Frias.Pages.AnimalCards" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .postContainer {
            margin: 5px;
            padding: 10px;
            border: 1px solid #ccc;
        }
        .post {
            margin: 5px;
            padding: 10px;
            border: 1px solid #ccc;
        }
        .post > div > img {
            width: 100px;
            height: 100px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="postContainer">
        <asp:Repeater ID="AnimalRepeater" runat="server">
            <ItemTemplate>
                <div class="post">
                    <asp:Image ID="AnimalImage" runat="server" ImageUrl='<%#NFDao.Tools.ImageConverterDAO.ConvertImageToURL((byte[])Eval("Photo")) %>' Width="100" Height="100" />
                    <h2><%# Eval("Name") %></h2>
                    <p>Raza: <%# Eval("AnimalBreed") %></p>
                    <p>Edad: <%# Eval("Age") %> años</p>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</asp:Content>
