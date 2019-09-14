﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MenuGraduado.aspx.cs" Inherits="SistemaEgresados.MenuGraduado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <script src="https://ajax.googleapis.com/ajax/libs/jquery/2.1.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <link href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" rel="stylesheet" />


<div class="container">
    <%--<br /><br /><br /><br />--%>
    <div class="text-center ">
        <asp:Label class="text-dark" id="Label13" Text="Menú Graduado:" runat="server" Width="400" Font-Size="XX-Large"/>
    </div>
    <br /><br />
    <div class="text-center">
        <img src="Images/lupa.png" height="20" width="30"/> &nbsp &nbsp
        <a href="#" class="btn btn-secondary btn-lg" style="font-size:small" role="button" aria-pressed="true" onclick="window.location.href='/ConsultarDatos.aspx'">Consultar datos actuales</a>
    </div>
    <br />
    <div class="text-center">
        <img src="Images/edit.png" height="18" width="45"/>
        <a href="#" class="btn btn-secondary btn-lg" style="font-size:small" role="button" aria-pressed="true" onclick="window.location.href='/EditarDatos.aspx'">Actualizar datos personales</a>
    </div>
</div>
</asp:Content>
