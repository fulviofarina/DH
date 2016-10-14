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
                vector = new Vector4((float)x, (float)y, (float)z, 1);

                Vector3 v = new Vector3(vector.X, vector.Y, vector.Z);
                model = new DenavitHartenbergModel(v);

                // = v;
                // Create the model combinator from the parent model
                arm = new DenavitHartenbergNode(model);

                IEnumerable<JointsRow> joints = GetJointsRows().Where(o => o.Show);
                joints = joints.OrderBy(p => p.Nr).ToList();

                model.Joints.Clear();
                foreach (JointsRow j in joints)
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
            public ModelsRow MakeAModel(int modelType)
            {
                ModelsRow mod = this.NewModelsRow();

                mod.x = 0;
                mod.y = 0;
                mod.z = 0;

                mod.ModelType = modelType;
                mod.Show = true;

                this.AddModelsRow(mod);
                return mod;
            }
        }
    }
}