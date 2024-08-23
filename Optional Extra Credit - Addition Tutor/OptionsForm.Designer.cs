using System.ComponentModel;

namespace Optional_Extra_Credit___Addition_Tutor
{
    partial class OptionsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.nextQuestionGroup = new System.Windows.Forms.GroupBox();
            this.secondsLabel = new System.Windows.Forms.Label();
            this.timerTextBox = new System.Windows.Forms.TextBox();
            this.buttonButton = new System.Windows.Forms.RadioButton();
            this.timerButton = new System.Windows.Forms.RadioButton();
            this.nextQuestionGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // nextQuestionGroup
            // 
            this.nextQuestionGroup.Controls.Add(this.secondsLabel);
            this.nextQuestionGroup.Controls.Add(this.timerTextBox);
            this.nextQuestionGroup.Controls.Add(this.buttonButton);
            this.nextQuestionGroup.Controls.Add(this.timerButton);
            this.nextQuestionGroup.Location = new System.Drawing.Point(12, 12);
            this.nextQuestionGroup.Name = "nextQuestionGroup";
            this.nextQuestionGroup.Size = new System.Drawing.Size(186, 81);
            this.nextQuestionGroup.TabIndex = 0;
            this.nextQuestionGroup.TabStop = false;
            this.nextQuestionGroup.Text = "Next Question Options";
            // 
            // secondsLabel
            // 
            this.secondsLabel.AutoSize = true;
            this.secondsLabel.Location = new System.Drawing.Point(168, 23);
            this.secondsLabel.Name = "secondsLabel";
            this.secondsLabel.Size = new System.Drawing.Size(12, 13);
            this.secondsLabel.TabIndex = 1;
            this.secondsLabel.Text = "s";
            // 
            // timerTextBox
            // 
            this.timerTextBox.Enabled = false;
            this.timerTextBox.Location = new System.Drawing.Point(105, 19);
            this.timerTextBox.Name = "timerTextBox";
            this.timerTextBox.Size = new System.Drawing.Size(57, 20);
            this.timerTextBox.TabIndex = 2;
            this.timerTextBox.Text = "3";
            this.timerTextBox.TextChanged += new System.EventHandler(this.timerTextBox_TextChanged);
            this.timerTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.timerTextBox_KeyPress);
            // 
            // buttonButton
            // 
            this.buttonButton.Location = new System.Drawing.Point(6, 46);
            this.buttonButton.Name = "buttonButton";
            this.buttonButton.Size = new System.Drawing.Size(86, 21);
            this.buttonButton.TabIndex = 1;
            this.buttonButton.TabStop = true;
            this.buttonButton.Text = "Button";
            this.buttonButton.UseVisualStyleBackColor = true;
            this.buttonButton.CheckedChanged += new System.EventHandler(this.buttonButton_CheckedChanged);
            // 
            // timerButton
            // 
            this.timerButton.Location = new System.Drawing.Point(6, 19);
            this.timerButton.Name = "timerButton";
            this.timerButton.Size = new System.Drawing.Size(86, 21);
            this.timerButton.TabIndex = 0;
            this.timerButton.TabStop = true;
            this.timerButton.Text = "Timer";
            this.timerButton.UseVisualStyleBackColor = true;
            this.timerButton.CheckedChanged += new System.EventHandler(this.timerButton_CheckedChanged);
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 104);
            this.Controls.Add(this.nextQuestionGroup);
            this.MinimumSize = new System.Drawing.Size(226, 143);
            this.Name = "OptionsForm";
            this.Text = "OptionsForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OptionsForm_FormClosed);
            this.nextQuestionGroup.ResumeLayout(false);
            this.nextQuestionGroup.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox nextQuestionGroup;
        private System.Windows.Forms.RadioButton timerButton;
        private System.Windows.Forms.RadioButton buttonButton;
        private System.Windows.Forms.TextBox timerTextBox;
        private System.Windows.Forms.Label secondsLabel;

        #endregion
    }
}