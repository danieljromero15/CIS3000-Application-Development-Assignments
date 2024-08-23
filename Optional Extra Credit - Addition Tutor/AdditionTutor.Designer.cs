using System.Windows.Forms;

namespace Optional_Extra_Credit___Addition_Tutor
{
    partial class AdditionTutor
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
            this.num1Label = new System.Windows.Forms.Label();
            this.num2Label = new System.Windows.Forms.Label();
            this.additionLabel = new System.Windows.Forms.Label();
            this.equalsLabel = new System.Windows.Forms.Label();
            this.answerTextBox = new System.Windows.Forms.TextBox();
            this.responseLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.optionsButton = new System.Windows.Forms.Button();
            this.NextQuestionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // num1Label
            // 
            this.num1Label.AutoSize = true;
            this.num1Label.BackColor = System.Drawing.Color.Transparent;
            this.num1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num1Label.Location = new System.Drawing.Point(12, 9);
            this.num1Label.Name = "num1Label";
            this.num1Label.Size = new System.Drawing.Size(40, 24);
            this.num1Label.TabIndex = 0;
            this.num1Label.Text = "000";
            this.num1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // num2Label
            // 
            this.num2Label.AutoSize = true;
            this.num2Label.BackColor = System.Drawing.Color.Transparent;
            this.num2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num2Label.Location = new System.Drawing.Point(85, 9);
            this.num2Label.Name = "num2Label";
            this.num2Label.Size = new System.Drawing.Size(40, 24);
            this.num2Label.TabIndex = 1;
            this.num2Label.Text = "000";
            this.num2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // additionLabel
            // 
            this.additionLabel.AutoSize = true;
            this.additionLabel.BackColor = System.Drawing.Color.Transparent;
            this.additionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.additionLabel.Location = new System.Drawing.Point(58, 9);
            this.additionLabel.Name = "additionLabel";
            this.additionLabel.Size = new System.Drawing.Size(21, 24);
            this.additionLabel.TabIndex = 2;
            this.additionLabel.Text = "+";
            this.additionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // equalsLabel
            // 
            this.equalsLabel.AutoSize = true;
            this.equalsLabel.BackColor = System.Drawing.Color.Transparent;
            this.equalsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalsLabel.Location = new System.Drawing.Point(131, 9);
            this.equalsLabel.Name = "equalsLabel";
            this.equalsLabel.Size = new System.Drawing.Size(21, 24);
            this.equalsLabel.TabIndex = 3;
            this.equalsLabel.Text = "=";
            this.equalsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // answerTextBox
            // 
            this.answerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerTextBox.Location = new System.Drawing.Point(158, 4);
            this.answerTextBox.MaxLength = 4;
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.Size = new System.Drawing.Size(60, 29);
            this.answerTextBox.TabIndex = 4;
            this.answerTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.answerTextBox_KeyPress_1);
            // 
            // responseLabel
            // 
            this.responseLabel.BackColor = System.Drawing.Color.Transparent;
            this.responseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.responseLabel.Location = new System.Drawing.Point(12, 36);
            this.responseLabel.Name = "responseLabel";
            this.responseLabel.Size = new System.Drawing.Size(140, 24);
            this.responseLabel.TabIndex = 5;
            this.responseLabel.Text = "Error";
            this.responseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.responseLabel.Visible = false;
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(188, 36);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(30, 24);
            this.exitButton.TabIndex = 6;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // optionsButton
            // 
            this.optionsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionsButton.Location = new System.Drawing.Point(158, 36);
            this.optionsButton.Name = "optionsButton";
            this.optionsButton.Size = new System.Drawing.Size(30, 24);
            this.optionsButton.TabIndex = 7;
            this.optionsButton.UseVisualStyleBackColor = true;
            this.optionsButton.Click += new System.EventHandler(this.optionsButton_Click);
            // 
            // NextQuestionButton
            // 
            this.NextQuestionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextQuestionButton.Location = new System.Drawing.Point(122, 36);
            this.NextQuestionButton.Name = "NextQuestionButton";
            this.NextQuestionButton.Size = new System.Drawing.Size(30, 24);
            this.NextQuestionButton.TabIndex = 8;
            this.NextQuestionButton.Text = ">";
            this.NextQuestionButton.UseVisualStyleBackColor = true;
            this.NextQuestionButton.Visible = false;
            this.NextQuestionButton.Click += new System.EventHandler(this.NextQuestionButton_Click);
            // 
            // AdditionTutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 69);
            this.Controls.Add(this.NextQuestionButton);
            this.Controls.Add(this.optionsButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.responseLabel);
            this.Controls.Add(this.answerTextBox);
            this.Controls.Add(this.equalsLabel);
            this.Controls.Add(this.additionLabel);
            this.Controls.Add(this.num2Label);
            this.Controls.Add(this.num1Label);
            this.MaximumSize = new System.Drawing.Size(242, 108);
            this.MinimumSize = new System.Drawing.Size(242, 108);
            this.Name = "AdditionTutor";
            this.Text = "Addition Tutor";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button NextQuestionButton;

        private System.Windows.Forms.Button optionsButton;

        private System.Windows.Forms.Button exitButton;

        private System.Windows.Forms.Label responseLabel;

        private System.Windows.Forms.TextBox answerTextBox;

        private System.Windows.Forms.Label additionLabel;
        private System.Windows.Forms.Label equalsLabel;

        private System.Windows.Forms.Label num2Label;

        private System.Windows.Forms.Label num1Label;

        #endregion
    }
}

