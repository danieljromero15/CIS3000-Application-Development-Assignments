using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_3___Joe_s_Automotive_App
{
    public partial class AutomotiveForm : Form
    {
        public AutomotiveForm()
        {
            InitializeComponent();
            Console.WriteLine(OtherCharges());
        }

        // prevents non-numbers from being inputted into text boxes
        private static void PreventNonNumbers(ref KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                // a non-number was pressed, does nothing
                e.Handled = true;
            }
        }

        private static double ReturnValueIfChecked(CheckBox checkBox)
        {
            if (checkBox.Checked)
            {
                return double.Parse(checkBox.AccessibleDescription);
            }
            return 0;
        }

        private static double ReturnValuesIfChecked(CheckBox[] checkBoxes)
        {
            double sum = 0;
            foreach (var checkBox in checkBoxes)
            {
                sum += ReturnValueIfChecked(checkBox);
            }

            return sum;
        }

        private double OilLubeCharges()
        {
            return ReturnValuesIfChecked([oilChangeCheck, lubeCheck]);
        }

        private double FlushCharges()
        {
            return ReturnValuesIfChecked([radiatorCheck, transmissionCheck]);
        }

        private double MiscCharges()
        {
            return ReturnValuesIfChecked([inspectionCheck, mufflerCheck, tireRotationCheck]);
        }

        private double OtherCharges()
        {
            // returns 0 if it can't parse afaik
            double.TryParse(partsTextBox.Text, out var parts);
            double.TryParse(laborTextBox.Text, out var labor);
            // not 100% sure it's supposed to be multiplication but the description isn't very descriptive
            return parts + labor;
        }

        private double TaxCharges()
        {
            return OtherCharges() * 0.06;
        }

        private double TotalCharges()
        {
            return OilLubeCharges() + FlushCharges() + MiscCharges() + OtherCharges() + TaxCharges();
        }

        private void ClearOilLube()
        {
            oilChangeCheck.Checked = false;
            lubeCheck.Checked = false;
        }

        private void ClearFlushes()
        {
            radiatorCheck.Checked = false;
            transmissionCheck.Checked = false;
        }

        private void ClearMisc()
        {
            inspectionCheck.Checked = false;
            mufflerCheck.Checked = false;
            tireRotationCheck.Checked = false;
        }

        private void ClearOther()
        {
            partsTextBox.Clear();
            laborTextBox.Clear();
        }

        private void ClearFees()
        {
            serviceAndLaborTextBox.Clear();
            partsSummaryTextBox.Clear();
            taxTextBox.Clear();
            totalTextBox.Clear();
        }

        private void ClearAll()
        {
            ClearOilLube();
            ClearFlushes();
            ClearMisc();
            ClearOther();
            ClearFees();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void partsTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            PreventNonNumbers(ref e);
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            serviceAndLaborTextBox.Text = ToCurrency(OilLubeCharges() + FlushCharges() + MiscCharges());
            partsSummaryTextBox.Text = ToCurrency(OtherCharges());
            taxTextBox.Text = ToCurrency(TaxCharges());
            totalTextBox.Text = ToCurrency(TotalCharges());

            return;

            string ToCurrency(double amount)
            {
                return amount.ToString("C", CultureInfo.CreateSpecificCulture("en-US"));
            }
        }

        private void laborTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            PreventNonNumbers(ref e);
        }
    }
}
