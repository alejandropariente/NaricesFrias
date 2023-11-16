<%@ Page Title="" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="BillsDetails.aspx.cs" Inherits="Narices_Frias.Pages.BillsDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Detalle</h1>
    <div>
        <h3>
            Nit : <%= RecoverNit(int.Parse(Request.QueryString["id"].ToString())) %>
        </h3>
        <h3>
            Razon social : <%= RecoverBillName(int.Parse(Request.QueryString["id"].ToString())) %>
        </h3>
        <h3>
            Total :  Bs. <%= RecoverTotal(int.Parse(Request.QueryString["id"].ToString())) %>
        </h3>
    </div>
    <h1>Productos :</h1>
    <asp:GridView runat="server" ID="dgvProducts" AutoGenerateColumns="false">
        <Columns>
            <asp:TemplateField HeaderText="Nombre">
                <ItemTemplate>
                    <asp:Label runat="server" Text='<%# RecoverProductName(int.Parse(Eval("productId").ToString())) %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="amount" HeaderText="Cantidad" />
            <asp:BoundField DataField="price" HeaderText="Precio Bs." />
        </Columns>
    </asp:GridView>
    <a href="BillView.aspx" class="btn btn-dark">Volver</a>
</asp:Content>
