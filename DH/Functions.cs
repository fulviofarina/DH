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
        /// <summary>
        /// Obtains an array of images from the stored ImagesRow DataTable images
        /// </summary>
        /// <returns>Array of images</returns>
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


        /// <summary>
        /// Functions to invoke when the max number of Path points have been draw
        /// in order to save the images into the database
        ///  </summary>
        /// <param name="images">images to save</param>
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
          //  Application.DoEvents();
            r.FinalDH = prueba;

            ls.Clear();
            ls = null;
            prueba = null;
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



        #region static utilities

        private static byte[] imageToByteArray(Image image)
        {
            // MemoryStream ms = new MemoryStream();

            // image.Save(ms, image.RawFormat);
            // return ms.ToArray();

            return (byte[])new ImageConverter().ConvertTo(image, typeof(byte[]));
        }

        private static Image byteArrayToImg(byte[] arr)
        {
            // MemoryStream ms = new MemoryStream();

            // System.Drawing.Image image;
            // image.Save(ms, image.RawFormat);
            // return ms.ToArray();
            return (Bitmap)((new ImageConverter()).ConvertFrom(arr));

            //            return (Image)new ImageConverter().ConvertTo(arr, typeof(Image));
        }

        #endregion

        #region MODELS

        /// <summary>
        /// Recomputes all the nodes asociated to the ModelsTable that have been selected (p.Show)
        /// </summary>
        /// <returns></returns>
        public DenavitHartenbergNode[] ComputeNodes(bool show=true)
        {
            IEnumerable<ModelsRow> models = this.Models.Rows.OfType<ModelsRow>();
            models = models.Where(p => p.Show==show);
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

        public void CleanPath()
        {
            IEnumerable<DH.db.ModelsRow> mods = this.Models;
            mods = mods.Where(o => o.ModelType == 0).ToList();
            int count = mods.Count();
            foreach (DH.db.ModelsRow m in mods)
            {
                m.Delete();
                //   m.AcceptChanges();
            }
           // this.Models.AcceptChanges();
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

        #endregion

    }
}