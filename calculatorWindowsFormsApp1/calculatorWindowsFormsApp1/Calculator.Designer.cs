namespace calculatorWindowsFormsApp1
{
    partial class Calculator
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
            this.addButton = new System.Windows.Forms.Button();
            this.sutractButton = new System.Windows.Forms.Button();
            this.multipyButton = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.firstNumTextBox = new System.Windows.Forms.TextBox();
            this.secondNumTextBox = new System.Windows.Forms.TextBox();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(59, 219);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // sutractButton
            // 
            this.sutractButton.Location = new System.Drawing.Point(178, 219);
            this.sutractButton.Name = "sutractButton";
            this.sutractButton.Size = new System.Drawing.Size(75, 23);
            this.sutractButton.TabIndex = 1;
            this.sutractButton.Text = "Subtract";
            this.sutractButton.UseVisualStyleBackColor = true;
            // 
            // multipyButton
            // 
            this.multipyButton.Location = new System.Drawing.Point(290, 218);
            this.multipyButton.Name = "multipyButton";
            this.multipyButton.Size = new System.Drawing.Size(75, 23);
            this.multipyButton.TabIndex = 2;
            this.multipyButton.Text = "Multiply";
            this.multipyButton.UseVisualStyleBackColor = true;
            // 
            // divideButton
            // 
            this.divideButton.Location = new System.Drawing.Point(408, 219);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(75, 23);
            this.divideButton.TabIndex = 3;
            this.divideButton.Text = "Divide";
            this.divideButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "First Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Second Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Result";
            // 
            // firstNumTextBox
            // 
            this.firstNumTextBox.Location = new System.Drawing.Point(158, 35);
            this.firstNumTextBox.Name = "firstNumTextBox";
            this.firstNumTextBox.Size = new System.Drawing.Size(134, 20);
            this.firstNumTextBox.TabIndex = 8;
            // 
            // secondNumTextBox
            // 
            this.secondNumTextBox.Location = new System.Drawing.Point(161, 85);
            this.secondNumTextBox.Name = "secondNumTextBox";
            this.secondNumTextBox.Size = new System.Drawing.Size(131, 20);
            this.secondNumTextBox.TabIndex = 9;
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(123, 141);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(141, 20);
            this.resultTextBox.TabIndex = 10;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 339);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.secondNumTextBox);
            this.Controls.Add(this.firstNumTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.divideButton);
            this.Controls.Add(this.multipyButton);
            this.Controls.Add(this.sutractButton);
            this.Controls.Add(this.addButton);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button sutractButton;
        private System.Windows.Forms.Button multipyButton;
        private System.Windows.Forms.Button divideButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox firstNumTextBox;
        private System.Windows.Forms.TextBox secondNumTextBox;
        private System.Windows.Forms.TextBox resultTextBox;
    }
}

