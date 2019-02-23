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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void lstGonderen_MouseDown(object sender, MouseEventArgs e)
        {
            if(lstGonderen.SelectedItem == null)
            {
                lstGonderen.DoDragDrop(lstGonderen, DragDropEffects.Move);
            }
            else
            {
                lstGonderen.DoDragDrop(lstGonderen.SelectedItem, DragDropEffects.Move);
            }
        }

        private void lstAlan_DragDrop(object sender, DragEventArgs e)
        {
            lstAlan.Items.Add(lstGonderen.SelectedItem);
            lstGonderen.Items.Remove(lstGonderen.SelectedItem);
            //lstAlan.Items.Add(e.Data.GetData(DataFormats.StringFormat));
            //lstGonderen.Items.Remove(e.Data.GetData(DataFormats.StringFormat));
        }

        private void lstAlan_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }
    }
}
