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

       


        private Model3DGroup CreateTriangleModel(MaterialGroup materialGroup, Triangle triangle)
        {
            return CreateTriangleModel(materialGroup, triangle.P0, triangle.P1, triangle.P2);
        }


        private Model3DGroup CreateTriangleModel(Material material, Point3D p0, Point3D p1, Point3D p2)
        {
            var mesh = new MeshGeometry3D();
            mesh.Positions.Add(p0);
            mesh.Positions.Add(p1);
            mesh.Positions.Add(p2);
            mesh.TriangleIndices.Add(0);
            mesh.TriangleIndices.Add(1);
            mesh.TriangleIndices.Add(2);
            var normal = CalculateNormal(p0, p1, p2);
            mesh.Normals.Add(normal);
            mesh.Normals.Add(normal);
            mesh.Normals.Add(normal);

            var model = new GeometryModel3D(mesh, material);

            var group = new Model3DGroup();
            group.Children.Add(model);
            return group;
        }


        private Vector3D CalculateNormal(Point3D p0, Point3D p1, Point3D p2)
        {
            var v0 = new Vector3D(p1.X - p0.X, p1.Y - p0.Y, p1.Z - p0.Z);
            var v1 = new Vector3D(p2.X - p1.X, p2.Y - p1.Y, p2.Z - p1.Z);
            return Vector3D.CrossProduct(v0, v1);
        }


        private void Transform(double adjustBy)
        {
            _angle += adjustBy;

            var rotateTransform3D = new RotateTransform3D { CenterX = 0, CenterZ = 0 };
            var axisAngleRotation3D = new AxisAngleRotation3D { Axis = new Vector3D(1, 1, 1), Angle = _angle };
            rotateTransform3D.Rotation = axisAngleRotation3D;
            var myTransform3DGroup = new Transform3DGroup();
            myTransform3DGroup.Children.Add(rotateTransform3D);
            _models.ForEach(x => x.Transform = myTransform3DGroup);
        }




    }
}
