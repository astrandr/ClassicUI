using System.ComponentModel;
using System.Windows;

namespace ClassicUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();

            PropertiesGrid.DataContext = new
            {
                ItemsSource = new[] { "Rectangle", "Ellipse", "Triangle" }
            };
        }

        private void RectangleButton_Click(object sender, RoutedEventArgs e)
        {
            this.PropertiesGrid.ColumnHeader = "New header";
            PropertiesGrid.DataContext = new
            {
                ItemsSource = new[] { "Ellipse", "Ellipse", "Ellipse" }
            };
        }
    }
}