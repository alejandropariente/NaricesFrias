<%@ Page Title="" EnableEventValidation="false" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="UserView.aspx.cs" Inherits="Narices_Frias.Pages.CrudUsers.UserView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Usuarios</h2>
    <asp:GridView runat="server" ID="dgvUsers" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField DataField="id" HeaderText="ID" />
            <asp:BoundField DataField="userName" HeaderText="Nombre de usuario" />
            <asp:BoundField DataField="email" HeaderText="Correo" />
            <asp:TemplateField HeaderText="Cumpleaños">
                <ItemTemplate>
                    <asp:Label runat="server"><%# Eval("birthdate", "{0:yyyy/MM/dd}")%></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Acciones">
                <ItemTemplate>
                    <a class="btn btn-primary" href='UserUpdate.aspx?id=<%# Eval("ID") %>'>Modificar</a>

                    <asp:Button runat="server" ID="btnDeleteUser" CssClass="btn btn-danger" Text="Eliminar" OnClick="btnDeleteUser_Click"
                        CommandArgument='<%# Eval("ID") %>' />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <h2>Usuarios del refugio</h2>
    <asp:GridView runat="server" ID="dgvShelterStaff" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField DataField="id" HeaderText="ID" />
            <asp:BoundField DataField="userName" HeaderText="Nombre de usuario" />
            <asp:TemplateField HeaderText="Rol">
                <ItemTemplate>
                    <asp:Label runat="server"><%# int.Parse(Eval("role").ToString()) == 1 ? "Medico": 
                                                      int.Parse(Eval("role").ToString()) == 2 ? "Cajero" : "Administrador"%></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="email" HeaderText="Correo" />
            <asp:TemplateField HeaderText="Cumpleaños">
                <ItemTemplate>
                    <asp:Label runat="server"><%# Eval("birthdate", "{0:yyyy/MM/dd}")%></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="ci" HeaderText="Ci" />
            <asp:BoundField DataField="phone" HeaderText="Telefono" />
            <asp:BoundField DataField="address" HeaderText="Direccion" />
            <asp:TemplateField HeaderText="Acciones">
                <ItemTemplate>
                    <a class="btn btn-primary" href='UserUpdate.aspx?id=<%# Eval("ID") %>'>Modificar</a>

                    <asp:Button runat="server" ID="btnDeleteShelterStaff" CssClass="btn btn-danger" Text="Eliminar" OnClick="btnDeleteUser_Click"
                        CommandArgument='<%# Eval("ID") %>' />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <a href="UserForm.aspx" class="btn btn-dark">Crear nuevo usuario</a>
</asp:Content>
