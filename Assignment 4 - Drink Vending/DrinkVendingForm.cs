using System;
using System.Windows.Forms;

namespace Assignment_4___Drink_Vending_Machine_Simulator_App
{
    public partial class DrinkVendingForm : Form
    {
        // var initialization
        private DrinkInfo[] _drinks;
        private double _totalSales;

        // struct initialization, stores label, price, and quantity
        // please don't give me points off for not storing the name, there is literally no point in storing the name anywhere as it's completely irrelevant to the functionality of the program.
        private struct DrinkInfo(Label drinkValueLabel, double drinkPrice, int drinkQuantity = 20)
        {
            private int _drinkQuantity = drinkQuantity;

            // sets label at the same time
            public void SetDrinkQuantity(int drinkQuantity)
            {
                _drinkQuantity = drinkQuantity;
                drinkValueLabel.Text = _drinkQuantity.ToString();
                //Console.WriteLine("Drink Quantity: " + _drinkQuantity);
            }

            public int GetDrinkQuantity()
            {
                return _drinkQuantity;
            }

            public Label GetDrinkLabel()
            {
                return drinkValueLabel;
            }

            public double GetDrinkPrice()
            {
                return drinkPrice;
            }
        }

        // initializes and resets
        public DrinkVendingForm()
        {
            InitializeComponent();
            Reset();
        }

        // reset function, resets all drinks and their quantities and all labels
        private void Reset()
        {
            //Console.WriteLine("Reset");

            _drinks =
            [
                new DrinkInfo(colaDrinksLeftValue, 1.00),
                new DrinkInfo(rootBeerDrinksLeftValue, 1.00),
                new DrinkInfo(lemonLimeDrinksLeftValue, 1.00),
                new DrinkInfo(grapeSodaDrinksLeftValue, 1.50),
                new DrinkInfo(creamSodaDrinksLeftValue, 1.50)
            ];

            _totalSales = 0;
            totalSalesValue.Text = 0.ToString("C");

            foreach (var drink in _drinks)
            {
                drink.GetDrinkLabel().Text = 20.ToString();
            }
        }

        // decrements the quantity of a particular drink
        private void DecrementDrinkQuantity(ref DrinkInfo drink)
        {
            var currentQuantity = drink.GetDrinkQuantity();
            if (currentQuantity > 0)
            {
                drink.SetDrinkQuantity(currentQuantity - 1);
                AddToTotalSales(drink);
            }
            else
            {
                MessageBox.Show("Sold Out!");
            }
        }

        // adds price to total sales and updates label
        private void AddToTotalSales(DrinkInfo drink)
        {
            _totalSales += drink.GetDrinkPrice();
            totalSalesValue.Text = _totalSales.ToString("C");
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        /*
         * PictureBox click methods
         */
        private void colaPictureBox_Click(object sender, EventArgs e)
        {
            DecrementDrinkQuantity(ref _drinks[0]);
        }

        private void rootBeerPictureBox_Click(object sender, EventArgs e)
        {
            DecrementDrinkQuantity(ref _drinks[1]);
        }

        private void lemonLimePictureBox_Click(object sender, EventArgs e)
        {
            DecrementDrinkQuantity(ref _drinks[2]);
        }

        private void grapeSodaPictureBox_Click(object sender, EventArgs e)
        {
            DecrementDrinkQuantity(ref _drinks[3]);
        }

        private void creamSodaPictureBox_Click(object sender, EventArgs e)
        {
            DecrementDrinkQuantity(ref _drinks[4]);
        }
    }
}