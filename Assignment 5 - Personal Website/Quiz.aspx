<%@ Page Title="Quiz" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="~/Quiz.aspx.cs" Inherits="Assignment_5___Personal_Website.Quiz" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <h2 id="title"><%: Title %></h2>
        <section>
            <h6>Question <%: CurrentQuestionNum %></h6>
            <asp:PlaceHolder runat="server" id="questionPlaceHolder"/>
        </section>
        <br>
        <asp:UpdatePanel ID="submitUpdatePanel" runat="server">
            <ContentTemplate>
                <asp:Label runat="server" ID="resultLabel"></asp:Label>
                <br>
                <asp:Button type="submit" ID="submitButton" Text="Submit" runat="server" OnClick="submitButton_OnClick"/>
            </ContentTemplate>
        </asp:UpdatePanel>
    </main>
</asp:Content>