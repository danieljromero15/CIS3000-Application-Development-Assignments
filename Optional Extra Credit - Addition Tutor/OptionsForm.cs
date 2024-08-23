// Programmer: Daniel Romero
// Class: CIS 3000 Fall 2024
// Program Purpose: Settings page for the Addition Tutor

using System;
using System.Windows.Forms;

namespace Optional_Extra_Credit___Addition_Tutor
{
    public partial class OptionsForm : Form
    {
        // initializes variable that we store the parent page in
        private readonly AdditionTutor _additionTutor;

        // settings page initialization, takes parent page as a parameter
        public OptionsForm(AdditionTutor additionTutor)
        {
            InitializeComponent();
            _additionTutor = additionTutor;

            // gets the current timer status from parent page, includes number and whether it's on
            var timerStatus = _additionTutor.GetTimer();

            // sets timer to the previous amount so it doesn't revert to default
            timerTextBox.Text = timerStatus.Item1.ToString();

            //Console.WriteLine(timerStatus.Item2);
            // sets radio button based on timer status
            if (timerStatus.Item2)
            {
                timerButton.Checked = true;
            }
            else
            {
                buttonButton.Checked = true;
            }
        }

        // runs when the timer button is checked, it sets timer to value in text box and enables timer mode
        private void timerButton_CheckedChanged(object sender, EventArgs e)
        {
            timerTextBox.Enabled = timerButton.Checked;
            if (timerTextBox.Text.Length != 0)
                _additionTutor.SetTimer(int.Parse(timerTextBox.Text), true);
        }

        // runs when value is changed, sets timer to value and enables timer mode (text box can only be edited in timer mode anyway, but just in case)
        private void timerTextBox_TextChanged(object sender, EventArgs e)
        {
            //Console.WriteLine(timerTextBox.Text);
            if (timerTextBox.Text.Length != 0)
                _additionTutor.SetTimer(int.Parse(timerTextBox.Text), true);
        }

        // prevents non-numbers to be inputted into the timer field
        private void timerTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // a non-number was pressed, does nothing
                e.Handled = true;
            }
        }

        // disables timer when button mode is selected
        private void buttonButton_CheckedChanged(object sender, EventArgs e)
        {
            if (timerTextBox.Text.Length == 0) timerTextBox.Text = "0";
            _additionTutor.SetTimer(int.Parse(timerTextBox.Text), false);
        }

        // runs when the settings are closed, enables or disables next question button
        private void OptionsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _additionTutor.EnableNextQuestionButton(buttonButton.Checked);
        }
    }
}