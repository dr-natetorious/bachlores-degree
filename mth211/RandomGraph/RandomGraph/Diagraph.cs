using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows;
using System.Windows.Shapes;

namespace RandomGraph
{
    /// <summary>
    /// Represents a Cryptographically Random Collection of Verticies and Edges
    /// </summary>
    class Diagraph : IDisposable
    {
        RandomNumberGenerator RandomGenerator;
        public ReadOnlyCollection<Point> Verticies { get; private set; }
        public ReadOnlyCollection<Edge> Edges { get; private set; }

        public ReadOnlyCollection<Component> Components { get; private set; }

        /// <summary>
        /// I&amps;m New!! Back to you Walley..
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="drawSize"></param>
        /// <param name="odds"></param>
        public Diagraph(int amount, Size drawSize, int odds)
        {
            RandomGenerator = RandomNumberGenerator.Create();
            Verticies = new ReadOnlyCollection<Point>(RandomPoints(amount, drawSize));
            Edges = new ReadOnlyCollection<Edge>(ConnectEdges(odds));
            Components = new ReadOnlyCollection<Component>(Component.FromMap(this));
        }

        /// <summary>
        /// Get a crytographically secure random number
        /// </summary>
        int CryptoRandomValue()
        {
            const int size_long = 4; //http://msdn.microsoft.com/en-us/library/vstudio/eahchzkf.aspx
            byte[] b = new byte[size_long];
            RandomGenerator.GetBytes(b);

            return BitConverter.ToInt32(b, 0);
        }
        public int RandomValue() { return Math.Abs(CryptoRandomValue()); }

        /// <summary>
        /// Select random points within a <paramref name="drawSpace"/> 
        /// </summary>
        /// <param name="amount">Number of points</param>
        /// <param name="drawSpace">Pick a size</param>
        public IList<Point> RandomPoints(int amount, Size drawSpace)
        {
            if (amount < 1) throw new ArgumentException("amount less than 1");

            var points = new Collection<Point>();

            for (var i = 0; i < amount; i++)
            {
                points.Add(new Point
                {
                    X = RandomValue() % drawSpace.Width,
                    Y= RandomValue() % drawSpace.Height,
                });
            }

            return points;
        }

        public IList<Edge> ConnectEdges(int odds)
        {
            var list = new List<Edge>();
            foreach(var vertice in Verticies)
            {
                var r = RandomValue() % 100;

                if(r < odds)
                {
                    var ix = (RandomValue() % Verticies.Count);
                    var randPoint = Verticies[ix];

                    list.Add(new Edge
                    {
                        A = vertice,
                        B = randPoint
                    });

                    continue;
                }
            }

            return list;
        }

        public IList<Point> PointsRadius(Point center, int radius)
        {
            var searchArea = new Rect
            {
                X = center.X,
                Y = center.Y,
                Size = new Size
                {
                    Width = radius,
                    Height = radius
                }
            };

            var list = new List<Point>();
            foreach(var point in this.Verticies)
            {

                if (point == center) continue;

                //
                //  Check point is in Search Area
                if(false == searchArea.IntersectsWith(new Rect
                {
                    X = point.X,
                    Y = point.Y,
                    Size = new Size { Height = 5, Width = 5 }
                })){continue; }

                //
                //  Add to List
                list.Add(point);
            }
            return new ReadOnlyCollection<Point>(list);
        }

        /// <summary>
        /// Free random number generator
        /// </summary>
        public void Dispose()
        {
            if(RandomGenerator != null)
            {
                RandomGenerator.Dispose();
            }
        }
    }

    class Edge
    {
        public Point A { get; set; }
        public Point B { get; set; }
    }

    class Component
    {
        public Collection<Edge> Connections { get; private set; }

        public Component()
        {
            Connections = new Collection<Edge>();
        }


        public bool IsConnected(Edge edge)
        {
            if (IsConnected(edge.A) || IsConnected(edge.B))
                return true;
            return false;
        }

        public bool IsConnected(Point point)
        {
            foreach(var connection in Connections)
            {
                if (connection.A == point || connection.B == point)
                    return true;
            }

            return false;
        }


        public static IList<Component> FromMap(Diagraph map)
        {
            var list = new List<Component>();

            foreach(var edge in map.Edges)
            {
                var match = list.FirstOrDefault(x => x.IsConnected(edge));
                if(match == null)
                {
                    var component = new Component();
                    component.Connections.Add(edge);

                    list.Add(component);
                }
                else
                {
                    match.Connections.Add(edge);
                }
            }

            return list;
            
        }

        
    }

}
