using System.Windows;
using System.Windows.Controls;

namespace ClassicUI
{
    /// <summary>
    /// Interaction logic for ToolBarButton.xaml
    /// </summary>
    public partial class ToolBarButton : UserControl
    {
        public string Text 
        { 
            get { return (string)Button.Content; }
            set { Button.Content = value; } 
        }


        public ToolBarButton()
        {
            InitializeComponent();
        }
    }
}
