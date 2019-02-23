using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragDrop_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox1.DoDragDrop("pct", DragDropEffects.Move);
        }

        private void pictureBox1_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void pictureBox1_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AllowDrop = true;
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string gelendata = e.Data.GetData(DataFormats.StringFormat).ToString();

            if (gelendata == "pct")
            {
                pictureBox1.Left = e.X - pictureBox1.Width / 2;
                pictureBox1.Top = e.Y - pictureBox1.Height / 2;
            }
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }
    }
}
