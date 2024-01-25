namespace Calculator_WindowsForms
{
    public partial class Form1 : Form
    {
        private decimal Result { get; set; }
        private decimal Value { get; set; }
        private Operations SelectOperation { get; set; }
        private enum Operations
        {
            Sum,
            Subtract,
            Multiply,
            Divide
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            textResult.Text += "0";
        }

        private void buttonOne_Click(object sender, EventArgs e)
        {
            textResult.Text += "1";
        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            textResult.Text += "2";
        }

        private void buttonThree_Click(object sender, EventArgs e)
        {
            textResult.Text += "3";
        }

        private void buttonFour_Click(object sender, EventArgs e)
        {
            textResult.Text += "4";
        }

        private void buttonFive_Click(object sender, EventArgs e)
        {
            textResult.Text += "5";
        }

        private void buttonSix_Click(object sender, EventArgs e)
        {
            textResult.Text += "6";
        }

        private void buttonSeven_Click(object sender, EventArgs e)
        {
            textResult.Text += "7";
        }

        private void buttonEight_Click(object sender, EventArgs e)
        {
            textResult.Text += "8";
        }

        private void buttonNine_Click(object sender, EventArgs e)
        {
            textResult.Text += "9";
        }

        private void buttonSum_Click(object sender, EventArgs e)
        {
            SelectOperation = Operations.Sum;
            Value = Convert.ToDecimal(textResult.Text);
            textResult.Text = "";
            labelOperation.Text = "+";
        }

        private void buttonSubtraction_Click(object sender, EventArgs e)
        {
            SelectOperation = Operations.Subtract;
            Value = Convert.ToDecimal(textResult.Text);
            textResult.Text = "";
            labelOperation.Text = "-";
        }

        private void buttonMultiplication_Click(object sender, EventArgs e)
        {
            SelectOperation = Operations.Multiply;
            Value = Convert.ToDecimal(textResult.Text);
            textResult.Text = "";
            labelOperation.Text = "x";
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            SelectOperation = Operations.Divide;
            Value = Convert.ToDecimal(textResult.Text);
            textResult.Text = "";
            labelOperation.Text = "/";
        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {
            if (textResult.Text == "")
            {
                textResult.Text += "0,";
            }
            if (!textResult.Text.Contains(","))
            {
                textResult.Text += ",";
            }
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            switch (SelectOperation)
            {
                case Operations.Sum:
                    Result = Value + Convert.ToDecimal(textResult.Text);
                    break;

                case Operations.Subtract:
                    Result = Value - Convert.ToDecimal(textResult.Text);
                    break;

                case Operations.Multiply:
                    Result = Value * Convert.ToDecimal(textResult.Text);
                    break;

                case Operations.Divide:
                    Result = Value / Convert.ToDecimal(textResult.Text);
                    break;
            }
            textResult.Text = Convert.ToString(Result);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textResult.Text = "";
            labelOperation.Text = "";
        }
    }
}