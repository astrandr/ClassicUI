using System.Windows.Controls;

namespace ClassicUI
{
    /// <summary>
    /// Interaction logic for UserC.xaml
    /// </summary>
    public partial class ShapePropertiesGrid : UserControl
    {
        public string ColumnHeader
        {
            get => (string)ShapeColumn.Header;
            set => ShapeColumn.Header = value;
        }

        public ShapePropertiesGrid()
        {
            InitializeComponent();
        }
    }
}
