using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using Accord.Controls;
using Accord.Math.Kinematics;

namespace DH
{
    public partial class ucView : UserControl
    {


        public override void  Refresh()
        {
            // Refresh the pictures
            pictureBox1.Refresh();
            pictureBox2.Refresh();
            pictureBox3.Refresh();
            base.Refresh();
        }

        public void Draw(ref DenavitHartenbergNode node)
        {
            node.Compute();
            viewer.ComputeImages( node);
            this.Refresh();
        

        }
        DenavitHartenbergViewer viewer;  // The visualization model
        void picurePlane(int i)
        {
            if (i == 1)
            {
                pictureBox1.Image = viewer.PlaneXY;
            }
            else if (i == 2)
            {
                pictureBox2.Image = viewer.PlaneXZ;
            }
            else if (i == 3)
            {
                pictureBox3.Image = viewer.PlaneYZ;
            }

        }
        public ucView()
        {
            InitializeComponent();

            // Create the model visualizer
            viewer = new DenavitHartenbergViewer(pictureBox1.Width, pictureBox1.Height);

            viewer.JointRadius = 2;
            //viewer.JointRadius

            // Assign each projection image of the model to a picture box
            //  pictureBox1.Image = viewer.PlaneXY;
            //  pictureBox2.Image = viewer.PlaneXZ;
            //  pictureBox3.Image = viewer.PlaneYZ;

            for (int i = 1; i < 4; i++)
            {
                picurePlane(i);
            }



        }



    }
}
