using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        //public void Slider_size(object sender, RoutedPropertyChangedEventArgs<double> e)
        //{
        //    if (Size != null)
        //    {
        //        slider1.Value = double.Parse(Size.Text);
        //        Message.FontSize = ((Slider)sender).Value;
        //    }
        //}
    }
}