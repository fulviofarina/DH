using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using Accord.Controls;
using Accord.Math.Kinematics;


using Axiom.Core;
using Axiom.Graphics;
using Axiom.Math;
using Axiom.Framework.Configuration;

namespace DH
{
    public partial class ucView : UserControl
    {

        RenderWindow window = null;
        Root root = null;
        public void prueba()
        {
            IConfigurationManager ConfigurationManager =  ConfigurationManagerFactory.CreateDefault();

            string glog = "Game1.log";
            root = new Root(glog);
          
            // ConfigurationManager = glog;
     //       ConfigurationManager.RestoreConfiguration(root);
       //     ConfigurationManager.RestoreConfiguration(root);
           // ConfigurationManager.SaveConfiguration(root, "DirectX9");
          //      if (ConfigurationManager.ShowConfigDialog(root))
                {

               
                
                //after
                  
                   root.RenderSystem = new Axiom.RenderSystems.DirectX9.D3DRenderSystem();
                //l
                window = root.Initialize(true);
                ResourceGroupManager.Instance.AddResourceLocation("media", "Folder", true);

                    SceneManager scene = root.CreateSceneManager(SceneType.Generic);
                    Camera camera = scene.CreateCamera("cam1");
                    Viewport viewport = window.AddViewport(camera);

                    TextureManager.Instance.DefaultMipmapCount = 5;
                    ResourceGroupManager.Instance.InitializeAllResourceGroups();

                    Entity penguin = scene.CreateEntity("bob", "ogrehead.mesh");
                    SceneNode penguinNode = scene.RootSceneNode.CreateChildSceneNode();
                    penguinNode.AttachObject(penguin);


                Entity penguin2 = scene.CreateEntity("bob2", "ogrehead.mesh");
                SceneNode penguinNode2 = penguinNode.CreateChildSceneNode("yoyo", new Vector3(0,150,1000));
                     penguinNode2.AttachObject(penguin2);

                //   ConfigurationManager.SaveConfiguration(root);
                //   ConfigurationManager.SaveConfiguration(root);


            //    for (int i = 0; i < 300; i++)
                {
                    camera.Move(new Vector3(0, 0, 300));
                    camera.LookAt(penguin2.BoundingBox.Center);
                   
                   // root.AddSceneManagerFactory()
                   // root.StartRendering();
                   root.RenderOneFrame();
                }

                }
              //  Console.Write("Press [Enter] to exit.");
              //  Console.ReadLine();
          
           

        }

        private IList<PictureBox> pics = new List<PictureBox>();
        private IList<PictureBox> Maxpics = new List<PictureBox>();

        private DenavitHartenbergViewer Maxviewer;  // The visualization model

        public IEnumerable<object> SavePics()
        {
            string filepath = Application.ExecutablePath;
            List<Image> imgs = new List<Image>();
            foreach (PictureBox p in pics)
            {
                imgs.Add(p.Image);
                //    p.Image.Save(filepath + "." + p.Tag + ".jpg");

                //  p.Image.SaveAdd(new System.Drawing.Imaging.EncoderParameter(System.Drawing.Imaging.Encoder.ChrominanceTable));
            }

            return imgs;
        }

        public void RefreshPlanes(ref PictureBox box, ref DenavitHartenbergViewer view)
        {
            int plane = (int)box.Tag;
            if (plane == 1)
            {
                box.Image = view.PlaneXY;
            }
            else if (plane == 2)
            {
                box.Image = view.PlaneXZ;
            }
            else if (plane == 3)
            {
                //  Image img = view.PlaneYZ;
                //  img.RotateFlip(RotateFlipType.Rotate90FlipY);
                box.Image = view.PlaneXY;
            }
            //    box.Tag = plane; //link de index!!!

            // Refresh the pictures

            // pictureBox3.Refresh();
            // base.Refresh();
        }

        private DenavitHartenbergNode[] currentArray;

