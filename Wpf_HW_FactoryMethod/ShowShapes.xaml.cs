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
using System.Windows.Shapes;

namespace Wpf_HW_FactoryMethod
{
    /// <summary>
    /// Interaction logic for ShowShapes.xaml
    /// </summary>
    public partial class ShowShapes : Window
    {
        string text;
        int num;
        Random rand = new Random();

        List<SolidColorBrush> brushes = new List<SolidColorBrush>
        {
             new SolidColorBrush(Colors.YellowGreen),
             new SolidColorBrush(Colors.BlueViolet),
             new SolidColorBrush(Colors.Teal),
             new SolidColorBrush(Colors.DeepPink),
             new SolidColorBrush(Colors.ForestGreen),
             new SolidColorBrush(Colors.DarkSalmon),
        };

        public ShowShapes(string text,int num)
        {
            InitializeComponent();

            this.text = text;
            this.num = num;
            lab_1.Content = text;

            if (text == "Circle")
            {
                CreateEllipse(num);
            }
            if (text == "Line")
            {
                CreateLine(num);
            }
            if (text == "Square")
            {
                CreateSquare(num);
            }
        }
        private void CreateEllipse(int num)
        {
            var color = brushes[rand.Next(brushes.Count)];
            Ellipse ellipse = new Ellipse();
            ellipse.Width = num;
            ellipse.Height = num;
            ellipse.Fill = color;
            stack_panel.Children.Add(ellipse);
            
        }
        private void CreateLine(int num)
        {
            var color = brushes[rand.Next(brushes.Count)];
            Line line = new Line();
            line.X1 = 10;
            line.X2 = num;
            line.Y1 = 50;
            line.Y2 = 50;
            line.Stroke = color;
            line.StrokeThickness = 10;
           
            stack_panel.Children.Add(line);
        }

        private void CreateSquare(int num)
        {
            var color = brushes[rand.Next(brushes.Count)];
            Rectangle rectangle = new Rectangle();
            rectangle.Width = num;
            rectangle.Height = num;
            rectangle.Fill = color;
            stack_panel.Children.Add(rectangle);
        }




    }


}
//Rectangle rectangle = new Rectangle();
//rectangle.Width = 20;
//rectangle.Height = 50;
//rectangle.VerticalAlignment = VerticalAlignment.Center;
//rectangle.HorizontalAlignment = HorizontalAlignment.Center;
//rectangle.Fill = Brushes.Azure;
//rectangle.Stroke = Brushes.Red;
//rectangle.StrokeThickness = 3;
//grid_1.Children.Add(rectangle);