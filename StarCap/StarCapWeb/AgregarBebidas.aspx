<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="AgregarBebidas.aspx.cs" Inherits="StarCapWeb.AgregarBebidas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
    <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class="mensajes">
                <asp:Label runat="server" ID="mensajesLbl" CssClass="text-success"></asp:Label>
            </div>
            <div class="card">
                <div class="card-header bg-info text-white">
                    <h3>Aagregar Bebidas</h3>
                </div>
                <div class="card-body">
                   <div class="form-group">
                       <label for="NomBebidaTxt">Agrege Nombre de la Bebida</label>
                       <asp:TextBox ID="NomBebidaTxt" runat="server" CssClass="form-control"></asp:TextBox>
                   </div>
                    <div class="form-group">
                        <label for="CodigoBebidaTxt">Ingrese Un Codigo para la Bebida</label>
                        <asp:TextBox ID="CodigoBebidaTxt" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div>
                       <asp:Button runat="server" ID="AgregarBebidaBtn" OnClick="AgregarBebidaBtn_Click" Text="Agregar" CssClass="btn btn-primary btn-lg" />
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
