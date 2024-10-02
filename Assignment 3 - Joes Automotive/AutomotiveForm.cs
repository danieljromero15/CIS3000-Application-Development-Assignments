// Programmer: Daniel Romero
// Class: CIS 3000 Fall 2024
// Program Purpose: To calculate the price of routine maintenance

using System;
using System.Globalization;
using System.Windows.Forms;

namespace Assignment_3___Joes_Automotive
{
    public partial class AutomotiveForm : Form
    {
        // Initializes form
        public AutomotiveForm()
        {
            InitializeComponent();
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

        // checks if the checkbox is checked, if it's checked it returns the appropriate value otherwise it returns 0 (doesn't matter since it's addition)
        private static double ReturnValueIfChecked(CheckBox checkBox)
        {
            if (checkBox.Checked)
            {
                // AccessibleDescription contains the prices as doubles
                return double.Parse(checkBox.AccessibleDescription);
            }

            return 0;
        }

        // returns the sum of multiple checkboxes (if they're checked)
        private static double ReturnSumOfChecked(CheckBox[] checkBoxes)
        {
            double sum = 0;
            foreach (var checkBox in checkBoxes)
            {
                sum += ReturnValueIfChecked(checkBox);
            }

            return sum;
        }

        // Returns the total charges for an oil change and/or a lube job, if any
        private double OilLubeCharges()
        {
            return ReturnSumOfChecked([oilChangeCheck, lubeCheck]);
        }

        // Returns the total charges for a radiator flush and/or a transmission flush, if any
        private double FlushCharges()
        {
            return ReturnSumOfChecked([radiatorCheck, transmissionCheck]);
        }

        // Returns the total charges for an inspection, muffler replacement, and/or a tire rotation, if any
        private double MiscCharges()
        {
            return ReturnSumOfChecked([inspectionCheck, mufflerCheck, tireRotationCheck]);
        }

        // Returns the total charges for other services (parts and labor), if any
        private double[] OtherCharges()
        {
            // returns 0 if it can't parse afaik, but shouldn't happen unless multiple periods are inputted
            double.TryParse(partsTextBox.Text, out var parts);
            double.TryParse(laborTextBox.Text, out var labor);
            // labor is in hours, $20 per hour. multiply by parts
            // oh i guess not? requirements changed...
            // please excuse messy fix, change in requirements doesn't match textbook
            return [parts, labor];
        }

        // Returns the amount of sales tax, if any. Sales tax is 6% and is charged only on parts. If the customer purchases services only, no sales tax is charged
        private double TaxCharges()
        {
            return OtherCharges()[0] * 0.06;
        }

        // Returns the total charges
        private double TotalCharges()
        {
            return OilLubeCharges() + FlushCharges() + MiscCharges() + OtherCharges()[1] + TaxCharges();
        }

        // Clears the checkboxes for oil change and lube job
        private void ClearOilLube()
        {
            oilChangeCheck.Checked = false;
            lubeCheck.Checked = false;
        }

        // Clears the checkboxes for radiator flush and transmission flush
        private void ClearFlushes()
        {
            radiatorCheck.Checked = false;
            transmissionCheck.Checked = false;
        }

        // Clears the checkboxes for inspection, muffler replacement, and tire rotation
        private void ClearMisc()
        {
            inspectionCheck.Checked = false;
            mufflerCheck.Checked = false;
            tireRotationCheck.Checked = false;
        }

        // Clears the text boxes for parts and labor
        private void ClearOther()
        {
            partsTextBox.Clear();
            laborTextBox.Clear();
        }

        // Clears the labels that display the labels in the section marked Summary
        private void ClearFees()
        {
            serviceAndLaborResultsLabel.Text = "";
            partsSummaryResultsLabel.Text = "";
            taxResultsLabel.Text = "";
            totalResultsLabel.Text = "";
        }

        // runs all clear functions
        private void ClearAll()
        {
            ClearOilLube();
            ClearFlushes();
            ClearMisc();
            ClearOther();
            ClearFees();
        }

        // runs clear all when button is pressed
        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        // Exit Button
        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        // prevents non-numbers from being inputted into the parts text box
        private void partsTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            PreventNonNumbers(ref e);
        }

        // prevents non-numbers and periods from being inputted into the parts text box
        private void laborTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            PreventNonNumbers(ref e);
        }

        // calculation
        private void calculateButton_Click(object sender, EventArgs e)
        {
            // calculates results
            serviceAndLaborResultsLabel.Text =
                ToCurrency(OilLubeCharges() + FlushCharges() + MiscCharges() + OtherCharges()[1]);
            partsSummaryResultsLabel.Text = ToCurrency(OtherCharges()[0]);
            taxResultsLabel.Text = ToCurrency(TaxCharges());
            totalResultsLabel.Text = ToCurrency(TotalCharges());

            // explicit return due to local function
            return;

            // returns currency double as a US currency string
            string ToCurrency(double amount)
            {
                return amount.ToString("C", CultureInfo.CreateSpecificCulture("en-US"));
            }
        }
    }
}