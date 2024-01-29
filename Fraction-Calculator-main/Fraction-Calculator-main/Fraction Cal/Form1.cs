using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System;

namespace Fraction_Cal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Add_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Subtract_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Multiply_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Divi_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Ltop_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (textBox != null && !textBox.Text.All(char.IsDigit))
            {
                // If the text contains non-digit characters, remove them
                textBox.Text = new string(textBox.Text.Where(char.IsDigit).ToArray());

                // Set the cursor at the end of the text
                textBox.SelectionStart = textBox.Text.Length;
            }
        }

        private void Lbottom_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (textBox != null && !textBox.Text.All(char.IsDigit))
            {
                // If the text contains non-digit characters, remove them
                textBox.Text = new string(textBox.Text.Where(char.IsDigit).ToArray());

                // Set the cursor at the end of the text
                textBox.SelectionStart = textBox.Text.Length;
            }
        }

        private void RTop_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (textBox != null && !textBox.Text.All(char.IsDigit))
            {
                // If the text contains non-digit characters, remove them
                textBox.Text = new string(textBox.Text.Where(char.IsDigit).ToArray());

                // Set the cursor at the end of the text
                textBox.SelectionStart = textBox.Text.Length;
            }
        }

        private void RBottom_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (textBox != null && !textBox.Text.All(char.IsDigit))
            {
                // If the text contains non-digit characters, remove them
                textBox.Text = new string(textBox.Text.Where(char.IsDigit).ToArray());

                // Set the cursor at the end of the text
                textBox.SelectionStart = textBox.Text.Length;
            }
        }

        private void PerformOperation_Click(object sender, EventArgs e)
        {
            ResultTop.Text = "";
            ResultBottom.Text = "";
            DoCalculation();
        }
        private void DoCalculation()
        {
            Fraction fraction1 = new Fraction(Ltop.Text, Lbottom.Text);
            Fraction fraction2 = new Fraction(RTop.Text, RBottom.Text);
            string operation = GetSelectedOperation();

            Fraction result = new Fraction(ResultTop.Text, ResultBottom.Text);

            switch (operation)
            {
                case "+":
                    result = fraction1 + fraction2;
                    break;

                case "-":
                    result = fraction1 - fraction2;
                    break;

                case "*":
                    result = fraction1 * fraction2;
                    break;

                case "/":
                    if (fraction2.Top != 0)
                        result = fraction1 / fraction2;
                    else
                        MessageBox.Show("Cannot divide by zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

                default:
                    MessageBox.Show("Please select an operation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

            ResultTop.Text = result.Top.ToString();
            ResultBottom.Text = result.Bottom.ToString();
        }

        private string GetSelectedOperation()
        {
            if (Add.Checked)
                return "+";
            else if (Subtract.Checked)
                return "-";
            else if (Multiply.Checked)
                return "*";
            else if (Divi.Checked)
                return "/";
            else
                return "+"; // Default to addition if no radio button is selected
        }

    }
}