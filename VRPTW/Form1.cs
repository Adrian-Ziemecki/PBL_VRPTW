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
using System.Windows.Forms.DataVisualization.Charting;
using VRPTW.Model;

namespace VRPTW
{
    public partial class Form1 : Form
    {
        DataFile dataFile;
        ToolTip tooltip = new ToolTip();

        public Form1()
        {
            InitializeComponent();
            Chromosome c = new Chromosome(10);
            c.Nodes = new int[] {0,1,2,3,4,5,6,7,8,9};
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

        private void chart1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            // Call Hit Test Method
            HitTestResult result = chart1.HitTest(e.X, e.Y);
            if (result.ChartElementType == ChartElementType.DataPoint)
            {
                tooltip.RemoveAll();
                foreach (DataPoint p in chart1.Series["Series1"].Points)
                {
                    p.Color = Color.DodgerBlue;
                }
                chart1.Series["Series1"].Points[0].Color = Color.Red;

                // index of the clicked point in its series
                int index = result.PointIndex;
                // actual values
                int xVal = Convert.ToInt32(result.Series.Points[result.PointIndex].XValue);
                int yVal = Convert.ToInt32(result.Series.Points[result.PointIndex].YValues[0]);

                Node node = new Node();
                foreach (Node n in dataFile.NodeList)
                {
                    if (n.X == xVal && n.Y == yVal)
                    {
                        node = n;
                        break;
                    }
                }
                //Console.WriteLine("(" + xVal + ", " + yVal + ")");
                tooltip.Show("#" + node.CustomerNr + "  (" + node.X + "," + node.Y + ")\r\nDemand:\t" + node.Demand + "\r\nReady:\t\t" + node.ReadyTime + "\r\nDue:\t\t" + node.DueDate + "\r\nService:\t\t" + node.Service,
                             this.chart1, e.Location.X + 15, e.Location.Y - 15);
                result.Series.Points[result.PointIndex].Color = Color.GreenYellow;
            }
            else
            {
                tooltip.RemoveAll();
                foreach (DataPoint p in chart1.Series["Series1"].Points) p.Color = Color.DodgerBlue;
                chart1.Series["Series1"].Points[0].Color = Color.Red;
            }
        }
    }
}