        public void Draw(DenavitHartenbergNode[] nodes)
        {
            currentArray = nodes;

            if (currentArray != null)
            {
                if (viewer != null) viewer.ComputeImages(currentArray);
                if (Maxviewer != null)
                {
                    Maxviewer.ComputeImages(currentArray);
                }
            }

            for (int i = 0; i < pics.Count; i++)
            {
                PictureBox box = pics[i];
                box.Tag = i + 1;
                this.RefreshPlanes(ref box, ref viewer);
            }
            for (int i = 0; i < Maxpics.Count; i++)
            {
                PictureBox box = Maxpics[i];
                // box.Tag = i;
                this.RefreshPlanes(ref box, ref Maxviewer);
            }
        }

        private DenavitHartenbergViewer viewer;  // The visualization model

        public void DisplayCinema(ref IEnumerable<object> images)
        {
            foreach (Image i in images)
            {
                DateTime ahora = DateTime.Now;
                pictureBox1.Image = i;
                Application.DoEvents();
                while (DateTime.Now.Subtract(ahora).TotalSeconds < 1)
                {
                }
                pictureBox1.Refresh();
            }
        }

        public ucView()
        {
            InitializeComponent();

            pictureBox1.Tag = 1;
            pictureBox2.Tag = 2;
            pictureBox3.Tag = 3;

            pics.Add(pictureBox1);
            pics.Add(pictureBox2);
            pics.Add(pictureBox3);

            viewer = new DenavitHartenbergViewer(pictureBox1.Width, pictureBox1.Height);
            viewer.BackColor = Color.LightGray;
            viewer.JointsColor = Color.GreenYellow;
            viewer.EndJointColor = Color.Tomato;
            viewer.BaseJointColor = Color.Black;
            viewer.ArrowsBoundingBox = new System.Drawing.Rectangle(20, 20, 25, 25);

            viewer.LinksColor = Color.Tomato;
            //viewer.
            viewer.JointRadius = 10;
            viewer.Scale = 10;
            Draw(currentArray);
            // Create the model visualizer
            //   viewer = new DenavitHartenbergViewer(pictureBox1.Width, pictureBox1.Height);
            //   viewer.JointRadius = 3;
            //viewer.JointRadius
            //    RefreshPlanes();
            // Assign each projection image of the model to a picture box
            //  pictureBox1.Image = viewer.PlaneXY;
            //  pictureBox2.Image = viewer.PlaneXZ;
            //  pictureBox3.Image = viewer.PlaneYZ;
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form form = sender as Form;
            PictureBox l = form.Controls[0] as PictureBox;
            Maxpics.Remove(l);
            l.Dispose();

            //  tableLayoutPanel1.Controls.Add(l);
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            //  viewer = new DenavitHartenbergViewer(pictureBox1.Width, pictureBox1.Height);
            //  viewer.JointRadius = 5;
            PictureBox box = sender as PictureBox;
            //  box.Dock = DockStyle.Fill;

            PictureBox uno = new PictureBox();
            uno.SizeMode = PictureBoxSizeMode.AutoSize;
            uno.Dock = DockStyle.Fill;
            uno.Tag = box.Tag;

            Form form = new Form();
            //   form.MaximizeBox = false;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            form.WindowState = FormWindowState.Maximized;
            form.FormClosing += Form_FormClosing;
            form.Visible = true;

            //  box.SizeMode = PictureBoxSizeMode.AutoSize;
            //   box.SizeMode = PictureBoxSizeMode.AutoSize;
            //    UserControl ctrl = new UserControl();
            //   ctrl.Dock = DockStyle.Fill;
            //  ctrl.AutoSizeMode = AutoSizeMode.GrowOnly;

            //    box.Size.Height = form.Size.Height - 50;
            form.Controls.Add(uno);
            uno.Size = new Size(form.Size.Width - 50, form.Size.Height - 50);
            //    ctrl.Controls.Add(box);
            //    box.Size = form.Size;
            Maxviewer = new DenavitHartenbergViewer(uno.Width, uno.Height);
            Maxviewer.JointRadius = 5;
            Maxviewer.Scale = 5;
            Maxpics.Add(uno);

            //    DenavitHartenbergViewer v=  makeViewer(ref box);
        }
    }
}