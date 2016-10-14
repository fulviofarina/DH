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





            //  interf.

        }
        public void Do(Point3D firstPoint)
        {
          

            ModelVisual3D m = CreateSphere(firstPoint, 6, 10, 10, Colors.AliceBlue);
            _models.Add(m);

       

           
        }
        public void ADD()
        {
            _models.ForEach(x => mainViewport.Children.Add(x));
        }

        public void nothing()
        {
            //set interface
            IAnother interf = this;

            Point3D firstPoint = new Point3D(0, 0, 50);
            Point3D secondPoint = new Point3D(0, 0, 10);


            var midPoint = firstPoint - secondPoint;
            var thirdpoint = midPoint - secondPoint;

            ModelVisual3D m = CreateSphere(firstPoint, 6, 10, 10, Colors.AliceBlue);
            _models.Add(m);

            m = CreateSphere(secondPoint, 6, 10, 10, Colors.AliceBlue);
            _models.Add(m);

            m = CreateSphere(thirdpoint, 6, 10, 10, Colors.AliceBlue);
            _models.Add(m);

            /*
           MaterialGroup mgr = GetSurfaceMaterial(Colors.Red);
        m = GetCylinder(mgr, secondPoint, 3, midPoint.Z);
           _models.Add(m);

    */

            _models.ForEach(x => mainViewport.Children.Add(x));


            //   interf.Init()
            //  interf.Init(new Point3D(0, 0, 50), new Point3D(0, 0, 10));
            //    interf.Init(new Point3D(0, 0, 500), new Point3D(0, 0, -400));
            //     interf.Init(new Point3D(0, 0, -40), new Point3D(0, 0, -90));


            _timer = new Timer(10);
            _timer.Elapsed += TimerElapsed;
            _timer.Enabled = true;
        }

    }
}