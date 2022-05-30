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
    internal class Triangle : Shape
    {
        public Triangle(Point p1, Point p2, Point p3)
        {
            P1 = p1;
            P2 = p2;
            P3 = p3;
        }

        public Point P1;
        public Point P2;
        public Point P3;

        public override void Draw(Canvas canv)
        {
            // Triangle(representis through polygon(cause learn C# only few hours))
            Polygon trian = new Polygon();
            trian.Fill = Brushes.Crimson;
            trian.Stroke = Brushes.DarkCyan;

            System.Windows.Point Point1 = new System.Windows.Point(P1.X, P1.Y);
            System.Windows.Point Point2 = new System.Windows.Point(P2.X, P2.Y);
            System.Windows.Point Point3 = new System.Windows.Point(P3.X, P3.Y);

            PointCollection trianPoints = new PointCollection();

            trianPoints.Add(Point1);
            trianPoints.Add(Point2);
            trianPoints.Add(Point3);

            trian.Points = trianPoints;



            canv.Children.Add(trian);

        }
    }

}
