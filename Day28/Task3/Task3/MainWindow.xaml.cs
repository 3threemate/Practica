using System.Windows;

namespace CustomButtons
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TriangleButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Треугольная кнопка нажата!");
        }

        private void CircleButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Круглая кнопка нажата!");
        }

        private void PyramidButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Кнопка-пирамида нажата!");
        }
    }
}