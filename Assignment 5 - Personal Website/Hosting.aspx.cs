using System;
using System.Web.UI;
using System.Web.UI.HtmlControls;

namespace Assignment_5___Personal_Website;

public partial class Hosting : Page
{
    private readonly struct HostingService(
        string name,
        string developerName,
        int numUsers,
        bool openSource,
        bool free,
        string notes = "")
    {
        // lists properties for header
        private static readonly string[] Properties =
            ["Name", "Developer", "Number of Users", "Open-source framework?", "Free Server Hosting?", "Notes"];

        private string Name => name;
        private string DeveloperName => developerName;
        private int NumUsers => numUsers;
        private bool OpenSource => openSource;
        private bool Free => free;
        private string Notes => notes;

        // converts object to tablerow
        public HtmlTableRow ToHtmlTableRow()
        {
            var tr = new HtmlTableRow();
            tr.Attributes.Add("style", "border: 1px solid white;"); // why doesn't HtmlTableRow have a Border property???
            tr.Cells.Add(new HtmlTableCell { InnerText = Name });
            tr.Cells.Add(new HtmlTableCell { InnerText = DeveloperName });
            tr.Cells.Add(new HtmlTableCell { InnerText = $"{NumUsers:N0} Users" });
            tr.Cells.Add(new HtmlTableCell { InnerText = OpenSource ? "Yes" : "No" });
            tr.Cells.Add(new HtmlTableCell { InnerText = Free ? "Yes" : "No" });
            tr.Cells.Add(new HtmlTableCell { InnerText = Notes });
            return tr;
        }

        // converts header to header row
        public static HtmlTableRow PropertiesToHtmlTableRow()
        {
            var tr = new HtmlTableRow();
            foreach (var property in Properties)
            {
                tr.Cells.Add(new HtmlTableCell { InnerText = property });
            }

            return tr;
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        var table = new HtmlTable();

        table.Border = 2;
        table.BorderColor = "White";
        table.CellPadding = 5;

        // adds header rows from struct properties
        table.Rows.Add(HostingService.PropertiesToHtmlTableRow());

        // initializes table array
        HostingService[] hostingServices =
        [
            new(name: "GitHub", developerName: "GitHub, Inc. (Bought by Microsoft)", numUsers: 94000000, openSource: false, free: true,
                notes: "By far the most popular. A great place to get started!"),
            new(name: "GitLab", developerName: "GitLab Inc.", numUsers: 31190000, openSource: true, free: true, notes: "Probably the second most popular, if it's not on GitHub, it's usually on GitLab."),
            new(name: "BitBucket", developerName: "Atlassian", numUsers: 5000000, openSource:false, free: false, notes:"Notably for use with Jira, Atlassian's project management software"),
            new(name: "SourceForge", developerName: "Slashdot Media", numUsers: 3700000, openSource:true, free: true, notes: "Falling out of popularity. Ad-supported.")
        ];

        // adds to table based on array
        foreach (var service in hostingServices)
        {
            table.Rows.Add(service.ToHtmlTableRow());
        }

        ranking_table.Controls.Add(table);
    }
}