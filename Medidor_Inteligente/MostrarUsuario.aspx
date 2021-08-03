<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="MostrarUsuario.aspx.cs" Inherits="Medidor_Inteligente.MostrarUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="row mt-5">
            <asp:GridView ID="grillaUsuario" CssClass ="table table-hover table-bordered" AutoGenerateColumns="false" ShowHeaderWhenEmpty="true" EmptyDataText="no hay registros" runat="server" OnRowCommand="grillaUsuario_RowCommand">
                <Columns>
                    <asp:BoundField HeaderText="Nombre" DataField="nombre" />
                    <asp:BoundField HeaderText="Rut" DataField="rut" />
                    <asp:BoundField HeaderText="Correo" DataField="correo" />
                    <asp:BoundField HeaderText="Medidor" DataField="medidor.ingreso" />
                    <asp:TemplateField HeaderText="Acciones">
                                    <ItemTemplate>
                                        <asp:Button CssClass="btn btn-danger" runat="server"
                                             CommandName="eliminar" Text="Eliminar"
                                             CommandArgument='<%# Eval("id_usuario")%>' />
                                    </ItemTemplate>
                                </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>
