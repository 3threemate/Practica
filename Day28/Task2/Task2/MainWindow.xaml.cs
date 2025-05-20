using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Controls;

namespace ShapesDrawingExample
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Title = "Рисование фигур с помощью DrawingContext";
            Width = 800;
            Height = 1000;

            Loaded += (s, e) => DrawShapes();
        }

        private void DrawShapes()
        {
            DrawingVisual visual = new DrawingVisual();
            using (DrawingContext dc = visual.RenderOpen())
            {
                DrawTriangle(dc, new Point(50, 50), Brushes.LightBlue);

                DrawEllipse(dc, new Point(200, 80), 50, 30, Brushes.LightGreen);

                DrawCircle(dc, new Point(350, 80), 40, Brushes.Red);

                DrawRectangle(dc, new Point(450, 50), 100, 60, Brushes.Yellow);

                DrawPieSegment(dc, new Point(200, 200), 50, 0, 90, Brushes.Purple);

                DrawConcentricCircles(dc, new Point(100, 350));

                DrawRectangleSequence(dc, new Point(50, 450));

                DrawChessBoard(dc, new Point(50, 650), 40);

                DrawLabels(dc);
            }

            DrawingCanvas.Children.Clear();
            DrawingCanvas.Children.Add(new VisualHost(visual));
        }

        private void DrawTriangle(DrawingContext dc, Point position, Brush fill)
        {
            PathGeometry geometry = new PathGeometry();
            PathFigure figure = new PathFigure();
            figure.StartPoint = position;
            figure.Segments.Add(new LineSegment(new Point(position.X + 50, position.Y), true));
            figure.Segments.Add(new LineSegment(new Point(position.X + 25, position.Y + 50), true));
            figure.IsClosed = true;
            geometry.Figures.Add(figure);

            dc.DrawGeometry(fill, new Pen(Brushes.Black, 2), geometry);
        }

        private void DrawEllipse(DrawingContext dc, Point center, double radiusX, double radiusY, Brush fill)
        {
            dc.DrawEllipse(fill, new Pen(Brushes.Black, 2),
                center, radiusX, radiusY);
        }

        private void DrawCircle(DrawingContext dc, Point center, double radius, Brush fill)
        {
            dc.DrawEllipse(fill, new Pen(Brushes.Black, 2),
                center, radius, radius);
        }

        private void DrawRectangle(DrawingContext dc, Point topLeft, double width, double height, Brush fill)
        {
            Rect rect = new Rect(topLeft, new Size(width, height));
            dc.DrawRectangle(fill, new Pen(Brushes.Black, 2), rect);
        }

        private void DrawPieSegment(DrawingContext dc, Point center, double radius, double startAngle, double sweepAngle, Brush fill)
        {
            PathGeometry geometry = new PathGeometry();
            PathFigure figure = new PathFigure();
            figure.StartPoint = center;

            Point startPoint = new Point(
                center.X + radius * Math.Cos(startAngle * Math.PI / 180),
                center.Y + radius * Math.Sin(startAngle * Math.PI / 180));
            figure.Segments.Add(new LineSegment(startPoint, true));

            Point endPoint = new Point(
                center.X + radius * Math.Cos((startAngle + sweepAngle) * Math.PI / 180),
                center.Y + radius * Math.Sin((startAngle + sweepAngle) * Math.PI / 180));

            bool isLargeArc = sweepAngle > 180;
            figure.Segments.Add(new ArcSegment(
                endPoint, new Size(radius, radius), 0, isLargeArc,
                SweepDirection.Clockwise, true));

            figure.Segments.Add(new LineSegment(center, true));
            figure.IsClosed = true;
            geometry.Figures.Add(figure);

            dc.DrawGeometry(fill, new Pen(Brushes.Black, 1), geometry);
        }

        private void DrawConcentricCircles(DrawingContext dc, Point center)
        {
            dc.DrawEllipse(null, new Pen(Brushes.Black, 1),
                center, 60, 60);

            dc.DrawEllipse(null, new Pen(Brushes.Black, 1),
                center, 40, 40);

            dc.DrawEllipse(null, new Pen(Brushes.Black, 1),
                center, 20, 20);
        }

        private void DrawRectangleSequence(DrawingContext dc, Point startPosition)
        {
            double size = 60; 
            Point currentPosition = startPosition;

            for (int i = 0; i < 5; i++)
            {
                Rect rect = new Rect(currentPosition, new Size(size, size));
                dc.DrawRectangle(Brushes.White, new Pen(Brushes.Black, 1), rect);

                currentPosition = new Point(
                    currentPosition.X + size - 8, 
                    currentPosition.Y + size - 8);
                size -= 8; 
            }
        }

        private void DrawChessBoard(DrawingContext dc, Point topLeft, double cellSize)
        {
            cellSize = 30; // было 40, теперь 30
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    Brush fill = (row + col) % 2 == 0 ? Brushes.White : Brushes.Black;
                    Rect rect = new Rect(
                        topLeft.X + col * cellSize,
                        topLeft.Y + row * cellSize,
                        cellSize,
                        cellSize);

                    dc.DrawRectangle(fill, new Pen(Brushes.Gray, 0.5), rect);
                }
            }
        }


        private void DrawLabels(DrawingContext dc)
        {
            DrawText(dc, "1. Треугольник", 50, 120);
            DrawText(dc, "2. Эллипс", 200, 130);
            DrawText(dc, "3. Закрашенный круг", 350, 130);
            DrawText(dc, "4. Закрашенный прямоугольник", 450, 120);
            DrawText(dc, "5. Сектор", 200, 270);
            DrawText(dc, "6. Концентрические круги", 50, 470);
            DrawText(dc, "7. Последовательность прямоугольников", 50, 620);
            DrawText(dc, "8. Шахматная доска 8x8", 50, 980);
        }

        private void DrawText(DrawingContext dc, string text, double x, double y)
        {
            var formattedText = new FormattedText(
                text,
                System.Globalization.CultureInfo.CurrentCulture,
                FlowDirection.LeftToRight,
                new Typeface("Arial"),
                14,
                Brushes.Black,
                VisualTreeHelper.GetDpi(this).PixelsPerDip);

            dc.DrawText(formattedText, new Point(x, y));
        }
    }

    // Класс для отображения DrawingVisual
    public class VisualHost : FrameworkElement
    {
        private Visual _visual;

        public VisualHost(Visual visual)
        {
            _visual = visual;
            AddVisualChild(_visual);
            AddLogicalChild(_visual);
        }

        protected override int VisualChildrenCount => _visual != null ? 1 : 0;

        protected override Visual GetVisualChild(int index)
        {
            if (index != 0 || _visual == null)
                throw new ArgumentOutOfRangeException();
            return _visual;
        }
    }
}