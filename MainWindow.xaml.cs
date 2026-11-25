using System.Windows;

namespace ClassicUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string GridColumnHeader { get; set; } = "Test header";

        public MainWindow()
        {
            InitializeComponent();

            PropertiesGrid.DataContext = new
            {
                ItemsSource = new[] { "Rectangle", "Ellipse", "Triangle" }
            };
        }
    }
}