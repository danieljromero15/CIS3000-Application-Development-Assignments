namespace Assignment_2___Workshop_Selector
{
    partial class WorkshopSelector
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
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.workshopBox = new System.Windows.Forms.ListBox();
            this.locationBox = new System.Windows.Forms.ListBox();
            this.resultsField = new System.Windows.Forms.Label();
            this.workshopLabel = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            // calculateButton
            //
            this.calculateButton.AutoSize = true;
            this.calculateButton.Location = new System.Drawing.Point(368, 207);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(110, 39);
            this.calculateButton.TabIndex = 0;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            //
            // exitButton
            //
            this.exitButton.AutoSize = true;
            this.exitButton.Location = new System.Drawing.Point(368, 252);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(110, 39);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            //
            // workshopBox
            //
            this.workshopBox.FormattingEnabled = true;
            this.workshopBox.Location = new System.Drawing.Point(12, 25);
            this.workshopBox.Name = "workshopBox";
            this.workshopBox.Size = new System.Drawing.Size(328, 108);
            this.workshopBox.TabIndex = 2;
            //
            // locationBox
            //
            this.locationBox.FormattingEnabled = true;
            this.locationBox.Location = new System.Drawing.Point(355, 25);
            this.locationBox.Name = "locationBox";
            this.locationBox.Size = new System.Drawing.Size(150, 108);
            this.locationBox.TabIndex = 3;
            //
            // resultsField
            //
            this.resultsField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultsField.Location = new System.Drawing.Point(12, 136);
            this.resultsField.Name = "resultsField";
            this.resultsField.Size = new System.Drawing.Size(328, 218);
            this.resultsField.TabIndex = 4;
            //
            // workshopLabel
            //
            this.workshopLabel.AutoSize = true;
            this.workshopLabel.Location = new System.Drawing.Point(12, 9);
            this.workshopLabel.Name = "workshopLabel";
            this.workshopLabel.Size = new System.Drawing.Size(208, 13);
            this.workshopLabel.TabIndex = 5;
            this.workshopLabel.Text = "Workshop / No of Days / Registration Fee";
            //
            // locationLabel
            //
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(355, 9);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(123, 13);
            this.locationLabel.TabIndex = 6;
            this.locationLabel.Text = "Location / Lodging Fees";
            //
            // WorkshopSelector
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 365);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.workshopLabel);
            this.Controls.Add(this.resultsField);
            this.Controls.Add(this.locationBox);
            this.Controls.Add(this.workshopBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.MaximumSize = new System.Drawing.Size(529, 404);
            this.MinimumSize = new System.Drawing.Size(529, 404);
            this.Name = "WorkshopSelector";
            this.Text = "Workshop Selector";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label workshopLabel;
        private System.Windows.Forms.Label locationLabel;

        private System.Windows.Forms.Label resultsField;

        private System.Windows.Forms.ListBox workshopBox;
        private System.Windows.Forms.ListBox locationBox;

        private System.Windows.Forms.Button exitButton;

        private System.Windows.Forms.Button calculateButton;

        #endregion
    }
}

