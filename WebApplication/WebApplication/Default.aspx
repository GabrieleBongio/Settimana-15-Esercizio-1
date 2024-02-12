<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
       <div>
           <asp:Button ID="Button1" runat="server" Text="Fai apparire nome e cognome" OnClick="ShowNameSurname"/>
       </div>
    </main>

</asp:Content>
