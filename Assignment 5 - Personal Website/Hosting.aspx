<%@ Page Title="Hosting" Language="C#" MasterPageFile="~/Site.Master" CodeBehind="~/Hosting.aspx.cs" Inherits="Assignment_5___Personal_Website.Hosting" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <h2 id="title">Comparing different hosting platforms</h2>
        <section id="ranking">
            <p>
                There are a couple different file hosting platforms, the most popular (sorting by number of users) being:
            </p>
            <ol>
                <li>
                    GitHub - 94,000,000 users
                </li>
                <li>
                    GitLab - 31,190,000 users
                </li>
                <li>
                    Bitbucket - 5,000,000 users
                </li>
                <li>
                    SourceForge - 3,700,000 users
                </li>
            </ol>
            <p>
                As well as many others.
            </p>
        </section>
        <section>
            <p>Here is a comparison of the most popular ones:</p>
            <%-- table programatically in codebehind --%>
            <asp:PlaceHolder runat="server" id="ranking_table"/>
        </section>
    </main>
</asp:Content>