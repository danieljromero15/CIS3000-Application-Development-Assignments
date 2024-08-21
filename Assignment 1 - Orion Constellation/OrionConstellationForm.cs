// Programmer: Daniel Romero
// Class: CIS 3000 Fall 2024
// Program Purpose: To display the Orion constellation and its stars.

using System;
using System.Windows.Forms;

namespace Assignment_1___Orion_Constellation
{
    public partial class OrionConstellationForm : Form
    {
		// Initializes variables
        private readonly Label[] _starLabels;
        private bool _labelsShown;

		// Initializes components and label array
        public OrionConstellationForm()
        {
            InitializeComponent();

            // assigning labels to array for use in loop
            _starLabels =
            [
                MeissaLabel,
                MintakaLabel,
                AlnilamLabel,
                AlnitakLabel,
                SaiphLabel,
                RigelLabel,
                BetelgeuseLabel,
            ];
        }

		// Show stars
        private void showStarNamesButton_Click(object sender, EventArgs e)
        {
            if (!_labelsShown) toggleStarNamesButton_Click(null, null);
        }

		// Hide stars
        private void hideStarNamesButton_Click(object sender, EventArgs e)
        {
            if (_labelsShown) toggleStarNamesButton_Click(null, null);
        }

		// Toggle stars
        private void toggleStarNamesButton_Click(object sender, EventArgs e)
        {
            foreach (var star in _starLabels)
            {
                star.Visible = !star.Visible;
                _labelsShown = star.Visible;
            }

            //Console.WriteLine(_labelsShown.ToString());
        }

		// Closes program
        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}