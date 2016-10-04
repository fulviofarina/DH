using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

     //   Viewport3D viewer;
      //  Slider slider;

        public MainWindow()
        {
            InitializeComponent();

           

           // viewer = FindName("viewport3D1") as Viewport3D ;
          //  slider = FindName("slider1") as Slider;
           // slider.CommandBindings.Clear();
          

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
           // Button b = sender as Button;
           


            slider.Value += 60;//.CommandBindings.Clear();

        }
    }
}
