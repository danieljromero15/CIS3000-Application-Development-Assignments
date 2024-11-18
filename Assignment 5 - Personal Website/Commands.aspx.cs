using System;
using System.Web.UI;

namespace Assignment_5___Personal_Website
{
    public partial class Commands : Page
    {
        private readonly struct Command(string arg, string description = "")
        {
            private string Args { get; } = "git " + arg;
            private string Description { get; } = description;

            public override string ToString()
            {
                return $"<code>{Args}</code><br>&emsp;{Description}";
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
                new("add", "This command "),
                new("commit"),
                new("status"),
                new("push"),
                new("reset"),
                new("revert"),
                new("branch"),
            ];

            foreach (var command in listElems)
            {
                commandList.InnerHtml += $"<li>{command.ToString()}</li>";
            }
        }
    }
}