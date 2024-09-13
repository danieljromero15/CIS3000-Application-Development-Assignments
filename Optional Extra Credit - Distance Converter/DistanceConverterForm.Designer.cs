namespace Optional_Extra_Credit___Distance_Converter
{
    partial class DistanceConverterForm
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
            this.distanceToConvertLabel = new System.Windows.Forms.Label();
            this.convertedDistanceLabel = new System.Windows.Forms.Label();
            this.distanceToConvertTextBox = new System.Windows.Forms.TextBox();
            this.fromGroupBox = new System.Windows.Forms.GroupBox();
            this.fromListBox = new System.Windows.Forms.ListBox();
            this.toGroupBox = new System.Windows.Forms.GroupBox();
            this.toListBox = new System.Windows.Forms.ListBox();
            this.convertedDistanceResultLabel = new System.Windows.Forms.Label();
            this.convertButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.fromGroupBox.SuspendLayout();
            this.toGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // distanceToConvertLabel
            // 
            this.distanceToConvertLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distanceToConvertLabel.Location = new System.Drawing.Point(12, 9);
            this.distanceToConvertLabel.Name = "distanceToConvertLabel";
            this.distanceToConvertLabel.Size = new System.Drawing.Size(203, 22);
            this.distanceToConvertLabel.TabIndex = 0;
            this.distanceToConvertLabel.Text = "Enter a distance to convert:";
            // 
            // convertedDistanceLabel
            // 
            this.convertedDistanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertedDistanceLabel.Location = new System.Drawing.Point(59, 193);
            this.convertedDistanceLabel.Name = "convertedDistanceLabel";
            this.convertedDistanceLabel.Size = new System.Drawing.Size(156, 22);
            this.convertedDistanceLabel.TabIndex = 1;
            this.convertedDistanceLabel.Text = "Converted Distance:";
            // 
            // distanceToConvertTextBox
            // 
            this.distanceToConvertTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distanceToConvertTextBox.Location = new System.Drawing.Point(221, 6);
            this.distanceToConvertTextBox.Name = "distanceToConvertTextBox";
            this.distanceToConvertTextBox.Size = new System.Drawing.Size(204, 26);
            this.distanceToConvertTextBox.TabIndex = 2;
            this.distanceToConvertTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.distanceToConvertTextBox_KeyPress);
            // 
            // fromGroupBox
            // 
            this.fromGroupBox.Controls.Add(this.fromListBox);
            this.fromGroupBox.Location = new System.Drawing.Point(12, 38);
            this.fromGroupBox.Name = "fromGroupBox";
            this.fromGroupBox.Size = new System.Drawing.Size(203, 152);
            this.fromGroupBox.TabIndex = 3;
            this.fromGroupBox.TabStop = false;
            this.fromGroupBox.Text = "From";
            // 
            // fromListBox
            // 
            this.fromListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromListBox.FormattingEnabled = true;
            this.fromListBox.ItemHeight = 16;
            this.fromListBox.Items.AddRange(new object[] { "Inches", "Feet", "Yards" });
            this.fromListBox.Location = new System.Drawing.Point(24, 40);
            this.fromListBox.Name = "fromListBox";
            this.fromListBox.Size = new System.Drawing.Size(160, 68);
            this.fromListBox.TabIndex = 0;
            // 
            // toGroupBox
            // 
            this.toGroupBox.Controls.Add(this.toListBox);
            this.toGroupBox.Location = new System.Drawing.Point(222, 38);
            this.toGroupBox.Name = "toGroupBox";
            this.toGroupBox.Size = new System.Drawing.Size(203, 152);
            this.toGroupBox.TabIndex = 4;
            this.toGroupBox.TabStop = false;
            this.toGroupBox.Text = "To";
            // 
            // toListBox
            // 
            this.toListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toListBox.FormattingEnabled = true;
            this.toListBox.ItemHeight = 16;
            this.toListBox.Items.AddRange(new object[] { "Inches", "Feet", "Yards" });
            this.toListBox.Location = new System.Drawing.Point(20, 40);
            this.toListBox.Name = "toListBox";
            this.toListBox.Size = new System.Drawing.Size(160, 68);
            this.toListBox.TabIndex = 1;
            // 
            // convertedDistanceResultLabel
            // 
            this.convertedDistanceResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.convertedDistanceResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertedDistanceResultLabel.Location = new System.Drawing.Point(221, 193);
            this.convertedDistanceResultLabel.Name = "convertedDistanceResultLabel";
            this.convertedDistanceResultLabel.Size = new System.Drawing.Size(156, 22);
            this.convertedDistanceResultLabel.TabIndex = 5;
            // 
            // convertButton
            // 
            this.convertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertButton.Location = new System.Drawing.Point(59, 228);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(150, 27);
            this.convertButton.TabIndex = 6;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(221, 228);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(150, 27);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // DistanceConverterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 270);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.convertedDistanceResultLabel);
            this.Controls.Add(this.toGroupBox);
            this.Controls.Add(this.fromGroupBox);
            this.Controls.Add(this.distanceToConvertTextBox);
            this.Controls.Add(this.convertedDistanceLabel);
            this.Controls.Add(this.distanceToConvertLabel);
            this.Name = "DistanceConverterForm";
            this.Text = "Distance Converter";
            this.fromGroupBox.ResumeLayout(false);
            this.toGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ListBox toListBox;
        private System.Windows.Forms.ListBox fromListBox;

        private System.Windows.Forms.Button convertButton;

        private System.Windows.Forms.GroupBox fromGroupBox;
        private System.Windows.Forms.GroupBox toGroupBox;
        private System.Windows.Forms.Label convertedDistanceResultLabel;

        private System.Windows.Forms.Label convertedDistanceLabel;
        private System.Windows.Forms.TextBox distanceToConvertTextBox;

        private System.Windows.Forms.Label distanceToConvertLabel;

        #endregion
    }
}

