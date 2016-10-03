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

     
    }
}