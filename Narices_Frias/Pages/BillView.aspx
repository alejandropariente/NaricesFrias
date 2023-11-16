<%@ Page Title="" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="BillView.aspx.cs" Inherits="Narices_Frias.Pages.BillView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <link rel="stylesheet" href="/Stylesheets/BillView.css">
    <div class="CrudSection">

    
    <h1>Facturas</h1>
    <asp:GridView runat="server" CssClass="table" ID="dgvBills" AutoGenerateColumns="false" >
        <Columns>
            <asp:BoundField DataField="id" HeaderText="ID" />
            <asp:TemplateField HeaderText="NIT">
                <ItemTemplate>
                    <asp:Label runat="server" Text='<%# RecoverNit(int.Parse(Eval("billNameId").ToString())) %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Razon social">
                <ItemTemplate>
                    <asp:Label runat="server" Text='<%# RecoverBillName(int.Parse(Eval("billNameId").ToString())) %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="totalBill" HeaderText="Total Bs." />
            <asp:TemplateField HeaderText="Acciones">
                <ItemTemplate>
                    <a class="btn btn-primary" href='BillsDetails.aspx?id=<%# Eval("ID") %>'>
                        Detalles
                    </a>
                    <asp:Button runat="server" ID="btnDeleteBill" OnClick="btnDeleteBill_Click" CssClass="btn btn-danger" Text="Seleccionar" 
                        CommandArgument='<%# Eval("ID") %>' />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <a class="btnRegistrar btn btn-dark" href="CashierView.aspx">Agregar nueva factura</a>
        </div>
</asp:Content>
