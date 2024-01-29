using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; // Add this for Control
using System.Drawing;

namespace Calculator
{
    public class DesignLayoutHelper : Control
    {
        
        public static void CenterControl(Control container, Control control)
        {
 
            int x = (container.Width - control.Width) ; // Calculate the X-coordinate for centering
            int y = (container.Height - control.Height); // Calculate the Y-coordinate for centering
            control.Location = new Point(x, y); // Set the location to center the control
        }
    }
}
