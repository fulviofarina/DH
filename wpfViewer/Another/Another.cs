using System;
using System.Windows.Media;
using System.Windows.Media.Media3D;
using System.Timers;
using System.Collections.Generic;

namespace wpfViewer
{
    public partial class Another : IAnother
    {

        //stores list of models
        private readonly List<ModelVisual3D> _models = new List<ModelVisual3D>();


        public void Joint(Point3D firstPoint, Point3D secondPoint)
        {



            var midPoint = firstPoint - secondPoint;


            ModelVisual3D m = CreateSphere(firstPoint, 2, 10, 10, Colors.YellowGreen);
            _models.Add(m);

            m = CreateSphere(secondPoint, 2, 10, 10, Colors.YellowGreen);
            _models.Add(m);

        //    MaterialGroup mgr = GetSurfaceMaterial(Colors.Red);
         //   m = GetCylinder(mgr, secondPoint, 3, midPoint.Z);

            _models.Add(m);



         //   _models.ForEach(x => mainViewport.Children.Add(x));


          
        }

        public void Init(Point3D firstPoint, Point3D secondPoint)
        {



            var midPoint = firstPoint - secondPoint;


             ModelVisual3D m = CreateSphere(firstPoint, 6, 10, 10, Colors.AliceBlue);
            _models.Add(m);

             m = CreateSphere(secondPoint, 6, 10, 10, Colors.AliceBlue);
            _models.Add(m);

            MaterialGroup mgr = GetSurfaceMaterial(Colors.Red);
            m = GetCylinder(mgr, secondPoint, 3, midPoint.Z);

            _models.Add(m);



            _models.ForEach(x => mainViewport.Children.Add(x));




        }

        public MaterialGroup GetSurfaceMaterial(Color colour)
        {
            var materialGroup = new MaterialGroup();
            var emmMat = new EmissiveMaterial(new SolidColorBrush(colour));
            materialGroup.Children.Add(emmMat);
            materialGroup.Children.Add(new DiffuseMaterial(new SolidColorBrush(colour)));
            var specMat = new SpecularMaterial(new SolidColorBrush(Colors.White), 30);
            materialGroup.Children.Add(specMat);
            return materialGroup;
        }

        public ModelVisual3D GetCube(MaterialGroup materialGroup, Point3D point, Size3D size)
        {
            var farPoint = new Point3D(point.X - (size.X / 2), point.Y - (size.Y / 2), point.Z - (size.Z / 2));
            var nearPoint = new Point3D(point.X + (size.X / 2), point.Y + (size.Y / 2), point.Z + (size.Z / 2));

            var cube = new Model3DGroup();
            var p0 = new Point3D(farPoint.X, farPoint.Y, farPoint.Z);
            var p1 = new Point3D(nearPoint.X, farPoint.Y, farPoint.Z);
            var p2 = new Point3D(nearPoint.X, farPoint.Y, nearPoint.Z);
            var p3 = new Point3D(farPoint.X, farPoint.Y, nearPoint.Z);
            var p4 = new Point3D(farPoint.X, nearPoint.Y, farPoint.Z);
            var p5 = new Point3D(nearPoint.X, nearPoint.Y, farPoint.Z);
            var p6 = new Point3D(nearPoint.X, nearPoint.Y, nearPoint.Z);
            var p7 = new Point3D(farPoint.X, nearPoint.Y, nearPoint.Z);
            //front side triangles
            cube.Children.Add(CreateTriangleModel(materialGroup, p3, p2, p6));
            cube.Children.Add(CreateTriangleModel(materialGroup, p3, p6, p7));
            //right side triangles
            cube.Children.Add(CreateTriangleModel(materialGroup, p2, p1, p5));
            cube.Children.Add(CreateTriangleModel(materialGroup, p2, p5, p6));
            //back side triangles
            cube.Children.Add(CreateTriangleModel(materialGroup, p1, p0, p4));
            cube.Children.Add(CreateTriangleModel(materialGroup, p1, p4, p5));
            //left side triangles
            cube.Children.Add(CreateTriangleModel(materialGroup, p0, p3, p7));
            cube.Children.Add(CreateTriangleModel(materialGroup, p0, p7, p4));
            //top side triangles
            cube.Children.Add(CreateTriangleModel(materialGroup, p7, p6, p5));
            cube.Children.Add(CreateTriangleModel(materialGroup, p7, p5, p4));
            //bottom side triangles
            cube.Children.Add(CreateTriangleModel(materialGroup, p2, p3, p0));
            cube.Children.Add(CreateTriangleModel(materialGroup, p2, p0, p1));
            var model = new ModelVisual3D();
            model.Content = cube;
            return model;
        }

