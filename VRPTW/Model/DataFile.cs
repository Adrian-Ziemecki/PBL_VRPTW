using System;
using System.Collections.Generic;
using System.IO;

namespace VRPTW.Model
{
    class DataFile
    {
        public string Filename { get; set; }
        public string SetName { get; set; }
        public int VehicleNumber { get; set; }
        public int VehicleCapacity { get; set; }
        public List<Node> NodeList { get; set; }

        public DataFile(string filename)
        {
            this.Filename = filename;
            readFile(this.Filename);
        }

        private void readFile(string filename)
        {
            StreamReader reader = null;
            try
            {
                reader = File.OpenText(filename);
            }
            catch (Exception e)
            {
                Console.Error.WriteLine("Failed to open file:\n" + e.StackTrace);
                return;
            }
            string line;
            List<string> fileContent = new List<string>();
            while ((line = reader.ReadLine()) != null)
            {
                if (line.Equals("")) continue;
                else fileContent.Add(line);
            }

            SetName = fileContent[0];
            VehicleNumber = Int32.Parse(fileContent[3].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)[0]);
            VehicleCapacity = Int32.Parse(fileContent[3].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)[1]);
            NodeList = new List<Node>();

            for (int i = 6; i < fileContent.Count-1; i++)
            {
                //Console.Out.WriteLine(fileContent[i]);
                string[] customerParams = fileContent[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                Node n = new Node();
                n.CustomerNr = Int32.Parse(customerParams[0]);
                n.X = Int32.Parse(customerParams[1]);
                n.Y = Int32.Parse(customerParams[2]);
                n.Demand = Int32.Parse(customerParams[3]);
                n.ReadyTime = Int32.Parse(customerParams[4]);
                n.DueDate = Int32.Parse(customerParams[5]);
                n.Service = Int32.Parse(customerParams[6]);
                NodeList.Add(n);
            }
        }
    }
}
