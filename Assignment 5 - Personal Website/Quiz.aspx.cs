using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_5___Personal_Website
{
    public partial class Quiz : Page
    {
        private IQuestion _currentQuestion;
        protected const int CurrentQuestionNum = 1;

        private interface IQuestion
        {
            public void CreateQuestion();
            public dynamic GetSelectedAnswer(); // answer can be either int or string I think
            public bool CheckAnswer(string selectedAnswer); // checks int or string against answers[0]

            public bool CheckAnswer(); // checks int or string against answers[0]
            //public string ToString(); // needs to have a ToString
        }

        // answers are sorted randomly, answers[0] is the correct one
        public class QuestionMultipleChoice : IQuestion
        {
            private readonly RadioButtonList _rbl;
            private readonly string _question;
            private readonly string[] _answers;
            private readonly PlaceHolder _placeHolder;

            public QuestionMultipleChoice(ref PlaceHolder placeHolder, string question, string[] answers)
            {
                _question = question;
                _answers = answers;
                _placeHolder = placeHolder;

                _rbl = new RadioButtonList();
                CreateQuestion();
            }

            public void CreateQuestion()
            {
                _placeHolder.Controls.Add(new Label { Text = _question });

                foreach (var answer in _answers)
                {
                    _rbl.Items.Add(new ListItem(answer));
                }

                _placeHolder.Controls.Add(_rbl);
            }

            public dynamic GetSelectedAnswer()
            {
                return _rbl.SelectedItem.Text;
            }

            public bool CheckAnswer()
            {
                return GetSelectedAnswer() == _answers[0];
            }

            public bool CheckAnswer(string selectedAnswer)
            {
                return selectedAnswer == _answers[0];
            }
        }

        public class QuestionFillInTheBlank
        {
            // TODO inherit interface, implement methods
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            // TODO add more questions, add switching between them
            _currentQuestion =
                new QuestionMultipleChoice(ref questionPlaceHolder, "How old am I?", ["1", "2", "3", "4"]);
        }

        protected void submitButton_OnClick(object sender, EventArgs e)
        {
            // TODO add logic for correct and incorrect answers, and add popup for next question
            resultLabel.Text = _currentQuestion.CheckAnswer().ToString();
        }
    }
}