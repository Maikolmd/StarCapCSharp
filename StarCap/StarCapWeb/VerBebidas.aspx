<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="VerBebidas.aspx.cs" Inherits="StarCapWeb.VerBebidas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
    <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class="card">
                <div class="card-header bg-secondary text-white">
                    <h1>VerBebidas</h1>
                </div>
                <div class="card-body">
                    <asp:GridView CssClass="table table-hover table-bordered"
                        OnRowCommand="grillaBebidas_RowCommand"
                        AutoGenerateColumns="false" EmptyDataText ="No existen bebeidas aun" ShowHeader="true"
                        runat="server" ID="grillasBebidas">
                        <Columns>
                            <asp:BoundField DataField="Codigo" HeaderText="Codigo de bebida"/>
                            <asp:BoundField DataField="Nombre" HeaderText="Nombre de la bebida" />
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:Button CommandName="eliminar" 
                                        CommandArgument='<%# Eval("codigo") %>'
                                        runat="server"
                                        CssClass="btn btn-danger" Text="Eliminar"/>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
