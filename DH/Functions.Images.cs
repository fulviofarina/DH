using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
            tableAdapterManager.ImagesTableAdapter.Fill(this.Images);

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
            images = null;
            prueba = null;


        }

       

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

      
    }
}