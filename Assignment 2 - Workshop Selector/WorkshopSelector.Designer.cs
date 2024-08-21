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
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.WorkshopBox = new System.Windows.Forms.ListBox();
            this.LocationBox = new System.Windows.Forms.ListBox();
            this.ResultsField = new System.Windows.Forms.Label();
            this.WorkshopLabel = new System.Windows.Forms.Label();
            this.LocationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CalculateButton
            // 
            this.CalculateButton.AutoSize = true;
            this.CalculateButton.Location = new System.Drawing.Point(368, 207);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(110, 39);
            this.CalculateButton.TabIndex = 0;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.AutoSize = true;
            this.ExitButton.Location = new System.Drawing.Point(368, 252);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(110, 39);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // WorkshopBox
            // 
            this.WorkshopBox.FormattingEnabled = true;
            this.WorkshopBox.Location = new System.Drawing.Point(12, 25);
            this.WorkshopBox.Name = "WorkshopBox";
            this.WorkshopBox.Size = new System.Drawing.Size(328, 108);
            this.WorkshopBox.TabIndex = 2;
            // 
            // LocationBox
            // 
            this.LocationBox.FormattingEnabled = true;
            this.LocationBox.Location = new System.Drawing.Point(355, 25);
            this.LocationBox.Name = "LocationBox";
            this.LocationBox.Size = new System.Drawing.Size(150, 108);
            this.LocationBox.TabIndex = 3;
            // 
            // ResultsField
            // 
            this.ResultsField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResultsField.Location = new System.Drawing.Point(12, 136);
            this.ResultsField.Name = "ResultsField";
            this.ResultsField.Size = new System.Drawing.Size(328, 218);
            this.ResultsField.TabIndex = 4;
            // 
            // WorkshopLabel
            // 
            this.WorkshopLabel.AutoSize = true;
            this.WorkshopLabel.Location = new System.Drawing.Point(12, 9);
            this.WorkshopLabel.Name = "WorkshopLabel";
            this.WorkshopLabel.Size = new System.Drawing.Size(208, 13);
            this.WorkshopLabel.TabIndex = 5;
            this.WorkshopLabel.Text = "Workshop / No of Days / Registration Fee";
            // 
            // LocationLabel
            // 
            this.LocationLabel.AutoSize = true;
            this.LocationLabel.Location = new System.Drawing.Point(355, 9);
            this.LocationLabel.Name = "LocationLabel";
            this.LocationLabel.Size = new System.Drawing.Size(123, 13);
            this.LocationLabel.TabIndex = 6;
            this.LocationLabel.Text = "Location / Lodging Fees";
            // 
            // WorkshopSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 365);
            this.Controls.Add(this.LocationLabel);
            this.Controls.Add(this.WorkshopLabel);
            this.Controls.Add(this.ResultsField);
            this.Controls.Add(this.LocationBox);
            this.Controls.Add(this.WorkshopBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.CalculateButton);
            this.MaximumSize = new System.Drawing.Size(529, 404);
            this.MinimumSize = new System.Drawing.Size(529, 404);
            this.Name = "WorkshopSelector";
            this.Text = "Workshop Selector";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label WorkshopLabel;
        private System.Windows.Forms.Label LocationLabel;

        private System.Windows.Forms.Label ResultsField;

        private System.Windows.Forms.ListBox WorkshopBox;
        private System.Windows.Forms.ListBox LocationBox;

        private System.Windows.Forms.Button ExitButton;

        private System.Windows.Forms.Button CalculateButton;

        #endregion
    }
}

