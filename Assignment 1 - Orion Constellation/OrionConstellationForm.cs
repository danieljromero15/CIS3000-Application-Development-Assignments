using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_1___Orion_Constellation
{
    public partial class OrionConstellationForm : Form
    {
        private Label[] _starLabels;
        private bool _labelsShown = false;

        public OrionConstellationForm()
        {
            InitializeComponent();

            // assigning labels to array for use in
            _starLabels = new[]
            {
                MeissaLabel,
                MintakaLabel,
                AlnilamLabel,
                AlnitakLabel,
                SaiphLabel,
                RigelLabel,
                BetelgeuseLabel,
            };
        }

        private void showStarNamesButton_Click(object sender, EventArgs e)
        {
            if (!_labelsShown) toggleStarNamesButton_Click(null, null);
        }

        private void hideStarNamesButton_Click(object sender, EventArgs e)
        {
            if (_labelsShown) toggleStarNamesButton_Click(null, null);
        }

        private void toggleStarNamesButton_Click(object sender, EventArgs e)
        {
            foreach (var star in _starLabels)
            {
                star.Visible = !star.Visible;
                _labelsShown = star.Visible;
            }

            //Console.WriteLine(_labelsShown.ToString());
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}