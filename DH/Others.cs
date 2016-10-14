using System;
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
                FreedomRow fre = this.NewFreedomRow();
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
                FactorsRow fa = this.NewFactorsRow();
                fa.JointID = jointID;
                fa.r = 0.001;
                fa.d = 0.001;
                fa.theta = 3.6;
                fa.alpha = 3.6;
                this.AddFactorsRow(fa);
            }
        }

    
    }
}