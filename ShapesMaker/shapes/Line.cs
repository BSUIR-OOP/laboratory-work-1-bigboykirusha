using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace ShapesMaker
{
    internal class Line : Shape
    {
        public Line(Point p1, Point p2)
        {
            P1 = p1;
            P2 = p2;  
        }

        public Point P1;
        public Point P2;

        public override void Draw(Canvas canv)
        {
            //Line
            System.Windows.Shapes.Line lin = new System.Windows.Shapes.Line();
            lin.X1 = P1.X;
            lin.Y1 = P1.Y;
            lin.X2 = P2.X;
            lin.Y2 = P2.Y;
            lin.StrokeThickness = 4;
            lin.Stroke = Brushes.Black;

            canv.Children.Add(lin);
        }
    }
}
