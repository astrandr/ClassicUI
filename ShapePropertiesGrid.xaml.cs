using System.Windows;
using System.Windows.Controls;

namespace ClassicUI
{
    /// <summary>
    /// Interaction logic for UserC.xaml
    /// </summary>
    public partial class ShapePropertiesGrid : UserControl
    {
        public static DependencyProperty ColumnHeaderProperty = DependencyProperty.Register(
            nameof(ColumnHeader),
            typeof(string),
            typeof(ShapePropertiesGrid),
            new PropertyMetadata("Shape", OnColumnHeaderChanged));

        public string ColumnHeader
        {
            get => (string)GetValue(ColumnHeaderProperty);
            set => SetValue(ColumnHeaderProperty, value);
        }

        private static void OnColumnHeaderChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = (ShapePropertiesGrid)d;
            control.ShapeColumn.Header = e.NewValue;
        }

        public ShapePropertiesGrid()
        {
            InitializeComponent();
        }
    }
}
