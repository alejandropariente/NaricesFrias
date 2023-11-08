<%@ Page Title="" EnableEventValidation="false" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="AdminDateControl.aspx.cs" Inherits="Narices_Frias.Pages.AdminDateControl" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" href="/Stylesheets/AdminDateControl.css">
     <div class="citasSection">

     
        <h1>Citas pendientes</h1>
        <asp:GridView runat="server" ID="dgvdates" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField DataField="id" HeaderText="ID" />
                    <asp:BoundField DataField="date" HeaderText="Fecha" />
                    <asp:TemplateField HeaderText="Tipo de cita">
                        <ItemTemplate>
                            <asp:Label runat="server" Text='<%# byte.Parse(Eval("type").ToString()) == 1 ? "Apadrinamiento/adopcion" : "Veterinario" %>'> </asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Nombre del solicitante">
                        <ItemTemplate>
                            <asp:Label runat="server" Text='<%# GetFullname(int.Parse(Eval("systemUserId").ToString())) %>'> </asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Correo">
                        <ItemTemplate>
                            <asp:Label runat="server" Text='<%# GetEmail(int.Parse(Eval("systemUserId").ToString())) %>'> </asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Acciones">
                        <ItemTemplate>
                            <asp:Button runat="server" ID="AcceptButtom" OnClick="AcceptButtom_Click" CssClass="btn btn-success" Text="Aceptar" CommandArgument='<%# Eval("ID") %>'/>
                            <asp:Button runat="server" ID="RejectButtom" OnClick="RejectButtom_Click" CssClass="btn btn-danger" Text="Rechazar" CommandArgument='<%# Eval("ID") %>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <div class="alert-info" runat="server" id="warningDiv">No hay citas pendientes</div>
            <h1>Historial de citas</h1>
            <asp:GridView runat="server" ID="dgvDateHistory" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField DataField="id" HeaderText="ID" />
                <asp:BoundField DataField="date" HeaderText="Fecha" />
                <asp:TemplateField HeaderText="Tipo de cita">
                    <ItemTemplate>
                        <asp:Label runat="server" Text='<%# byte.Parse(Eval("type").ToString()) == 1 ? "Apadrinamiento/adopcion" : "Veterinario" %>'> </asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Nombre del solicitante">
                    <ItemTemplate>
                        <asp:Label runat="server" Text='<%# GetFullname(int.Parse(Eval("systemUserId").ToString())) %>'> </asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Correo">
                    <ItemTemplate>
                        <asp:Label runat="server" Text='<%# GetEmail(int.Parse(Eval("systemUserId").ToString())) %>'> </asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Estado">
                    <ItemTemplate>
                        <asp:Label runat="server" Text='<%# byte.Parse(Eval("status").ToString()) == 2 ? "Aceptado":"Rechazado" %>'> </asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Acciones">
                    <ItemTemplate>
                        <asp:Button runat="server" ID="DeleteButtom" OnClick="DeleteButtom_Click" CssClass="btn btn-danger" Text="Eliminar" CommandArgument='<%# Eval("ID") %>'/>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
         </div>
</asp:Content>
