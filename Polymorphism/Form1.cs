using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polymorphism
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNvidia_Click(object sender, EventArgs e)
        {
            Nvidia nvidia = new Nvidia();
            nvidia.Model = "RTX 2080TI";
            nvidia.Memory = "11 GB";
            nvidia.IsExternal = true;
            nvidia.Price = "1200$";
            nvidia.Sound();

            MessageBox.Show("Graphic card brand: " + nvidia.Model + "\nGraphic card memory: " + nvidia.Memory +
                "\nGraphic card is external: " + nvidia.IsExternal + "\nGraphic card price: " + nvidia.Price);

        }

        private void btnAMD_Click(object sender, EventArgs e)
        {
            AMD amd = new AMD();
            amd.Model = "RX 580";
            amd.Memory = "8 GB";
            amd.IsExternal = true;
            amd.Price = "400$";
            amd.Sound();

            MessageBox.Show("Graphic card brand: " + amd.Model + "\nGraphic card memory: " + amd.Memory +
                "\nGraphic card is external: " + amd.IsExternal + "\nGraphic card price: " + amd.Price);
        }

        private void btnIntel_Click(object sender, EventArgs e)
        {
            Intel intel = new Intel();
            intel.Model = "UHD Graphics 630";
            intel.Memory = "4 GB";
            intel.IsExternal = false;
            intel.Price = "-";
            intel.Sound();

            MessageBox.Show("Graphic card brand: " + intel.Model + "\nGraphic card memory: " + intel.Memory +
                "\nGraphic card is external: " + intel.IsExternal + "\nGraphic card price: " + intel.Price);
        }

       
    }
}