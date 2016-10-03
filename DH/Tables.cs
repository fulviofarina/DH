using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Accord.Math;
using Accord.Math.Kinematics;

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
            private DenavitHartenbergJoint joint;
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

            public void Animate()
            {
                double angle = 0;
                angle = theta;
                double ft = FactorsRow.theta;
                if (angle > 360 && ft > 0 || angle < 0 && ft < 0) ft = -1 * ft;
                //  if (angle > 360 && FactorsRow.theta > 0 || angle < 0 && FactorsRow.theta < 0) FactorsRow.theta = -1 * FactorsRow.theta;
                //       else if (angle < 0) fac = -1 * fac;
                angle += ft;

                if (FreedomRow.theta) theta = angle;

                angle = alpha;
                double fa = FactorsRow.alpha;
                if (angle > 360 && fa > 0 || angle < 0 && fa < 0) fa = -1 * fa;
                angle += fa;

                if (FreedomRow.alpha) alpha = angle;
                // theta = alpha = angle;
                //  theta = (float)(Math.Sin(angle) * Math.PI / 4 + Math.PI / 6);
                //  alpha = (float)(Math.Sin(angle) * Math.PI / 4 + Math.PI / 6);
                if (FreedomRow.d) d += (FactorsRow.d);
                if (FreedomRow.r) r += (FactorsRow.r);
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
            private DenavitHartenbergModel model;
            private DenavitHartenbergNode arm;
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

            public void Link()
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

        public partial class ModelsDataTable
        {
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
        }
    }
}