using System.Windows.Media.Media3D;

namespace wpfViewer
{
    public partial class Another
    {
        public class CircleAssitor
        {
            public CircleAssitor()
            {
                CurrentTriangle = new Triangle();
            }

            public Point3D FirstPoint { get; set; }
            public Point3D LastPoint { get; set; }
            public Triangle CurrentTriangle { get; set; }
        }

        public class Triangle
        {
            public Point3D P0 { get; set; }
            public Point3D P1 { get; set; }
            public Point3D P2 { get; set; }

            public Triangle Clone(double z, bool switchP1andP2)
            {
                var newTriangle = new Triangle();
                newTriangle.P0 = GetPointAdjustedBy(this.P0, new Point3D(0, 0, z));

                var point1 = GetPointAdjustedBy(this.P1, new Point3D(0, 0, z));
                var point2 = GetPointAdjustedBy(this.P2, new Point3D(0, 0, z));

                if (!switchP1andP2)
                {
                    newTriangle.P1 = point1;
                    newTriangle.P2 = point2;
                }
                else
                {
                    newTriangle.P1 = point2;
                    newTriangle.P2 = point1;
                }
                return newTriangle;
            }

            private Point3D GetPointAdjustedBy(Point3D point, Point3D adjustBy)
            {
                var newPoint = new Point3D { X = point.X, Y = point.Y, Z = point.Z };
                newPoint.Offset(adjustBy.X, adjustBy.Y, adjustBy.Z);
                return newPoint;
            }
        }

        private class VectorHelper
        {
            public static Vector3D CalcNormal(Point3D p0, Point3D p1, Point3D p2)
            {
                Vector3D v0 = new Vector3D(p1.X - p0.X, p1.Y - p0.Y, p1.Z - p0.Z);
                Vector3D v1 = new Vector3D(p2.X - p1.X, p2.Y - p1.Y, p2.Z - p1.Z);
                return Vector3D.CrossProduct(v0, v1);
            }
        }
    }
}