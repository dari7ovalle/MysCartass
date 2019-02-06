<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="rCartas.aspx.cs" Inherits="MysCartas.UI.Registros.rCartas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="card card-register mx-auto mt-5">
        <div class="card-header text-uppercase text-center text-primary">Registro Carta</div>
        <div class="card-body">
            <div class="form-row justify-content-center">
                <div class="col-md-6 col-md-offset-3">
                    <div class="container">
                        <div class="form-group">
                            <asp:Label Text="Carta Id" class="text-primary" runat="server" />
                            <asp:LinkButton ID="BuscarLinkButton" CssClass="btn btn-outline-info mt-4" runat="server">
                <span class="fas fa-search"></span>
                     Buscar
                                   
                            </asp:LinkButton>
                            <div class="col-md-6 col-md-offset-3">
                                <asp:TextBox ID="CartaIdTextBox" class="form-control input-group" TextMode="Number" placeholder="0" runat="server" />
                            </div>
                        </div>
                    </div>            
                    <div class="col-md-6 col-md-offset-3">
                        <div class="container">
                            <div class="form-group">
                                <asp:Label Text="Fecha" runat="server" />
                                <asp:TextBox ID="FechaTextBox" class="form-control input-group" TextMode="Date" runat="server" />
                            </div>
                        </div>
                    </div>
                     <div class="form-row">

                        <div class="form-group col-md-3">
                            <asp:Label Text="Carta" runat="server" />
                            <asp:DropDownList ID="CartaDropDownList" class="form-control input-sm" runat="server">
                                <asp:ListItem Selected="True">[Seleccione]</asp:ListItem>
                            </asp:DropDownList>
                            </div>
                         </div>
                       <div class="col-md-6 col-md-offset-3"">
                    <div class="container">
                        <div class="form-group">
                            <asp:Label Text="Cuerpo" runat="server" />
                            <asp:TextBox ID="CuerpoTextBox" class="form-control input-sm" runat="server" />
                        </div>
                    </div>
                </div>
                    <div class="form-row">
                        <asp:Label ID="MensajeLabel" runat="server" Text=""></asp:Label>
                        <div class="panel-footer">
                            <div class="text-center">
                                <div class="form-group" style="display: inline-block">
                                    <asp:Button Text="Nuevo" class="btn btn-outline-info btn-md" runat="server" ID="NuevoButton" />
                                    <asp:Button Text="Guardar" class="btn btn-outline-success btn-md" runat="server" ValidationGroup="Guardar" ID="GuadarButton" />
                                    <asp:Button Text="Eliminar" class="btn btn-outline-danger btn-md" runat="server" ID="EliminarButton" />
                                </div>
                            </div>
                        </div>
                    </div>

                </div>
            </div>
        </div>
    </div>
</asp:Content>
