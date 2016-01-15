namespace Soft_Computing
{
    partial class NeuronForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainPanel = new System.Windows.Forms.Panel();
            this.trainingSetLabel = new System.Windows.Forms.Label();
            this.trainingSetLV = new System.Windows.Forms.ListView();
            this.trainingSetBtn = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.trainingStepTB = new System.Windows.Forms.TextBox();
            this.trainingStepLabel = new System.Windows.Forms.Label();
            this.epochsLabel = new System.Windows.Forms.Label();
            this.epochsTB = new System.Windows.Forms.TextBox();
            this.trainNeuronBtn = new System.Windows.Forms.Button();
            this.trainingOutputLV = new System.Windows.Forms.ListView();
            this.Weight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.trainingOutputLabel = new System.Windows.Forms.Label();
            this.computeBtn = new System.Windows.Forms.Button();
            this.computationOutputLabel = new System.Windows.Forms.Label();
            this.computationOutputLV = new System.Windows.Forms.ListView();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.epochsTB);
            this.mainPanel.Controls.Add(this.trainingStepTB);
            this.mainPanel.Controls.Add(this.trainNeuronBtn);
            this.mainPanel.Controls.Add(this.computeBtn);
            this.mainPanel.Controls.Add(this.trainingSetBtn);
            this.mainPanel.Controls.Add(this.epochsLabel);
            this.mainPanel.Controls.Add(this.computationOutputLV);
            this.mainPanel.Controls.Add(this.trainingOutputLV);
            this.mainPanel.Controls.Add(this.trainingSetLV);
            this.mainPanel.Controls.Add(this.computationOutputLabel);
            this.mainPanel.Controls.Add(this.trainingStepLabel);
            this.mainPanel.Controls.Add(this.trainingOutputLabel);
            this.mainPanel.Controls.Add(this.trainingSetLabel);
            this.mainPanel.Location = new System.Drawing.Point(12, 12);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(667, 485);
            this.mainPanel.TabIndex = 0;
            // 
            // trainingSetLabel
            // 
            this.trainingSetLabel.AutoSize = true;
            this.trainingSetLabel.Location = new System.Drawing.Point(4, 4);
            this.trainingSetLabel.Name = "trainingSetLabel";
            this.trainingSetLabel.Size = new System.Drawing.Size(85, 17);
            this.trainingSetLabel.TabIndex = 0;
            this.trainingSetLabel.Text = "Training Set";
            // 
            // trainingSetLV
            // 
            this.trainingSetLV.FullRowSelect = true;
            this.trainingSetLV.GridLines = true;
            this.trainingSetLV.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.trainingSetLV.Location = new System.Drawing.Point(3, 24);
            this.trainingSetLV.Name = "trainingSetLV";
            this.trainingSetLV.Size = new System.Drawing.Size(252, 414);
            this.trainingSetLV.TabIndex = 0;
            this.trainingSetLV.UseCompatibleStateImageBehavior = false;
            this.trainingSetLV.View = System.Windows.Forms.View.Details;
            // 
            // trainingSetBtn
            // 
            this.trainingSetBtn.Location = new System.Drawing.Point(7, 445);
            this.trainingSetBtn.Name = "trainingSetBtn";
            this.trainingSetBtn.Size = new System.Drawing.Size(248, 37);
            this.trainingSetBtn.TabIndex = 1;
            this.trainingSetBtn.Text = "Load Training Set";
            this.trainingSetBtn.UseVisualStyleBackColor = true;
            this.trainingSetBtn.Click += new System.EventHandler(this.trainingSetBtn_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // trainingStepTB
            // 
            this.trainingStepTB.Location = new System.Drawing.Point(264, 44);
            this.trainingStepTB.Name = "trainingStepTB";
            this.trainingStepTB.Size = new System.Drawing.Size(100, 22);
            this.trainingStepTB.TabIndex = 2;
            this.trainingStepTB.Text = "0,1";
            // 
            // trainingStepLabel
            // 
            this.trainingStepLabel.AutoSize = true;
            this.trainingStepLabel.Location = new System.Drawing.Point(261, 24);
            this.trainingStepLabel.Name = "trainingStepLabel";
            this.trainingStepLabel.Size = new System.Drawing.Size(93, 17);
            this.trainingStepLabel.TabIndex = 0;
            this.trainingStepLabel.Text = "Training Step";
            // 
            // epochsLabel
            // 
            this.epochsLabel.AutoSize = true;
            this.epochsLabel.Location = new System.Drawing.Point(261, 69);
            this.epochsLabel.Name = "epochsLabel";
            this.epochsLabel.Size = new System.Drawing.Size(125, 17);
            this.epochsLabel.TabIndex = 0;
            this.epochsLabel.Text = "Number of Epochs";
            // 
            // epochsTB
            // 
            this.epochsTB.Location = new System.Drawing.Point(264, 89);
            this.epochsTB.Name = "epochsTB";
            this.epochsTB.Size = new System.Drawing.Size(100, 22);
            this.epochsTB.TabIndex = 2;
            this.epochsTB.Text = "100";
            // 
            // trainNeuronBtn
            // 
            this.trainNeuronBtn.Enabled = false;
            this.trainNeuronBtn.Location = new System.Drawing.Point(267, 445);
            this.trainNeuronBtn.Name = "trainNeuronBtn";
            this.trainNeuronBtn.Size = new System.Drawing.Size(122, 37);
            this.trainNeuronBtn.TabIndex = 1;
            this.trainNeuronBtn.Text = "Train Neuron";
            this.trainNeuronBtn.UseVisualStyleBackColor = true;
            this.trainNeuronBtn.Click += new System.EventHandler(this.trainNeuronBtn_Click);
            // 
            // trainingOutputLV
            // 
            this.trainingOutputLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Weight,
            this.Value});
            this.trainingOutputLV.FullRowSelect = true;
            this.trainingOutputLV.GridLines = true;
            this.trainingOutputLV.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.trainingOutputLV.Location = new System.Drawing.Point(264, 188);
            this.trainingOutputLV.Name = "trainingOutputLV";
            this.trainingOutputLV.Size = new System.Drawing.Size(125, 250);
            this.trainingOutputLV.TabIndex = 0;
            this.trainingOutputLV.UseCompatibleStateImageBehavior = false;
            this.trainingOutputLV.View = System.Windows.Forms.View.Details;
            // 
            // Weight
            // 
            this.Weight.Text = "Weight";
            // 
            // Value
            // 
            this.Value.Text = "Value";
            // 
            // trainingOutputLabel
            // 
            this.trainingOutputLabel.AutoSize = true;
            this.trainingOutputLabel.Location = new System.Drawing.Point(264, 168);
            this.trainingOutputLabel.Name = "trainingOutputLabel";
            this.trainingOutputLabel.Size = new System.Drawing.Size(107, 17);
            this.trainingOutputLabel.TabIndex = 0;
            this.trainingOutputLabel.Text = "Training Output";
            // 
            // computeBtn
            // 
            this.computeBtn.Enabled = false;
            this.computeBtn.Location = new System.Drawing.Point(409, 445);
            this.computeBtn.Name = "computeBtn";
            this.computeBtn.Size = new System.Drawing.Size(248, 37);
            this.computeBtn.TabIndex = 1;
            this.computeBtn.Text = "Load and Compute Values";
            this.computeBtn.UseVisualStyleBackColor = true;
            this.computeBtn.Click += new System.EventHandler(this.computeBtn_Click);
            // 
            // computationOutputLabel
            // 
            this.computationOutputLabel.AutoSize = true;
            this.computationOutputLabel.Location = new System.Drawing.Point(406, 4);
            this.computationOutputLabel.Name = "computationOutputLabel";
            this.computationOutputLabel.Size = new System.Drawing.Size(134, 17);
            this.computationOutputLabel.TabIndex = 0;
            this.computationOutputLabel.Text = "Computation Output";
            // 
            // computationOutputLV
            // 
            this.computationOutputLV.FullRowSelect = true;
            this.computationOutputLV.GridLines = true;
            this.computationOutputLV.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.computationOutputLV.Location = new System.Drawing.Point(409, 24);
            this.computationOutputLV.Name = "computationOutputLV";
            this.computationOutputLV.Size = new System.Drawing.Size(248, 415);
            this.computationOutputLV.TabIndex = 0;
            this.computationOutputLV.UseCompatibleStateImageBehavior = false;
            this.computationOutputLV.View = System.Windows.Forms.View.Details;
            // 
            // FormNeuron
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 509);
            this.Controls.Add(this.mainPanel);
            this.Name = "FormNeuron";
            this.Text = "Neuron";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button trainingSetBtn;
        private System.Windows.Forms.ListView trainingSetLV;
        private System.Windows.Forms.Label trainingSetLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox epochsTB;
        private System.Windows.Forms.TextBox trainingStepTB;
        private System.Windows.Forms.Label epochsLabel;
        private System.Windows.Forms.Label trainingStepLabel;
        private System.Windows.Forms.Button trainNeuronBtn;
        private System.Windows.Forms.Button computeBtn;
        private System.Windows.Forms.ListView computationOutputLV;
        private System.Windows.Forms.ListView trainingOutputLV;
        private System.Windows.Forms.ColumnHeader Weight;
        private System.Windows.Forms.ColumnHeader Value;
        private System.Windows.Forms.Label computationOutputLabel;
        private System.Windows.Forms.Label trainingOutputLabel;
    }
}

