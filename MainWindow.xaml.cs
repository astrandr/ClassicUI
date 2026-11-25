using System.ComponentModel;
using System.Windows;

namespace ClassicUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private string _gridColumnHeader = "Test header";

        public string GridColumnHeader
        {
            get => _gridColumnHeader;
            set
            {
                if (_gridColumnHeader == value) return;

                _gridColumnHeader = value;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(GridColumnHeader)));
            }
        }

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
            this.GridColumnHeader = "New header";
        }
    }
}