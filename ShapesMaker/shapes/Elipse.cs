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
    internal class Elipse: Shape
    {
        public Elipse(Point p1, int width, int height)
        {
            P1 = p1;
            Width = width;
            Height = height;
        }

        public Point P1;
        public int Width;
        public int Height;

        public override void Draw(Canvas canv)
        {
            // Ellipse
            Ellipse el = new Ellipse();
            el.Width = Width;
            el.Height = Height;
            Canvas.SetTop(el, P1.Y);
            Canvas.SetLeft(el, P1.X);
            el.Fill = Brushes.Green;
            el.Stroke = Brushes.Yellow;

            canv.Children.Add(el);
        }
    }
}
