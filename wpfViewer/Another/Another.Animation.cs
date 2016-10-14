using System;
using System.Collections.Generic;

using System.Timers;
using System.Windows.Media.Media3D;
using System.Windows.Threading;

namespace wpfViewer
{
    public partial class Another
    {
        /// <summary>
        /// for animation
        /// </summary>
        public Timer _timer;

     
        /// <summary>
        /// used in animation
        /// </summary>
        private double _angle;

        private void TimerElapsed(object sender, ElapsedEventArgs e)
        {

            Action<double, Vector3D> action = new Action<double, Vector3D>(Transform);
            Vector3D axis = new Vector3D(0, 1, 1);
           // double adjustBy = 0.5d;
            double adjustBy = 0.5d;
            Dispatcher.Invoke(DispatcherPriority.Normal, action, adjustBy, axis);


        }
    }
}