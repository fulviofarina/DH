using System;
using System.Collections.Generic;
using System.Timers;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Media3D;
using System.Windows.Threading;

namespace wpfViewer
{
    
    public partial class Another : Window
    {
        public Another()
        {
            InitializeComponent();
            Init(new Point3D(0, 0, 30), new Point3D(0, 0, -30));
        }

      
      
     
    }

}