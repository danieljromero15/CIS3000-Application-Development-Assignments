// Programmer: Daniel Romero
// Class: CIS 3000 Fall 2024
// Program Purpose: Convert Imperial Units

using System;
using System.Windows.Forms;

namespace Optional_Extra_Credit___Distance_Converter
{
    public partial class DistanceConverterForm : Form
    {
        // amazing variable names, I know
        // constant variables to multiply and divide by
        private const int FeetFactor = 12;
        private const int YardFactor = 3;

        public DistanceConverterForm()
        {
            InitializeComponent();
        }

        // exit button
        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        // prevents non-numbers from being inputted into text boxes
        // should be added to _KeyPress functions with ref e as the parameter
        private static void PreventNonNumbers(ref KeyPressEventArgs e, bool isDecimal = true)
        {
            var isNonDigit = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
            var isDecimalPoint = e.KeyChar == '.';

            if ((isNonDigit && !isDecimal) || (isNonDigit && !isDecimalPoint))
            {
                // a non-number was pressed, does nothing
                e.Handled = true;
            }
        }

        // prevents non-numbers to be inputted into distanceToConvert
        private void distanceToConvertTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            PreventNonNumbers(ref e);
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            // checks if the value in the text box is a valid number, stops program if it's not
            // should only happen with multiple decimal points
            if (!double.TryParse(distanceToConvertTextBox.Text, out var inputValue))
            {
                MessageBox.Show("Please enter a valid number");
                return;
            }

            // checks from box and converts to inches
            switch (fromListBox.SelectedIndex)
            {
                case -1:
                    MessageBox.Show("Please enter a value in the From Box");
                    break;
                case 1:
                    inputValue = inputValue * FeetFactor;
                    break;
                case 2:
                    inputValue = inputValue * YardFactor * FeetFactor;
                    break;
            }

            // checks to box and converts from inches to specified unit
            var outputValue = inputValue;
            switch (toListBox.SelectedIndex)
            {
                case -1:
                    MessageBox.Show("Please enter a value in the To Box");
                    break;
                case 1:
                    outputValue = inputValue / FeetFactor;
                    break;
                case 2:
                    outputValue = inputValue / (YardFactor * FeetFactor);
                    break;
            }

            convertedDistanceResultLabel.Text = outputValue.ToString() + " " + toListBox.Text;
        }
    }
}