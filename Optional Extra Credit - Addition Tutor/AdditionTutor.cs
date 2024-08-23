// Programmer: Daniel Romero
// Class: CIS 3000 Fall 2024
// Program Purpose: To provide simple addition problems

using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Optional_Extra_Credit___Addition_Tutor
{
    public partial class AdditionTutor : Form
    {
        // inits variables and settings vars
        private int _num1, _num2, _answer;
        private int _timer = 3;
        private bool _timerEnabled = true;

        // starts program, sets button images since I didn't want to import any, and starts setup
        public AdditionTutor()
        {
            InitializeComponent();

            exitButton.Image = SystemIcons.Error.ToBitmap();
            optionsButton.Image = SystemIcons.Information.ToBitmap();

            Setup();
        }

        // Setup function, it's really more of a NewGame
        // Resets answer box, removes "Correct" or "Try again". Generates random numbers and assigns them
        private void Setup()
        {
            answerTextBox.Text = "";
            responseLabel.Visible = false;

            // random num generator
            var random = new Random();
            _num1 = random.Next(100, 501);
            _num2 = random.Next(100, 501);
            _answer = _num1 + _num2;
            // Prints answer to console for cheating/debugging purposes
            Console.WriteLine($"{_num1} + {_num2} = {_answer}");

            // assigns random numbers to labels
            num1Label.Text = _num1.ToString();
            num2Label.Text = _num2.ToString();
        }

        // code for key presses within text box
        private async void answerTextBox_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            //Console.WriteLine(_timerEnabled);
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // a non-number was pressed, does nothing
                e.Handled = true;
            }
            else if (e.KeyChar == (char)Keys.Return)
            {
                //Enter pressed
                if (answerTextBox.Text == _answer.ToString())
                {
                    responseLabel.Text = "Correct!";
                    responseLabel.ForeColor = Color.Green;
                }
                else
                {
                    responseLabel.Text = "Try again!";
                    responseLabel.ForeColor = Color.Red;
                }

                // sets responselabel to be visible regardless of correct or not
                responseLabel.Visible = true;

                // if timer is not enabled, stop here. Else, start timer then restart
                if (!_timerEnabled)
                {
                    return;
                }

                await Task.Delay(_timer * 1000);

                Setup();
            }
        }

        // sets timer and boolean variables for settings page usage
        public void SetTimer(int time, bool timerEnabled)
        {
            _timer = time;
            _timerEnabled = timerEnabled;
        }

        // returns timer and timer enabled status for settings page
        public (int, bool) GetTimer()
        {
            return (_timer, _timerEnabled);
        }

        // closes program
        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        // starts a new optionsform and opens it
        private void optionsButton_Click(object sender, EventArgs e)
        {
            var optionsForm = new OptionsForm(this);
            optionsForm.Show();
        }

        // runs whenever settings page is closed, sets next question button and label size
        public void EnableNextQuestionButton(bool enabled)
        {
            if (enabled)
            {
                NextQuestionButton.Visible = true;
                responseLabel.Size = new Size(113, 24);
            }
            else
            {
                NextQuestionButton.Visible = false;
                responseLabel.Size = new Size(140, 24);
            }
        }

        // runs when you click the next question button, generates new question
        // this has the unintended side effect that button mode is better because you can skip questions
        private void NextQuestionButton_Click(object sender, EventArgs e)
        {
            Setup();
        }
    }
}