using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RandomGraph
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DoStuff();
        }

        void DoStuff()
        {
            //
            //  Resize UI
            this.WindowState = System.Windows.WindowState.Maximized;
            this.DrawArea.Width = 1960;
            this.DrawArea.Height = 1024;
            this.DrawArea.Background = Brushes.Black;

            //var brush = new SolidColorBrush(Color.FromRgb(255, 255, 255));

            //this.DrawArea.Children.Add(new Line
            //{
            //    Fill= brush,
            //    Stroke = Brushes.Black,
            //    X1= 100,
            //    X2=400,
            //    Y1=-300,
            //    Y2=600
            //});
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            DrawArea.Children.Clear();

            int verticies;
            if (!int.TryParse(Vertice.Text, out verticies))
            {
                MessageBox.Show("Bad Value in Verticy #");
                return;
            }

            int odds;
            if(!int.TryParse(Odds.Text, out odds))
            {
                MessageBox.Show("Bad Value in Odds 1-100");
            }

            DrawArea.Children.Clear();

            var randomMap = new Diagraph(verticies, DrawArea.RenderSize, odds);
            DrawMap(randomMap, DrawArea.Children, odds);
        }


        void DrawMap(Diagraph map, UIElementCollection surface, int odds)
        {
            var brush = new SolidColorBrush(Color.FromRgb(255, 255, 255));

            foreach(var point in map.Verticies)
            {
                //
                //  Connect Random Point within range
                var rangePoints = map.PointsRadius(point, 500);

                var doIt = map.RandomValue() % 100;
                if (doIt < odds && rangePoints.Count != 0)
                {
                    var randPoint = rangePoints[map.RandomValue() % rangePoints.Count];

                    surface.Add(new Line
                    {
                        Fill = brush,
                        Stroke = Brushes.Orange,
                        X1 = point.X,
                        X2 = randPoint.X,
                        Y1 = point.Y,
                        Y2 = randPoint.Y
                    });
                }

                //
                //  Draw Point
                surface.Add(new Line
                {
                    Fill = brush,
                    Stroke = Brushes.White,
                    X1 = point.X,
                    X2 = point.X+5,
                    Y1 = point.Y,
                    Y2 = point.Y+5
                });

                
                

                
            }

            //for(var ix =0; ix < map.Components.Count; ix++)
            //{
            //    var color = BrushByIndex(ix);
            //    foreach (var edge in map.Components[ix].Connections)
            //    {
            //        surface.Add(new Line
            //        {
            //            Fill = brush,
            //            Stroke = color,
            //            X1 = edge.A.X,
            //            X2 = edge.B.X,
            //            Y1 = edge.A.Y,
            //            Y2 = edge.B.Y
            //        });
            //    }
            //}

            //this.Title = string.Format("Render {0} Components for {1} Verticies",
            //    surface.Count, map.Edges
        }

        static SolidColorBrush BrushByIndex(int index)
        {

            var properties = (from p in typeof(Brushes).GetProperties((BindingFlags)int.MaxValue)
                              where p.PropertyType == typeof(SolidColorBrush)
                              select p).ToArray();

            var brush = properties[index % properties.Length];

            return (SolidColorBrush)brush.GetValue(null,null);
        }

    }
}
