<%@ Page Title="Quiz" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="~/Quiz.aspx.cs" Inherits="Assignment_5___Personal_Website.Quiz" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <h2 id="title"><%: Title %></h2>
        <asp:UpdatePanel ID="questionUpdatePanel" runat="server" UpdateMode="Conditional">
            <ContentTemplate>
                <h6>Question <%: CurrentQuestionNum + 1 %></h6>
                <asp:PlaceHolder EnableViewState="False" runat="server" id="questionPlaceHolder"/>
            </ContentTemplate>
        </asp:UpdatePanel>
        <br>
        <asp:UpdatePanel ID="submitUpdatePanel" runat="server">
            <ContentTemplate>
                <asp:Label runat="server" ID="resultLabel"></asp:Label>
                <br>
                <asp:Button ID="backButton" Text="Back" runat="server" OnClick="backButton_OnClick" />
                <asp:Button type="submit" ID="submitButton" Text="Submit" runat="server" OnClick="submitButton_OnClick"/>
                <asp:Button ID="nextButton" Text="Next" runat="server" OnClick="nextButton_OnClick" />
            </ContentTemplate>
        </asp:UpdatePanel>
    </main>
</asp:Content>