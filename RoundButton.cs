using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

#region Import
using System.Drawing.Drawing2D;
#endregion Import

namespace TimeSeriesControl
{
    public partial class RoundButton : Button
    {
        public RoundButton()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            GraphicsPath buttonPath = new GraphicsPath();

            // Set a new rectangle to the same size as the button's 
            // ClientRectangle property.
            Rectangle newRectangle = this.ClientRectangle;

            // Decrease the size of the rectangle.
            newRectangle.Inflate(-10, -10);

            // Draw the button's border.
            pevent.Graphics.DrawEllipse(Pens.Black, newRectangle);

            // Increase the size of the rectangle to include the border.
            newRectangle.Inflate(1, 1);

            // Create a circle within the new rectangle.
            buttonPath.AddEllipse(newRectangle);

            // Set the button's Region property to the newly created 
            // circle region.
            this.Region = new Region(buttonPath);

            base.OnPaint(pevent);
        }
    } // class
} // namespace
