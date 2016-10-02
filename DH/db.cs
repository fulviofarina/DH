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

            public DenavitHartenbergJoint Joint
            {
                get
                {

                    joint = new DenavitHartenbergJoint(alpha, theta, r, d);
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

            public DH.db.JointsRow MakeAJoint(int ModelID)
            {
                DH.db.JointsRow j = this.NewJointsRow();


                j.ModelID = ModelID;
                j.Nr = this.Count + 1;
                j.theta = Math.PI / 4;
                j.alpha = 0;
                j.r = 35;//is it radius?
                j.d = 0; //is it offset?




                this.AddJointsRow(j);
                return j;
            }




        }

        public partial class ModelsRow
        {
            DenavitHartenbergModel model;
            DenavitHartenbergNode arm;
            private Vector4 vector;

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
                    vector = new Vector4((float)this.x, (float)this.y, (float)this.z, 1);
                    return vector;
                }
            }



        }
        public partial class ModelsDataTable
        {

            double angle = 0;                // Angle variable for animation
            public void AnimateAs()
            {

                double factor = 0.001;
                double fac = (factor * 3600);
                double fac2 = (factor * 3600);

                foreach (DH.db.ModelsRow m in this)
                {

                    IEnumerable<DH.db.JointsRow> joints = m.GetJointsRows();

                    foreach (DH.db.JointsRow j in joints)
                    {

                        
                        angle = j.theta;
                        if (angle > 360 && j.FactorsRow.theta > 0 || angle < 0 && j.FactorsRow.theta < 0) j.FactorsRow.theta = -1 * j.FactorsRow.theta;
                 //       else if (angle < 0) fac = -1 * fac;
                        angle += j.FactorsRow.theta;

                        if (j.FreedomRow.theta) j.theta = angle;

                        angle = j.alpha;
                        if (angle > 360  && j.FactorsRow.alpha > 0 || angle < 0 && j.FactorsRow.alpha<0) j.FactorsRow.theta = -1 * j.FactorsRow.alpha;
                        angle += j.FactorsRow.alpha;

                        if (j.FreedomRow.alpha) j.alpha = angle;
                        // j.theta = j.alpha = angle;
                        //  j.theta = (float)(Math.Sin(angle) * Math.PI / 4 + Math.PI / 6);
                        //  j.alpha = (float)(Math.Sin(angle) * Math.PI / 4 + Math.PI / 6);
                        if (j.FreedomRow.d) j.d += j.d * (j.FactorsRow.d);
                        if (j.FreedomRow.r) j.r += j.r * (j.FactorsRow.r);
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

                this.AddModelsRow(j);
                return j;
            }


            public void LinkModels()
            {
                foreach (DataRow r in this)
                {
                    ModelsRow m = r as ModelsRow;
                    LinkModels(ref m);

                }
            }
            public DenavitHartenbergNode[] ComputeNodes()
            {
                IEnumerable<DenavitHartenbergNode> nodes = this.Rows.OfType<ModelsRow>().Select(p => p.Arm);

                foreach (DenavitHartenbergNode n in nodes)
                {
                    n.Compute();
                }
                return nodes.ToList().ToArray();
            }
            public void LinkModels(ref ModelsRow m)
            {

                //   foreach (ModelsRow m in this)
                //   {


                m.Model = new DenavitHartenbergModel(new Vector3((float)m.x, (float)m.y, (float)m.z));

                // = v;
                // Create the model combinator from the parent model
                m.Arm = new DenavitHartenbergNode(m.Model);

                //  m.RefreshPosition();

                IEnumerable<DH.db.JointsRow> joints = m.GetJointsRows();
                joints = joints.OrderBy(p => p.Nr);

                m.Model.Joints.Clear();
                foreach (DH.db.JointsRow j in joints)
                {
                    m.Model.Joints.Add(j.Joint);
                }

                // Add the second joint
                // model.Joints.Add(alpha: 0, theta: -Math.PI / 3, radius: 35, offset: 0);

                //   arm.Compute();

                // Compute the images for displaying on the picture boxes

                //   }
            }

        }

    }
}
