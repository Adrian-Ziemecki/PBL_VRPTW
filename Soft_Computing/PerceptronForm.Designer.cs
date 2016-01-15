namespace Soft_Computing
{
    partial class PerceptronForm
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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.trainingSetBtn = new System.Windows.Forms.Button();
            this.trainNeuronBtn = new System.Windows.Forms.Button();
            this.computeBtn = new System.Windows.Forms.Button();
            this.epochsTB = new System.Windows.Forms.TextBox();
            this.trainingStepTB = new System.Windows.Forms.TextBox();
            this.epochsLabel = new System.Windows.Forms.Label();
            this.trainingOutputLV = new System.Windows.Forms.ListView();
            this.Weight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.trainingSetLV = new System.Windows.Forms.ListView();
            this.trainingStepLabel = new System.Windows.Forms.Label();
            this.trainingOutputLabel = new System.Windows.Forms.Label();
            this.trainingSetLabel = new System.Windows.Forms.Label();
            this.biasedChkBox = new System.Windows.Forms.CheckBox();
            this.computationOutputLV = new System.Windows.Forms.ListView();
            this.computationOutputLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hiddenNeuronsTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // trainingSetBtn
            // 
            this.trainingSetBtn.Location = new System.Drawing.Point(12, 449);
            this.trainingSetBtn.Name = "trainingSetBtn";
            this.trainingSetBtn.Size = new System.Drawing.Size(248, 37);
            this.trainingSetBtn.TabIndex = 2;
            this.trainingSetBtn.Text = "Load Training Set";
            this.trainingSetBtn.UseVisualStyleBackColor = true;
            this.trainingSetBtn.Click += new System.EventHandler(this.trainingSetBtn_Click);
            // 
            // trainNeuronBtn
            // 
            this.trainNeuronBtn.Enabled = false;
            this.trainNeuronBtn.Location = new System.Drawing.Point(392, 449);
            this.trainNeuronBtn.Name = "trainNeuronBtn";
            this.trainNeuronBtn.Size = new System.Drawing.Size(122, 37);
            this.trainNeuronBtn.TabIndex = 3;
            this.trainNeuronBtn.Text = "Train Neuron";
            this.trainNeuronBtn.UseVisualStyleBackColor = true;
            this.trainNeuronBtn.Click += new System.EventHandler(this.trainNeuronBtn_Click);
            // 
            // computeBtn
            // 
            this.computeBtn.Enabled = false;
            this.computeBtn.Location = new System.Drawing.Point(627, 449);
            this.computeBtn.Name = "computeBtn";
            this.computeBtn.Size = new System.Drawing.Size(248, 37);
            this.computeBtn.TabIndex = 4;
            this.computeBtn.Text = "Load and Compute Values";
            this.computeBtn.UseVisualStyleBackColor = true;
            this.computeBtn.Click += new System.EventHandler(this.computeBtn_Click);
            // 
            // epochsTB
            // 
            this.epochsTB.Location = new System.Drawing.Point(392, 94);
            this.epochsTB.Name = "epochsTB";
            this.epochsTB.Size = new System.Drawing.Size(100, 22);
            this.epochsTB.TabIndex = 11;
            this.epochsTB.Text = "100";
            // 
            // trainingStepTB
            // 
            this.trainingStepTB.Location = new System.Drawing.Point(392, 49);
            this.trainingStepTB.Name = "trainingStepTB";
            this.trainingStepTB.Size = new System.Drawing.Size(100, 22);
            this.trainingStepTB.TabIndex = 12;
            this.trainingStepTB.Text = "0,1";
            // 
            // epochsLabel
            // 
            this.epochsLabel.AutoSize = true;
            this.epochsLabel.Location = new System.Drawing.Point(389, 74);
            this.epochsLabel.Name = "epochsLabel";
            this.epochsLabel.Size = new System.Drawing.Size(125, 17);
            this.epochsLabel.TabIndex = 5;
            this.epochsLabel.Text = "Number of Epochs";
            // 
            // trainingOutputLV
            // 
            this.trainingOutputLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Weight,
            this.Value});
            this.trainingOutputLV.FullRowSelect = true;
            this.trainingOutputLV.GridLines = true;
            this.trainingOutputLV.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.trainingOutputLV.Location = new System.Drawing.Point(389, 211);
            this.trainingOutputLV.Name = "trainingOutputLV";
            this.trainingOutputLV.Size = new System.Drawing.Size(232, 232);
            this.trainingOutputLV.TabIndex = 6;
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
            // trainingSetLV
            // 
            this.trainingSetLV.FullRowSelect = true;
            this.trainingSetLV.GridLines = true;
            this.trainingSetLV.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.trainingSetLV.Location = new System.Drawing.Point(15, 29);
            this.trainingSetLV.Name = "trainingSetLV";
            this.trainingSetLV.Size = new System.Drawing.Size(368, 414);
            this.trainingSetLV.TabIndex = 7;
            this.trainingSetLV.UseCompatibleStateImageBehavior = false;
            this.trainingSetLV.View = System.Windows.Forms.View.Details;
            // 
            // trainingStepLabel
            // 
            this.trainingStepLabel.AutoSize = true;
            this.trainingStepLabel.Location = new System.Drawing.Point(389, 29);
            this.trainingStepLabel.Name = "trainingStepLabel";
            this.trainingStepLabel.Size = new System.Drawing.Size(93, 17);
            this.trainingStepLabel.TabIndex = 8;
            this.trainingStepLabel.Text = "Training Step";
            // 
            // trainingOutputLabel
            // 
            this.trainingOutputLabel.AutoSize = true;
            this.trainingOutputLabel.Location = new System.Drawing.Point(389, 191);
            this.trainingOutputLabel.Name = "trainingOutputLabel";
            this.trainingOutputLabel.Size = new System.Drawing.Size(107, 17);
            this.trainingOutputLabel.TabIndex = 9;
            this.trainingOutputLabel.Text = "Training Output";
            // 
            // trainingSetLabel
            // 
            this.trainingSetLabel.AutoSize = true;
            this.trainingSetLabel.Location = new System.Drawing.Point(12, 9);
            this.trainingSetLabel.Name = "trainingSetLabel";
            this.trainingSetLabel.Size = new System.Drawing.Size(85, 17);
            this.trainingSetLabel.TabIndex = 10;
            this.trainingSetLabel.Text = "Training Set";
            // 
            // biasedChkBox
            // 
            this.biasedChkBox.AutoSize = true;
            this.biasedChkBox.Location = new System.Drawing.Point(392, 167);
            this.biasedChkBox.Name = "biasedChkBox";
            this.biasedChkBox.Size = new System.Drawing.Size(73, 21);
            this.biasedChkBox.TabIndex = 13;
            this.biasedChkBox.Text = "Biased";
            this.biasedChkBox.UseVisualStyleBackColor = false;
            // 
            // computationOutputLV
            // 
            this.computationOutputLV.FullRowSelect = true;
            this.computationOutputLV.GridLines = true;
            this.computationOutputLV.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.computationOutputLV.Location = new System.Drawing.Point(627, 29);
            this.computationOutputLV.Name = "computationOutputLV";
            this.computationOutputLV.Size = new System.Drawing.Size(364, 415);
            this.computationOutputLV.TabIndex = 14;
            this.computationOutputLV.UseCompatibleStateImageBehavior = false;
            this.computationOutputLV.View = System.Windows.Forms.View.Details;
            // 
            // computationOutputLabel
            // 
            this.computationOutputLabel.AutoSize = true;
            this.computationOutputLabel.Location = new System.Drawing.Point(624, 9);
            this.computationOutputLabel.Name = "computationOutputLabel";
            this.computationOutputLabel.Size = new System.Drawing.Size(134, 17);
            this.computationOutputLabel.TabIndex = 15;
            this.computationOutputLabel.Text = "Computation Output";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(389, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "HL Neurons";
            // 
            // hiddenNeuronsTB
            // 
            this.hiddenNeuronsTB.Location = new System.Drawing.Point(392, 139);
            this.hiddenNeuronsTB.Name = "hiddenNeuronsTB";
            this.hiddenNeuronsTB.Size = new System.Drawing.Size(100, 22);
            this.hiddenNeuronsTB.TabIndex = 11;
            this.hiddenNeuronsTB.Text = "2";
            // 
            // PerceptronForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 501);
            this.Controls.Add(this.computationOutputLV);
            this.Controls.Add(this.computationOutputLabel);
            this.Controls.Add(this.biasedChkBox);
            this.Controls.Add(this.hiddenNeuronsTB);
            this.Controls.Add(this.epochsTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trainingStepTB);
            this.Controls.Add(this.epochsLabel);
            this.Controls.Add(this.trainingOutputLV);
            this.Controls.Add(this.trainingSetLV);
            this.Controls.Add(this.trainingStepLabel);
            this.Controls.Add(this.trainingOutputLabel);
            this.Controls.Add(this.trainingSetLabel);
            this.Controls.Add(this.computeBtn);
            this.Controls.Add(this.trainNeuronBtn);
            this.Controls.Add(this.trainingSetBtn);
            this.Name = "PerceptronForm";
            this.Text = "Perceptron";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button trainingSetBtn;
        private System.Windows.Forms.Button trainNeuronBtn;
        private System.Windows.Forms.Button computeBtn;
        private System.Windows.Forms.TextBox epochsTB;
        private System.Windows.Forms.TextBox trainingStepTB;
        private System.Windows.Forms.Label epochsLabel;
        private System.Windows.Forms.ListView trainingOutputLV;
        private System.Windows.Forms.ColumnHeader Weight;
        private System.Windows.Forms.ColumnHeader Value;
        private System.Windows.Forms.ListView trainingSetLV;
        private System.Windows.Forms.Label trainingStepLabel;
        private System.Windows.Forms.Label trainingOutputLabel;
        private System.Windows.Forms.Label trainingSetLabel;
        private System.Windows.Forms.CheckBox biasedChkBox;
        private System.Windows.Forms.ListView computationOutputLV;
        private System.Windows.Forms.Label computationOutputLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox hiddenNeuronsTB;
    }
}