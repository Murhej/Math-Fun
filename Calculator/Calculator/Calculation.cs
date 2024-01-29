using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using System.Windows.Forms;

namespace Calculator
{
    // calculate the inpute it
    public class Calculation
    {

        protected double NumberOne { get; set; }
        private double NumberTwo { get; set; }
        private char Operation { get; set; }
        public double Total { get; private set; }


        // constructor to take the input
        public Calculation(double One, double Two, char operation)
        {
            NumberOne = One;
            NumberTwo = Two;
            Operation = operation;
        }
        public double PerformOperation()
        {
            switch (Operation)
            {
                case '+':
                    Add();
                    break;
                case '-':
                    Subtract();
                    break;
                case 'x':
                    Multply();
                    break;
                case '/':
                    Divide();
                    break;
            }

            return Total;
        }
        public  double Add() =>  Total = NumberOne + NumberTwo;

        public double Subtract() => Total = NumberOne - NumberTwo;

        public double Multply() => Total = NumberOne * NumberTwo;

        public double Divide()
        {
            try
            {
                if (NumberTwo != 0)
                {
                    return NumberOne / NumberTwo;
                }
                else
                {
                    throw new DivideByZeroException("Can't divide by zero");
                }
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message, "Dividing Zero", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return double.NaN;
            
          
        }
        public int AC() => 0;
        //change the sign from a negive to a postive vice versa
        public void SignChnage(double value)
        {
            value *= -1;

        }
        //calcualtin the percenage
        public double Percentage(string inpute)
        {
            if(inpute.EndsWith("%"))
            {
                string numericPart = inpute.Substring(0, inpute.Length - 1);

                if (double.TryParse(numericPart, out double numericValue))
                {
                    return numericValue / 100.0;
                }
            }
            return double.NaN;
        }
        public override string ToString()
        {
            return $"{Total}";
        }
     
    }
}
