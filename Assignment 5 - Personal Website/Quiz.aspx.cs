using System;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_5___Personal_Website;

public partial class Quiz : Page
{
    private QuestionBase _currentQuestion;
    protected static int CurrentQuestionNum;
    private static PlaceHolder _qPlaceHolder;

    private static readonly QuestionBase[] Questions =
    [
        new QuestionFillInTheBlank("What command is used to pull any changes from a remote repo?", "git pull"),
        new QuestionMultipleChoice("Where is a .gitignore file placed?",
        [
            "In the root directory", "In the folder you want to exclude", "In the .git folder",
            "In your Documents folder"
        ]),
        new QuestionMultipleChoice("Who originally created Git?",
            ["Linus Torvalds", "Bill Gates", "Steve Jobs", "Dennis Ritchie"]),
        new QuestionFillInTheBlank("What is the most popular Git hosting platform?", "GitHub"),
        new QuestionFillInTheBlank("What command is used to see the status of a local Git repository?", "git status"),
        new QuestionMultipleChoice("Which command can be used to revert all your changes to the last commit?", ["git reset", "git revert", "git rollback", "git rebase"]),
        new QuestionMultipleChoice("What is an example of the type of file or folder you should exclude as part of your .gitignore?", [".vs", "index.html", "README.MD", "script.js", "style.css"]),
        new QuestionMultipleChoice("What type of software is Git?", ["Free and open-source software (FOSS)", "Proprietary", "Adware", "Freemium", "Abandonware"])
    ];

    public abstract class QuestionBase(string question)
    {
        protected readonly string Question = question;

        //protected readonly PlaceHolder PHolder = _qPlaceHolder;
        protected string Answer;

        public abstract void Create();
        protected abstract string GetSelectedAnswer(); // depends on Control

        public bool CheckAnswer()
        {
            return GetSelectedAnswer() == Answer;
        }

        public bool CheckAnswer(string selectedAnswer)
        {
            return selectedAnswer == Answer;
        }
    }

    // answers are sorted randomly, answers[0] is the correct one
    public sealed class QuestionMultipleChoice : QuestionBase
    {
        private readonly RadioButtonList _rbl;
        private readonly string[] _answers;

        public QuestionMultipleChoice(string question, string[] answers) : base(question)
        {
            _answers = answers;
            Answer = _answers[0];
            _rbl = new RadioButtonList();
            //CreateQuestion();
        }

        public override void Create()
        {
            var randy = new Random();
            _qPlaceHolder.Controls.Clear();
            _qPlaceHolder.Controls.Add(new Label { Text = Question });
            _rbl.Items.Clear();

            var randomAnswers = _answers.OrderBy(_ => randy.Next()).ToArray();
            foreach (var answer in randomAnswers)
            {
                _rbl.Items.Add(answer);
            }

            //foreach (var answer in _answers) _rbl.Items.Add(answer);

            _qPlaceHolder.Controls.Add(_rbl);
        }

        protected override string GetSelectedAnswer()
        {
            return _rbl.SelectedItem != null ? _rbl.SelectedItem.Text : "";
        }
    }

    public sealed class QuestionFillInTheBlank : QuestionBase
    {
        private readonly TextBox _txt;

        public QuestionFillInTheBlank(string question, string answer) : base(question)
        {
            Answer = answer;

            _txt = new TextBox();
            //CreateQuestion();
        }

        public override void Create()
        {
            _qPlaceHolder.Controls.Clear();
            _qPlaceHolder.Controls.Add(new Label { Text = Question + " " });
            _qPlaceHolder.Controls.Add(_txt);
        }

        protected override string GetSelectedAnswer()
        {
            return _txt.Text;
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        _qPlaceHolder = questionPlaceHolder;

        if (CurrentQuestionNum >= Questions.Length - 1)
        {
            nextButton.Visible = false;
        }

        if (CurrentQuestionNum == 0)
        {
            backButton.Visible = false;
        }

        // TODO add more questions, add switching between them
        load_question(CurrentQuestionNum);
    }

    private void load_question(int num)
    {
        _currentQuestion = Questions[num];
        _currentQuestion.Create();
    }

    protected void submitButton_OnClick(object sender, EventArgs e)
    {
        var result = _currentQuestion.CheckAnswer();
        resultLabel.Text = result ? "Correct!" : "Incorrect!";

        // TODO add logic for correct and incorrect answers, and add popup for next question

        //resultLabel.Text = _currentQuestion.CheckAnswer() ? "Correct!" : "Incorrect!";
        Page.Title =
            "Quiz - Intro to GitHub"; // title would reset to just quiz? no idea why that was happening, here's a band-aid
    }

    protected void backButton_OnClick(object sender, EventArgs e)
    {
        CurrentQuestionNum--;
        Response.Redirect(Request.RawUrl);
    }

    protected void nextButton_OnClick(object sender, EventArgs e)
    {
        CurrentQuestionNum++;
        Response.Redirect(Request.RawUrl);
    }
}