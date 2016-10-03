using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Accord.Math;
using Accord.Math.Kinematics;

namespace DH
{
    public partial class db
    {
        public IEnumerable<Image> GetImages()
        {
            Func<ImagesRow, Image> conv = o =>
            {
                return byteArrayToImg(o.PlaneXY);
            };
            //  IEnumerable<DH.db.ImagesRow> imgs = this.Images;
            IEnumerable<Image> images = this.Images.Select(conv);

            return images;
        }

        public DenavitHartenbergNode[] ComputeNodes()
        {
            IEnumerable<ModelsRow> models = this.Models.Rows.OfType<ModelsRow>();
            models = models.Where(p => p.Show);
            IEnumerable<DenavitHartenbergNode> nodes = models.Select(p => p.Arm);

            foreach (DenavitHartenbergNode n in nodes)
            {
                n.Compute();
            }
            return nodes.ToList().ToArray();
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

        public void Link()
        {
            IList<DH.db.ModelsRow> models = this.Models.Where(p => p.Show).ToList();
            int count = models.Count();
            for (int i = 0; i < count; i++)
            {
                DH.db.ModelsRow m = models[i];
                m.Link();
            }
        }

        private Matrix4x4 transform;

        /// <summary>
        /// The basePosition is the chosen
        /// </summary>
        /// <param name="basePosition"></param>
        /// <param name="maxPathCnt"></param>
        public void FindEndPosition(Vector4 basePosition)
        {
            //position of end-effector on first frame?
            Vector4 position0 = Matrix4x4.Multiply(transform, basePosition);

            //ENDEFFECTORPOSITION IS THIS ONE
            db.ModelsRow m = this.Models.MakeAModel(0);
            m.ModelType = 0;
            m.x = position0.X;
            m.y = position0.Y;
            m.z = position0.Z;
        }

        public void CleanPath()
        {
            IEnumerable<DH.db.ModelsRow> mods = this.Models;
            mods = mods.Where(o => o.ModelType == 0).ToList();
            foreach (DH.db.ModelsRow m in mods)
            {
                m.Delete();
                //   m.AcceptChanges();
            }
            this.AcceptChanges();
        }

        //double angle = 0;                // Angle variable for animation
        public void AnimateAs()
        {
            IEnumerable<DH.db.ModelsRow> models = this.Models;
            models = models.Where(p => p.ModelType > 0);
            models = models.Where(p => p.Show);
            models = models.ToList();

            foreach (DH.db.ModelsRow m in models)
            {
                IEnumerable<DH.db.JointsRow> joints = m.GetJointsRows();
                joints = joints.Where(p => p.Show);

                foreach (DH.db.JointsRow j in joints) j.Animate();

                joints = null;
            }

            models = null;
        }

        public static byte[] imageToByteArray(System.Drawing.Image image)
        {
            // MemoryStream ms = new MemoryStream();

            // image.Save(ms, image.RawFormat);
            // return ms.ToArray();

            return (byte[])new ImageConverter().ConvertTo(image, typeof(byte[]));
        }

        public static System.Drawing.Image byteArrayToImg(byte[] arr)
        {
            // MemoryStream ms = new MemoryStream();

            // System.Drawing.Image image;
            // image.Save(ms, image.RawFormat);
            // return ms.ToArray();
            return (Bitmap)((new ImageConverter()).ConvertFrom(arr));

            //            return (Image)new ImageConverter().ConvertTo(arr, typeof(Image));
        }


        public bool ShouldCheck (int maxPathCnt)
        {

            
                return this.Models.Where(o => o.ModelType == 0).Count() > maxPathCnt;
            
        }
        internal void CheckIteration(ref IEnumerable<object> images)
        {
           
                // this.Images.Clear();
                // foreach (System.Drawing.Image i in imgs)
                //    {

                IList<Image> ls = images.Cast<Image>().ToList();

                Application.DoEvents();
                ImagesRow r = this.Images.NewImagesRow();
                this.Images.AddImagesRow(r);

                r.PlaneXY = imageToByteArray(ls[0]); //.Clone().To<byte[]>();
                Application.DoEvents();
                r.PlaneXZ = imageToByteArray(ls[1]);
                Application.DoEvents();
                r.PlaneYZ = imageToByteArray(ls[2]);
                Application.DoEvents();

                byte[] prueba = Encoding.ASCII.GetBytes(this.GetXml());// ConvertTo( this.GetXml(), typeof(byte[]));
                Application.DoEvents();
                Application.DoEvents();
                r.FinalDH = prueba;


                ls.Clear();
                ls = null;
                prueba = null;
               
           
           
        }
    }
}