﻿<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SistemaEgresados._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron" style="background-color: #150E38; color: #FFFFFF; font-size: large; font-family: Arial, Helvetica, sans-serif" >
        
        Sistema de Graduados<br />
    Área Académica de Gerencia de Proyectos<img alt="" src="Images/logoTec.JPG" style="width: 224px; height: 65px; position: relative; top: -19px; left: 438px;" /></div>

    <div class="row">
        <div class="col-md-4">
        </div>
        <div class="col-md-4">
            <div style="text-align: center;">
                <div style="width: 400px; margin-left: auto; margin-right:auto;">
                    <asp:Login ID="AppLogin" runat="server"
                                DestinationPageUrl="~/Default.aspx"
                                LoginButtonText="Ingresar" PasswordLabelText="Contraseña:" UserNameLabelText="Correo:" TitleText="Iniciar Sesión" Height="148px" Width="400px">
                    </asp:Login>
 
                </div>
 
            </div>
        </div>
        <div class="col-md-4">
            <h2>&nbsp;</h2>
        </div>
    </div>

</asp:Content>
