<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Assignment_5___Personal_Website._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <section class="row" aria-labelledby="IntroToGitHubTitle">
            <h1 id="IntroToGitHubTitle">Intro to GitHub</h1>
            <p class="lead">Git is a free and open-source version control software used around the world, and helps keep your code organized</p>
        </section>

        <div class="row">
            <section class="col-md-4" aria-labelledby="gettingStartedTitle">
                <h2 id="gettingStartedTitle">Getting started</h2>
                <p>
                    Creating a GitHub repository (or "repo") is really easy! First of all, go to your Command Line or Terminal, and type <code class="nowrap">git --version</code>.
                    If you get a result like <code class="nowrap">git version 2.41.0</code>, congrats! Git is already installed on your computer.
                    If you get an error, you might have to install Git from your package manager, such as <code>winget install --id Git.Git -e --source winget</code> on Windows or <code class="nowrap">sudo apt-get install git</code> on Linux, depending on your package manager.
                </p>
                <p>
                    From there, all you need to do is <code>cd</code> (change directory) into the folder you want to start the repository in, and you type <code>git init</code>.
                    This will start a brand-new Git repository in your folder!
                </p>
                <p>
                    <a class="btn btn-primary" href="https://www.atlassian.com/git/tutorials/install-git">Git install guide from Atlassian &raquo;</a>
                </p>
            </section>
            <section class="col-md-4" aria-labelledby="confusionsTitle">
                <h2 id="confusionsTitle">Common confusions</h2>
                <p>
                    It's important to note that Git and GitHub are not the same thing.
                </p>
                <p>
                    <a href="https://git-scm.com/">Git</a> is a free and open-source software (<a href="https://en.wikipedia.org/wiki/Free_and_open-source_software">FOSS</a>) that helps you keep multiple different versions of your code,
                    originally created by <a href="https://en.wikipedia.org/wiki/Linus_Torvalds">Linus Torvalds</a>,
                    the creator of the Linux operating system, to help keep his own software organized, and is now used by millions of software projects all around the world.
                </p>
                <p>
                    <a href="https://github.com/">GitHub</a> is simply a place where you can upload and view your Git repositories.
                    In fact, this very website is being uploaded to GitHub, available <a href="https://github.com/danieljromero15/CIS3000-Application-Development-Assignments/tree/main/Assignment%205%20-%20Personal%20Website">here</a>!
                    GitHub is currently owned by Microsoft, but it is not the only one of its kind.
                    Other examples include
                    <a href="https://sourceforge.net/">SourceForge</a>,
                    <a href="https://bitbucket.org/product/">BitBucket</a>,
                    and <a href="https://about.gitlab.com/">GitLab</a>.
                </p>
                <!--<p>
                    <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301949">Learn more &raquo;</a>
                </p>-->
            </section>
            <section class="col-md-4" aria-labelledby="hostingTitle">
                <h2 id="hostingTitle">Take a quiz</h2>
                <p>
                    Take a quiz on your Git knowledge!
                </p>
                <p>
                    <a class="btn btn-primary" target="_self" href="Quiz.aspx">Take the quiz &raquo;</a>
                </p>
            </section>
        </div>
    </main>

</asp:Content>