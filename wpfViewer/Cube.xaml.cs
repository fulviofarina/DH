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
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace wpfViewer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Cube : Window
    {

     //   Viewport3D viewer;
      //  Slider slider;

        public Cube()
        {
            InitializeComponent();

           

           // viewer = FindName("viewport3D1") as Viewport3D ;
          //  slider = FindName("slider1") as Slider;
           // slider.CommandBindings.Clear();
          

        }
       // string angleProperty = "Angle";

        private void button_Click(object sender, RoutedEventArgs e)
        {
            // Button b = sender as Button;


            //LA GEOMETRIA BASE MESH

            //Modelo 3D
          


            //Modelo Geo3D
            MeshGeometry3D g3d = new MeshGeometry3D();
            g3d.TriangleIndices = this.meshGeo.TriangleIndices;
            g3d.Positions = this.meshGeo.Positions;
         
            GeometryModel3D geo3d = new GeometryModel3D();
            geo3d.Geometry = g3d;

      
         
            //material and color
            Color colorMesh = Colors.Red;
            //Color.AliceBlue es el mejor para hacer GHOST

            SolidColorBrush sbrush = new SolidColorBrush();
            sbrush.Color = colorMesh; //asign color

            DiffuseMaterial difuse = new DiffuseMaterial();
            difuse.Brush = sbrush; //assign brush to Material
            geo3d.Material = difuse; //assign material to GeoModel 3d




            //ROTATE
            double xA = 1;
            double yA = 4;
            double zA = 6;

            double x = 100;
            double y = 40;
            double z = 60;

            AxisAngleRotation3D d = new AxisAngleRotation3D();
            d.Axis = new Vector3D(xA, yA, zA);
            //I HAVE TO VARY THE ANGLE!!
            //d.Angle;
            Rotation3D rot3d = d;

            // RotateTransform3D rot3d = new RotateTransform3D()
            Point3D point = new Point3D(x, y, z);
            RotateTransform3D rotTranf3d = new RotateTransform3D(rot3d, point);



            ModelVisual3D model3d = new ModelVisual3D();
            model3d.Content = geo3d; //asociacion

            model3d.Transform = rotTranf3d;
            //  Model3D mod = Model3D.TransformProperty;


            viewer.Children.Add(model3d);

           // DependencyProperty p = slider.Value;
           // slider.SetBinding( "{ Binding ElementName = aAngleRota, Path=Angle}");
            //  Binding n = new Binding(angleProperty);
            //  n.ElementName = aAngleRota.ToString();


            slider.Value += 60;//.CommandBindings.Clear();

        }
    }
}
