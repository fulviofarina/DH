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

            public void MakeAJoint(int ModelID)
            {
                DH.db.JointsRow j = this.NewJointsRow();

            
                j.ModelID = ModelID;
                j.Nr = this.Count+1;
                j.theta = Math.PI / 4;
                j.alpha = 0;
                j.r = 35;//is it radius?
                j.d = 0; //is it offset?


                this.AddJointsRow(j);

            }


        }

        public partial class ModelsRow
        {
            DenavitHartenbergModel model;
            DenavitHartenbergNode arm;
            private Vector3 vector;

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
            public Vector3 Vector
            {

                get
                {
                    vector = new Vector3((float)this.x, (float)this.y, (float)this.z);
                    return vector;
                }
            }

        }
        public partial class ModelsDataTable
        {

            public void MakeAModel()
            {
                DH.db.ModelsRow j = this.NewModelsRow();

                j.x = 0;
                j.y = 0;
                j.z = 0;

             

                this.AddModelsRow(j);
            }
            public void LinkModels()
            {
                foreach (ModelsRow m in this)
                {


                    m.Model = new DenavitHartenbergModel(m.Vector);

                    // = v;
                    // Create the model combinator from the parent model
                    m.Arm = new DenavitHartenbergNode(m.Model);

              

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
                  
                }
            }

        }

    }
}
