using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;

namespace MultiFaceRec
{
    public partial class RegisterStudent : Form
    {
        public RegisterStudent(Image<Gray, byte> Face)
        {
            InitializeComponent();
            faceBox.Image = Face;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
