using System;
using System.Linq;
using Accord.Math;
using Accord.Math.Kinematics;

namespace DH
{
    public partial class db
    {
       

        public partial class JointsRow
        {
            //  private DenavitHartenbergJoint joint;

            public DenavitHartenbergJoint Joint
            {
                get
                {
                     double factor =  (Math.PI / 180);
                    // joint = null;
                    return new DenavitHartenbergJoint(alpha * factor, theta * factor, r, d);
                    //  return joint;
                }
            }

            public void Animate()
            {
                if (FreedomRow.theta)
                {
                    double angle = 0;
                    angle = theta;
                    double ft = FactorsRow.theta;
                    if (angle > 360 && ft > 0 || angle < 0 && ft < 0) ft = -1 * ft;
                    //  if (angle > 360 && FactorsRow.theta > 0 || angle < 0 && FactorsRow.theta < 0) FactorsRow.theta = -1 * FactorsRow.theta;
                    //       else if (angle < 0) fac = -1 * fac;
                    angle += ft;
                    FactorsRow.theta = ft; //maldita sea no borrar
                    theta = angle;
                }
                if (FreedomRow.alpha)
                {
                    double angle2 = 0;
                    angle2 = alpha;
                    double fa = FactorsRow.alpha;
                    if (angle2 > 360 && fa > 0 || angle2 < 0 && fa < 0) fa = -1 * fa;
                    angle2 += fa;
                    FactorsRow.alpha = fa; //maldita sea no borrar

                    alpha = angle2;
                }
                // theta = alpha = angle;
                //  theta = (float)(Math.Sin(angle) * Math.PI / 4 + Math.PI / 6);
                //  alpha = (float)(Math.Sin(angle) * Math.PI / 4 + Math.PI / 6);
                if (FreedomRow.d) d += (FactorsRow.d);
                if (FreedomRow.r) r += (FactorsRow.r);
            }
        }

        public partial class JointsDataTable
        {
            public JointsRow MakeAJoint(ref ModelsRow m)
            {
                JointsRow j = this.NewJointsRow();

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