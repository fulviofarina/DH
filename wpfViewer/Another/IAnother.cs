using System.Windows.Media;
using System.Windows.Media.Media3D;

namespace wpfViewer
{
    public interface IAnother
    {
        ModelVisual3D CreateSphere(Point3D center, double radius, int u, int v, Color color);
        Model3DGroup CreateTriangleFace(Point3D p0, Point3D p1, Point3D p2, Color color);
        ModelVisual3D GetCube(MaterialGroup materialGroup, Point3D point, Size3D size);
        ModelVisual3D GetCylinder(MaterialGroup materialGroup, Point3D midPoint, double radius, double depth);
        MaterialGroup GetSurfaceMaterial(Color colour);
        void Init(Point3D firstPoint, Point3D secondPoint);
      //  void InitializeComponent();
    }
}