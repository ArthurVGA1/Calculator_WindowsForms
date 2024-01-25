namespace Calculator_WindowsForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textResult = new TextBox();
            buttonZero = new Button();
            buttonEight = new Button();
            buttonSeven = new Button();
            buttonSix = new Button();
            buttonFive = new Button();
            buttonThree = new Button();
            buttonFour = new Button();
            buttonTwo = new Button();
            buttonOne = new Button();
            buttonNine = new Button();
            buttonEqual = new Button();
            buttonPoint = new Button();
            buttonMultiplication = new Button();
            buttonDivision = new Button();
            buttonSubtraction = new Button();
            buttonSum = new Button();
            buttonClear = new Button();
            labelOperation = new Label();
            SuspendLayout();
            // 
            // textResult
            // 
            textResult.Location = new Point(8, 15);
            textResult.Name = "textResult";
            textResult.ReadOnly = true;
            textResult.Size = new Size(254, 23);
            textResult.TabIndex = 0;
            textResult.TextAlign = HorizontalAlignment.Right;
            // 
            // buttonZero
            // 
            buttonZero.Location = new Point(73, 291);
            buttonZero.Name = "buttonZero";
            buttonZero.Size = new Size(59, 58);
            buttonZero.TabIndex = 1;
            buttonZero.Text = "0";
            buttonZero.UseVisualStyleBackColor = true;
            buttonZero.Click += buttonZero_Click;
            // 
            // buttonEight
            // 
            buttonEight.Location = new Point(73, 101);
            buttonEight.Name = "buttonEight";
            buttonEight.Size = new Size(59, 58);
            buttonEight.TabIndex = 2;
            buttonEight.Text = "8";
            buttonEight.UseVisualStyleBackColor = true;
            buttonEight.Click += buttonEight_Click;
            // 
            // buttonSeven
            // 
            buttonSeven.Location = new Point(8, 101);
            buttonSeven.Name = "buttonSeven";
            buttonSeven.Size = new Size(59, 58);
            buttonSeven.TabIndex = 3;
            buttonSeven.Text = "7";
            buttonSeven.UseVisualStyleBackColor = true;
            buttonSeven.Click += buttonSeven_Click;
            // 
            // buttonSix
            // 
            buttonSix.Location = new Point(138, 165);
            buttonSix.Name = "buttonSix";
            buttonSix.Size = new Size(59, 58);
            buttonSix.TabIndex = 4;
            buttonSix.Text = "6";
            buttonSix.UseVisualStyleBackColor = true;
            buttonSix.Click += buttonSix_Click;
            // 
            // buttonFive
            // 
            buttonFive.Location = new Point(73, 165);
            buttonFive.Name = "buttonFive";
            buttonFive.Size = new Size(59, 58);
            buttonFive.TabIndex = 5;
            buttonFive.Text = "5";
            buttonFive.UseVisualStyleBackColor = true;
            buttonFive.Click += buttonFive_Click;
            // 
            // buttonThree
            // 
            buttonThree.Location = new Point(138, 229);
            buttonThree.Name = "buttonThree";
            buttonThree.Size = new Size(59, 58);
            buttonThree.TabIndex = 6;
            buttonThree.Text = "3";
            buttonThree.UseVisualStyleBackColor = true;
            buttonThree.Click += buttonThree_Click;
            // 
            // buttonFour
            // 
            buttonFour.Location = new Point(8, 165);
            buttonFour.Name = "buttonFour";
            buttonFour.Size = new Size(59, 58);
            buttonFour.TabIndex = 7;
            buttonFour.Text = "4";
            buttonFour.UseVisualStyleBackColor = true;
            buttonFour.Click += buttonFour_Click;
            // 
            // buttonTwo
            // 
            buttonTwo.Location = new Point(73, 229);
            buttonTwo.Name = "buttonTwo";
            buttonTwo.Size = new Size(59, 58);
            buttonTwo.TabIndex = 8;
            buttonTwo.Text = "2";
            buttonTwo.UseVisualStyleBackColor = true;
            buttonTwo.Click += buttonTwo_Click;
            // 
            // buttonOne
            // 
            buttonOne.Location = new Point(8, 229);
            buttonOne.Name = "buttonOne";
            buttonOne.Size = new Size(59, 58);
            buttonOne.TabIndex = 9;
            buttonOne.Text = "1";
            buttonOne.UseVisualStyleBackColor = true;
            buttonOne.Click += buttonOne_Click;
            // 
            // buttonNine
            // 
            buttonNine.Location = new Point(138, 101);
            buttonNine.Name = "buttonNine";
            buttonNine.Size = new Size(59, 58);
            buttonNine.TabIndex = 10;
            buttonNine.Text = "9";
            buttonNine.UseVisualStyleBackColor = true;
            buttonNine.Click += buttonNine_Click;
            // 
            // buttonEqual
            // 
            buttonEqual.Location = new Point(138, 291);
            buttonEqual.Name = "buttonEqual";
            buttonEqual.Size = new Size(59, 58);
            buttonEqual.TabIndex = 11;
            buttonEqual.Text = "=";
            buttonEqual.UseVisualStyleBackColor = true;
            buttonEqual.Click += buttonEqual_Click;
            // 
            // buttonPoint
            // 
            buttonPoint.Location = new Point(8, 291);
            buttonPoint.Name = "buttonPoint";
            buttonPoint.Size = new Size(59, 58);
            buttonPoint.TabIndex = 12;
            buttonPoint.Text = ".";
            buttonPoint.UseVisualStyleBackColor = true;
            buttonPoint.Click += buttonPoint_Click;
            // 
            // buttonMultiplication
            // 
            buttonMultiplication.Location = new Point(203, 165);
            buttonMultiplication.Name = "buttonMultiplication";
            buttonMultiplication.Size = new Size(59, 58);
            buttonMultiplication.TabIndex = 13;
            buttonMultiplication.Text = "x";
            buttonMultiplication.UseVisualStyleBackColor = true;
            buttonMultiplication.Click += buttonMultiplication_Click;
            // 
            // buttonDivision
            // 
            buttonDivision.Location = new Point(203, 101);
            buttonDivision.Name = "buttonDivision";
            buttonDivision.Size = new Size(59, 58);
            buttonDivision.TabIndex = 14;
            buttonDivision.Text = "/";
            buttonDivision.UseVisualStyleBackColor = true;
            buttonDivision.Click += buttonDivision_Click;
            // 
            // buttonSubtraction
            // 
            buttonSubtraction.Location = new Point(203, 229);
            buttonSubtraction.Name = "buttonSubtraction";
            buttonSubtraction.Size = new Size(59, 58);
            buttonSubtraction.TabIndex = 15;
            buttonSubtraction.Text = "-";
            buttonSubtraction.UseVisualStyleBackColor = true;
            buttonSubtraction.Click += buttonSubtraction_Click;
            // 
            // buttonSum
            // 
            buttonSum.Location = new Point(203, 291);
            buttonSum.Name = "buttonSum";
            buttonSum.Size = new Size(59, 58);
            buttonSum.TabIndex = 16;
            buttonSum.Text = "+";
            buttonSum.UseVisualStyleBackColor = true;
            buttonSum.Click += buttonSum_Click;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(203, 61);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(59, 34);
            buttonClear.TabIndex = 17;
            buttonClear.Text = "C";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // labelOperation
            // 
            labelOperation.AutoSize = true;
            labelOperation.Location = new Point(17, 18);
            labelOperation.Name = "labelOperation";
            labelOperation.Size = new Size(0, 15);
            labelOperation.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(275, 365);
            Controls.Add(labelOperation);
            Controls.Add(buttonClear);
            Controls.Add(buttonSum);
            Controls.Add(buttonSubtraction);
            Controls.Add(buttonDivision);
            Controls.Add(buttonMultiplication);
            Controls.Add(buttonPoint);
            Controls.Add(buttonEqual);
            Controls.Add(buttonNine);
            Controls.Add(buttonOne);
            Controls.Add(buttonTwo);
            Controls.Add(buttonFour);
            Controls.Add(buttonThree);
            Controls.Add(buttonFive);
            Controls.Add(buttonSix);
            Controls.Add(buttonSeven);
            Controls.Add(buttonEight);
            Controls.Add(buttonZero);
            Controls.Add(textResult);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textResult;
        private Button buttonZero;
        private Button buttonEight;
        private Button buttonSeven;
        private Button buttonSix;
        private Button buttonFive;
        private Button buttonThree;
        private Button buttonFour;
        private Button buttonTwo;
        private Button buttonOne;
        private Button buttonNine;
        private Button buttonEqual;
        private Button buttonPoint;
        private Button buttonMultiplication;
        private Button buttonDivision;
        private Button buttonSubtraction;
        private Button buttonSum;
        private Button buttonClear;
        private Label labelOperation;
    }
}