using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Timers;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Media3D;
using System.Windows.Threading;
namespace wpfViewer
{
    public partial class Another
    {

        private Timer _timer;
        private readonly List<ModelVisual3D> _models = new List<ModelVisual3D>();
        private double _angle;


        private void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Normal, new Action<double>(Transform), 0.5d);
        }





    }
}
