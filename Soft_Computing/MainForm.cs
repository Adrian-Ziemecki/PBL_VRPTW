using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soft_Computing
{
    public partial class MainForm : Form
    {
        private Form currentForm = null;

        public MainForm()
        {
            InitializeComponent();
        }

        private void neuronBtn_Click(object sender, EventArgs e)
        {
            if (currentForm != null) currentForm.Close();
            currentForm = new NeuronForm();
            currentForm.Show();
        }

        private void perceptronBtn_Click(object sender, EventArgs e)
        {
            if (currentForm != null) currentForm.Close();
            currentForm = new PerceptronForm();
            currentForm.Show();
        }

        private void geneticBtn_Click(object sender, EventArgs e)
        {
            if (currentForm != null) currentForm.Close();
            currentForm = new SGAForm();
            currentForm.Show();
        }
    }
}
