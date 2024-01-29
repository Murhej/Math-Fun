
using System.Net.Sockets;

namespace Calculator
{
 
    public partial class Calculator : Form
    {
        Calculation calculation;
        private string Value = " ";
        private double NumberOne;
        private Char operation;
        private double NumberTwo;
        public Calculator()
        {
            InitializeComponent();
            DotOperationCheck();
        }

      

        private void Calculator_Load(object sender, EventArgs e)
        {
           
        }
        // buttons for the GUI, taking the user inoute and storing it in to  value
        private void Integer_Seven_Click(object sender, EventArgs e)
        {
             Value += Integer_Seven.Text;
            UpdateTextBox();

        }

        private void Integer_Eight_Click(object sender, EventArgs e)
        {

             Value += Integer_Eight.Text;
            UpdateTextBox();
        }

        private void Integer_Nine_Click(object sender, EventArgs e)
        {

            Value += Integer_Nine.Text;
            UpdateTextBox();
        }

        private void Integer_Four_Click(object sender, EventArgs e)
        {
            Value += Integer_Four.Text;
            UpdateTextBox();
        }

        private void Integer_Five_Click(object sender, EventArgs e)
        {
            Value += Integer_Five.Text;
            UpdateTextBox();
        }

        private void Integer_Six_Click(object sender, EventArgs e)
        {
            Value += Integer_Six.Text;
            UpdateTextBox();
        }

        private void Integer_One_Click(object sender, EventArgs e)
        {
            Value += Integer_One.Text;
            UpdateTextBox();
        }

        private void Integer_Second_Click(object sender, EventArgs e)
        {
            Value += Integer_Second.Text;
            UpdateTextBox();
        }

        private void Integer_Three_Click(object sender, EventArgs e)
        {
            Value += Integer_Three.Text;
            UpdateTextBox();
        }

        private void Interger_Zero_Click(object sender, EventArgs e)
        {
            Value += Integer_Zero.Text;
            
            UpdateTextBox();
        }

        private void Dot_Click(object sender, EventArgs e)
        {
            Value += Dot.Text;
            DotValided();
            UpdateTextBox();
        }
        //dpt button used to add a dot in the operation
        private void DotValided()
        {
            string dot = ".";

            //checki if the value contain a dot
            if (Value.Contains(dot))
            {
                //if does unenable the button
                Dot.Enabled = false;
               

            }
            else
            {
                Dot.Enabled = true;
            }
          
        }
        //loop to check if the operation already been clicked
        private bool loopingOperation()
        {
            
                if (Value.Contains("x") || Value.Contains("-") || Value.Contains("+") || Value.Contains("/"))
                {
                    Multply.Enabled = false;
                    Divide.Enabled = false;
                    Add.Enabled = false;
                    Subtract.Enabled = false;
                    return true;

                }
               
            
           
           
            return false;
          
        }
        // check if the value has Operation char at the end of the char
        private void DotOperationCheck()
        {
           
                // If value has an operation at the end of it, enable the dot  
                if (Value.EndsWith("x") || Value.EndsWith("/") || Value.EndsWith("-") || Value.EndsWith("+"))
                {
                    Dot.Enabled = true;
                    loopingOperation();
                }
              
                // It seems unnecessary to call loopingOperation here
            
            UpdateTextBox(); 
        }


        private void UpdateTextBox()
        {
         textBox1.Text = Value;




        }
        //Operation Buutton
        //the divide button
        private void Divide_Click(object sender, EventArgs e)
        {
            Value += Divide.Text;
            DotOperationCheck();
            UpdateTextBox();

        }

        private void Multply_Click(object sender, EventArgs e)
        {
            Value += Multply.Text;
            DotOperationCheck();
            UpdateTextBox();

        }

        private void Subtract_Click(object sender, EventArgs e)
        {
            Value += Subtract.Text;
            DotOperationCheck();
            UpdateTextBox();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Value += Add.Text;
            DotOperationCheck();
            UpdateTextBox();
        }
        private void SplitValue()
        {
           if(loopingOperation()) {
                string[] subvalue = Value.Split('x', '-', '+', '/');
                if(subvalue.Length ==2)
                {
                    if (double.TryParse(subvalue[0], out NumberOne)) { }
                    
                    if (double.TryParse(subvalue[1], out NumberTwo)) { }
                   
                }

                if (loopingOperation())
                {
                    char[] Operation = { 'x', '-', '+', '/' };
                    foreach (char Opera in Value)
                    {
                        if (Array.IndexOf(Operation, Opera) != -1)
                        {
                            operation = Opera;
                            break;
                        }
                    }
                }

            }
         
      

        }

        private void Equal_Click(object sender, EventArgs e)
        {
            SplitValue();
            cal();


        }
        private void cal()
        {
           
            calculation = new Calculation(NumberOne, NumberTwo, operation);
            calculation.PerformOperation();
           
            textBox1.Text = calculation.Total.ToString();
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

    }
}