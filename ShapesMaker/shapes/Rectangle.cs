using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace ShapesMaker
{
    internal class Rectangle : Shape
    {
        public Rectangle(Point p1, Point p2, Point p3, Point p4)
        {
            P1 = p1;
            P2 = p2;
            P3 = p3;
            P4 = p4;
        }

        public Point P1;
        public Point P2;
        public Point P3;
        public Point P4;


        public override void Draw(Canvas canv)
        {

            // Rectangular
            System.Windows.Shapes.Rectangle rect = new System.Windows.Shapes.Rectangle();
            rect.Height = P1.Y - P2.Y;
            rect.Width = P3.X - P2.X;
            Canvas.SetTop(rect, P1.Y);
            Canvas.SetLeft(rect, P1.X);
            rect.Fill = Brushes.Chocolate;
            rect.Stroke = Brushes.Coral;

            canv.Children.Add(rect);

        }

    }
}
