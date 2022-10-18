using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiMideaProject1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void ZoomInOut_Click(object sender, EventArgs e)
        {
            Zoom_Out_In zoom = new Zoom_Out_In();
            zoom.Show();
            Visible = false;


        }

        private void crop1_Click(object sender, EventArgs e)
        {
            Crop crop = new Crop();
            crop.Show();
            Visible = false;

        }

        private void CopyCutPast_Click(object sender, EventArgs e)
        {
            CopyPast copy = new CopyPast();
            copy.Show();
            Visible = false;

        }

        private void Edid_Click(object sender, EventArgs e)
        {
            EditPhoto edit = new EditPhoto();
            edit.Show();
            Visible = false;


        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
