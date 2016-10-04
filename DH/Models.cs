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
   

        public partial class ModelsRow
        {
            private DenavitHartenbergModel model;
            private DenavitHartenbergNode arm;
            private Vector4 vector;
           
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
            /// <summary>
            /// Makes a ModelRow base on the ModelType
            /// Type =  0 = EndPosition
            /// Type = -1 = BasePosition
            /// Type = 1 = A DH Model
            /// </summary>
            /// <param name="modelType">The ModelType to associate</param>
            /// <returns></returns>
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