        public ModelVisual3D GetCylinder(MaterialGroup materialGroup, Point3D midPoint, double radius, double depth)
        {


            var cylinder = new Model3DGroup();

            var nearCircle = new CircleAssitor();


            var farCircle = new CircleAssitor();



            var twoPi = Math.PI * 2;
            var firstPass = true;

            double x;
            double y;

            var increment = 0.1d;



            for (double i = 0; i < twoPi + increment; i = i + increment)
            {
                x = (radius * Math.Cos(i));
                y = (-radius * Math.Sin(i));

                farCircle.CurrentTriangle.P0 = midPoint;
                farCircle.CurrentTriangle.P1 = farCircle.LastPoint;
                Point3D p2New = new Point3D(x + midPoint.X, y + midPoint.Y, midPoint.Z);
                farCircle.CurrentTriangle.P2 = p2New;

                nearCircle.CurrentTriangle = farCircle.CurrentTriangle.Clone(depth, true);

                if (!firstPass)
                {
                    Model3DGroup mdgr = CreateTriangleModel(materialGroup, farCircle.CurrentTriangle);
                    cylinder.Children.Add(mdgr);
                    mdgr = CreateTriangleModel(materialGroup, nearCircle.CurrentTriangle);
                    cylinder.Children.Add(mdgr);
                    mdgr = CreateTriangleModel(materialGroup, farCircle.CurrentTriangle.P2, farCircle.CurrentTriangle.P1, nearCircle.CurrentTriangle.P2);
                    cylinder.Children.Add(mdgr);

                    mdgr = CreateTriangleModel(materialGroup, nearCircle.CurrentTriangle.P2, nearCircle.CurrentTriangle.P1, farCircle.CurrentTriangle.P2);
                    cylinder.Children.Add(mdgr);
                }
                else
                {
                    farCircle.FirstPoint = farCircle.CurrentTriangle.P1;
                    nearCircle.FirstPoint = nearCircle.CurrentTriangle.P1;
                    firstPass = false;
                }
                farCircle.LastPoint = farCircle.CurrentTriangle.P2;
                nearCircle.LastPoint = nearCircle.CurrentTriangle.P2;
            }


            var model = new ModelVisual3D { Content = cylinder };
            return model;
        }

        /// <summary>
        /// Makes a Sphere centered around the provided point
        /// </summary>
        /// <param name="center">center point of Sphere</param>
        /// <param name="radius">radius of Sphere</param>
        /// <param name="u"></param>
        /// <param name="v"></param>
        /// <param name="color">Spehere Color</param>
        /// <returns></returns>
        public ModelVisual3D CreateSphere(Point3D center, double radius, int u, int v, Color color)
        {
            Model3DGroup spear = new Model3DGroup();

            if (u < 2 || v < 2)
                return null;



            Point3D[,] pts = new Point3D[u, v];
            for (int i = 0; i < u; i++)
            {
                for (int j = 0; j < v; j++)
                {
                    double a= i * 180 / (u - 1);
                    double b = j * 360 / (v - 1);
                    pts[i, j] = getPosition(radius, a,b);
                    pts[i, j] += (Vector3D)center;
                }
            }

            Point3D[] p = new Point3D[4];
            for (int i = 0; i < u - 1; i++)
            {
                for (int j = 0; j < v - 1; j++)
                {

                    p[0] = pts[i, j];
                    p[1] = pts[i + 1, j];
                    p[2] = pts[i + 1, j + 1];
                    p[3] = pts[i, j + 1];
                    Model3DGroup m3dgr = CreateTriangleFace(p[0], p[1], p[2], color); 
                    Model3DGroup m3dgr2 = CreateTriangleFace(p[2], p[3], p[0], color);
                    spear.Children.Add(m3dgr);
                    spear.Children.Add(m3dgr2);
                }
            }


            ModelVisual3D model = new ModelVisual3D();
            model.Content = spear;


            return model;
        }

        /// <summary>
        /// Sphere realated
        /// </summary>
        /// <param name="radius"></param>
        /// <param name="theta"></param>
        /// <param name="phi"></param>
        /// <returns></returns>
        private Point3D getPosition(double radius, double theta, double phi)
        {
            Point3D pt = new Point3D();
            double factor = Math.PI / 180;
            theta = theta * factor;
            phi = phi * factor;
            double snt = Math.Sin(theta );
            double cnt = Math.Cos(theta );
            double snp = Math.Sin(phi);
            double cnp = Math.Cos(phi );
            pt.X = radius * snt * cnp;
            pt.Y = radius * cnt;
            pt.Z = -radius * snt * snp;
            return pt;
        }

        public Model3DGroup CreateTriangleFace(Point3D p0, Point3D p1, Point3D p2, Color color)
        {
        
            Vector3D normal = VectorHelper.CalcNormal(p0, p1, p2);

            MeshGeometry3D mesh = new MeshGeometry3D();
            Point3D[] t3D = { p0, p1, p2 };
            short i = 0;
            while (i<3)
            {
                mesh.Positions.Add(t3D[i]);
                mesh.TriangleIndices.Add(i);
                mesh.Normals.Add(normal);
                i++;
            }


            SolidColorBrush brush = new SolidColorBrush(color);


            Material material = new DiffuseMaterial(brush);
            GeometryModel3D model = new GeometryModel3D(mesh, material);



            Model3DGroup group = new Model3DGroup();
            group.Children.Add(model);

            return group;
        }
    }
}