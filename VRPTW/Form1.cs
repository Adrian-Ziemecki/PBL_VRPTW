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
            Chromosome c = new Chromosome(10);
            c.Route = new int[] {0,1,2,3,4,5,6,7,8,9};
            output_textbox.Text += "init chromo: \r\n" + c.ChromosomeString() + "\r\n";
            c.MutateChromosome(6);
            output_textbox.Text += "mutated chromo: \r\n" + c.ChromosomeString() + "\r\n";
        }

        private void openFileDialog_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                dataFile = new DataFile(openFileDialog1.FileName);
                chart1.Series["Series1"].Points.Clear();
                output_textbox.Clear();
                output_textbox.Text += "Vehicle number: " + dataFile.VehicleNumber + "; Vehicle capacity: " + dataFile.VehicleCapacity + "\r\n";
                output_textbox.Text += "Nodes:\r\n";
                output_textbox.Text += "ID\tx\ty\tDemand\tReady\tDue\tService\r\n";
                foreach (Node n in dataFile.NodeList)
                {
                    output_textbox.Text += n.CustomerNr + "\t" + n.X + "\t" + n.Y + "\t" + n.Demand + "\t" + n.ReadyTime + "\t" + n.DueDate + "\t" + n.Service + "\r\n";
                    chart1.Series["Series1"].Points.AddXY(n.X, n.Y);
                }
                chart1.Series["Series1"].Points[0].Color = Color.Red;
            }
        }
    }
}
