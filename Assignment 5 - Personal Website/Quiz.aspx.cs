using System;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_5___Personal_Website;

public partial class Quiz : Page
{
    private QuestionBase _currentQuestion;
    private static PlaceHolder _qPlaceHolder;
    protected const int CurrentQuestionNum = 1;

    public abstract class QuestionBase(string question)
    {
        protected readonly string Question = question;
        protected readonly PlaceHolder PlaceHolder = _qPlaceHolder;
        protected string Answer;

        protected abstract void CreateQuestion();
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

        public QuestionMultipleChoice(string question, string[] answers) : base(
            question)
        {
            _answers = answers;
            Answer = _answers[0];

            _rbl = new RadioButtonList();
            CreateQuestion();
        }

        protected override void CreateQuestion()
        {
            var randy = new Random();
            PlaceHolder.Controls.Add(new Label { Text = Question });

            var randomAnswers = _answers.OrderBy(_ => randy.Next()).ToArray();
            foreach (var answer in randomAnswers)
            {
                _rbl.Items.Add(new ListItem(answer));
            }

            PlaceHolder.Controls.Add(_rbl);
        }

        protected override string GetSelectedAnswer()
        {
            return _rbl.SelectedItem.Text;
        }
    }

    public sealed class QuestionFillInTheBlank : QuestionBase
    {
        private readonly TextBox _txt;

        public QuestionFillInTheBlank(string question, string answer) : base(question)
        {
            Answer = answer;

            _txt = new TextBox();
            CreateQuestion();
        }

        protected override void CreateQuestion()
        {
            PlaceHolder.Controls.Add(new Label { Text = Question + " " });
            PlaceHolder.Controls.Add(_txt);
        }

        protected override string GetSelectedAnswer()
        {
            return _txt.Text;
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        _qPlaceHolder = questionPlaceHolder;
        // TODO add more questions, add switching between them
        //_currentQuestion = new QuestionMultipleChoice("How old am I?", ["1", "2", "3", "4"]);
        _currentQuestion = new QuestionFillInTheBlank("What command is used to pull from a remote repo?", "git pull");
    }

    protected void submitButton_OnClick(object sender, EventArgs e)
    {
        // TODO add logic for correct and incorrect answers, and add popup for next question
        resultLabel.Text = _currentQuestion.CheckAnswer().ToString();
        Page.Title =
            "Quiz - Intro to GitHub"; // title would reset to just quiz? no idea why that was happening, here's a band-aid
    }
}