using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace ShapesMaker
{
    internal class Circle :Shape
    {
        public Circle(Point p1, int diameter)
        {
            P1 = p1;
            Diameter = diameter;
        }

        public Point P1 { get; set; }
        public int Diameter { get; set; }
        


        public override void Draw(Canvas canv)
        {
            // Circle
            Ellipse circl = new Ellipse();
            circl.Width = Diameter;
            circl.Height = Diameter;
            Canvas.SetTop(circl, P1.Y);
            Canvas.SetLeft(circl, P1.X);
            circl.Fill = Brushes.WhiteSmoke;
            circl.Stroke = Brushes.DarkRed;
            canv.Children.Add(circl);
        }

    }
}
