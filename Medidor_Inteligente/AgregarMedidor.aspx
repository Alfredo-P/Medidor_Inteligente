<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="AgregarMedidor.aspx.cs" Inherits="Medidor_Inteligente.AgregarMedidor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row mt-5">
        <div class="col-lg-6 mx-auto">
            <div class="card">
                <div class="card-header bg-primary text-white">
                    <h3>Ingresar Medidor</h3>
                </div>
                <div class="card-body">
                    <div class="form-group">
                        <label for="fechaTxt">fecha (YYYY-MM-DD)</label>
                        <asp:TextBox ID="fechaTxt" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>

                   <div class="form-group">
                        <label for="nombreTxt">Nombre</label>
                        <asp:TextBox ID="nombreTxt" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>

                    <div class="form-group">
                        <label for="consumoTxt">Valor Consumo</label>
                        <asp:TextBox ID="consumoTxt" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>

                  <asp:Button OnClick="ingresarBtn_Click1" runat="server" ID="ingresarBtn" Text="Ingresar" />

                    

                </div>
            </div>
        </div>
    </div>
</asp:Content>
