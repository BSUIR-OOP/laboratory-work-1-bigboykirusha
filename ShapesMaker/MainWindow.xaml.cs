using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ShapesMaker
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Line line = new Line(new Point(100,200), new Point(700,200));
            Rectangle rectangle = new Rectangle(new Point(400, 50), new Point(400, 0), new Point(500, 0), new Point
                (500, 50));
            Square square = new Square(new Point(300, 50), new Point(300, 0), new Point(350, 0), new Point
                (350, 50));
            Circle circle = new Circle(new Point(200, 50), 50);
            Triangle triangle = new Triangle(new Point(600, 100), new Point(650, 50), new Point(700, 100));
            Elipse elipse = new Elipse(new Point(50, 50), 100, 50);


            Canvas canv = new Canvas();

            List <Shape> shapes = new List <Shape>();
            shapes.Add(line);
            shapes.Add(triangle);
            shapes.Add(square);
            shapes.Add(circle);
            shapes.Add(rectangle);
            shapes.Add(elipse);

            foreach (var item in shapes)
            {
                item.Draw(canv);
            }
         
            this.Content = canv;

        }
    }
}
