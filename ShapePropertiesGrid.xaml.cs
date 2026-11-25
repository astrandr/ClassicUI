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
            new PropertyMetadata("Shape")
            );

        public string ColumnHeader
        {
            get => (string)GetValue(ColumnHeaderProperty);
            set => SetValue(ColumnHeaderProperty, value);
        }


        public ShapePropertiesGrid()
        {
            InitializeComponent();
        }
    }
}
