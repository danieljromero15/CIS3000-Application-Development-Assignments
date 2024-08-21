// Programmer: Daniel Romero
// Class: CIS 3000 Fall 2024
// Program Purpose: To calculate the total price of registration and lodging for a specified workshop

using System;
using System.Windows.Forms;

namespace Assignment_2___Workshop_Selector
{
    public partial class WorkshopSelector : Form
    {
        // Struct for workshop info to make data easier to parse without having to do string methods
        private struct Workshops
        {
            public readonly string Name;
            public readonly int Length;
            public readonly int Price;

            public Workshops(string name, int length, int price)
            {
                Name = name;
                Length = length;
                Price = price;
            }
        }

        // Struct for Location info
        private struct Locations
        {
            public readonly string Name;
            public readonly int Price;

            public Locations(string name, int price)
            {
                Name = name;
                Price = price;
            }
        }

        // defines workshop names, lengths in days, and prices
        private readonly Workshops[] _workshops =
        {
            new Workshops("Handling Stress", 3, 1000),
            new Workshops("Time Management", 3, 800),
            new Workshops("Supervision Skills", 3, 1500),
            new Workshops("Negotiation", 5, 1300),
            new Workshops("How to Interview", 1, 500),
        };

        // defines locations and their prices per day
        private readonly Locations[] _locations =
        {
            new Locations("Austin", 150),
            new Locations("Chicago", 225),
            new Locations("Dallas", 175),
            new Locations("Orlando", 300),
            new Locations("Phoenix", 175),
            new Locations("Raleigh", 150),
        };

        // initializes program, adds workshops and locations into their respective info boxes
        public WorkshopSelector()
        {
            InitializeComponent();

            // Adds all workshop info into box
            foreach (var workshop in _workshops)
            {
                WorkshopBox.Items.Add($"{workshop.Name}\t{workshop.Length} {DayPlural(workshop.Length)}\t${workshop.Price:N0}");
            }

            foreach (var location in _locations)
            {
                LocationBox.Items.Add($"{location.Name}\t${location.Price:N0}");
            }
        }

        // simple method to return either 'day' or 'days' depending on the number of days
        private static string DayPlural(int numOfDays)
        {
            if(numOfDays == 1) return "day";
            return "days";
        }

        // Exit Button, closes program
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Runs calculation and puts it into the box
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            ResultsField.Text = "";
            //Console.WriteLine($"{WorkshopBox.SelectedIndex} {LocationBox.SelectedIndex}");
            if (WorkshopBox.SelectedIndex != -1 && LocationBox.SelectedIndex != -1)
            {
                var selectedWorkshop = _workshops[WorkshopBox.SelectedIndex];
                var selectedLocation = _locations[LocationBox.SelectedIndex];

                var locPrice = selectedLocation.Price;
                var workPrice = selectedWorkshop.Price;
                
                ResultsField.Text += $"Registration: ${workPrice:N0}";
                ResultsField.Text += $"\nLodging: ${locPrice:N0} \u00d7 {selectedWorkshop.Length} {DayPlural(selectedWorkshop.Length)} = ${(locPrice * selectedWorkshop.Length):N0}";
                ResultsField.Text += $"\nTotal: ${(workPrice + (locPrice * selectedWorkshop.Length)):N0}";
            }
            else
            {
                ResultsField.Text = "Please select a workshop and location";
            }
        }
    }
}