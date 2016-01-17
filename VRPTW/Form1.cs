using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VRPTW.Model;

namespace VRPTW
{
    public partial class Form1 : Form
    {
        DataFile dataFile;

        public Form1()
        {
            InitializeComponent();
        }

        private void openFileDialog_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                dataFile = new DataFile(openFileDialog1.FileName);
                output_textbox.Clear();
                output_textbox.Text += "Vehicle number: " + dataFile.VehicleNumber + "; Vehicle capacity: " + dataFile.VehicleCapacity + "\r\n";
                output_textbox.Text += "Nodes:\r\n";
                foreach (Node n in dataFile.NodeList)
                {
                    output_textbox.Text += "ID:" + n.CustomerNr + "\tx: " + n.X + "\ty: " + n.Y + "\tDemand: " + n.Demand + "\tReady: " + n.ReadyTime + "   \tDue: " + n.DueDate + "    \tService: " + n.Service + "\r\n";
                }
            }
        }
    }
}
