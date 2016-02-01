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
using VRPTW.Controller;
using VRPTW.Model;

namespace VRPTW
{
    public partial class Form1 : Form
    {
        DataFile dataFile = null;
        Map map = new Map();
        ToolTip tooltip = new ToolTip();
        String inputFilename = "";

        public Form1()
        {
            InitializeComponent();
            /*Chromosome c = new Chromosome(10);
            c.Nodes = new int[] {0,1,2,3,4,5,6,7,8,9};
            output_textbox.Text += "init chromo: \r\n" + c.ChromosomeString() + "\r\n";
            c.MutateChromosome(6);
            output_textbox.Text += "mutated chromo: \r\n" + c.ChromosomeString() + "\r\n";*/
            
        }

        private void openFileDialog_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                inputFilename = Path.GetFileNameWithoutExtension(openFileDialog1.FileName);
                dataFile = new DataFile(openFileDialog1.FileName);
                map.Locations = dataFile.NodeList;
                map.NumberOfVehicles = dataFile.VehicleNumber;
                map.VehicleCapacity = dataFile.VehicleCapacity;
                chart1.Series.Clear();
                chart1.Series.Add("Points");
                chart1.Series["Points"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
                //output_textbox.Clear();
                //output_textbox.Text += "Vehicle number: " + dataFile.VehicleNumber + "; Vehicle capacity: " + dataFile.VehicleCapacity + "\r\n";
                //output_textbox.Text += "Nodes:\r\n";
                //output_textbox.Text += "ID\tx\ty\tDemand\tReady\tDue\tService\r\n";
                foreach (Node n in dataFile.NodeList)
                {
                    //output_textbox.Text += n.CustomerNr + "\t" + n.X + "\t" + n.Y + "\t" + n.Demand + "\t" + n.ReadyTime + "\t" + n.DueDate + "\t" + n.Service + "\r\n";
                    chart1.Series["Points"].Points.AddXY(n.X, n.Y);
                }
                chart1.Series["Points"].Points[0].Color = Color.Red;
            }
        }

        private void chart1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            // Call Hit Test Method
            HitTestResult result = chart1.HitTest(e.X, e.Y);
            if (result.ChartElementType == ChartElementType.DataPoint)
            {
                tooltip.RemoveAll();
                foreach (DataPoint p in chart1.Series["Points"].Points)
                {
                    p.Color = Color.DodgerBlue;
                }
                chart1.Series["Points"].Points[0].Color = Color.Red;

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
                foreach (DataPoint p in chart1.Series["Points"].Points) p.Color = Color.DodgerBlue;
                chart1.Series["Points"].Points[0].Color = Color.Red;
            }
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            if (dataFile == null) return;

            Map m = new Map();
            m.Locations = dataFile.NodeList;
            m.NumberOfVehicles = dataFile.VehicleNumber;
            m.VehicleCapacity = dataFile.VehicleCapacity;

            output_textbox.Clear();
            output_textbox.Text = String.Empty;
            string s = "";

            GAController gac = new GAController(Int32.Parse(population_tb.Text), Int32.Parse(generations_tb.Text));
            //for (int i = 0; i < gac.Generations; i++)
            //{
                gac.RunSimulation(m);
                Chromosome ch = gac.GetBestSolutionFound();
                ch.fixRoutes();
                s += "Cost: " + ch.Fitness + ", routes number: " + ch.Routes.Count() + ", routes:" + ch.ChromosomeRouteString() + "\r\n";
            //}
            output_textbox.Text = s;
            
            //output_textbox.Text = gac.GetSolutionText();

            // remove everything from chart and redraw points
            chart1.Series.Clear();
            chart1.Series.Add("Points");
            chart1.Series["Points"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            foreach (Node n in dataFile.NodeList)
            {
                //output_textbox.Text += n.CustomerNr + "\t" + n.X + "\t" + n.Y + "\t" + n.Demand + "\t" + n.ReadyTime + "\t" + n.DueDate + "\t" + n.Service + "\r\n";
                chart1.Series["Points"].Points.AddXY(n.X, n.Y);
            }
            chart1.Series["Points"].Points[0].Color = Color.Red;

            Chromosome c = gac.GetBestSolutionFound();    // draw routes for best chromosome found
            
            // draw all routes in given chromosome
            List<int[]> routes = c.Routes;
            for (int i = 0; i < routes.Count; i++)
            {
                int[] route = routes[i];
                chart1.Series.Add("Route_"+i);
                for (int j = 0; j < route.Length; j++)
                {
                    Node n = dataFile.NodeList[route[j]];
                    chart1.Series["Route_" + i].Points.AddXY(n.X, n.Y);
                }

                chart1.Series["Route_" + i].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            }
            chart1.SaveImage(inputFilename + ".png", ChartImageFormat.Png);
            File.WriteAllText(inputFilename + "_solution.txt", output_textbox.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
