<%@ Page Title="" EnableEventValidation="false" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="CashierView.aspx.cs" Inherits="Narices_Frias.Pages.CashierView" %>
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
    <asp:ScriptManager runat="server" ID="scriptmanager1"></asp:ScriptManager>
    <div class="row">
        <div class="col-md-8" style="background-color:red;">
            <h1>Productos</h1>
            <asp:Repeater runat="server" ID="productsPanel">
                <ItemTemplate>
                    <div class="productCard">
                        <h2><%# Eval("name") %></h2>
                        <p>
                            Descripcion : 
                                        <%# Eval("description") %>
                        </p>
                        <p>
                            Precio unitario : 
                                        <%# Eval("unitPrice") %>
                        </p>
                        <p>
                            Stock disponible : 
                                        <%# Eval("stock") %>
                        </p>
                        <asp:Image runat="server" ImageUrl='<%#NFDao.Tools.ImageConverterDAO.ConvertImageToURL((byte[])Eval("photo")) %>' />
                        <asp:UpdatePanel runat="server">
                            <ContentTemplate>
                                <asp:Button CssClass="btn btn-success" runat="server" Text="+" ID="AddButtom" CommandArgument='<%# Eval("id") %>' OnClick="AddButtom_Click" />
                            </ContentTemplate>
                            <Triggers>
                                <asp:AsyncPostBackTrigger ControlID="AddButtom" EventName="Click" />
                            </Triggers>
                        </asp:UpdatePanel>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
        <div class="col-md-4" style="background-color:blue;">
            <h1>Facturas</h1>
            
            <asp:UpdatePanel runat="server">
                <ContentTemplate>
                    <asp:Repeater runat="server" ID="billPreviews">
                        <ItemTemplate>
                            <div>
                                <p><%# Eval("product.name").ToString() %></p>
                                <p><%# Eval("product.unitPrice").ToString() %></p>
                                <asp:TextBox AutoPostBack="true" prodId='<%# Eval("product.id").ToString() %>' ID="detailAmount" OnTextChanged="detailAmount_TextChanged"
                                     runat="server" TextMode="Number" Text='<%# int.Parse(Eval("detail.amount").ToString()) == 0 ? "1" : Eval("detail.amount").ToString() %>'></asp:TextBox>
                                <asp:Button Text="-" CssClass="btn btn-danger" runat="server" ID="deleteDetail" OnClick="deleteDetail_Click" CommandArgument='<%# Eval("product.id") %>' />
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>
                </ContentTemplate>
            </asp:UpdatePanel>
            
            <asp:Button runat="server" ID="btnGenerateBill" Text="Generar factura" OnClick="btnGenerateBill_Click" />
        </div>
    </div>
    <div class="row">
        <h1>Nit :</h1>
        <asp:TextBox runat="server" ID="txtNit"></asp:TextBox>
        <a href="#">Nuevo Cliente</a>
    </div>
</asp:Content>
