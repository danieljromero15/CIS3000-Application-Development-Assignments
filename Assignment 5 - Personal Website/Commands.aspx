<%@ Page Title="Commands" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="~/Commands.aspx.cs" Inherits="Assignment_5___Personal_Website.Commands" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <!-- TODO: Potentially add https://github.com/BattlefieldDuck/XtermBlazor in for an integrated terminal? could be cool -->

    <main aria-labelledby="title">
        <h2 id="title"><%: Title %></h2>
        <!-- <h3>Basic Git commands</h3> -->
        Basic commands
        <br>
        <ul runat="server" id="commandList"></ul>
    </main>
</asp:Content>