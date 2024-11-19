<%@ Page Title="Commands" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="~/Commands.aspx.cs" Inherits="Assignment_5___Personal_Website.Commands" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <!-- TODO: Potentially add https://github.com/BattlefieldDuck/XtermBlazor in for an integrated terminal? could be cool -->

    <main aria-labelledby="title">
        <h2 id="title"><%: Title %></h2>
        <section>
            <h4>Basic Git commands</h4>
            <%-- Programatically adds list elements in codebehind --%>
            <ul runat="server" id="commandList"></ul>
        </section>
        <section>
            <h4>.gitignore</h4>
            <p>
                You can define a <code>.gitignore</code> file in the root directory of your project.
                Any file or folder names that you put into your <code>.gitignore</code> will be excluded from being added to the Git repository.
            </p>
            <p>
                Usually, these are files that should not be uploaded to the internet or are unnecessary, or any files that are specific to your computer,
                such as a file containing API keys or any files that have IDE settings like <code>.vs</code> or <code>.idea</code>.
                Some other examples include folders that include the compiled files, usually a folder called <code>bin</code> or <code>release</code>, depending on language and folder structure.
            </p>
        </section>
    </main>
</asp:Content>