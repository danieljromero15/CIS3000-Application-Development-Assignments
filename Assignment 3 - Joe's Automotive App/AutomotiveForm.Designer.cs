namespace Assignment_3___Joe_s_Automotive_App
{
    partial class AutomotiveForm
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
            this.oilLubeBox = new System.Windows.Forms.GroupBox();
            this.lubeCheck = new System.Windows.Forms.CheckBox();
            this.oilChangeCheck = new System.Windows.Forms.CheckBox();
            this.flushesBox = new System.Windows.Forms.GroupBox();
            this.transmissionCheck = new System.Windows.Forms.CheckBox();
            this.radiatorCheck = new System.Windows.Forms.CheckBox();
            this.miscBox = new System.Windows.Forms.GroupBox();
            this.tireRotationCheck = new System.Windows.Forms.CheckBox();
            this.mufflerCheck = new System.Windows.Forms.CheckBox();
            this.inspectionCheck = new System.Windows.Forms.CheckBox();
            this.partsAndLaborBox = new System.Windows.Forms.GroupBox();
            this.laborLabel = new System.Windows.Forms.Label();
            this.partsLabel = new System.Windows.Forms.Label();
            this.summaryBox = new System.Windows.Forms.GroupBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.taxTextBox = new System.Windows.Forms.TextBox();
            this.partsSummaryLabel = new System.Windows.Forms.Label();
            this.serviceAndLaborLabel = new System.Windows.Forms.Label();
            this.serviveAndLaborTextBox = new System.Windows.Forms.TextBox();
            this.partsSummaryTextBox = new System.Windows.Forms.TextBox();
            this.partsTextBox = new System.Windows.Forms.TextBox();
            this.laborTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.oilLubeBox.SuspendLayout();
            this.flushesBox.SuspendLayout();
            this.miscBox.SuspendLayout();
            this.partsAndLaborBox.SuspendLayout();
            this.summaryBox.SuspendLayout();
            this.SuspendLayout();
            //
            // oilLubeBox
            //
            this.oilLubeBox.Controls.Add(this.lubeCheck);
            this.oilLubeBox.Controls.Add(this.oilChangeCheck);
            this.oilLubeBox.Location = new System.Drawing.Point(12, 12);
            this.oilLubeBox.Name = "oilLubeBox";
            this.oilLubeBox.Size = new System.Drawing.Size(220, 92);
            this.oilLubeBox.TabIndex = 0;
            this.oilLubeBox.TabStop = false;
            this.oilLubeBox.Text = "Oil and Lube";
            //
            // lubeCheck
            //
            this.lubeCheck.AccessibleDescription = "18.00";
            this.lubeCheck.AccessibleName = "Lube job";
            this.lubeCheck.Location = new System.Drawing.Point(6, 55);
            this.lubeCheck.Name = "lubeCheck";
            this.lubeCheck.Size = new System.Drawing.Size(208, 31);
            this.lubeCheck.TabIndex = 1;
            this.lubeCheck.Text = "Lube job ($18.00)";
            this.lubeCheck.UseVisualStyleBackColor = true;
            //
            // oilChangeCheck
            //
            this.oilChangeCheck.AccessibleDescription = "26.00";
            this.oilChangeCheck.AccessibleName = "Oil Change";
            this.oilChangeCheck.Location = new System.Drawing.Point(6, 19);
            this.oilChangeCheck.Name = "oilChangeCheck";
            this.oilChangeCheck.Size = new System.Drawing.Size(208, 30);
            this.oilChangeCheck.TabIndex = 0;
            this.oilChangeCheck.Text = "Oil Change ($26.00)";
            this.oilChangeCheck.UseVisualStyleBackColor = true;
            //
            // flushesBox
            //
            this.flushesBox.Controls.Add(this.transmissionCheck);
            this.flushesBox.Controls.Add(this.radiatorCheck);
            this.flushesBox.Location = new System.Drawing.Point(238, 12);
            this.flushesBox.Name = "flushesBox";
            this.flushesBox.Size = new System.Drawing.Size(220, 92);
            this.flushesBox.TabIndex = 1;
            this.flushesBox.TabStop = false;
            this.flushesBox.Text = "Flushes";
            //
            // transmissionCheck
            //
            this.transmissionCheck.AccessibleDescription = "80.00";
            this.transmissionCheck.AccessibleName = "Transmission Flush";
            this.transmissionCheck.Location = new System.Drawing.Point(6, 55);
            this.transmissionCheck.Name = "transmissionCheck";
            this.transmissionCheck.Size = new System.Drawing.Size(208, 31);
            this.transmissionCheck.TabIndex = 3;
            this.transmissionCheck.Text = "Transmission Flush ($80.00)";
            this.transmissionCheck.UseVisualStyleBackColor = true;
            //
            // radiatorCheck
            //
            this.radiatorCheck.AccessibleDescription = "30.00";
            this.radiatorCheck.AccessibleName = "Radiator Flush";
            this.radiatorCheck.Location = new System.Drawing.Point(6, 19);
            this.radiatorCheck.Name = "radiatorCheck";
            this.radiatorCheck.Size = new System.Drawing.Size(208, 30);
            this.radiatorCheck.TabIndex = 2;
            this.radiatorCheck.Text = "Radiator Flush ($30.00)";
            this.radiatorCheck.UseVisualStyleBackColor = true;
            //
            // miscBox
            //
            this.miscBox.Controls.Add(this.tireRotationCheck);
            this.miscBox.Controls.Add(this.mufflerCheck);
            this.miscBox.Controls.Add(this.inspectionCheck);
            this.miscBox.Location = new System.Drawing.Point(12, 110);
            this.miscBox.Name = "miscBox";
            this.miscBox.Size = new System.Drawing.Size(220, 136);
            this.miscBox.TabIndex = 2;
            this.miscBox.TabStop = false;
            this.miscBox.Text = "Misc";
            //
            // tireRotationCheck
            //
            this.tireRotationCheck.AccessibleDescription = "20.00";
            this.tireRotationCheck.AccessibleName = "Tire Rotation";
            this.tireRotationCheck.Location = new System.Drawing.Point(6, 92);
            this.tireRotationCheck.Name = "tireRotationCheck";
            this.tireRotationCheck.Size = new System.Drawing.Size(208, 31);
            this.tireRotationCheck.TabIndex = 6;
            this.tireRotationCheck.Text = "Tire Rotation ($20.00)";
            this.tireRotationCheck.UseVisualStyleBackColor = true;
            //
            // mufflerCheck
            //
            this.mufflerCheck.AccessibleDescription = "100.00";
            this.mufflerCheck.AccessibleName = "Replace Muffler";
            this.mufflerCheck.Location = new System.Drawing.Point(6, 55);
            this.mufflerCheck.Name = "mufflerCheck";
            this.mufflerCheck.Size = new System.Drawing.Size(208, 31);
            this.mufflerCheck.TabIndex = 5;
            this.mufflerCheck.Text = "Replace Muffler ($100.00)";
            this.mufflerCheck.UseVisualStyleBackColor = true;
            //
            // inspectionCheck
            //
            this.inspectionCheck.AccessibleDescription = "15.00";
            this.inspectionCheck.AccessibleName = "Inspection";
            this.inspectionCheck.Location = new System.Drawing.Point(6, 19);
            this.inspectionCheck.Name = "inspectionCheck";
            this.inspectionCheck.Size = new System.Drawing.Size(208, 30);
            this.inspectionCheck.TabIndex = 4;
            this.inspectionCheck.Text = "Inspection ($15.00)";
            this.inspectionCheck.UseVisualStyleBackColor = true;
            //
            // partsAndLaborBox
            //
            this.partsAndLaborBox.Controls.Add(this.laborTextBox);
            this.partsAndLaborBox.Controls.Add(this.partsTextBox);
            this.partsAndLaborBox.Controls.Add(this.laborLabel);
            this.partsAndLaborBox.Controls.Add(this.partsLabel);
            this.partsAndLaborBox.Location = new System.Drawing.Point(238, 110);
            this.partsAndLaborBox.Name = "partsAndLaborBox";
            this.partsAndLaborBox.Size = new System.Drawing.Size(220, 136);
            this.partsAndLaborBox.TabIndex = 3;
            this.partsAndLaborBox.TabStop = false;
            this.partsAndLaborBox.Text = "Parts and Labor";
            //
            // laborLabel
            //
            this.laborLabel.Location = new System.Drawing.Point(35, 75);
            this.laborLabel.Name = "laborLabel";
            this.laborLabel.Size = new System.Drawing.Size(67, 19);
            this.laborLabel.TabIndex = 3;
            this.laborLabel.Text = "Labor ($)";
            this.laborLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // partsLabel
            //
            this.partsLabel.Location = new System.Drawing.Point(35, 38);
            this.partsLabel.Name = "partsLabel";
            this.partsLabel.Size = new System.Drawing.Size(67, 19);
            this.partsLabel.TabIndex = 2;
            this.partsLabel.Text = "Parts";
            this.partsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // summaryBox
            //
            this.summaryBox.Controls.Add(this.totalLabel);
            this.summaryBox.Controls.Add(this.taxLabel);
            this.summaryBox.Controls.Add(this.totalTextBox);
            this.summaryBox.Controls.Add(this.taxTextBox);
            this.summaryBox.Controls.Add(this.partsSummaryLabel);
            this.summaryBox.Controls.Add(this.serviceAndLaborLabel);
            this.summaryBox.Controls.Add(this.serviveAndLaborTextBox);
            this.summaryBox.Controls.Add(this.partsSummaryTextBox);
            this.summaryBox.Location = new System.Drawing.Point(12, 252);
            this.summaryBox.Name = "summaryBox";
            this.summaryBox.Size = new System.Drawing.Size(446, 130);
            this.summaryBox.TabIndex = 4;
            this.summaryBox.TabStop = false;
            this.summaryBox.Text = "Summary";
            //
            // totalLabel
            //
            this.totalLabel.Location = new System.Drawing.Point(11, 99);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(121, 19);
            this.totalLabel.TabIndex = 11;
            this.totalLabel.Text = "Total Fees";
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // taxLabel
            //
            this.taxLabel.Location = new System.Drawing.Point(11, 73);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(121, 19);
            this.taxLabel.TabIndex = 10;
            this.taxLabel.Text = "Tax (on parts)";
            this.taxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // totalTextBox
            //
            this.totalTextBox.Location = new System.Drawing.Point(138, 98);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.ReadOnly = true;
            this.totalTextBox.Size = new System.Drawing.Size(76, 20);
            this.totalTextBox.TabIndex = 9;
            //
            // taxTextBox
            //
            this.taxTextBox.Location = new System.Drawing.Point(138, 72);
            this.taxTextBox.Name = "taxTextBox";
            this.taxTextBox.ReadOnly = true;
            this.taxTextBox.Size = new System.Drawing.Size(76, 20);
            this.taxTextBox.TabIndex = 8;
            //
            // partsSummaryLabel
            //
            this.partsSummaryLabel.Location = new System.Drawing.Point(11, 47);
            this.partsSummaryLabel.Name = "partsSummaryLabel";
            this.partsSummaryLabel.Size = new System.Drawing.Size(121, 19);
            this.partsSummaryLabel.TabIndex = 7;
            this.partsSummaryLabel.Text = "Parts";
            this.partsSummaryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // serviceAndLaborLabel
            //
            this.serviceAndLaborLabel.Location = new System.Drawing.Point(11, 21);
            this.serviceAndLaborLabel.Name = "serviceAndLaborLabel";
            this.serviceAndLaborLabel.Size = new System.Drawing.Size(121, 19);
            this.serviceAndLaborLabel.TabIndex = 6;
            this.serviceAndLaborLabel.Text = "Service and Labor";
            this.serviceAndLaborLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // serviveAndLaborTextBox
            //
            this.serviveAndLaborTextBox.Location = new System.Drawing.Point(138, 20);
            this.serviveAndLaborTextBox.Name = "serviveAndLaborTextBox";
            this.serviveAndLaborTextBox.ReadOnly = true;
            this.serviveAndLaborTextBox.Size = new System.Drawing.Size(76, 20);
            this.serviveAndLaborTextBox.TabIndex = 4;
            //
            // partsSummaryTextBox
            //
            this.partsSummaryTextBox.Location = new System.Drawing.Point(138, 46);
            this.partsSummaryTextBox.Name = "partsSummaryTextBox";
            this.partsSummaryTextBox.ReadOnly = true;
            this.partsSummaryTextBox.Size = new System.Drawing.Size(76, 20);
            this.partsSummaryTextBox.TabIndex = 5;
            //
            // partsTextBox
            //
            this.partsTextBox.Location = new System.Drawing.Point(108, 37);
            this.partsTextBox.Name = "partsTextBox";
            this.partsTextBox.Size = new System.Drawing.Size(76, 20);
            this.partsTextBox.TabIndex = 12;
            //
            // laborTextBox
            //
            this.laborTextBox.Location = new System.Drawing.Point(108, 75);
            this.laborTextBox.Name = "laborTextBox";
            this.laborTextBox.Size = new System.Drawing.Size(76, 20);
            this.laborTextBox.TabIndex = 13;
            //
            // calculateButton
            //
            this.calculateButton.Location = new System.Drawing.Point(77, 388);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(102, 30);
            this.calculateButton.TabIndex = 5;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            //
            // clearButton
            //
            this.clearButton.Location = new System.Drawing.Point(185, 388);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(102, 30);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            //
            // exitButton
            //
            this.exitButton.Location = new System.Drawing.Point(293, 388);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(102, 30);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            //
            // AutomotiveForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 427);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.summaryBox);
            this.Controls.Add(this.partsAndLaborBox);
            this.Controls.Add(this.miscBox);
            this.Controls.Add(this.flushesBox);
            this.Controls.Add(this.oilLubeBox);
            this.Name = "AutomotiveForm";
            this.Text = "Automotive";
            this.oilLubeBox.ResumeLayout(false);
            this.flushesBox.ResumeLayout(false);
            this.miscBox.ResumeLayout(false);
            this.partsAndLaborBox.ResumeLayout(false);
            this.partsAndLaborBox.PerformLayout();
            this.summaryBox.ResumeLayout(false);
            this.summaryBox.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;

        private System.Windows.Forms.TextBox partsTextBox;
        private System.Windows.Forms.TextBox laborTextBox;

        private System.Windows.Forms.GroupBox summaryBox;
        private System.Windows.Forms.Label partsSummaryLabel;
        private System.Windows.Forms.Label serviceAndLaborLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.TextBox taxTextBox;

        private System.Windows.Forms.TextBox partsSummaryTextBox;
        private System.Windows.Forms.TextBox serviveAndLaborTextBox;
        private System.Windows.Forms.Label partsLabel;
        private System.Windows.Forms.Label laborLabel;

        private System.Windows.Forms.GroupBox oilLubeBox;
        private System.Windows.Forms.GroupBox flushesBox;
        private System.Windows.Forms.GroupBox miscBox;
        private System.Windows.Forms.GroupBox partsAndLaborBox;
        private System.Windows.Forms.CheckBox oilChangeCheck;
        private System.Windows.Forms.CheckBox lubeCheck;
        private System.Windows.Forms.CheckBox transmissionCheck;
        private System.Windows.Forms.CheckBox radiatorCheck;
        private System.Windows.Forms.CheckBox mufflerCheck;
        private System.Windows.Forms.CheckBox inspectionCheck;
        private System.Windows.Forms.CheckBox tireRotationCheck;

        #endregion
    }
}

