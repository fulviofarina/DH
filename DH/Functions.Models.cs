using System.Collections.Generic;
using System.Data;
using System.Linq;
using Accord.Math;
using Accord.Math.Kinematics;

namespace DH
{
    public partial class db
    {
        /// <summary>
        /// Recomputes all the nodes asociated to the ModelsTable that have been selected (p.Show)
        /// </summary>
        /// <returns></returns>
        public DenavitHartenbergNode[] ComputeNodes(bool show = true)
        {
            IEnumerable<ModelsRow> models = this.Models.Rows.OfType<ModelsRow>();
            models = models.Where(p => p.Show == show);
            IEnumerable<DenavitHartenbergNode> nodes = models.Select(p => p.Arm);
            nodes = nodes.ToList();

            foreach (DenavitHartenbergNode n in nodes)
            {
                n.Compute();
            }
            return nodes.ToList().ToArray();
        }

        public void Link()
        {
            IEnumerable<DH.db.ModelsRow> models = this.Models.Where(p => p.Show);
            models = models.ToList();

            foreach (ModelsRow item in models)
            {
                item.Link();
            }
        }

        public bool ShouldCheck(int maxPathCnt)
        {
            return this.Models.Where(o => o.ModelType == 0).Count() > maxPathCnt;
        }


        /// <summary>
        /// Cleans the points that draws the path followed by the end-effector
        /// </summary>
        public void CleanPath()
        {
            IEnumerable<DH.db.ModelsRow> mods = this.Models;
            mods = mods.Where(o => o.ModelType == 0).ToList();
            int count = mods.Count();
            foreach (DH.db.ModelsRow m in mods)
            {
                m.Delete();
              
            }
        }

        //double angle = 0;                // Angle variable for animation
        public void AnimateAs()
        {
            IEnumerable<ModelsRow> models = this.Models;
            models = models.Where(p => p.ModelType > 0);
            models = models.Where(p => p.Show);
            models = models.ToList();

            foreach (ModelsRow m in models)
            {
                IEnumerable<JointsRow> joints = m.GetJointsRows();
                joints = joints.Where(p => p.Show).ToList();

                foreach (JointsRow j in joints) j.Animate();

                // joints = null;
            }

            // models = null;
        }
    }
}