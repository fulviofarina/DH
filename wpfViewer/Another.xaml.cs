using System.Timers;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Media3D;

namespace wpfViewer
{
    public partial class Another : Window
    {
        public Another()
        {
            InitializeComponent();


          //  Init(new Point3D(0,4,5), new Point3D(20,40,50));

            _timer = new Timer(1000);
            _timer.Elapsed += TimerElapsed;
            _timer.Enabled = true;

            //  interf.

        }
       
        public void ADD()
        {

            mainViewport.Children.Clear();
            try
            {
                _models.ForEach(x => mainViewport.Children.Add(x));

            }
            catch (System.Exception)
            {

            }
            _models.Clear();
            }

   

    }
}