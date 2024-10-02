namespace Assignment_4___Drink_Vending_Machine_Simulator_App
{
    partial class DrinkVendingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleLabel = new System.Windows.Forms.Label();
            this.colaPanel = new System.Windows.Forms.Panel();
            this.colaDrinksLeftValue = new System.Windows.Forms.Label();
            this.colaDrinksLeftLabel = new System.Windows.Forms.Label();
            this.colaPriceLabel = new System.Windows.Forms.Label();
            this.colaPictureBox = new System.Windows.Forms.PictureBox();
            this.rootBeerPanel = new System.Windows.Forms.Panel();
            this.rootBeerDrinksLeftValue = new System.Windows.Forms.Label();
            this.rootBeerDrinksLeftLabel = new System.Windows.Forms.Label();
            this.rootBeerPriceLabel = new System.Windows.Forms.Label();
            this.rootBeerPictureBox = new System.Windows.Forms.PictureBox();
            this.lemonLimePanel = new System.Windows.Forms.Panel();
            this.lemonLimeDrinksLeftValue = new System.Windows.Forms.Label();
            this.lemonLimeDrinksLeftLabel = new System.Windows.Forms.Label();
            this.lemonLimePriceLabel = new System.Windows.Forms.Label();
            this.lemonLimePictureBox = new System.Windows.Forms.PictureBox();
            this.grapeSodaPanel = new System.Windows.Forms.Panel();
            this.grapeSodaDrinksLeftValue = new System.Windows.Forms.Label();
            this.grapeSodaDrinksLeftLabel = new System.Windows.Forms.Label();
            this.grapeSodaPriceLabel = new System.Windows.Forms.Label();
            this.grapeSodaPictureBox = new System.Windows.Forms.PictureBox();
            this.creamSodaPanel = new System.Windows.Forms.Panel();
            this.creamSodaDrinksLeftValue = new System.Windows.Forms.Label();
            this.creamSodaDrinksLeftLabel = new System.Windows.Forms.Label();
            this.creamSodaPriceLabel = new System.Windows.Forms.Label();
            this.creamSodaPictureBox = new System.Windows.Forms.PictureBox();
            this.totalSalesPanel = new System.Windows.Forms.Panel();
            this.totalSalesValue = new System.Windows.Forms.Label();
            this.totalSalesLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.colaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colaPictureBox)).BeginInit();
            this.rootBeerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rootBeerPictureBox)).BeginInit();
            this.lemonLimePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lemonLimePictureBox)).BeginInit();
            this.grapeSodaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grapeSodaPictureBox)).BeginInit();
            this.creamSodaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.creamSodaPictureBox)).BeginInit();
            this.totalSalesPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(128, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(122, 20);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Select a Drink";
            // 
            // colaPanel
            // 
            this.colaPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.colaPanel.Controls.Add(this.colaDrinksLeftValue);
            this.colaPanel.Controls.Add(this.colaDrinksLeftLabel);
            this.colaPanel.Controls.Add(this.colaPriceLabel);
            this.colaPanel.Controls.Add(this.colaPictureBox);
            this.colaPanel.Location = new System.Drawing.Point(12, 43);
            this.colaPanel.Name = "colaPanel";
            this.colaPanel.Size = new System.Drawing.Size(174, 77);
            this.colaPanel.TabIndex = 1;
            // 
            // colaDrinksLeftValue
            // 
            this.colaDrinksLeftValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colaDrinksLeftValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colaDrinksLeftValue.Location = new System.Drawing.Point(91, 39);
            this.colaDrinksLeftValue.Name = "colaDrinksLeftValue";
            this.colaDrinksLeftValue.Padding = new System.Windows.Forms.Padding(5);
            this.colaDrinksLeftValue.Size = new System.Drawing.Size(73, 28);
            this.colaDrinksLeftValue.TabIndex = 4;
            this.colaDrinksLeftValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // colaDrinksLeftLabel
            // 
            this.colaDrinksLeftLabel.AutoSize = true;
            this.colaDrinksLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colaDrinksLeftLabel.Location = new System.Drawing.Point(91, 23);
            this.colaDrinksLeftLabel.Name = "colaDrinksLeftLabel";
            this.colaDrinksLeftLabel.Size = new System.Drawing.Size(73, 16);
            this.colaDrinksLeftLabel.TabIndex = 3;
            this.colaDrinksLeftLabel.Text = "Drinks Left:";
            // 
            // colaPriceLabel
            // 
            this.colaPriceLabel.AutoSize = true;
            this.colaPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colaPriceLabel.Location = new System.Drawing.Point(100, 3);
            this.colaPriceLabel.Name = "colaPriceLabel";
            this.colaPriceLabel.Size = new System.Drawing.Size(54, 20);
            this.colaPriceLabel.TabIndex = 2;
            this.colaPriceLabel.Text = "$1.00";
            // 
            // colaPictureBox
            // 
            this.colaPictureBox.Image = global::Assignment_4___Drink_Vending_Machine_Simulator_App.Properties.Resources.Cola;
            this.colaPictureBox.Location = new System.Drawing.Point(3, 3);
            this.colaPictureBox.Name = "colaPictureBox";
            this.colaPictureBox.Size = new System.Drawing.Size(64, 64);
            this.colaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.colaPictureBox.TabIndex = 0;
            this.colaPictureBox.TabStop = false;
            this.colaPictureBox.Click += new System.EventHandler(this.colaPictureBox_Click);
            // 
            // rootBeerPanel
            // 
            this.rootBeerPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.rootBeerPanel.Controls.Add(this.rootBeerDrinksLeftValue);
            this.rootBeerPanel.Controls.Add(this.rootBeerDrinksLeftLabel);
            this.rootBeerPanel.Controls.Add(this.rootBeerPriceLabel);
            this.rootBeerPanel.Controls.Add(this.rootBeerPictureBox);
            this.rootBeerPanel.Location = new System.Drawing.Point(192, 43);
            this.rootBeerPanel.Name = "rootBeerPanel";
            this.rootBeerPanel.Size = new System.Drawing.Size(174, 77);
            this.rootBeerPanel.TabIndex = 5;
            // 
            // rootBeerDrinksLeftValue
            // 
            this.rootBeerDrinksLeftValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rootBeerDrinksLeftValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rootBeerDrinksLeftValue.Location = new System.Drawing.Point(91, 39);
            this.rootBeerDrinksLeftValue.Name = "rootBeerDrinksLeftValue";
            this.rootBeerDrinksLeftValue.Padding = new System.Windows.Forms.Padding(5);
            this.rootBeerDrinksLeftValue.Size = new System.Drawing.Size(73, 28);
            this.rootBeerDrinksLeftValue.TabIndex = 4;
            this.rootBeerDrinksLeftValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rootBeerDrinksLeftLabel
            // 
            this.rootBeerDrinksLeftLabel.AutoSize = true;
            this.rootBeerDrinksLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rootBeerDrinksLeftLabel.Location = new System.Drawing.Point(91, 23);
            this.rootBeerDrinksLeftLabel.Name = "rootBeerDrinksLeftLabel";
            this.rootBeerDrinksLeftLabel.Size = new System.Drawing.Size(73, 16);
            this.rootBeerDrinksLeftLabel.TabIndex = 3;
            this.rootBeerDrinksLeftLabel.Text = "Drinks Left:";
            // 
            // rootBeerPriceLabel
            // 
            this.rootBeerPriceLabel.AutoSize = true;
            this.rootBeerPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rootBeerPriceLabel.Location = new System.Drawing.Point(100, 3);
            this.rootBeerPriceLabel.Name = "rootBeerPriceLabel";
            this.rootBeerPriceLabel.Size = new System.Drawing.Size(54, 20);
            this.rootBeerPriceLabel.TabIndex = 2;
            this.rootBeerPriceLabel.Text = "$1.00";
            // 
            // rootBeerPictureBox
            // 
            this.rootBeerPictureBox.Image = global::Assignment_4___Drink_Vending_Machine_Simulator_App.Properties.Resources.RootBeer;
            this.rootBeerPictureBox.Location = new System.Drawing.Point(3, 3);
            this.rootBeerPictureBox.Name = "rootBeerPictureBox";
            this.rootBeerPictureBox.Size = new System.Drawing.Size(64, 64);
            this.rootBeerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.rootBeerPictureBox.TabIndex = 0;
            this.rootBeerPictureBox.TabStop = false;
            this.rootBeerPictureBox.Click += new System.EventHandler(this.rootBeerPictureBox_Click);
            // 
            // lemonLimePanel
            // 
            this.lemonLimePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lemonLimePanel.Controls.Add(this.lemonLimeDrinksLeftValue);
            this.lemonLimePanel.Controls.Add(this.lemonLimeDrinksLeftLabel);
            this.lemonLimePanel.Controls.Add(this.lemonLimePriceLabel);
            this.lemonLimePanel.Controls.Add(this.lemonLimePictureBox);
            this.lemonLimePanel.Location = new System.Drawing.Point(12, 126);
            this.lemonLimePanel.Name = "lemonLimePanel";
            this.lemonLimePanel.Size = new System.Drawing.Size(174, 77);
            this.lemonLimePanel.TabIndex = 6;
            // 
            // lemonLimeDrinksLeftValue
            // 
            this.lemonLimeDrinksLeftValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lemonLimeDrinksLeftValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lemonLimeDrinksLeftValue.Location = new System.Drawing.Point(91, 39);
            this.lemonLimeDrinksLeftValue.Name = "lemonLimeDrinksLeftValue";
            this.lemonLimeDrinksLeftValue.Padding = new System.Windows.Forms.Padding(5);
            this.lemonLimeDrinksLeftValue.Size = new System.Drawing.Size(73, 28);
            this.lemonLimeDrinksLeftValue.TabIndex = 4;
            this.lemonLimeDrinksLeftValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lemonLimeDrinksLeftLabel
            // 
            this.lemonLimeDrinksLeftLabel.AutoSize = true;
            this.lemonLimeDrinksLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lemonLimeDrinksLeftLabel.Location = new System.Drawing.Point(91, 23);
            this.lemonLimeDrinksLeftLabel.Name = "lemonLimeDrinksLeftLabel";
            this.lemonLimeDrinksLeftLabel.Size = new System.Drawing.Size(73, 16);
            this.lemonLimeDrinksLeftLabel.TabIndex = 3;
            this.lemonLimeDrinksLeftLabel.Text = "Drinks Left:";
            // 
            // lemonLimePriceLabel
            // 
            this.lemonLimePriceLabel.AutoSize = true;
            this.lemonLimePriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lemonLimePriceLabel.Location = new System.Drawing.Point(100, 3);
            this.lemonLimePriceLabel.Name = "lemonLimePriceLabel";
            this.lemonLimePriceLabel.Size = new System.Drawing.Size(54, 20);
            this.lemonLimePriceLabel.TabIndex = 2;
            this.lemonLimePriceLabel.Text = "$1.00";
            // 
            // lemonLimePictureBox
            // 
            this.lemonLimePictureBox.Image = global::Assignment_4___Drink_Vending_Machine_Simulator_App.Properties.Resources.LemonLime;
            this.lemonLimePictureBox.Location = new System.Drawing.Point(3, 3);
            this.lemonLimePictureBox.Name = "lemonLimePictureBox";
            this.lemonLimePictureBox.Size = new System.Drawing.Size(62, 64);
            this.lemonLimePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.lemonLimePictureBox.TabIndex = 0;
            this.lemonLimePictureBox.TabStop = false;
            this.lemonLimePictureBox.Click += new System.EventHandler(this.lemonLimePictureBox_Click);
            // 
            // grapeSodaPanel
            // 
            this.grapeSodaPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grapeSodaPanel.Controls.Add(this.grapeSodaDrinksLeftValue);
            this.grapeSodaPanel.Controls.Add(this.grapeSodaDrinksLeftLabel);
            this.grapeSodaPanel.Controls.Add(this.grapeSodaPriceLabel);
            this.grapeSodaPanel.Controls.Add(this.grapeSodaPictureBox);
            this.grapeSodaPanel.Location = new System.Drawing.Point(192, 126);
            this.grapeSodaPanel.Name = "grapeSodaPanel";
            this.grapeSodaPanel.Size = new System.Drawing.Size(174, 77);
            this.grapeSodaPanel.TabIndex = 7;
            // 
            // grapeSodaDrinksLeftValue
            // 
            this.grapeSodaDrinksLeftValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grapeSodaDrinksLeftValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grapeSodaDrinksLeftValue.Location = new System.Drawing.Point(91, 39);
            this.grapeSodaDrinksLeftValue.Name = "grapeSodaDrinksLeftValue";
            this.grapeSodaDrinksLeftValue.Padding = new System.Windows.Forms.Padding(5);
            this.grapeSodaDrinksLeftValue.Size = new System.Drawing.Size(73, 28);
            this.grapeSodaDrinksLeftValue.TabIndex = 4;
            this.grapeSodaDrinksLeftValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grapeSodaDrinksLeftLabel
            // 
            this.grapeSodaDrinksLeftLabel.AutoSize = true;
            this.grapeSodaDrinksLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grapeSodaDrinksLeftLabel.Location = new System.Drawing.Point(91, 23);
            this.grapeSodaDrinksLeftLabel.Name = "grapeSodaDrinksLeftLabel";
            this.grapeSodaDrinksLeftLabel.Size = new System.Drawing.Size(73, 16);
            this.grapeSodaDrinksLeftLabel.TabIndex = 3;
            this.grapeSodaDrinksLeftLabel.Text = "Drinks Left:";
            // 
            // grapeSodaPriceLabel
            // 
            this.grapeSodaPriceLabel.AutoSize = true;
            this.grapeSodaPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grapeSodaPriceLabel.Location = new System.Drawing.Point(100, 3);
            this.grapeSodaPriceLabel.Name = "grapeSodaPriceLabel";
            this.grapeSodaPriceLabel.Size = new System.Drawing.Size(54, 20);
            this.grapeSodaPriceLabel.TabIndex = 2;
            this.grapeSodaPriceLabel.Text = "$1.50";
            // 
            // grapeSodaPictureBox
            // 
            this.grapeSodaPictureBox.Image = global::Assignment_4___Drink_Vending_Machine_Simulator_App.Properties.Resources.GrapeSoda;
            this.grapeSodaPictureBox.Location = new System.Drawing.Point(3, 3);
            this.grapeSodaPictureBox.Name = "grapeSodaPictureBox";
            this.grapeSodaPictureBox.Size = new System.Drawing.Size(62, 64);
            this.grapeSodaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.grapeSodaPictureBox.TabIndex = 0;
            this.grapeSodaPictureBox.TabStop = false;
            this.grapeSodaPictureBox.Click += new System.EventHandler(this.grapeSodaPictureBox_Click);
            // 
            // creamSodaPanel
            // 
            this.creamSodaPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.creamSodaPanel.Controls.Add(this.creamSodaDrinksLeftValue);
            this.creamSodaPanel.Controls.Add(this.creamSodaDrinksLeftLabel);
            this.creamSodaPanel.Controls.Add(this.creamSodaPriceLabel);
            this.creamSodaPanel.Controls.Add(this.creamSodaPictureBox);
            this.creamSodaPanel.Location = new System.Drawing.Point(12, 209);
            this.creamSodaPanel.Name = "creamSodaPanel";
            this.creamSodaPanel.Size = new System.Drawing.Size(174, 77);
            this.creamSodaPanel.TabIndex = 8;
            // 
            // creamSodaDrinksLeftValue
            // 
            this.creamSodaDrinksLeftValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.creamSodaDrinksLeftValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creamSodaDrinksLeftValue.Location = new System.Drawing.Point(91, 39);
            this.creamSodaDrinksLeftValue.Name = "creamSodaDrinksLeftValue";
            this.creamSodaDrinksLeftValue.Padding = new System.Windows.Forms.Padding(5);
            this.creamSodaDrinksLeftValue.Size = new System.Drawing.Size(73, 28);
            this.creamSodaDrinksLeftValue.TabIndex = 4;
            this.creamSodaDrinksLeftValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // creamSodaDrinksLeftLabel
            // 
            this.creamSodaDrinksLeftLabel.AutoSize = true;
            this.creamSodaDrinksLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creamSodaDrinksLeftLabel.Location = new System.Drawing.Point(91, 23);
            this.creamSodaDrinksLeftLabel.Name = "creamSodaDrinksLeftLabel";
            this.creamSodaDrinksLeftLabel.Size = new System.Drawing.Size(73, 16);
            this.creamSodaDrinksLeftLabel.TabIndex = 3;
            this.creamSodaDrinksLeftLabel.Text = "Drinks Left:";
            // 
            // creamSodaPriceLabel
            // 
            this.creamSodaPriceLabel.AutoSize = true;
            this.creamSodaPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creamSodaPriceLabel.Location = new System.Drawing.Point(100, 3);
            this.creamSodaPriceLabel.Name = "creamSodaPriceLabel";
            this.creamSodaPriceLabel.Size = new System.Drawing.Size(54, 20);
            this.creamSodaPriceLabel.TabIndex = 2;
            this.creamSodaPriceLabel.Text = "$1.50";
            // 
            // creamSodaPictureBox
            // 
            this.creamSodaPictureBox.Image = global::Assignment_4___Drink_Vending_Machine_Simulator_App.Properties.Resources.CreamSoda;
            this.creamSodaPictureBox.Location = new System.Drawing.Point(3, 3);
            this.creamSodaPictureBox.Name = "creamSodaPictureBox";
            this.creamSodaPictureBox.Size = new System.Drawing.Size(62, 64);
            this.creamSodaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.creamSodaPictureBox.TabIndex = 0;
            this.creamSodaPictureBox.TabStop = false;
            this.creamSodaPictureBox.Click += new System.EventHandler(this.creamSodaPictureBox_Click);
            // 
            // totalSalesPanel
            // 
            this.totalSalesPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalSalesPanel.Controls.Add(this.totalSalesValue);
            this.totalSalesPanel.Controls.Add(this.totalSalesLabel);
            this.totalSalesPanel.Location = new System.Drawing.Point(192, 209);
            this.totalSalesPanel.Name = "totalSalesPanel";
            this.totalSalesPanel.Size = new System.Drawing.Size(174, 77);
            this.totalSalesPanel.TabIndex = 9;
            // 
            // totalSalesValue
            // 
            this.totalSalesValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalSalesValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalSalesValue.Location = new System.Drawing.Point(43, 39);
            this.totalSalesValue.Name = "totalSalesValue";
            this.totalSalesValue.Padding = new System.Windows.Forms.Padding(5);
            this.totalSalesValue.Size = new System.Drawing.Size(73, 28);
            this.totalSalesValue.TabIndex = 4;
            this.totalSalesValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalSalesLabel
            // 
            this.totalSalesLabel.AutoSize = true;
            this.totalSalesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalSalesLabel.Location = new System.Drawing.Point(31, 3);
            this.totalSalesLabel.Name = "totalSalesLabel";
            this.totalSalesLabel.Size = new System.Drawing.Size(99, 20);
            this.totalSalesLabel.TabIndex = 2;
            this.totalSalesLabel.Text = "Total Sales";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(192, 292);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(88, 31);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(98, 292);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(88, 31);
            this.resetButton.TabIndex = 0;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // DrinkMachineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 327);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.totalSalesPanel);
            this.Controls.Add(this.creamSodaPanel);
            this.Controls.Add(this.grapeSodaPanel);
            this.Controls.Add(this.lemonLimePanel);
            this.Controls.Add(this.rootBeerPanel);
            this.Controls.Add(this.colaPanel);
            this.Controls.Add(this.titleLabel);
            this.MaximumSize = new System.Drawing.Size(388, 366);
            this.MinimumSize = new System.Drawing.Size(388, 366);
            this.Name = "DrinkVendingForm";
            this.Text = "Drink Machine";
            this.colaPanel.ResumeLayout(false);
            this.colaPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colaPictureBox)).EndInit();
            this.rootBeerPanel.ResumeLayout(false);
            this.rootBeerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rootBeerPictureBox)).EndInit();
            this.lemonLimePanel.ResumeLayout(false);
            this.lemonLimePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lemonLimePictureBox)).EndInit();
            this.grapeSodaPanel.ResumeLayout(false);
            this.grapeSodaPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grapeSodaPictureBox)).EndInit();
            this.creamSodaPanel.ResumeLayout(false);
            this.creamSodaPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.creamSodaPictureBox)).EndInit();
            this.totalSalesPanel.ResumeLayout(false);
            this.totalSalesPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button resetButton;

        private System.Windows.Forms.Panel rootBeerPanel;
        private System.Windows.Forms.Label rootBeerDrinksLeftValue;
        private System.Windows.Forms.Label rootBeerDrinksLeftLabel;
        private System.Windows.Forms.Label rootBeerPriceLabel;
        private System.Windows.Forms.PictureBox rootBeerPictureBox;
        private System.Windows.Forms.Panel lemonLimePanel;
        private System.Windows.Forms.Label lemonLimeDrinksLeftValue;
        private System.Windows.Forms.Label lemonLimeDrinksLeftLabel;
        private System.Windows.Forms.Label lemonLimePriceLabel;
        private System.Windows.Forms.PictureBox lemonLimePictureBox;
        private System.Windows.Forms.Panel grapeSodaPanel;
        private System.Windows.Forms.Label grapeSodaDrinksLeftValue;
        private System.Windows.Forms.Label grapeSodaDrinksLeftLabel;
        private System.Windows.Forms.Label grapeSodaPriceLabel;
        private System.Windows.Forms.PictureBox grapeSodaPictureBox;
        private System.Windows.Forms.Panel creamSodaPanel;
        private System.Windows.Forms.Label creamSodaDrinksLeftValue;
        private System.Windows.Forms.Label creamSodaDrinksLeftLabel;
        private System.Windows.Forms.Label creamSodaPriceLabel;
        private System.Windows.Forms.PictureBox creamSodaPictureBox;
        private System.Windows.Forms.Panel totalSalesPanel;
        private System.Windows.Forms.Label totalSalesValue;
        private System.Windows.Forms.Label totalSalesLabel;
        private System.Windows.Forms.Button exitButton;

        private System.Windows.Forms.Label colaPriceLabel;

        private System.Windows.Forms.Label colaDrinksLeftValue;

        private System.Windows.Forms.Label colaDrinksLeftLabel;

        private System.Windows.Forms.PictureBox colaPictureBox;

        private System.Windows.Forms.Panel colaPanel;

        private System.Windows.Forms.Label titleLabel;

        #endregion
    }
}

