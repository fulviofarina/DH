using System.Linq;
using Accord.Math;
using Accord.Math.Kinematics;

namespace DH
{
    public partial class db
    {
        private Matrix4x4 transform;

        /// <summary>
        /// The basePosition is the chosen
        /// </summary>
        /// <param name="basePosition"></param>
        /// <param name="maxPathCnt"></param>
        public void FindEndPosition(Vector4 basePosition)
        {
            //position of end-effector on first frame?
            Vector4 position1 = Matrix4x4.Multiply(transform, basePosition);

            //ENDEFFECTORPOSITION IS THIS ONE
            db.ModelsRow m = this.Models.MakeAModel(0);
            //  m.ModelType = 0;
            m.x = position1.X;
            m.y = position1.Y;
            m.z = position1.Z;
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
                    matrix = Matrix4x4.Multiply(matrix, n.Model.Transform);
                }
            }

            transform = matrix;
        }
    }
}