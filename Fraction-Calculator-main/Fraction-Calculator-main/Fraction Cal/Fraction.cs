using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction_Cal
{
    /**
 * Fraction class supplies the underlying logic to 
 * drive this application. A better design might be
 * to have this in a separate file or as a library.
 */
    public class Fraction
    {
        public int Top { get; }
        public int Bottom { get; }
        public Fraction(string topStr = "0", string bottomStr = "1")
        {
            if (int.TryParse(topStr, out int top) && int.TryParse(bottomStr, out int bottom))
            {
                (Top, Bottom) = (top, bottom);
            }
            else
            {
                // Handle parsing errors or set default values as needed
                (Top, Bottom) = (0, 1);
            }
        }

        
        public Fraction(int top = 0, int bottom = 1)
            => (Top, Bottom) = (top, bottom);
        /**
         * Add another constructor that takes two optional string
         * arguments and assigns them to the appropriate
         * properties (of course after conversion).
         */
        public static Fraction operator +(Fraction lhs, Fraction rhs)
            => new Fraction(lhs.Top * rhs.Bottom + rhs.Top * lhs.Bottom, lhs.Bottom * rhs.Bottom);

        public static Fraction operator -(Fraction lhs, Fraction rhs)
            => new Fraction(lhs.Top * rhs.Bottom - rhs.Top * lhs.Bottom, lhs.Bottom * rhs.Bottom);
     
        public static Fraction operator *(Fraction lhs, Fraction rhs)
            => new Fraction(lhs.Top * rhs.Top, lhs.Bottom * rhs.Bottom);

        public static Fraction operator /(Fraction lhs, Fraction rhs)
        {
            // Ensure that the denominator (rhs.Bottom) is not zero
            if (rhs.Bottom == 0)
            {
                throw new ArgumentException("Division by zero is not allowed.");
            }

            // Multiply the numerator of the left fraction by the denominator of the right fraction
            // and multiply the denominator of the left fraction by the numerator of the right fraction
            return new Fraction(lhs.Top * rhs.Bottom, lhs.Bottom * rhs.Top);
        }


        public override string ToString()
            => $"[{Top}, {Bottom}]";
        /**
         * This Deconstructor allows you to get both properties
         * with a single statement.
         */
        public void Deconstruct(out string top, out string bottom)
            => (top, bottom) = ($"{Top}", $"{Bottom}");
    }





}
