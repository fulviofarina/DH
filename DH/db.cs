using System;
using System.Windows.Forms;
using Accord.Controls;
using Accord.Math.Kinematics;
using Accord.Math;
using System.Collections.Generic;
using System.Data;
using System.Linq;
namespace DH
{


    public partial class db
    {
        public partial class FreedomDataTable
        {
            public void MakeAFreedom(int jointID)
            {

                db.FreedomRow fre = this.NewFreedomRow();
                fre.JointID = jointID;
                fre.r = false;
                fre.d = false;
                fre.theta = false;
                fre.alpha = false;
                this.AddFreedomRow(fre);
            }
        }
        public partial class FactorsDataTable
        {
            public void MakeAFactor(int jointID)
            {

                db.FactorsRow fre = this.NewFactorsRow();
                fre.JointID = jointID;
                fre.r = 0.001;
                fre.d = 0.001;
                fre.theta = 3.6;
                fre.alpha = 3.6;
                this.AddFactorsRow(fre);
            }
        }
        public partial class JointsRow
        {
            DenavitHartenbergJoint joint;
            private const double factor = Math.PI * 2 / 360;
            public DenavitHartenbergJoint Joint
            {
                get
                {

                    joint = new DenavitHartenbergJoint(alpha * factor, theta * factor, r, d);
                    return joint;
                }

                set
                {
                    joint = value;
                }
            }
        }
        public partial class JointsDataTable
        {

            public DH.db.JointsRow MakeAJoint(ref ModelsRow m)
            {
                DH.db.JointsRow j = this.NewJointsRow();


                j.ModelID = m.ID;
                j.Nr = m.GetJointsRows().Count() + 1;
                j.theta = Math.PI / 4;
                j.alpha = 0;
                j.r = 35;//is it radius?
                j.d = 0; //is it offset?
                j.Show = true;



                this.AddJointsRow(j);
                return j;
            }




        }

        public partial class ModelsRow
        {
            DenavitHartenbergModel model;
            DenavitHartenbergNode arm;
            private Vector4 vector;
            /*
            public DenavitHartenbergModel Model
            {
                get
                {
                    return model;
                }
                set
                {
                    model = value;
                }

            }
             */

            public DenavitHartenbergNode Arm
            {
                get
                {
                    return arm;
                }
                set
                {
                    arm = value;
                }

            }
           
            public Vector4 Vector
            {

                get
                {
                   // vector = new Vector4((float)this.x, (float)this.y, (float)this.z, 1);
                    return vector;
                }
            }

            public void LinkModel()
            {


                vector = new Vector4((float)this.x, (float)this.y, (float)this.z, 1);


                Vector3 v = new Vector3(vector.X, vector.Y, vector.Z);
                model = new DenavitHartenbergModel(v);

                // = v;
                // Create the model combinator from the parent model
                arm = new DenavitHartenbergNode(model);

                //  m.RefreshPosition();

                IEnumerable<DH.db.JointsRow> joints = GetJointsRows().Where(o => o.Show);
                joints = joints.OrderBy(p => p.Nr).ToList();

                model.Joints.Clear();
                foreach (DH.db.JointsRow j in joints)
                {
                    model.Joints.Add(j.Joint);
                }


            }


        }
        public DenavitHartenbergNode[] ComputeNodes()
        {
            IEnumerable<ModelsRow> models = this.Models.Rows.OfType<ModelsRow>();
            models = models.Where(p => p.Show);
            IEnumerable<DenavitHartenbergNode> nodes =models.Select(p => p.Arm);

            foreach (DenavitHartenbergNode n in nodes)
            {
                n.Compute();
            }
            return nodes.ToList().ToArray();
        }
        public void SetFKTFromBaseToEndPoint(DenavitHartenbergNode[] nodes)
        {

            Matrix4x4 matrix = nodes.First().Model.Transform;
            bool assigned = false;
            foreach (DenavitHartenbergNode n in nodes)
            {
                if (!assigned)
                {

                    assigned = true;
                }
                else
                {
                    matrix = Matrix4x4.Multiply( matrix, n.Model.Transform);

                }
            }


            transform = matrix;

        }

        private Matrix4x4 transform;

        /// <summary>
        /// The basePosition is the chosen
        /// </summary>
        /// <param name="basePosition"></param>
        /// <param name="maxPathCnt"></param>
        public void FindEndPosition(Vector4 basePosition, int maxPathCnt)
        {
            //position of end-effector on first frame?
            Vector4 position0 = Matrix4x4.Multiply(transform, basePosition);

            if (this.Models.Count> maxPathCnt)
            {
                this.Models.CleanPath();
            }

            //ENDEFFECTORPOSITION IS THIS ONE
            db.ModelsRow m = this.Models.MakeAModel(0);
            m.ModelType = 0;
            m.x = position0.X;
            m.y = position0.Y;
            m.z = position0.Z;


        }

        public partial class ModelsDataTable
        {
            public void CleanPath()
            {

                IEnumerable<DH.db.ModelsRow> mods = this;
                mods = mods.Where(o=> o.ModelType == 0).ToList();
                foreach (DH.db.ModelsRow m in mods)
                {
                    m.Delete();
                 //   m.AcceptChanges();
                }
                  this.AcceptChanges();

            }
            double angle = 0;                // Angle variable for animation
            public void AnimateAs()
            {


                IEnumerable<DH.db.ModelsRow> models = this.Where(p=> p.ModelType>0).Where(p => p.Show).ToList();

                foreach (DH.db.ModelsRow m in models)
                {

               //     if (!m.Show) continue;

                    IEnumerable<DH.db.JointsRow> joints = m.GetJointsRows().Where(p=> p.Show);

                    foreach (DH.db.JointsRow j in joints)
                    {

                        angle = j.theta;
                        if (angle > 360 && j.FactorsRow.theta > 0 || angle < 0 && j.FactorsRow.theta < 0) j.FactorsRow.theta = -1 * j.FactorsRow.theta;
                        //       else if (angle < 0) fac = -1 * fac;
                        angle += j.FactorsRow.theta;

                        if (j.FreedomRow.theta) j.theta = angle;

                        angle = j.alpha;
                        if (angle > 360 && j.FactorsRow.alpha > 0 || angle < 0 && j.FactorsRow.alpha < 0) j.FactorsRow.theta = -1 * j.FactorsRow.alpha;
                        angle += j.FactorsRow.alpha;

                        if (j.FreedomRow.alpha) j.alpha = angle;
                        // j.theta = j.alpha = angle;
                        //  j.theta = (float)(Math.Sin(angle) * Math.PI / 4 + Math.PI / 6);
                        //  j.alpha = (float)(Math.Sin(angle) * Math.PI / 4 + Math.PI / 6);
                        if (j.FreedomRow.d) j.d += (j.FactorsRow.d);
                        if (j.FreedomRow.r) j.r += (j.FactorsRow.r);
                    }

                }

            }
            public DH.db.ModelsRow MakeAModel(int modelType)
            {
                DH.db.ModelsRow j = this.NewModelsRow();

                j.x = 0;
                j.y = 0;
                j.z = 0;

                j.ModelType = modelType;
                j.Show = true;
                this.AddModelsRow(j);
                return j;
            }


            public void LinkModels()
            {

                IList<DH.db.ModelsRow> models = this.Where(p => p.Show).ToList();
                int count = models.Count();
                for (int i = 0; i < count; i++)
                {
                    DH.db.ModelsRow m = models[i];
                    m.LinkModel();
                }
            }

        

        }

    }
}
