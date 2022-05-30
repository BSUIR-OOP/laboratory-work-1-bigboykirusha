using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace ShapesMaker
{
    internal class Square : Shape
    {
        public Square(Point p1, Point p2, Point p3, Point p4)
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
            // Square
            System.Windows.Shapes.Rectangle squar = new System.Windows.Shapes.Rectangle();
            squar.Height = P1.Y - P2.Y;
            squar.Width = P3.X - P2.X;
            Canvas.SetTop(squar, P1.Y);
            Canvas.SetLeft(squar, P1.X);
            squar.Fill = Brushes.Aquamarine;
            squar.Stroke = Brushes.BurlyWood;

            canv.Children.Add(squar);


        }

    }
}
