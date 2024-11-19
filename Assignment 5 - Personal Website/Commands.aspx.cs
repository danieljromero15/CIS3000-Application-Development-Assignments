using System;
using System.Web.UI;

namespace Assignment_5___Personal_Website;

public partial class Commands : Page
{
    // list element structure, adds 'git' to the args str
    private readonly struct Command(string arg, string description = "")
    {
        private string Args { get; } = "git " + arg;
        private string Description { get; } = description;

        // returns string formatted in html
        public override string ToString()
        {
            return $"<code>{Args}</code><br>{Description}";
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        Command[] listElems =
        [
            new("init",
                "Use this to start a new Git repository! This should almost always be the first step!"),
            new("clone",
                "This command creates a copy of an existing Git repository, whether it comes from GitHub, another computer, or any other source."),
            new("pull", "This command pulls the latest changes from your remote repository, in our case GitHub."),
            new("add",
                "This command adds the specified files to the Git repository. You can use <code>git add .</code> to add all files in the directory."),
            new("commit",
                "This command commits all your changes to a commit, essentially a snapshot of the repository at that point in time."),
            new("status",
                "This command shows the current status of the Git repository, including any pending commits to be uploaded to the remote. It also shows any pending changes that are not yet committed."),
            new("push", "This command pushes the latest changes to the remote repository."),
            new("reset",
                "This command resets any uncommited changes. Say you make a mistake in a certain file, this can be used to revert that specific file back to the last commit."),
            new("revert",
                "This command allows you to revert any commits, whether they contain faulty or bad code or for any other reason. It differs from reset because reset changes files, revert changes commits."),
            new("branch",
                "This command allows you to change branches, one of the most powerful features of Git. Branches allow you to keep multiple versions of the same code within the same repository, either to have multiple people work on the same code or to develop a version that may not need to be in the main branch. There are many different ways of using branches.")
        ];

        foreach (var command in listElems) // adds list elements to ul programatically
        {
            commandList.InnerHtml += $"<li>{command.ToString()}</li>";
        }
    }
}